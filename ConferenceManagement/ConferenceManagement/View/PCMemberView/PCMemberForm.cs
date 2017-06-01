using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConferenceManagement.Client;
using ConferenceManagement.Model;

namespace ConferenceManagement.View.PCMemberView
{
    public partial class PCMemberForm : Form
    {
        ClientController ctrl;
        PCMember pcMember;
        public PCMemberForm(ClientController ctr, PCMember pcMem)
        {
            InitializeComponent();
            ctrl = ctr;
            pcMember = pcMem;
            List<Conference> cfs = ctrl.getAllPlannedConferences();
            dataGridView2.DataSource = ctrl.getAllPlannedConferences();
        }

        // Opens the window with the list of the articles for this conference.
        private void SubmittedArticles_button_Click(object sender, EventArgs e)
        {
            string id = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            int ID = Int16.Parse(id);
            string name = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            SubmittedArticlesForm submittedArticlesForm = new SubmittedArticlesForm(ctrl,ID,name);
            submittedArticlesForm.Show();
        }

        // Opens the window with the list of the participants for this conference.
        private void Participants_button_Click(object sender, EventArgs e)
        {
            ParticipantsListForm participantsList = new ParticipantsListForm(ctrl);
            participantsList.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateConferenceView conferenceView = new CreateConferenceView(this.ctrl);
            conferenceView.Show();
        }
    }
}

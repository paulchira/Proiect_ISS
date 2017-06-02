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
        public LoginForm parentForm { set; get; }
        public PCMemberForm(ClientController ctr, PCMember pcMem)
        {
            InitializeComponent();
            ctrl = ctr;
            pcMember = pcMem;
            List<Conference> cfs = ctrl.getAllPlannedConferences();
            dataGridView2.DataSource = ctrl.getAllPlannedConferences();
            dataGridView1.DataSource = ctrl.getAllConferences();


        }

        // Opens the window with the list of the articles for this conference.
        private void SubmittedArticles_button_Click(object sender, EventArgs e)
        {
            string id = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            int ID = Int16.Parse(id);
            string name = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            SubmittedArticlesForm submittedArticlesForm = new SubmittedArticlesForm(ctrl,ID,name);
            submittedArticlesForm.parentForm = this;
            this.Owner = submittedArticlesForm;
            this.Hide();
            submittedArticlesForm.Show();
        }

        // Opens the window with the list of the participants for this conference.
        private void Participants_button_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex];
                int idConf = Int16.Parse(row.Cells[0].Value.ToString());
                string cofName = row.Cells[1].Value.ToString();
                string confDate = row.Cells[2].Value.ToString();
                string confEd = row.Cells[3].Value.ToString();
                Conference conference = new Conference(idConf, cofName, confDate, confEd);
                ParticipantsListForm participantsList = new ParticipantsListForm(ctrl, conference);
                participantsList.parentForm = this;
                this.Owner = participantsList;
                this.Hide();
                participantsList.Show();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateConferenceView conferenceView = new CreateConferenceView(this.ctrl);
            conferenceView.parentForm = this;
            this.Owner = conferenceView;
            this.Hide();
            conferenceView.Show();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            parentForm.Show();
        }
    }
}

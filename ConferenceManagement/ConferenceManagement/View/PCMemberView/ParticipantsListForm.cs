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
    public partial class ParticipantsListForm : Form
    {
        ClientController ctrl;
        Conference conference;
        public PCMemberForm parentForm { set; get; }
        public delegate void UpdateListBoxCallback(DataGridView list, List<Participant> data);

        public ParticipantsListForm(ClientController ctr, Conference conf)
        {
            InitializeComponent();
            ctrl = ctr;
            ctrl.updateEvent += Ctrl_updateEvent;
            conference = conf;

            dataGridView1.DataSource = ctrl.getAllParticipantsByConference(conf.Id);
            dataGridView1.Columns[4].Visible = false; // hide password column
            noParticpants_textBox.Text = ctrl.getAllParticipantsByConference(conf.Id).Count+ "";

        }

        private void Ctrl_updateEvent(object sender, ClientEvents e)
        {
            if (e.UserEvent == UserEvent.newUser)
            {
                int idConf = int.Parse(e.Data.ToString());
                List<Participant> listPart = ctrl.getAllParticipantsByConference(idConf);
                dataGridView1.BeginInvoke(new UpdateListBoxCallback(this.updateListBox), new Object[] { dataGridView1, listPart });
            }
        }

        private void updateListBox(DataGridView grid, List<Participant> newData)
        {
            grid.DataSource = null;
            grid.DataSource = newData;
            grid.Columns[4].Visible = false;
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            parentForm.Show();
        }
    }
}

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
        public ParticipantsListForm(ClientController ctr, Conference conf)
        {
            InitializeComponent();
            ctrl = ctr;
            conference = conf;

            dataGridView1.DataSource = ctrl.getAllParticipantsByConference(conf.Id);
            dataGridView1.Columns[4].Visible = false; // hide password column
            noParticpants_textBox.Text = ctrl.getAllParticipantsByConference(conf.Id).Count+ "";

        }
    }
}

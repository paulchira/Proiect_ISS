using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ConferenceManagement.Client;
using ConferenceManagement.Model;
using ConferenceManagement.View.SectionsView;

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
            dataGridView2.Columns[4].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            this.FormClosing += PCMemberForm_FormClosing;
        }

        private void PCMemberForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ctrl.logout(pcMember.Username);
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
            ctrl.logout(pcMember.Username);
            this.Hide();
            parentForm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0)
            {
                MessageBox.Show("There's no conference!");
                return;
            }
            try
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                int idConf = Convert.ToInt16(selectedRow.Cells["Id"].Value);
                SectionsForm sectionsForm = new SectionsForm(ctrl, idConf);
                sectionsForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

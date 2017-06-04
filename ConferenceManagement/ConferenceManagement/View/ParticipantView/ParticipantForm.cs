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
using ConferenceManagement.View.ParticipantView;
using ConferenceManagement.View.SectionsView;

namespace ConferenceManagement.View
{
    public partial class ParticipantForm : Form
    {
        ClientController ctrl;
        Participant participant;
        public LoginForm parentLoginForm { set; get; }
        public ParticipantForm(ClientController ctr,Participant part)
        {
            InitializeComponent();
            ctrl = ctr;
            participant = part;
            setDataGrid();
        }

        private void setDataGrid()
        {
            var bindingList = new BindingList<Conference>(ctrl.getAllConferences());
            Conferences_dataGridView.DataSource = bindingList;
            Conferences_dataGridView.Columns[4].Visible = false;
        }

        private void attendConference_button_Click(object sender, EventArgs e)
        {
            if (Conferences_dataGridView.RowCount == 0)
            {
                MessageBox.Show("There's no conference!");
                return;
            }
            try
            {
                int selectedrowindex = Conferences_dataGridView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = Conferences_dataGridView.Rows[selectedrowindex];
                int idConf = Convert.ToInt16(selectedRow.Cells["Id"].Value);
                ctrl.attendToConference(participant.ID, idConf);
                PaymentView payment = new PaymentView();
                payment.Show();
                

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button_back_Click(object sender, EventArgs e)
        {
            ctrl.logout(participant.Username);
            this.Hide();
            parentLoginForm.Show();
        }

        private void btnSections_Click(object sender, EventArgs e)
        {
            if(Conferences_dataGridView.RowCount == 0)
            {
                MessageBox.Show("There's no conference!");
                return;
            }
            try
            {
                int selectedrowindex = Conferences_dataGridView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = Conferences_dataGridView.Rows[selectedrowindex];
                int idConf = Convert.ToInt16(selectedRow.Cells["Id"].Value);
                SectionsForm sectionsForm = new SectionsForm(ctrl, idConf);
                sectionsForm.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

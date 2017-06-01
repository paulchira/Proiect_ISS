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

namespace ConferenceManagement.View
{
    public partial class ParticipantForm : Form
    {
        ClientController ctrl;
        Participant participant;

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
        }

        private void attendConference_button_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedrowindex = Conferences_dataGridView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = Conferences_dataGridView.Rows[selectedrowindex];
                int idConf = Convert.ToInt16(selectedRow.Cells["Id"].Value);
                ctrl.attendToConference(participant.ID, idConf);
                //PaymentForm payment = new PaymentForm();
                //this.Hide();
                //payment.Show();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}

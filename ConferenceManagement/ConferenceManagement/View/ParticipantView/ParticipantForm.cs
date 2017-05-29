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

        public ParticipantForm(ClientController ctr)
        {
            InitializeComponent();
            ctrl = ctr;
            setDataGrid();
        }

        private void setDataGrid()
        {
            var bindingList = new BindingList<Conference>(ctrl.getAllConferences());
            Conferences_dataGridView.DataSource = bindingList;
        }

    }
}

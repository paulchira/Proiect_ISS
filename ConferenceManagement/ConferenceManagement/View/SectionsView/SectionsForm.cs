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
namespace ConferenceManagement.View.SectionsView
{
    public partial class SectionsForm : Form
    {
        private ClientController ctrl;
        public SectionsForm(ClientController ctr,int idConf)
        {
            InitializeComponent();
            ctrl = ctr;
            List<String> sections = ctrl.getSectionsByConference(idConf);
            listBox.DataSource = sections;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

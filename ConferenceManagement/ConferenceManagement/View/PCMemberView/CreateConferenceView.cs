using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConferenceManagement.Model;
using ConferenceManagement.Client;
using System.Globalization;

namespace ConferenceManagement.View.PCMemberView
{
    
    public partial class CreateConferenceView : Form
    {
        ClientController ctrl;
        public PCMemberForm parentForm { set; get; }
        public CreateConferenceView(ClientController ctrl)
        {
            this.ctrl = ctrl;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string conferenceName = textBoxConferenceName.Text;
            string conferenceDate = textBoxConferenceDate.Text;

            string conferenceEdition = textBoxConferenceEdition.Text;
            string sections = richTextBoxConferenceSection.Text;

            ctrl.addConference(new Conference(conferenceName, conferenceDate, conferenceEdition));

            
            int ID = ctrl.getConferenceIdFromName(conferenceName);

            string[] stringSeparators = new string[] { "," };
            string[] lines = sections.Split(stringSeparators, StringSplitOptions.None);
            foreach (string s in lines)
            {
                Section section = new Section(s, ID);
                ctrl.addSection(section);
            }
            MessageBox.Show("Conference created!");
            this.Close();

        }

        private void richTextBoxConferenceSection_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            parentForm.Show();
        }
    }
}

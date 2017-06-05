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
        public delegate void UpdateListBoxCallback(DataGridView list, List<Conference> data);

        public CreateConferenceView(ClientController ctrl)
        {
            this.ctrl = ctrl;
            ctrl.updateEvent += Ctrl_updateEvent; ;
            InitializeComponent();
        }

        private void Ctrl_updateEvent(object sender, ClientEvents e)
        {
            if (e.UserEvent == UserEvent.newConference)
            {
                int idConf = int.Parse(e.Data.ToString());
                List<Conference> listConf = ctrl.getAllPlannedConferences();
                parentForm.dataGridView2.Invoke(new UpdateListBoxCallback(this.updateListBox), new Object[] {parentForm.dataGridView2, listConf });
            }
        }

        private void updateListBox(DataGridView listBox, List<Conference> newData)
        {
            listBox.DataSource = null;
            listBox.DataSource = newData;
            listBox.Columns[4].Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string conferenceName = textBoxConferenceName.Text;
                string conferenceDate = textBoxConferenceDate.Text;

                string conferenceEdition = textBoxConferenceEdition.Text;
                string sections = richTextBoxConferenceSection.Text;

                if (conferenceName.Equals(String.Empty) || conferenceDate.Equals(String.Empty) || conferenceEdition.Equals(String.Empty) || sections.Equals(String.Empty))
                {
                    MessageBox.Show("All fields are mandatory!");
                    return;
                }

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
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

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

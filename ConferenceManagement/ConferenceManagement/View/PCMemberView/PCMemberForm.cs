using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConferenceManagement.View.PCMemberView
{
    public partial class PCMemberForm : Form
    {
        public PCMemberForm()
        {
            InitializeComponent();
        }

        // Opens the window with the list of the articles for this conference.
        private void SubmittedArticles_button_Click(object sender, EventArgs e)
        {
            SubmittedArticlesForm submittedArticlesForm = new SubmittedArticlesForm();
            submittedArticlesForm.Show();
        }

        // Opens the window with the list of the participants for this conference.
        private void Participants_button_Click(object sender, EventArgs e)
        {
            ParticipantsListForm participantsList = new ParticipantsListForm();
            participantsList.Show();
        }
    }
}

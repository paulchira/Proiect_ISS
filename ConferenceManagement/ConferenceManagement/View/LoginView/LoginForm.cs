using ConferenceManagement.Model;
using ConferenceManagement.Service;
using ConferenceManagement.View.PCMemberView;
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
using ConferenceManagement.View.LoginView;

namespace ConferenceManagement.View
{
    public partial class LoginForm : Form
    {
        ClientController ctrl;
        public LoginForm(ClientController ctr)
        {
            InitializeComponent();
            ctrl = ctr;
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            String username = username_textBox.Text;
            String password = password_textBox.Text;

            try
            {
                User user = ctrl.validateAccount(username, password);
                ctrl.login(username);
                if (user is Author)
                {
                    AuthorForm authorForm = new AuthorForm(ctrl, (Author)user);
                    authorForm.parentForm = this;
                    this.Owner = authorForm;
                    this.Hide();

                    authorForm.Show();
                }

                if (user is Participant)
                {
                    ParticipantForm participantForm = new ParticipantForm(ctrl,(Participant)user);
                    participantForm.parentLoginForm = this;
                    this.Owner = participantForm;
                    this.Hide();

                    participantForm.Show();
                }

                if (user is PCMember)
                {
                    PCMemberForm pcMemberForm = new PCMemberForm(ctrl,(PCMember)user);
                    pcMemberForm.parentForm = this;
                    this.Owner = pcMemberForm;
                    this.Hide();

                    pcMemberForm.Show();
                }

                if (user is Reviewer)
                {
                    ReviewerForm reviewerForm = new ReviewerForm(ctrl, (Reviewer)user);
                    reviewerForm.parentForm = this;
                    this.Owner = reviewerForm;
                    this.Hide();

                    reviewerForm.Show();
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void button_SignUp_Click(object sender, EventArgs e)
        {
            SignUpForm signup = new SignUpForm(ctrl);
            signup.parentForm = this;
            this.Owner = signup;
            this.Hide();
            signup.Show();
        }
    }
}

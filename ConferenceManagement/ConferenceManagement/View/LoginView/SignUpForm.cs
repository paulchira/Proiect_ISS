using ConferenceManagement.Client;
using ConferenceManagement.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ConferenceManagement.View.LoginView
{
    public partial class SignUpForm : Form

    {
        ClientController ctrl;
        Dictionary<string, int> dict = new Dictionary<string, int>();
        public LoginForm parentForm { set; get; }

        public SignUpForm(ClientController c)
        {
            ctrl = c;
            InitializeComponent();
            dict.Add("Author", 1);
            dict.Add("Participant", 2);
            dict.Add("Reviewer", 3);
            dict.Add("PC Member", 4);


        }

        private void button_signUp_Click(object sender, EventArgs e)
        {
            string role = (string)comboBox_roles.SelectedItem;
            if (textBox_firstName.Text.Equals(String.Empty) 
                || textBox_lastName.Text.Equals(String.Empty)
                || textBox_pass.Text.Equals(String.Empty) 
                || textBox_pass2.Text.Equals(String.Empty)
                || textBox_userName.Text.Equals(String.Empty)
                || role.Equals(String.Empty)
                )
            {
                MessageBox.Show("All fields are mandatory!");
                return;
            }
            try
            {
                if (textBox_pass.Text.Equals( textBox_pass2.Text))
                {
                    User u = new Model.User(textBox_firstName.Text, textBox_lastName.Text, textBox_userName.Text, textBox_pass.Text);

                    int idRole = dict[(string)comboBox_roles.SelectedItem];
                    ctrl.signUp(u, idRole);
                    MessageBox.Show("The account was created!");
                }
                else
                {
                    MessageBox.Show("The passwords don't match!");
                }
                this.Hide();
                parentForm.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            parentForm.Show();
        }
    }
}

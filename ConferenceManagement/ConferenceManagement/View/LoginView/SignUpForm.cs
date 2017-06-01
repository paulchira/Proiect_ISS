using ConferenceManagement.Client;
using ConferenceManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConferenceManagement.View.LoginView
{
    public partial class SignUpForm : Form

    {
        ClientController ctrl;
        Dictionary<string, int> dict = new Dictionary<string, int>();
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
            if(textBox_pass.Text == textBox_pass2.Text)
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
            this.Close();
        }
    }
}

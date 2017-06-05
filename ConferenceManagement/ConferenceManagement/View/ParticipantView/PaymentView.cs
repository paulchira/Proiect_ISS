using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConferenceManagement.View.ParticipantView
{
    public partial class PaymentView : Form
    {
        public PaymentView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Equals(String.Empty) ||
                    comboBox1.SelectedItem.ToString().Equals(String.Empty)
                    || comboBox2.SelectedItem.ToString().Equals(String.Empty)
                    || textBox2.Text.Equals(string.Empty))
                {
                    MessageBox.Show("All fields are mandatory!");
                    return;
                }
                MessageBox.Show("Succes!");
                this.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

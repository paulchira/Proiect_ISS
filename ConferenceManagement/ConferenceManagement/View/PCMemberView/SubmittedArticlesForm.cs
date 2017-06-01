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

namespace ConferenceManagement.View.PCMemberView
{
    public partial class SubmittedArticlesForm : Form
    {
        ClientController ctrl;
        public SubmittedArticlesForm(ClientController ctr,int id,string name)
        {
            InitializeComponent();
            ctrl = ctr;
            conferenceName_textBox.Text = name;
            dataGridView1.DataSource = ctrl.getUnreviewedArticles(id);
            reviewerList_comboBox.DataSource = ctrl.getAvailableReviewers();
            reviewerList_comboBox.DisplayMember="FirstName";
            reviewerList_comboBox.ValueMember = "ID";

        }

        private void requireReview_button_Click(object sender, EventArgs e)
        {
            int idReviewer = (int)reviewerList_comboBox.SelectedValue;
            string sidArticle = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            int idArticle = Int16.Parse(sidArticle);
            
            ctrl.addReview(new Review(idArticle, idReviewer));
            MessageBox.Show("Succesfully added User " + reviewerList_comboBox.Text + " to review article " + dataGridView1.CurrentRow.Cells[1].Value.ToString());
        }
    }
}

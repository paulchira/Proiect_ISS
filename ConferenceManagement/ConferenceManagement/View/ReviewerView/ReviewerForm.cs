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
using ConferenceManagement.View.ReviewerView;

namespace ConferenceManagement.View
{
    public partial class ReviewerForm : Form
    {
        ClientController ctrl;
        Reviewer reviewer;
        public LoginForm parentForm { set; get; }
        public ReviewerForm(ClientController ctr, Reviewer reviewer)
        {
            InitializeComponent();
            ctrl = ctr;
            this.reviewer = reviewer;
            setDataGrid();
        }
        private void setDataGrid()
        {
            var bindingList = new BindingList<Article>(ctrl.getAllArticles(this.reviewer.ID));
            reviewer_dataGridView.DataSource = bindingList;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void submitReview_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            string idArticle = reviewer_dataGridView.CurrentRow.Cells[0].Value.ToString();
            string articleTitle = reviewer_dataGridView.CurrentRow.Cells[1].Value.ToString();
            string articleAbstract= reviewer_dataGridView.CurrentRow.Cells[2].Value.ToString();
            string articleText = reviewer_dataGridView.CurrentRow.Cells[3].Value.ToString();
            string upload = reviewer_dataGridView.CurrentRow.Cells[4].Value.ToString();
            string sectionId = reviewer_dataGridView.CurrentRow.Cells[5].Value.ToString();
            Article a = new Article(Int16.Parse(idArticle),articleTitle,articleAbstract,articleText,upload,Int16.Parse(sectionId));

            ReviewArticleForm f2 = new ReviewArticleForm(ctrl,reviewer,a);
            f2.parentForm = this;
            this.Owner = f2;
            this.Hide();
            f2.Show();
            
        }

        private void ReviewerForm_Load(object sender, EventArgs e)
        {

        }

        private void button_back_Click(object sender, EventArgs e)
        {
            ctrl.logout(reviewer.Username);
            this.Hide();
            parentForm.Show();
        }
    }
}

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

namespace ConferenceManagement.View.ReviewerView
{
    public partial class ReviewsList : Form
    {
        ClientController ctrl;
        Reviewer reviewer;
        Article article;
        int a;
        public ReviewerForm parentForm { set; get; }
        public ReviewsList(ClientController ctr, Reviewer reviewer,Article article)
        {
            InitializeComponent();
            ctrl = ctr;
            this.reviewer = reviewer;
            this.article = article;
            a = this.article.IdArticle;
            setDataGrid();
        }
        private void setDataGrid()
        {
            //Console.WriteLine(a);
            var bindingList = new BindingList<Review>(ctrl.getAllReviews(this.reviewer.ID,a));
            dataGridView1.DataSource = bindingList;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReviewerForm f2 = new ReviewerForm(ctrl,reviewer);
            this.Hide();
            f2.Show();
      
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ReviewsList_Load(object sender, EventArgs e)
        {

        }
    }
}

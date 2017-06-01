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

namespace ConferenceManagement.View.ReviewerView
{
    public partial class ReviewArticleForm : Form
    {
        ClientController ctrl;
        Article article;
        public ReviewArticleForm(ClientController ctr, Article article)
        {
            InitializeComponent();
            ctrl = ctr;
            this.article = article;
            textBox_ArticleTitle.Text = article.ArticleTitle;
        }

        private void SubmitReview_button_Click(object sender, EventArgs e)
        {
            // RepositoryPCMember.add()
        }
    }
}

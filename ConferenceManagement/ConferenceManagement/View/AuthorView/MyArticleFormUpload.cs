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

namespace ConferenceManagement.View.AuthorView
{
    public partial class MyArticleFormUpload : Form
    {
        private ClientController ctrl;
        private Article article;
        private ListBox listBox;
        private int idAuthor;
        public MyArticleFormUpload()
        {
            InitializeComponent();
        }

        public ClientController Ctrl
        {
            get
            {
                return ctrl;
            }

            set
            {
                ctrl = value;
            }
        }

        public Article Article
        {
            get
            {
                return article;
            }

            set
            {
                article = value;
            }
        }

        public ListBox ListBox
        {
            get
            {
                return listBox;
            }

            set
            {
                listBox = value;
            }
        }

        public int IdAuthor
        {
            get
            {
                return idAuthor;
            }

            set
            {
                idAuthor = value;
            }
        }

        public void initializeUploadComponents()
        {

        }

        private void button_upload_Click(object sender, EventArgs e)
        {
            String textArticle = richTextBox_upload.Text;
            if (textArticle.Equals(string.Empty))
            {
                MessageBox.Show("Article is empty!");
                return;
            }
            Article newA = new Article();
            newA.IdArticle = article.IdArticle;
            newA.ArticleTitle = article.ArticleTitle;
            newA.ArticleAbstract = article.ArticleAbstract;
            newA.ArticleText = textArticle;
            newA.Upload = "YES";
            newA.SectionId = article.SectionId;

            ctrl.updateArticle(article,newA);
            listBox.DataSource = getAllArticlesforAuthor();
            MessageBox.Show("Succes");
            this.Hide();
        }

        private List<string> getAllArticlesforAuthor()
        {
            List<string> articles = new List<string>();
            List<Int16> author_articles = ctrl.getAllArticlesforAuthor(idAuthor);

            foreach (Int16 article in author_articles)
            {
                Article a = ctrl.findOneArticle(article);
                articles.Add(a.IdArticle + " " + a.ArticleTitle + " " + a.Upload);
            }
            return articles;
        }
    }
}

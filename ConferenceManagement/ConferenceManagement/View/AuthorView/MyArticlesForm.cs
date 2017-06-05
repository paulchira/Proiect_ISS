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
    // Manages the articles of an author
    public partial class MyArticlesForm : Form
    {
        private AuthorForm parentFormAuthor;
        private ClientController ctrl;
        private Author author;
        public delegate void UpdateListBoxCallback(ListBox list, List<string> data);
        public MyArticlesForm(ClientController ctr)
        {
            InitializeComponent();
            ctrl = ctr;
            Ctrl.updateEvent += Ctrl_updateEvent;
        }

        private void Ctrl_updateEvent(object sender, ClientEvents e)
        {
            if (e.UserEvent == UserEvent.newArticle)
            {
                List<string> listArticle = getAllArticlesforAuthor();
                listBox_myArticles.Invoke(new UpdateListBoxCallback(this.updateListBox), new Object[] { listBox_myArticles, listArticle });
            }
        }

        private void updateListBox(ListBox list, List<string> newData)
        {
            list.DataSource = null;
            list.DataSource = newData;
        }


        public void initializeAuthorComponents()
        {
            listBox_myArticles.DataSource = getAllArticlesforAuthor();
        }

        public AuthorForm ParentFormAuthor
        {
            get
            {
                return parentFormAuthor;
            }

            set
            {
                parentFormAuthor = value;
            }
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

        public Author Author
        {
            get
            {
                return author;
            }

            set
            {
                author = value;
            }
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();

            parentFormAuthor.Show();
        }

        private List<string> getAllArticlesforAuthor()
        {
            List<string> articles = new List<string>();
            List<Int16> author_articles = ctrl.getAllArticlesforAuthor(author.ID);
            
            foreach(Int16 article in author_articles)
            {
                Article a = ctrl.findOneArticle(article);
                articles.Add(a.IdArticle + " " + a.ArticleTitle + " " + a.Upload);
            }
            return articles;
        }

        private void listBox_myArticles_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void uploadArticle_button_Click(object sender, EventArgs e)
        {
            try
            {
                MyArticleFormUpload myarticle = new MyArticleFormUpload();

                if (listBox_myArticles.SelectedItem == null)
                {
                    MessageBox.Show("Please select an article");
                    return;
                }
                String selectedArticle = (String)listBox_myArticles.SelectedItem;
                if (selectedArticle != null)
                {
                    String[] upload_val = selectedArticle.Split(' ');
                    if (upload_val[2].Equals("yes") || upload_val[2].Equals("YES"))
                    {
                        MessageBox.Show("Article is uploaded");
                        return;
                    }
                    myarticle.Article = ctrl.findOneArticle(Convert.ToInt16(upload_val[0]));
                    myarticle.IdAuthor = author.ID;
                    myarticle.ListBox = listBox_myArticles;
                }
                myarticle.Ctrl = this.ctrl;
                myarticle.initializeUploadComponents();

                myarticle.Show();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

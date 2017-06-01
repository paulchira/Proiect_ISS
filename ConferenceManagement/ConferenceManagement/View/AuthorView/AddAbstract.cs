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
    public partial class AddAbstract : Form
    {
        private AuthorForm parentFormAuthor;
        private ClientController ctrl;
        private Author author;

        public AddAbstract()
        {
            InitializeComponent();
        }

        public void initializeAuthorComponents()
        {
            comboBox_section.DataSource = getAllSectionName(); 
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

        private void button_addAbstract_Click(object sender, EventArgs e)
        {
            addAbstractArticle();
        }

        //returns a list with all sections name which will be set to combobox
        private List<String> getAllSectionName()
        {
            List<Section> sections = ctrl.getAllSections();
            List<String> sectionsName = new List<String>();
            foreach(Section section in sections)
            {
                sectionsName.Add(section.SectionName);
            }
            return sectionsName;
        }

        //return idSection from nameSection
        private int getIdSection(string sectionName)
        {
            List<Section> sections = ctrl.getAllSections();
            int idSection = -1;
            foreach (Section section in sections)
            {
                if (section.SectionName.Equals(sectionName))
                {
                    idSection = section.IdSection;
                }
            }
            return idSection;
        }

        //add article(IN ARTICLE TABLE) with upload : not and articleText : null
        private void addAbstractArticle()
        {
            try
            {
                string articleTitle = textBox_title.Text;
                string articleAbastract = richTextBox_abstract.Text;
                string section = (string)comboBox_section.SelectedItem;
                Article article = new Article(-1,articleTitle,articleAbastract,getIdSection(section));
                ctrl.addArticle(article);
                
                ctrl.addArticleAuthor(getIdArticle(articleTitle), author.ID);
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private int getIdArticle(string articleTitle)
        {
            List<Article> articles = ctrl.getAllArticles();
            int idArticle = -1;
            foreach(Article article in articles)
            {
                if (article.ArticleTitle.Equals(articleTitle)){
                    idArticle = article.IdArticle;
                }
            }
            return idArticle;
        }
    }
}

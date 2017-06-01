using ConferenceManagement.View.AuthorView;
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

namespace ConferenceManagement.View
{
    public partial class AuthorForm : Form
    {
        ClientController ctrl;
        Author author;
        AuthorForm currentAuthorForm;

        public AuthorForm(ClientController ctr,Author au)
        {
            InitializeComponent();
            ctrl = ctr;
            author = au;
            setDataGrid();
            currentAuthorForm = this;
        }

        private void setDataGrid()
        {
            var bindingList = new BindingList<Conference>(ctrl.getAllConferences());
            conferences_dataGridView.DataSource = bindingList;
        }

        /// <summary>
        /// Redirects to the window with the articles submitted by an author
        /// </summary>
        private void myArticles_button_Click(object sender, EventArgs e)
        {
            MyArticlesForm myArticlesForm = new MyArticlesForm();
            myArticlesForm.Ctrl = this.ctrl;
            myArticlesForm.ParentFormAuthor = this;
            myArticlesForm.initializeAuthorComponents();
            this.Owner = myArticlesForm;
            this.Hide();

            myArticlesForm.Show();
        }

        private void submitArticle_button_Click(object sender, EventArgs e)
        {
            AddAbstract addAbstract = new AddAbstract();
            addAbstract.Ctrl = this.ctrl;
            addAbstract.ParentFormAuthor = this;
            addAbstract.Author = this.author;
            addAbstract.initializeAuthorComponents();
            this.Owner = addAbstract;
            this.Hide();
           
            addAbstract.Show();
        }
    }
}

using ConferenceManagement.View.AuthorView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using ConferenceManagement.Client;
using ConferenceManagement.Model;
using ConferenceManagement.View.SectionsView;

namespace ConferenceManagement.View
{
    public partial class AuthorForm : Form
    {
        ClientController ctrl;
        Author author;
        AuthorForm currentAuthorForm;
        public LoginForm parentForm { set; get; }

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
            var bindingList = new BindingList<Conference>(ctrl.getAllPlannedConferences());
            conferences_dataGridView.DataSource = bindingList;
            conferences_dataGridView.Columns[4].Visible = false;
        }

        /// <summary>
        /// Redirects to the window with the articles submitted by an author
        /// </summary>
        private void myArticles_button_Click(object sender, EventArgs e)
        {
            MyArticlesForm myArticlesForm = new MyArticlesForm(ctrl);
            myArticlesForm.ParentFormAuthor = this;
            myArticlesForm.Author = author;
            myArticlesForm.initializeAuthorComponents();
            this.Owner = myArticlesForm;
            this.Hide();

            myArticlesForm.Show();
        }

        private void submitArticle_button_Click(object sender, EventArgs e)
        {
            if(conferences_dataGridView.CurrentRow.DataBoundItem != null)
            {
                Conference conference = (Conference)conferences_dataGridView.CurrentRow.DataBoundItem;
                AddAbstract addAbstract = new AddAbstract();
                addAbstract.Ctrl = this.ctrl;
                addAbstract.ParentFormAuthor = this;
                addAbstract.Author = this.author;
                addAbstract.Conference = conference;
                addAbstract.initializeAuthorComponents();
                this.Owner = addAbstract;
                this.Hide();
                addAbstract.Show();

            }else
            {
                MessageBox.Show("Please select a conference!");
            }
           
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            ctrl.logout(author.Username);
            this.Hide();
            parentForm.Show();
        }

        private void btnSections_Click(object sender, EventArgs e)
        {
            if (conferences_dataGridView.RowCount == 0)
            {
                MessageBox.Show("There's no conference!");
                return;
            }
            try
            {
                int selectedrowindex = conferences_dataGridView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = conferences_dataGridView.Rows[selectedrowindex];
                int idConf = Convert.ToInt16(selectedRow.Cells["Id"].Value);
                SectionsForm sectionsForm = new SectionsForm(ctrl, idConf);
                sectionsForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

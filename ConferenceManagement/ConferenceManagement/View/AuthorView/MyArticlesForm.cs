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
        AuthorForm parentFormAuthor;

        public MyArticlesForm()
        {
            InitializeComponent();
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

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();

            parentFormAuthor.Show();
        }
    }
}

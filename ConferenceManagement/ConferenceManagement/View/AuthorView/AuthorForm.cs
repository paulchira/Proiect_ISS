﻿using ConferenceManagement.View.AuthorView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConferenceManagement.View
{
    public partial class AuthorForm : Form
    {
        public AuthorForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Redirects to the window with the articles submitted by an author
        /// </summary>
        private void myArticles_button_Click(object sender, EventArgs e)
        {
            MyArticlesForm myArticlesForm = new MyArticlesForm();
            myArticlesForm.Show();
        }
    }
}
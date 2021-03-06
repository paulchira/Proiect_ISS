﻿using System;
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
        Reviewer reviewer;
        
        public ReviewerForm parentForm { set; get; }
        public ReviewArticleForm(ClientController ctr, Reviewer reviewer, Article article)
        {
            InitializeComponent();
            ctrl = ctr;
            this.reviewer = reviewer;
            this.article = article;
            textBox_ArticleTitle.Text = article.ArticleTitle;
        }

        private void SubmitReview_button_Click_1(object sender, EventArgs e)
        {
            int calificativ = 0;
            if (checkBox1.Checked) calificativ = 1;
            if (checkBox2.Checked) calificativ = 2;
            if (checkBox3.Checked) calificativ = 3;
            if (checkBox4.Checked) calificativ = 4;
            if (checkBox5.Checked) calificativ = 5;
            if (checkBox6.Checked) calificativ = 6;
            if (checkBox7.Checked) calificativ = 7;

            if (calificativ == 0 || richTextBox1.Text.Equals(String.Empty))
            {
                MessageBox.Show("All fields are mandatory!");
                return;
            }
            else {
                ctrl.insertReview(reviewer.ID, article.IdArticle, richTextBox1.Text, calificativ);


                MessageBox.Show("Your vote has been recorded!");

            }
        }

        private void ReviewArticleForm_Load(object sender, EventArgs e)
        {

        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            parentForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReviewsList f3 = new ReviewsList(ctrl, reviewer,article);
            //f3.parentForm = this;
            this.Owner = f3;
            this.Hide();
            f3.Show();
        }
    }
}

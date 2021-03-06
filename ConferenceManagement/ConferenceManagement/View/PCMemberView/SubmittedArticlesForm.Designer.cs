﻿namespace ConferenceManagement.View.PCMemberView
{
    partial class SubmittedArticlesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.reviewerList_comboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.requireReview_button = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.conferenceName_text = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conference name: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(405, 175);
            this.dataGridView1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Submitted articles: ";
            // 
            // reviewerList_comboBox
            // 
            this.reviewerList_comboBox.FormattingEnabled = true;
            this.reviewerList_comboBox.Location = new System.Drawing.Point(204, 309);
            this.reviewerList_comboBox.Name = "reviewerList_comboBox";
            this.reviewerList_comboBox.Size = new System.Drawing.Size(121, 21);
            this.reviewerList_comboBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Available reviewers: ";
            // 
            // requireReview_button
            // 
            this.requireReview_button.BackColor = System.Drawing.Color.PaleTurquoise;
            this.requireReview_button.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requireReview_button.Location = new System.Drawing.Point(112, 361);
            this.requireReview_button.Name = "requireReview_button";
            this.requireReview_button.Size = new System.Drawing.Size(162, 40);
            this.requireReview_button.TabIndex = 6;
            this.requireReview_button.Text = "Require review";
            this.requireReview_button.UseVisualStyleBackColor = false;
            this.requireReview_button.Click += new System.EventHandler(this.requireReview_button_Click);
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button_back.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_back.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button_back.Location = new System.Drawing.Point(435, 12);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(89, 33);
            this.button_back.TabIndex = 10;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // conferenceName_text
            // 
            this.conferenceName_text.AutoSize = true;
            this.conferenceName_text.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conferenceName_text.ForeColor = System.Drawing.SystemColors.Highlight;
            this.conferenceName_text.Location = new System.Drawing.Point(172, 8);
            this.conferenceName_text.Name = "conferenceName_text";
            this.conferenceName_text.Size = new System.Drawing.Size(64, 33);
            this.conferenceName_text.TabIndex = 11;
            this.conferenceName_text.Text = "name";
            // 
            // SubmittedArticlesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(536, 459);
            this.Controls.Add(this.conferenceName_text);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.requireReview_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.reviewerList_comboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "SubmittedArticlesForm";
            this.Text = "SubmittedArticlesForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox reviewerList_comboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button requireReview_button;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Label conferenceName_text;
    }
}
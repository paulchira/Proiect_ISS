namespace ConferenceManagement.View.ReviewerView
{
    partial class ReviewArticleForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.downloadArticle_button = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SubmitReview_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(127, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Article title:";
            // 
            // downloadArticle_button
            // 
            this.downloadArticle_button.BackColor = System.Drawing.Color.SkyBlue;
            this.downloadArticle_button.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadArticle_button.Location = new System.Drawing.Point(380, 24);
            this.downloadArticle_button.Name = "downloadArticle_button";
            this.downloadArticle_button.Size = new System.Drawing.Size(120, 32);
            this.downloadArticle_button.TabIndex = 2;
            this.downloadArticle_button.Text = "Download article";
            this.downloadArticle_button.UseVisualStyleBackColor = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.PowderBlue;
            this.richTextBox1.Location = new System.Drawing.Point(12, 88);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(410, 236);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // SubmitReview_button
            // 
            this.SubmitReview_button.BackColor = System.Drawing.Color.SkyBlue;
            this.SubmitReview_button.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitReview_button.Location = new System.Drawing.Point(380, 376);
            this.SubmitReview_button.Name = "SubmitReview_button";
            this.SubmitReview_button.Size = new System.Drawing.Size(170, 38);
            this.SubmitReview_button.TabIndex = 4;
            this.SubmitReview_button.Text = "Submit my review";
            this.SubmitReview_button.UseVisualStyleBackColor = false;
            // 
            // ReviewArticleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(562, 460);
            this.Controls.Add(this.SubmitReview_button);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.downloadArticle_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "ReviewArticleForm";
            this.Text = "ReviewArticleForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button downloadArticle_button;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button SubmitReview_button;
    }
}
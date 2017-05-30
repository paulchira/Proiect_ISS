namespace ConferenceManagement.View.AuthorView
{
    partial class MyArticlesForm
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
            this.myArticles_dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.uploadArticle_button = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.myArticles_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // myArticles_dataGridView
            // 
            this.myArticles_dataGridView.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.myArticles_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myArticles_dataGridView.Location = new System.Drawing.Point(12, 73);
            this.myArticles_dataGridView.Name = "myArticles_dataGridView";
            this.myArticles_dataGridView.Size = new System.Drawing.Size(350, 181);
            this.myArticles_dataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "My articles:";
            // 
            // uploadArticle_button
            // 
            this.uploadArticle_button.BackColor = System.Drawing.Color.SkyBlue;
            this.uploadArticle_button.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadArticle_button.Location = new System.Drawing.Point(91, 287);
            this.uploadArticle_button.Name = "uploadArticle_button";
            this.uploadArticle_button.Size = new System.Drawing.Size(199, 46);
            this.uploadArticle_button.TabIndex = 2;
            this.uploadArticle_button.Text = "Upload complete article";
            this.uploadArticle_button.UseVisualStyleBackColor = false;
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.OrangeRed;
            this.button_back.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_back.Location = new System.Drawing.Point(440, 9);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(78, 32);
            this.button_back.TabIndex = 3;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // MyArticlesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(530, 438);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.uploadArticle_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.myArticles_dataGridView);
            this.Name = "MyArticlesForm";
            this.Text = "MyArticlesForm";
            ((System.ComponentModel.ISupportInitialize)(this.myArticles_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView myArticles_dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button uploadArticle_button;
        private System.Windows.Forms.Button button_back;
    }
}
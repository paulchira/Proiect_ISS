namespace ConferenceManagement.View.AuthorView
{
    partial class MyArticleFormUpload
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
            this.richTextBox_upload = new System.Windows.Forms.RichTextBox();
            this.button_upload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox_upload
            // 
            this.richTextBox_upload.BackColor = System.Drawing.Color.PowderBlue;
            this.richTextBox_upload.Location = new System.Drawing.Point(51, 37);
            this.richTextBox_upload.Name = "richTextBox_upload";
            this.richTextBox_upload.Size = new System.Drawing.Size(297, 155);
            this.richTextBox_upload.TabIndex = 0;
            this.richTextBox_upload.Text = "";
            // 
            // button_upload
            // 
            this.button_upload.BackColor = System.Drawing.Color.SkyBlue;
            this.button_upload.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_upload.Location = new System.Drawing.Point(150, 224);
            this.button_upload.Name = "button_upload";
            this.button_upload.Size = new System.Drawing.Size(87, 34);
            this.button_upload.TabIndex = 1;
            this.button_upload.Text = "Upload";
            this.button_upload.UseVisualStyleBackColor = false;
            this.button_upload.Click += new System.EventHandler(this.button_upload_Click);
            // 
            // MyArticleFormUpload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(401, 281);
            this.Controls.Add(this.button_upload);
            this.Controls.Add(this.richTextBox_upload);
            this.Name = "MyArticleFormUpload";
            this.Text = "MyArticleFormUpload";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_upload;
        private System.Windows.Forms.Button button_upload;
    }
}
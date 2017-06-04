namespace ConferenceManagement.View
{
    partial class AuthorForm
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
            this.conferences_dataGridView = new System.Windows.Forms.DataGridView();
            this.submitArticle_button = new System.Windows.Forms.Button();
            this.myArticles_button = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.btnSections = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.conferences_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Upcoming conferences:";
            // 
            // conferences_dataGridView
            // 
            this.conferences_dataGridView.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.conferences_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.conferences_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.conferences_dataGridView.Location = new System.Drawing.Point(33, 93);
            this.conferences_dataGridView.Name = "conferences_dataGridView";
            this.conferences_dataGridView.Size = new System.Drawing.Size(331, 175);
            this.conferences_dataGridView.TabIndex = 3;
            // 
            // submitArticle_button
            // 
            this.submitArticle_button.BackColor = System.Drawing.Color.PaleTurquoise;
            this.submitArticle_button.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitArticle_button.Location = new System.Drawing.Point(45, 324);
            this.submitArticle_button.Name = "submitArticle_button";
            this.submitArticle_button.Size = new System.Drawing.Size(181, 34);
            this.submitArticle_button.TabIndex = 4;
            this.submitArticle_button.Text = "Submit an article";
            this.submitArticle_button.UseVisualStyleBackColor = false;
            this.submitArticle_button.Click += new System.EventHandler(this.submitArticle_button_Click);
            // 
            // myArticles_button
            // 
            this.myArticles_button.BackColor = System.Drawing.Color.PaleTurquoise;
            this.myArticles_button.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myArticles_button.Location = new System.Drawing.Point(434, 93);
            this.myArticles_button.Name = "myArticles_button";
            this.myArticles_button.Size = new System.Drawing.Size(127, 35);
            this.myArticles_button.TabIndex = 5;
            this.myArticles_button.Text = "My articles";
            this.myArticles_button.UseVisualStyleBackColor = false;
            this.myArticles_button.Click += new System.EventHandler(this.myArticles_button_Click);
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button_back.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_back.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button_back.Location = new System.Drawing.Point(460, 17);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(89, 33);
            this.button_back.TabIndex = 8;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // btnSections
            // 
            this.btnSections.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSections.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSections.Location = new System.Drawing.Point(434, 165);
            this.btnSections.Name = "btnSections";
            this.btnSections.Size = new System.Drawing.Size(127, 35);
            this.btnSections.TabIndex = 9;
            this.btnSections.Text = "Sections";
            this.btnSections.UseVisualStyleBackColor = false;
            this.btnSections.Click += new System.EventHandler(this.btnSections_Click);
            // 
            // AuthorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(573, 370);
            this.Controls.Add(this.btnSections);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.myArticles_button);
            this.Controls.Add(this.submitArticle_button);
            this.Controls.Add(this.conferences_dataGridView);
            this.Controls.Add(this.label1);
            this.Name = "AuthorForm";
            this.Text = "AuthorForm";
            ((System.ComponentModel.ISupportInitialize)(this.conferences_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView conferences_dataGridView;
        private System.Windows.Forms.Button submitArticle_button;
        private System.Windows.Forms.Button myArticles_button;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button btnSections;
    }
}
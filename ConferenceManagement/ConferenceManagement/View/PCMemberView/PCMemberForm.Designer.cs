namespace ConferenceManagement.View.PCMemberView
{
    partial class PCMemberForm
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.SubmittedArticles_button = new System.Windows.Forms.Button();
            this.Participants_button = new System.Windows.Forms.Button();
            this.createConference = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Upcoming conferences:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 297);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(366, 182);
            this.dataGridView1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Planned conferences:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 80);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(356, 160);
            this.dataGridView2.TabIndex = 3;
            // 
            // SubmittedArticles_button
            // 
            this.SubmittedArticles_button.BackColor = System.Drawing.Color.PaleTurquoise;
            this.SubmittedArticles_button.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmittedArticles_button.Location = new System.Drawing.Point(400, 80);
            this.SubmittedArticles_button.Name = "SubmittedArticles_button";
            this.SubmittedArticles_button.Size = new System.Drawing.Size(174, 66);
            this.SubmittedArticles_button.TabIndex = 4;
            this.SubmittedArticles_button.Text = "See the submitted articles";
            this.SubmittedArticles_button.UseVisualStyleBackColor = false;
            this.SubmittedArticles_button.Click += new System.EventHandler(this.SubmittedArticles_button_Click);
            // 
            // Participants_button
            // 
            this.Participants_button.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Participants_button.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Participants_button.Location = new System.Drawing.Point(400, 308);
            this.Participants_button.Name = "Participants_button";
            this.Participants_button.Size = new System.Drawing.Size(174, 64);
            this.Participants_button.TabIndex = 5;
            this.Participants_button.Text = "See the list of the participants";
            this.Participants_button.UseVisualStyleBackColor = false;
            this.Participants_button.Click += new System.EventHandler(this.Participants_button_Click);
            // 
            // createConference
            // 
            this.createConference.BackColor = System.Drawing.Color.PaleTurquoise;
            this.createConference.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createConference.Location = new System.Drawing.Point(400, 459);
            this.createConference.Name = "createConference";
            this.createConference.Size = new System.Drawing.Size(174, 64);
            this.createConference.TabIndex = 6;
            this.createConference.Text = "Create New Conference";
            this.createConference.UseVisualStyleBackColor = false;
            this.createConference.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.SkyBlue;
            this.button_back.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_back.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button_back.Location = new System.Drawing.Point(500, 12);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(89, 33);
            this.button_back.TabIndex = 10;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // PCMemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(601, 535);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.createConference);
            this.Controls.Add(this.Participants_button);
            this.Controls.Add(this.SubmittedArticles_button);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "PCMemberForm";
            this.Text = "PCMemberForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button SubmittedArticles_button;
        private System.Windows.Forms.Button Participants_button;
        private System.Windows.Forms.Button createConference;
        private System.Windows.Forms.Button button_back;
    }
}
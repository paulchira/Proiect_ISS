namespace ConferenceManagement.View
{
    partial class ParticipantForm
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
            this.Conferences_dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.attendConference_button = new System.Windows.Forms.Button();
            this.submitArticle_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Conferences_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Conferences_dataGridView
            // 
            this.Conferences_dataGridView.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.Conferences_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Conferences_dataGridView.Location = new System.Drawing.Point(25, 90);
            this.Conferences_dataGridView.Name = "Conferences_dataGridView";
            this.Conferences_dataGridView.Size = new System.Drawing.Size(338, 192);
            this.Conferences_dataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Upcoming conferences:";
            // 
            // attendConference_button
            // 
            this.attendConference_button.BackColor = System.Drawing.Color.SkyBlue;
            this.attendConference_button.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attendConference_button.Location = new System.Drawing.Point(407, 105);
            this.attendConference_button.Name = "attendConference_button";
            this.attendConference_button.Size = new System.Drawing.Size(152, 39);
            this.attendConference_button.TabIndex = 2;
            this.attendConference_button.Text = "Attend conference";
            this.attendConference_button.UseVisualStyleBackColor = false;
            this.attendConference_button.Click += new System.EventHandler(this.attendConference_button_Click);
            // 
            // submitArticle_button
            // 
            this.submitArticle_button.BackColor = System.Drawing.Color.SkyBlue;
            this.submitArticle_button.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitArticle_button.Location = new System.Drawing.Point(407, 189);
            this.submitArticle_button.Name = "submitArticle_button";
            this.submitArticle_button.Size = new System.Drawing.Size(152, 39);
            this.submitArticle_button.TabIndex = 3;
            this.submitArticle_button.Text = "Submit an article";
            this.submitArticle_button.UseVisualStyleBackColor = false;
            // 
            // ParticipantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(586, 433);
            this.Controls.Add(this.submitArticle_button);
            this.Controls.Add(this.attendConference_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Conferences_dataGridView);
            this.Name = "ParticipantForm";
            this.Text = "ParticipantForm";
            ((System.ComponentModel.ISupportInitialize)(this.Conferences_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Conferences_dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button attendConference_button;
        private System.Windows.Forms.Button submitArticle_button;
    }
}
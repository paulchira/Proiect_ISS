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
            this.button_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Conferences_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Conferences_dataGridView
            // 
            this.Conferences_dataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.Conferences_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
            this.attendConference_button.BackColor = System.Drawing.Color.PaleTurquoise;
            this.attendConference_button.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attendConference_button.Location = new System.Drawing.Point(406, 106);
            this.attendConference_button.Name = "attendConference_button";
            this.attendConference_button.Size = new System.Drawing.Size(152, 39);
            this.attendConference_button.TabIndex = 2;
            this.attendConference_button.Text = "Attend conference";
            this.attendConference_button.UseVisualStyleBackColor = false;
            this.attendConference_button.Click += new System.EventHandler(this.attendConference_button_Click);
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button_back.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_back.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button_back.Location = new System.Drawing.Point(469, 23);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(89, 33);
            this.button_back.TabIndex = 8;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // ParticipantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(570, 316);
            this.Controls.Add(this.button_back);
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
        private System.Windows.Forms.Button button_back;
    }
}
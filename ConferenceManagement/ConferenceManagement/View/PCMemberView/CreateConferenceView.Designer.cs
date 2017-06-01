namespace ConferenceManagement.View.PCMemberView
{
    partial class CreateConferenceView
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxConferenceName = new System.Windows.Forms.TextBox();
            this.richTextBoxConferenceSection = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxConferenceDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxConferenceEdition = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(202, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxConferenceName
            // 
            this.textBoxConferenceName.Location = new System.Drawing.Point(141, 32);
            this.textBoxConferenceName.Name = "textBoxConferenceName";
            this.textBoxConferenceName.Size = new System.Drawing.Size(269, 20);
            this.textBoxConferenceName.TabIndex = 1;
            // 
            // richTextBoxConferenceSection
            // 
            this.richTextBoxConferenceSection.Location = new System.Drawing.Point(141, 213);
            this.richTextBoxConferenceSection.Name = "richTextBoxConferenceSection";
            this.richTextBoxConferenceSection.Size = new System.Drawing.Size(269, 118);
            this.richTextBoxConferenceSection.TabIndex = 2;
            this.richTextBoxConferenceSection.Text = "";
            this.richTextBoxConferenceSection.TextChanged += new System.EventHandler(this.richTextBoxConferenceSection_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Conference name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sections";
            // 
            // textBoxConferenceDate
            // 
            this.textBoxConferenceDate.Location = new System.Drawing.Point(141, 89);
            this.textBoxConferenceDate.Name = "textBoxConferenceDate";
            this.textBoxConferenceDate.Size = new System.Drawing.Size(269, 20);
            this.textBoxConferenceDate.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date";
            // 
            // textBoxConferenceEdition
            // 
            this.textBoxConferenceEdition.Location = new System.Drawing.Point(141, 145);
            this.textBoxConferenceEdition.Name = "textBoxConferenceEdition";
            this.textBoxConferenceEdition.Size = new System.Drawing.Size(269, 20);
            this.textBoxConferenceEdition.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Edition";
            // 
            // CreateConferenceView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 419);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxConferenceEdition);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxConferenceDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBoxConferenceSection);
            this.Controls.Add(this.textBoxConferenceName);
            this.Controls.Add(this.button1);
            this.Name = "CreateConferenceView";
            this.Text = "CreateConferenceView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxConferenceName;
        private System.Windows.Forms.RichTextBox richTextBoxConferenceSection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxConferenceDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxConferenceEdition;
        private System.Windows.Forms.Label label4;
    }
}
﻿namespace ConferenceManagement.View.PCMemberView
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
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxConferenceEdition = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_back = new System.Windows.Forms.Button();
            this.textBoxConferenceDate = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(206, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxConferenceName
            // 
            this.textBoxConferenceName.Location = new System.Drawing.Point(159, 61);
            this.textBoxConferenceName.Name = "textBoxConferenceName";
            this.textBoxConferenceName.Size = new System.Drawing.Size(269, 20);
            this.textBoxConferenceName.TabIndex = 1;
            // 
            // richTextBoxConferenceSection
            // 
            this.richTextBoxConferenceSection.Location = new System.Drawing.Point(159, 221);
            this.richTextBoxConferenceSection.Name = "richTextBoxConferenceSection";
            this.richTextBoxConferenceSection.Size = new System.Drawing.Size(269, 67);
            this.richTextBoxConferenceSection.TabIndex = 2;
            this.richTextBoxConferenceSection.Text = "";
            this.richTextBoxConferenceSection.TextChanged += new System.EventHandler(this.richTextBoxConferenceSection_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Conference name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sections";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date";
            // 
            // textBoxConferenceEdition
            // 
            this.textBoxConferenceEdition.Location = new System.Drawing.Point(159, 169);
            this.textBoxConferenceEdition.Name = "textBoxConferenceEdition";
            this.textBoxConferenceEdition.Size = new System.Drawing.Size(269, 20);
            this.textBoxConferenceEdition.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Edition";
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button_back.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_back.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button_back.Location = new System.Drawing.Point(483, 12);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(89, 33);
            this.button_back.TabIndex = 9;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // textBoxConferenceDate
            // 
            this.textBoxConferenceDate.Location = new System.Drawing.Point(159, 113);
            this.textBoxConferenceDate.Mask = "00/00/0000";
            this.textBoxConferenceDate.Name = "textBoxConferenceDate";
            this.textBoxConferenceDate.Size = new System.Drawing.Size(72, 20);
            this.textBoxConferenceDate.TabIndex = 10;
            // 
            // CreateConferenceView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(584, 349);
            this.Controls.Add(this.textBoxConferenceDate);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxConferenceEdition);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxConferenceEdition;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.MaskedTextBox textBoxConferenceDate;
    }
}
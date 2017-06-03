namespace ConferenceManagement.View
{
    partial class ReviewerForm
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
            this.reviewer_dataGridView = new System.Windows.Forms.DataGridView();
            this.submitReview_button = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.reviewer_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "To do:";
            // 
            // reviewer_dataGridView
            // 
            this.reviewer_dataGridView.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.reviewer_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reviewer_dataGridView.Location = new System.Drawing.Point(-2, 62);
            this.reviewer_dataGridView.Name = "reviewer_dataGridView";
            this.reviewer_dataGridView.Size = new System.Drawing.Size(559, 186);
            this.reviewer_dataGridView.TabIndex = 1;
            this.reviewer_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // submitReview_button
            // 
            this.submitReview_button.BackColor = System.Drawing.Color.SkyBlue;
            this.submitReview_button.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitReview_button.Location = new System.Drawing.Point(113, 290);
            this.submitReview_button.Name = "submitReview_button";
            this.submitReview_button.Size = new System.Drawing.Size(186, 46);
            this.submitReview_button.TabIndex = 2;
            this.submitReview_button.Text = "Submit review";
            this.submitReview_button.UseVisualStyleBackColor = false;
            this.submitReview_button.Click += new System.EventHandler(this.submitReview_button_Click);
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.SkyBlue;
            this.button_back.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_back.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button_back.Location = new System.Drawing.Point(458, 12);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(89, 33);
            this.button_back.TabIndex = 8;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // ReviewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(559, 409);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.submitReview_button);
            this.Controls.Add(this.reviewer_dataGridView);
            this.Controls.Add(this.label1);
            this.Name = "ReviewerForm";
            this.Text = "ReviewerForm";
            this.Load += new System.EventHandler(this.ReviewerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reviewer_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView reviewer_dataGridView;
        private System.Windows.Forms.Button submitReview_button;
        private System.Windows.Forms.Button button_back;
    }
}

namespace Organiser
{
    partial class Notes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notes));
            this.label1 = new System.Windows.Forms.Label();
            this.HistoryNotes = new System.Windows.Forms.TextBox();
            this.TodayLabel = new System.Windows.Forms.Label();
            this.TodayNotes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "History";
            // 
            // HistoryNotes
            // 
            this.HistoryNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.HistoryNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HistoryNotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.HistoryNotes.Location = new System.Drawing.Point(16, 37);
            this.HistoryNotes.MaxLength = 9999999;
            this.HistoryNotes.Multiline = true;
            this.HistoryNotes.Name = "HistoryNotes";
            this.HistoryNotes.ReadOnly = true;
            this.HistoryNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.HistoryNotes.Size = new System.Drawing.Size(785, 585);
            this.HistoryNotes.TabIndex = 1;
            // 
            // TodayLabel
            // 
            this.TodayLabel.AutoSize = true;
            this.TodayLabel.Font = new System.Drawing.Font("Arial", 16F);
            this.TodayLabel.Location = new System.Drawing.Point(12, 634);
            this.TodayLabel.Name = "TodayLabel";
            this.TodayLabel.Size = new System.Drawing.Size(72, 25);
            this.TodayLabel.TabIndex = 2;
            this.TodayLabel.Text = "Today";
            // 
            // TodayNotes
            // 
            this.TodayNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.TodayNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TodayNotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.TodayNotes.Location = new System.Drawing.Point(17, 662);
            this.TodayNotes.MaxLength = 9999999;
            this.TodayNotes.Multiline = true;
            this.TodayNotes.Name = "TodayNotes";
            this.TodayNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TodayNotes.Size = new System.Drawing.Size(785, 265);
            this.TodayNotes.TabIndex = 3;
            // 
            // Notes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(813, 939);
            this.Controls.Add(this.TodayNotes);
            this.Controls.Add(this.TodayLabel);
            this.Controls.Add(this.HistoryNotes);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Notes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Notes_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox HistoryNotes;
        private System.Windows.Forms.Label TodayLabel;
        private System.Windows.Forms.TextBox TodayNotes;
    }
}
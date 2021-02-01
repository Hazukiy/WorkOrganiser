namespace Organiser
{
    partial class EditWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditWindow));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DeleteRecord = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.CreationDate = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ADOLink = new System.Windows.Forms.LinkLabel();
            this.CopyDetails = new System.Windows.Forms.Button();
            this.Extravalue = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.Port = new System.Windows.Forms.TextBox();
            this.Host = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ChangesPending = new System.Windows.Forms.Label();
            this.Comments = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.State = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.DeleteRecord);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.CreationDate);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.ADOLink);
            this.groupBox1.Controls.Add(this.CopyDetails);
            this.groupBox1.Controls.Add(this.Extravalue);
            this.groupBox1.Controls.Add(this.Password);
            this.groupBox1.Controls.Add(this.Username);
            this.groupBox1.Controls.Add(this.Port);
            this.groupBox1.Controls.Add(this.Host);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ChangesPending);
            this.groupBox1.Controls.Add(this.Comments);
            this.groupBox1.Controls.Add(this.Save);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.State);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(868, 376);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "{TITLE}";
            // 
            // DeleteRecord
            // 
            this.DeleteRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(47)))), ((int)(((byte)(45)))));
            this.DeleteRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteRecord.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteRecord.ForeColor = System.Drawing.Color.White;
            this.DeleteRecord.Location = new System.Drawing.Point(772, 335);
            this.DeleteRecord.Name = "DeleteRecord";
            this.DeleteRecord.Size = new System.Drawing.Size(90, 35);
            this.DeleteRecord.TabIndex = 22;
            this.DeleteRecord.Text = "Delete";
            this.DeleteRecord.UseVisualStyleBackColor = false;
            this.DeleteRecord.Click += new System.EventHandler(this.DeleteRecord_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(386, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "Date:";
            // 
            // CreationDate
            // 
            this.CreationDate.AutoSize = true;
            this.CreationDate.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreationDate.Location = new System.Drawing.Point(441, 64);
            this.CreationDate.Name = "CreationDate";
            this.CreationDate.Size = new System.Drawing.Size(123, 16);
            this.CreationDate.TabIndex = 20;
            this.CreationDate.Text = "{CREATIONDATE}";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(387, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "ADO:";
            // 
            // ADOLink
            // 
            this.ADOLink.AutoSize = true;
            this.ADOLink.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADOLink.Location = new System.Drawing.Point(441, 39);
            this.ADOLink.Name = "ADOLink";
            this.ADOLink.Size = new System.Drawing.Size(67, 15);
            this.ADOLink.TabIndex = 18;
            this.ADOLink.TabStop = true;
            this.ADOLink.Text = "{ADOLINK}";
            this.ADOLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ADOLink_LinkClicked);
            // 
            // CopyDetails
            // 
            this.CopyDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CopyDetails.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyDetails.Location = new System.Drawing.Point(101, 312);
            this.CopyDetails.Name = "CopyDetails";
            this.CopyDetails.Size = new System.Drawing.Size(165, 34);
            this.CopyDetails.TabIndex = 14;
            this.CopyDetails.Text = "Copy Details";
            this.CopyDetails.UseVisualStyleBackColor = true;
            this.CopyDetails.Click += new System.EventHandler(this.CopyDetails_Click);
            // 
            // Extravalue
            // 
            this.Extravalue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Extravalue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Extravalue.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Extravalue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.Extravalue.Location = new System.Drawing.Point(101, 183);
            this.Extravalue.Multiline = true;
            this.Extravalue.Name = "Extravalue";
            this.Extravalue.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Extravalue.Size = new System.Drawing.Size(274, 123);
            this.Extravalue.TabIndex = 13;
            this.Extravalue.TextChanged += new System.EventHandler(this.ExtraValues_TextChanged);
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Password.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.Password.Location = new System.Drawing.Point(101, 141);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(274, 23);
            this.Password.TabIndex = 12;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // Username
            // 
            this.Username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Username.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.Username.Location = new System.Drawing.Point(101, 108);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(274, 23);
            this.Username.TabIndex = 11;
            this.Username.TextChanged += new System.EventHandler(this.Username_TextChanged);
            // 
            // Port
            // 
            this.Port.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Port.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Port.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Port.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.Port.Location = new System.Drawing.Point(101, 73);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(274, 23);
            this.Port.TabIndex = 10;
            this.Port.TextChanged += new System.EventHandler(this.Port_TextChanged);
            // 
            // Host
            // 
            this.Host.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Host.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Host.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Host.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.Host.Location = new System.Drawing.Point(101, 36);
            this.Host.Name = "Host";
            this.Host.Size = new System.Drawing.Size(274, 23);
            this.Host.TabIndex = 0;
            this.Host.TextChanged += new System.EventHandler(this.Host_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(2, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "ExtraValues:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Username:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Port:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Host:";
            // 
            // ChangesPending
            // 
            this.ChangesPending.AutoSize = true;
            this.ChangesPending.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangesPending.ForeColor = System.Drawing.Color.Maroon;
            this.ChangesPending.Location = new System.Drawing.Point(412, 299);
            this.ChangesPending.Name = "ChangesPending";
            this.ChangesPending.Size = new System.Drawing.Size(113, 16);
            this.ChangesPending.TabIndex = 2;
            this.ChangesPending.Text = "*Changes pending";
            this.ChangesPending.Visible = false;
            // 
            // Comments
            // 
            this.Comments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Comments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Comments.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Comments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.Comments.Location = new System.Drawing.Point(389, 144);
            this.Comments.Multiline = true;
            this.Comments.Name = "Comments";
            this.Comments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Comments.Size = new System.Drawing.Size(383, 123);
            this.Comments.TabIndex = 3;
            this.Comments.TextChanged += new System.EventHandler(this.Comments_TextChanged);
            // 
            // Save
            // 
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.Location = new System.Drawing.Point(415, 318);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(150, 51);
            this.Save.TabIndex = 1;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(386, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Comments";
            // 
            // State
            // 
            this.State.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.State.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.State.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.State.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.State.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.State.FormattingEnabled = true;
            this.State.Location = new System.Drawing.Point(444, 95);
            this.State.Name = "State";
            this.State.Size = new System.Drawing.Size(121, 23);
            this.State.TabIndex = 8;
            this.State.SelectedIndexChanged += new System.EventHandler(this.State_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(387, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "State:";
            // 
            // EditWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(892, 393);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox State;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Comments;
        private System.Windows.Forms.Label ChangesPending;
        private System.Windows.Forms.TextBox Host;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Port;
        private System.Windows.Forms.TextBox Extravalue;
        private System.Windows.Forms.Button CopyDetails;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel ADOLink;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label CreationDate;
        private System.Windows.Forms.Button DeleteRecord;
    }
}
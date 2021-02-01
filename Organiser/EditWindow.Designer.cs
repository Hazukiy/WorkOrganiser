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
            this.btnCopyDetails = new System.Windows.Forms.Button();
            this.txtBoxExtraValues = new System.Windows.Forms.TextBox();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.txtBoxUsername = new System.Windows.Forms.TextBox();
            this.txtBoxPort = new System.Windows.Forms.TextBox();
            this.txtBoxHost = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblChangesPending = new System.Windows.Forms.Label();
            this.txtBoxComments = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ddlEntryState = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DeleteRecord);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.CreationDate);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.ADOLink);
            this.groupBox1.Controls.Add(this.btnCopyDetails);
            this.groupBox1.Controls.Add(this.txtBoxExtraValues);
            this.groupBox1.Controls.Add(this.txtBoxPassword);
            this.groupBox1.Controls.Add(this.txtBoxUsername);
            this.groupBox1.Controls.Add(this.txtBoxPort);
            this.groupBox1.Controls.Add(this.txtBoxHost);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblChangesPending);
            this.groupBox1.Controls.Add(this.txtBoxComments);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ddlEntryState);
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
            // btnCopyDetails
            // 
            this.btnCopyDetails.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopyDetails.Location = new System.Drawing.Point(6, 335);
            this.btnCopyDetails.Name = "btnCopyDetails";
            this.btnCopyDetails.Size = new System.Drawing.Size(165, 34);
            this.btnCopyDetails.TabIndex = 14;
            this.btnCopyDetails.Text = "Copy Details";
            this.btnCopyDetails.UseVisualStyleBackColor = true;
            this.btnCopyDetails.Click += new System.EventHandler(this.btnCopyDetails_Click);
            // 
            // txtBoxExtraValues
            // 
            this.txtBoxExtraValues.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxExtraValues.Location = new System.Drawing.Point(101, 183);
            this.txtBoxExtraValues.Multiline = true;
            this.txtBoxExtraValues.Name = "txtBoxExtraValues";
            this.txtBoxExtraValues.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxExtraValues.Size = new System.Drawing.Size(274, 123);
            this.txtBoxExtraValues.TabIndex = 13;
            this.txtBoxExtraValues.TextChanged += new System.EventHandler(this.txtBoxExtraValues_TextChanged);
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPassword.Location = new System.Drawing.Point(101, 141);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(274, 23);
            this.txtBoxPassword.TabIndex = 12;
            this.txtBoxPassword.TextChanged += new System.EventHandler(this.txtBoxPassword_TextChanged);
            // 
            // txtBoxUsername
            // 
            this.txtBoxUsername.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxUsername.Location = new System.Drawing.Point(101, 108);
            this.txtBoxUsername.Name = "txtBoxUsername";
            this.txtBoxUsername.Size = new System.Drawing.Size(274, 23);
            this.txtBoxUsername.TabIndex = 11;
            this.txtBoxUsername.TextChanged += new System.EventHandler(this.txtBoxUsername_TextChanged);
            // 
            // txtBoxPort
            // 
            this.txtBoxPort.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPort.Location = new System.Drawing.Point(101, 73);
            this.txtBoxPort.Name = "txtBoxPort";
            this.txtBoxPort.Size = new System.Drawing.Size(274, 23);
            this.txtBoxPort.TabIndex = 10;
            this.txtBoxPort.TextChanged += new System.EventHandler(this.txtBoxPort_TextChanged);
            // 
            // txtBoxHost
            // 
            this.txtBoxHost.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxHost.Location = new System.Drawing.Point(101, 36);
            this.txtBoxHost.Name = "txtBoxHost";
            this.txtBoxHost.Size = new System.Drawing.Size(274, 23);
            this.txtBoxHost.TabIndex = 9;
            this.txtBoxHost.TextChanged += new System.EventHandler(this.txtBoxHost_TextChanged);
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
            // lblChangesPending
            // 
            this.lblChangesPending.AutoSize = true;
            this.lblChangesPending.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangesPending.ForeColor = System.Drawing.Color.Maroon;
            this.lblChangesPending.Location = new System.Drawing.Point(421, 299);
            this.lblChangesPending.Name = "lblChangesPending";
            this.lblChangesPending.Size = new System.Drawing.Size(113, 16);
            this.lblChangesPending.TabIndex = 2;
            this.lblChangesPending.Text = "*Changes pending";
            this.lblChangesPending.Visible = false;
            // 
            // txtBoxComments
            // 
            this.txtBoxComments.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxComments.Location = new System.Drawing.Point(389, 144);
            this.txtBoxComments.Multiline = true;
            this.txtBoxComments.Name = "txtBoxComments";
            this.txtBoxComments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxComments.Size = new System.Drawing.Size(383, 123);
            this.txtBoxComments.TabIndex = 3;
            this.txtBoxComments.TextChanged += new System.EventHandler(this.txtBoxComments_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(415, 318);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 51);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            // ddlEntryState
            // 
            this.ddlEntryState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlEntryState.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlEntryState.FormattingEnabled = true;
            this.ddlEntryState.Location = new System.Drawing.Point(444, 95);
            this.ddlEntryState.Name = "ddlEntryState";
            this.ddlEntryState.Size = new System.Drawing.Size(121, 23);
            this.ddlEntryState.TabIndex = 1;
            this.ddlEntryState.SelectedIndexChanged += new System.EventHandler(this.ddlState_SelectedIndexChanged);
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
            this.ClientSize = new System.Drawing.Size(892, 393);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ddlEntryState;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxComments;
        private System.Windows.Forms.Label lblChangesPending;
        private System.Windows.Forms.TextBox txtBoxHost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.TextBox txtBoxUsername;
        private System.Windows.Forms.TextBox txtBoxPort;
        private System.Windows.Forms.TextBox txtBoxExtraValues;
        private System.Windows.Forms.Button btnCopyDetails;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel ADOLink;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label CreationDate;
        private System.Windows.Forms.Button DeleteRecord;
    }
}
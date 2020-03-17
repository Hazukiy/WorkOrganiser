namespace Organiser
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ddlState = new System.Windows.Forms.ComboBox();
            this.btn_InsertRecord = new System.Windows.Forms.Button();
            this.txtBoxComments = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxLink = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxOutput = new System.Windows.Forms.ListBox();
            this.ddlFilter = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxColorCoding = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ddlState);
            this.groupBox1.Controls.Add(this.btn_InsertRecord);
            this.groupBox1.Controls.Add(this.txtBoxComments);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtBoxLink);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBoxTitle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(414, 524);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "State";
            // 
            // ddlState
            // 
            this.ddlState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlState.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlState.FormattingEnabled = true;
            this.ddlState.Location = new System.Drawing.Point(6, 367);
            this.ddlState.Name = "ddlState";
            this.ddlState.Size = new System.Drawing.Size(121, 24);
            this.ddlState.TabIndex = 8;
            // 
            // btn_InsertRecord
            // 
            this.btn_InsertRecord.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InsertRecord.Location = new System.Drawing.Point(10, 475);
            this.btn_InsertRecord.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_InsertRecord.Name = "btn_InsertRecord";
            this.btn_InsertRecord.Size = new System.Drawing.Size(397, 42);
            this.btn_InsertRecord.TabIndex = 7;
            this.btn_InsertRecord.Text = "Insert Record";
            this.btn_InsertRecord.UseVisualStyleBackColor = true;
            this.btn_InsertRecord.Click += new System.EventHandler(this.btn_InsertRecord_Click);
            // 
            // txtBoxComments
            // 
            this.txtBoxComments.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxComments.Location = new System.Drawing.Point(7, 191);
            this.txtBoxComments.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxComments.Multiline = true;
            this.txtBoxComments.Name = "txtBoxComments";
            this.txtBoxComments.Size = new System.Drawing.Size(399, 142);
            this.txtBoxComments.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Comments";
            // 
            // txtBoxLink
            // 
            this.txtBoxLink.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLink.Location = new System.Drawing.Point(7, 124);
            this.txtBoxLink.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxLink.Name = "txtBoxLink";
            this.txtBoxLink.Size = new System.Drawing.Size(399, 21);
            this.txtBoxLink.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Azure Devops Link";
            // 
            // txtBoxTitle
            // 
            this.txtBoxTitle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTitle.Location = new System.Drawing.Point(7, 60);
            this.txtBoxTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxTitle.Name = "txtBoxTitle";
            this.txtBoxTitle.Size = new System.Drawing.Size(399, 21);
            this.txtBoxTitle.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 18);
            this.label2.TabIndex = 0;
            // 
            // listBoxOutput
            // 
            this.listBoxOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.listBoxOutput.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBoxOutput.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.listBoxOutput.FormattingEnabled = true;
            this.listBoxOutput.ItemHeight = 18;
            this.listBoxOutput.Location = new System.Drawing.Point(435, 33);
            this.listBoxOutput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxOutput.Name = "listBoxOutput";
            this.listBoxOutput.Size = new System.Drawing.Size(670, 454);
            this.listBoxOutput.TabIndex = 1;
            this.listBoxOutput.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBoxOutput_DrawItem);
            this.listBoxOutput.DoubleClick += new System.EventHandler(this.listBoxOutput_DoubleClick);
            this.listBoxOutput.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBoxOutput_MouseDown);
            // 
            // ddlFilter
            // 
            this.ddlFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlFilter.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlFilter.FormattingEnabled = true;
            this.ddlFilter.Location = new System.Drawing.Point(504, 500);
            this.ddlFilter.Name = "ddlFilter";
            this.ddlFilter.Size = new System.Drawing.Size(121, 24);
            this.ddlFilter.TabIndex = 10;
            this.ddlFilter.SelectedIndexChanged += new System.EventHandler(this.ddlFilter_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(437, 503);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Filter By:";
            // 
            // checkBoxColorCoding
            // 
            this.checkBoxColorCoding.AutoSize = true;
            this.checkBoxColorCoding.Location = new System.Drawing.Point(647, 502);
            this.checkBoxColorCoding.Name = "checkBoxColorCoding";
            this.checkBoxColorCoding.Size = new System.Drawing.Size(152, 20);
            this.checkBoxColorCoding.TabIndex = 12;
            this.checkBoxColorCoding.Text = "Enable Colour Coding";
            this.checkBoxColorCoding.UseVisualStyleBackColor = true;
            this.checkBoxColorCoding.CheckedChanged += new System.EventHandler(this.checkBoxColorCoding_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(437, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Search";
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSearch.Location = new System.Drawing.Point(492, 10);
            this.txtBoxSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(249, 21);
            this.txtBoxSearch.TabIndex = 10;
            this.txtBoxSearch.TextChanged += new System.EventHandler(this.txtBoxSearch_TextChanged);
            this.txtBoxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxSearch_KeyDown);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 554);
            this.Controls.Add(this.txtBoxSearch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkBoxColorCoding);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBoxOutput);
            this.Controls.Add(this.ddlFilter);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project Organiser";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBoxTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxComments;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxLink;
        private System.Windows.Forms.Button btn_InsertRecord;
        private System.Windows.Forms.ListBox listBoxOutput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ddlState;
        private System.Windows.Forms.ComboBox ddlFilter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBoxColorCoding;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxSearch;
    }
}


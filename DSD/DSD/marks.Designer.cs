namespace DSD
{
    partial class marks
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(marks));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSubject = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTeacher = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnsend = new System.Windows.Forms.Button();
            this.btnclick = new System.Windows.Forms.Button();
            this.rddaily = new System.Windows.Forms.RadioButton();
            this.rdfinal = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblError = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtmsgCount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmsg = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtPaperNo = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chkMSGTrue = new System.Windows.Forms.CheckBox();
            this.btnExcel = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(648, 175);
            this.dataGridView1.TabIndex = 0;
            // 
            // cmbYear
            // 
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(33, 15);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(126, 21);
            this.cmbYear.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "subject";
            // 
            // cmbSubject
            // 
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Location = new System.Drawing.Point(202, 15);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(126, 21);
            this.cmbSubject.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "teacher";
            // 
            // cmbTeacher
            // 
            this.cmbTeacher.FormattingEnabled = true;
            this.cmbTeacher.Location = new System.Drawing.Point(375, 12);
            this.cmbTeacher.Name = "cmbTeacher";
            this.cmbTeacher.Size = new System.Drawing.Size(126, 21);
            this.cmbTeacher.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(504, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "date";
            // 
            // btnsend
            // 
            this.btnsend.BackColor = System.Drawing.Color.Blue;
            this.btnsend.Enabled = false;
            this.btnsend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsend.ForeColor = System.Drawing.Color.White;
            this.btnsend.Location = new System.Drawing.Point(297, 76);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(88, 30);
            this.btnsend.TabIndex = 9;
            this.btnsend.Text = "send message";
            this.btnsend.UseVisualStyleBackColor = false;
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // btnclick
            // 
            this.btnclick.BackColor = System.Drawing.Color.Blue;
            this.btnclick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclick.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclick.ForeColor = System.Drawing.Color.White;
            this.btnclick.Location = new System.Drawing.Point(584, 35);
            this.btnclick.Name = "btnclick";
            this.btnclick.Size = new System.Drawing.Size(76, 30);
            this.btnclick.TabIndex = 10;
            this.btnclick.Text = "search";
            this.btnclick.UseVisualStyleBackColor = false;
            this.btnclick.Click += new System.EventHandler(this.btnclick_Click);
            // 
            // rddaily
            // 
            this.rddaily.AutoSize = true;
            this.rddaily.Location = new System.Drawing.Point(477, 48);
            this.rddaily.Name = "rddaily";
            this.rddaily.Size = new System.Drawing.Size(46, 17);
            this.rddaily.TabIndex = 11;
            this.rddaily.TabStop = true;
            this.rddaily.Text = "daily";
            this.rddaily.UseVisualStyleBackColor = true;
            this.rddaily.CheckedChanged += new System.EventHandler(this.rddaily_CheckedChanged);
            // 
            // rdfinal
            // 
            this.rdfinal.AutoSize = true;
            this.rdfinal.Location = new System.Drawing.Point(529, 48);
            this.rdfinal.Name = "rdfinal";
            this.rdfinal.Size = new System.Drawing.Size(49, 17);
            this.rdfinal.TabIndex = 13;
            this.rdfinal.TabStop = true;
            this.rdfinal.Text = "finaly";
            this.rdfinal.UseVisualStyleBackColor = true;
            this.rdfinal.CheckedChanged += new System.EventHandler(this.rdfinal_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.lblError);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtmsgCount);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtmsg);
            this.groupBox1.Controls.Add(this.txtPhoneNumber);
            this.groupBox1.Controls.Add(this.btnsend);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(265, 249);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 118);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "use for send mark";
            // 
            // lblError
            // 
            this.lblError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblError.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblError.FormattingEnabled = true;
            this.lblError.Location = new System.Drawing.Point(306, 35);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(79, 26);
            this.lblError.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(246, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Error no:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(254, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Count :";
            // 
            // txtmsgCount
            // 
            this.txtmsgCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtmsgCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmsgCount.Enabled = false;
            this.txtmsgCount.Location = new System.Drawing.Point(306, 13);
            this.txtmsgCount.Name = "txtmsgCount";
            this.txtmsgCount.Size = new System.Drawing.Size(47, 13);
            this.txtmsgCount.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Message";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Phone no:";
            // 
            // txtmsg
            // 
            this.txtmsg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtmsg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmsg.Enabled = false;
            this.txtmsg.Location = new System.Drawing.Point(73, 37);
            this.txtmsg.Multiline = true;
            this.txtmsg.Name = "txtmsg";
            this.txtmsg.Size = new System.Drawing.Size(158, 73);
            this.txtmsg.TabIndex = 11;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhoneNumber.Enabled = false;
            this.txtPhoneNumber.Location = new System.Drawing.Point(73, 19);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(158, 13);
            this.txtPhoneNumber.TabIndex = 10;
            // 
            // txtPaperNo
            // 
            this.txtPaperNo.Location = new System.Drawing.Point(539, 11);
            this.txtPaperNo.Name = "txtPaperNo";
            this.txtPaperNo.Size = new System.Drawing.Size(118, 20);
            this.txtPaperNo.TabIndex = 17;
            // 
            // chkMSGTrue
            // 
            this.chkMSGTrue.AutoSize = true;
            this.chkMSGTrue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkMSGTrue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMSGTrue.ForeColor = System.Drawing.Color.Red;
            this.chkMSGTrue.Location = new System.Drawing.Point(98, 252);
            this.chkMSGTrue.Name = "chkMSGTrue";
            this.chkMSGTrue.Size = new System.Drawing.Size(159, 17);
            this.chkMSGTrue.TabIndex = 18;
            this.chkMSGTrue.Text = "Allow To Send Message";
            this.chkMSGTrue.UseVisualStyleBackColor = true;
            this.chkMSGTrue.CheckedChanged += new System.EventHandler(this.chkMSGTrue_CheckedChanged);
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.Blue;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.ForeColor = System.Drawing.Color.White;
            this.btnExcel.Location = new System.Drawing.Point(13, 254);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(76, 30);
            this.btnExcel.TabIndex = 19;
            this.btnExcel.Text = "Excel";
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(-4, 371);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(686, 11);
            this.progressBar1.TabIndex = 20;
            // 
            // marks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(668, 386);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.chkMSGTrue);
            this.Controls.Add(this.txtPaperNo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rdfinal);
            this.Controls.Add(this.rddaily);
            this.Controls.Add(this.btnclick);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbTeacher);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbSubject);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "marks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "marks";
            this.Load += new System.EventHandler(this.marks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSubject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTeacher;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnsend;
        private System.Windows.Forms.Button btnclick;
        private System.Windows.Forms.RadioButton rddaily;
        private System.Windows.Forms.RadioButton rdfinal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPaperNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmsg;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtmsgCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lblError;
        private System.Windows.Forms.CheckBox chkMSGTrue;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}
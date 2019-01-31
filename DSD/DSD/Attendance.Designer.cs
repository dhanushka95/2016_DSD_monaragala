namespace DSD
{
    partial class Attendance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Attendance));
            this.lblName = new System.Windows.Forms.Label();
            this.lblNa = new System.Windows.Forms.Label();
            this.lblSN = new System.Windows.Forms.Label();
            this.lblStudentNo = new System.Windows.Forms.Label();
            this.txtRead = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbCheck = new System.Windows.Forms.RadioButton();
            this.rbIssu = new System.Windows.Forms.RadioButton();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.cmbSubject = new System.Windows.Forms.ComboBox();
            this.cmbTeacher = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblSubj = new System.Windows.Forms.Label();
            this.lblTeacher = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblS = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.txtStudentNo = new System.Windows.Forms.TextBox();
            this.lblIssuSN = new System.Windows.Forms.Label();
            this.lblIssuLM = new System.Windows.Forms.Label();
            this.txtLastMonth = new System.Windows.Forms.TextBox();
            this.btnIssu = new System.Windows.Forms.Button();
            this.lblBarcode = new System.Windows.Forms.Label();
            this.btnSet = new System.Windows.Forms.Button();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.txtCurrent = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblWorning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblName.Location = new System.Drawing.Point(64, 208);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(217, 42);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name         :";
            // 
            // lblNa
            // 
            this.lblNa.AutoSize = true;
            this.lblNa.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNa.Location = new System.Drawing.Point(270, 208);
            this.lblNa.Name = "lblNa";
            this.lblNa.Size = new System.Drawing.Size(38, 42);
            this.lblNa.TabIndex = 1;
            this.lblNa.Text = " :";
            this.lblNa.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSN
            // 
            this.lblSN.AutoSize = true;
            this.lblSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSN.Location = new System.Drawing.Point(269, 278);
            this.lblSN.Name = "lblSN";
            this.lblSN.Size = new System.Drawing.Size(38, 42);
            this.lblSN.TabIndex = 3;
            this.lblSN.Text = " :";
            // 
            // lblStudentNo
            // 
            this.lblStudentNo.AutoSize = true;
            this.lblStudentNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblStudentNo.Location = new System.Drawing.Point(54, 278);
            this.lblStudentNo.Name = "lblStudentNo";
            this.lblStudentNo.Size = new System.Drawing.Size(225, 42);
            this.lblStudentNo.TabIndex = 2;
            this.lblStudentNo.Text = "Student No :";
            // 
            // txtRead
            // 
            this.txtRead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRead.Location = new System.Drawing.Point(624, 9);
            this.txtRead.Name = "txtRead";
            this.txtRead.Size = new System.Drawing.Size(171, 20);
            this.txtRead.TabIndex = 4;
            this.txtRead.TextChanged += new System.EventHandler(this.txtRead_TextChanged);
            this.txtRead.DoubleClick += new System.EventHandler(this.txtRead_DoubleClick);
            this.txtRead.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRead_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-17, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 42);
            this.label3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(-13, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1138, 42);
            this.label4.TabIndex = 6;
            this.label4.Text = "________________________________________________________";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // rbCheck
            // 
            this.rbCheck.AutoSize = true;
            this.rbCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCheck.Location = new System.Drawing.Point(3, 5);
            this.rbCheck.Name = "rbCheck";
            this.rbCheck.Size = new System.Drawing.Size(76, 24);
            this.rbCheck.TabIndex = 7;
            this.rbCheck.Text = "Check";
            this.rbCheck.UseVisualStyleBackColor = true;
            this.rbCheck.CheckedChanged += new System.EventHandler(this.rbCheck_CheckedChanged);
            // 
            // rbIssu
            // 
            this.rbIssu.AutoSize = true;
            this.rbIssu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbIssu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbIssu.Location = new System.Drawing.Point(3, 37);
            this.rbIssu.Name = "rbIssu";
            this.rbIssu.Size = new System.Drawing.Size(70, 24);
            this.rbIssu.TabIndex = 8;
            this.rbIssu.Text = "Issue";
            this.rbIssu.UseVisualStyleBackColor = true;
            this.rbIssu.CheckedChanged += new System.EventHandler(this.rbIssu_CheckedChanged);
            // 
            // cmbYear
            // 
            this.cmbYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(127, 6);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(83, 21);
            this.cmbYear.TabIndex = 9;
            this.cmbYear.SelectedIndexChanged += new System.EventHandler(this.cmbYear_SelectedIndexChanged);
            // 
            // cmbSubject
            // 
            this.cmbSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Location = new System.Drawing.Point(277, 5);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(83, 21);
            this.cmbSubject.TabIndex = 10;
            this.cmbSubject.SelectedIndexChanged += new System.EventHandler(this.cmbSubject_SelectedIndexChanged);
            // 
            // cmbTeacher
            // 
            this.cmbTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTeacher.FormattingEnabled = true;
            this.cmbTeacher.Location = new System.Drawing.Point(435, 5);
            this.cmbTeacher.Name = "cmbTeacher";
            this.cmbTeacher.Size = new System.Drawing.Size(83, 21);
            this.cmbTeacher.TabIndex = 11;
            this.cmbTeacher.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(86, 10);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(41, 16);
            this.lblYear.TabIndex = 12;
            this.lblYear.Text = "Year";
            // 
            // lblSubj
            // 
            this.lblSubj.AutoSize = true;
            this.lblSubj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubj.Location = new System.Drawing.Point(216, 10);
            this.lblSubj.Name = "lblSubj";
            this.lblSubj.Size = new System.Drawing.Size(60, 16);
            this.lblSubj.TabIndex = 13;
            this.lblSubj.Text = "Subject";
            // 
            // lblTeacher
            // 
            this.lblTeacher.AutoSize = true;
            this.lblTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacher.Location = new System.Drawing.Point(366, 7);
            this.lblTeacher.Name = "lblTeacher";
            this.lblTeacher.Size = new System.Drawing.Size(66, 16);
            this.lblTeacher.TabIndex = 14;
            this.lblTeacher.Text = "Teacher";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(61, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 16);
            this.label8.TabIndex = 15;
            // 
            // lblS
            // 
            this.lblS.AutoSize = true;
            this.lblS.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblS.Location = new System.Drawing.Point(268, 350);
            this.lblS.Name = "lblS";
            this.lblS.Size = new System.Drawing.Size(38, 42);
            this.lblS.TabIndex = 17;
            this.lblS.Text = " :";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblSubject.Location = new System.Drawing.Point(57, 350);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(223, 42);
            this.lblSubject.TabIndex = 16;
            this.lblSubject.Text = "Subject       :";
            // 
            // txtStudentNo
            // 
            this.txtStudentNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStudentNo.Location = new System.Drawing.Point(130, 63);
            this.txtStudentNo.Name = "txtStudentNo";
            this.txtStudentNo.Size = new System.Drawing.Size(133, 20);
            this.txtStudentNo.TabIndex = 18;
            this.txtStudentNo.TextChanged += new System.EventHandler(this.txtStudentNo_TextChanged);
            // 
            // lblIssuSN
            // 
            this.lblIssuSN.AutoSize = true;
            this.lblIssuSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssuSN.Location = new System.Drawing.Point(41, 66);
            this.lblIssuSN.Name = "lblIssuSN";
            this.lblIssuSN.Size = new System.Drawing.Size(84, 16);
            this.lblIssuSN.TabIndex = 19;
            this.lblIssuSN.Text = "Student No";
            // 
            // lblIssuLM
            // 
            this.lblIssuLM.AutoSize = true;
            this.lblIssuLM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssuLM.Location = new System.Drawing.Point(41, 101);
            this.lblIssuLM.Name = "lblIssuLM";
            this.lblIssuLM.Size = new System.Drawing.Size(82, 16);
            this.lblIssuLM.TabIndex = 21;
            this.lblIssuLM.Text = "Last Month";
            // 
            // txtLastMonth
            // 
            this.txtLastMonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastMonth.Location = new System.Drawing.Point(129, 98);
            this.txtLastMonth.Name = "txtLastMonth";
            this.txtLastMonth.ReadOnly = true;
            this.txtLastMonth.Size = new System.Drawing.Size(135, 20);
            this.txtLastMonth.TabIndex = 20;
            this.txtLastMonth.TextChanged += new System.EventHandler(this.txtLastMonth_TextChanged);
            // 
            // btnIssu
            // 
            this.btnIssu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnIssu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssu.ForeColor = System.Drawing.Color.White;
            this.btnIssu.Location = new System.Drawing.Point(280, 118);
            this.btnIssu.Name = "btnIssu";
            this.btnIssu.Size = new System.Drawing.Size(80, 28);
            this.btnIssu.TabIndex = 22;
            this.btnIssu.Text = "Issue";
            this.btnIssu.UseVisualStyleBackColor = false;
            this.btnIssu.Click += new System.EventHandler(this.btnIssu_Click);
            // 
            // lblBarcode
            // 
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarcode.Location = new System.Drawing.Point(523, 10);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(95, 16);
            this.lblBarcode.TabIndex = 23;
            this.lblBarcode.Text = "Barcode  No";
            // 
            // btnSet
            // 
            this.btnSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSet.ForeColor = System.Drawing.Color.White;
            this.btnSet.Location = new System.Drawing.Point(280, 55);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(80, 28);
            this.btnSet.TabIndex = 24;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = false;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdate.Location = new System.Drawing.Point(23, 129);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(104, 16);
            this.lblUpdate.TabIndex = 26;
            this.lblUpdate.Text = "Update Month";
            // 
            // txtCurrent
            // 
            this.txtCurrent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCurrent.Location = new System.Drawing.Point(129, 126);
            this.txtCurrent.Name = "txtCurrent";
            this.txtCurrent.Size = new System.Drawing.Size(135, 20);
            this.txtCurrent.TabIndex = 25;
            this.txtCurrent.TextChanged += new System.EventHandler(this.txtCurrent_TextChanged);
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.ForeColor = System.Drawing.Color.White;
            this.btnCheck.Location = new System.Drawing.Point(280, 86);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(80, 28);
            this.btnCheck.TabIndex = 27;
            this.btnCheck.Text = "check";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblWorning
            // 
            this.lblWorning.AutoSize = true;
            this.lblWorning.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorning.ForeColor = System.Drawing.Color.Red;
            this.lblWorning.Location = new System.Drawing.Point(-3, 119);
            this.lblWorning.Name = "lblWorning";
            this.lblWorning.Size = new System.Drawing.Size(28, 42);
            this.lblWorning.TabIndex = 28;
            this.lblWorning.Text = ".";
            // 
            // Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(830, 529);
            this.Controls.Add(this.lblWorning);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblUpdate);
            this.Controls.Add(this.txtCurrent);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.lblBarcode);
            this.Controls.Add(this.btnIssu);
            this.Controls.Add(this.lblIssuLM);
            this.Controls.Add(this.txtLastMonth);
            this.Controls.Add(this.lblIssuSN);
            this.Controls.Add(this.txtStudentNo);
            this.Controls.Add(this.lblS);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblTeacher);
            this.Controls.Add(this.lblSubj);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.cmbTeacher);
            this.Controls.Add(this.cmbSubject);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.rbIssu);
            this.Controls.Add(this.rbCheck);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRead);
            this.Controls.Add(this.lblSN);
            this.Controls.Add(this.lblStudentNo);
            this.Controls.Add(this.lblNa);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Attendance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendance";
            this.Load += new System.EventHandler(this.Attendance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNa;
        private System.Windows.Forms.Label lblSN;
        private System.Windows.Forms.Label lblStudentNo;
        private System.Windows.Forms.TextBox txtRead;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbCheck;
        private System.Windows.Forms.RadioButton rbIssu;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.ComboBox cmbSubject;
        private System.Windows.Forms.ComboBox cmbTeacher;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblSubj;
        private System.Windows.Forms.Label lblTeacher;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblS;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.TextBox txtStudentNo;
        private System.Windows.Forms.Label lblIssuSN;
        private System.Windows.Forms.Label lblIssuLM;
        private System.Windows.Forms.TextBox txtLastMonth;
        private System.Windows.Forms.Button btnIssu;
        private System.Windows.Forms.Label lblBarcode;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.TextBox txtCurrent;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblWorning;
    }
}
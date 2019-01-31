namespace DSD
{
    partial class UpdateBarcode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateBarcode));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsn = new System.Windows.Forms.TextBox();
            this.txtbv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnbv = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnup = new System.Windows.Forms.Button();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.cmbSubject = new System.Windows.Forms.ComboBox();
            this.cmbTeacher = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(167, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Subject";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(349, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Teacher";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Student No";
            // 
            // txtsn
            // 
            this.txtsn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsn.Location = new System.Drawing.Point(118, 91);
            this.txtsn.Name = "txtsn";
            this.txtsn.Size = new System.Drawing.Size(132, 20);
            this.txtsn.TabIndex = 7;
            this.txtsn.TextChanged += new System.EventHandler(this.txtsn_TextChanged);
            // 
            // txtbv
            // 
            this.txtbv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbv.Location = new System.Drawing.Point(118, 121);
            this.txtbv.Name = "txtbv";
            this.txtbv.ReadOnly = true;
            this.txtbv.Size = new System.Drawing.Size(132, 20);
            this.txtbv.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Barcode Value";
            // 
            // txtnbv
            // 
            this.txtnbv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnbv.Location = new System.Drawing.Point(148, 208);
            this.txtnbv.Name = "txtnbv";
            this.txtnbv.Size = new System.Drawing.Size(177, 20);
            this.txtnbv.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-3, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "New Barcode Value";
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.Blue;
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.ForeColor = System.Drawing.Color.White;
            this.btnCheck.Location = new System.Drawing.Point(181, 147);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(69, 30);
            this.btnCheck.TabIndex = 12;
            this.btnCheck.Text = "check";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnup
            // 
            this.btnup.BackColor = System.Drawing.Color.Blue;
            this.btnup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnup.ForeColor = System.Drawing.Color.White;
            this.btnup.Location = new System.Drawing.Point(256, 234);
            this.btnup.Name = "btnup";
            this.btnup.Size = new System.Drawing.Size(69, 30);
            this.btnup.TabIndex = 13;
            this.btnup.Text = "Update";
            this.btnup.UseVisualStyleBackColor = false;
            this.btnup.Click += new System.EventHandler(this.btnup_Click);
            // 
            // cmbYear
            // 
            this.cmbYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(48, 13);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(112, 21);
            this.cmbYear.TabIndex = 14;
            // 
            // cmbSubject
            // 
            this.cmbSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Location = new System.Drawing.Point(231, 13);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(112, 21);
            this.cmbSubject.TabIndex = 15;
            // 
            // cmbTeacher
            // 
            this.cmbTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTeacher.FormattingEnabled = true;
            this.cmbTeacher.Location = new System.Drawing.Point(421, 13);
            this.cmbTeacher.Name = "cmbTeacher";
            this.cmbTeacher.Size = new System.Drawing.Size(112, 21);
            this.cmbTeacher.TabIndex = 16;
            // 
            // UpdateBarcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(545, 268);
            this.Controls.Add(this.cmbTeacher);
            this.Controls.Add(this.cmbSubject);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.btnup);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtnbv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtbv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtsn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateBarcode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Barcode";
            this.Load += new System.EventHandler(this.UpdateBarcode_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsn;
        private System.Windows.Forms.TextBox txtbv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnbv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnup;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.ComboBox cmbSubject;
        private System.Windows.Forms.ComboBox cmbTeacher;
    }
}
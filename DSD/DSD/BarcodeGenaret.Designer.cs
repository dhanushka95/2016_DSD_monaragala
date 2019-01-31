namespace DSD
{
    partial class BarcodeGenaret
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BarcodeGenaret));
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenarate = new System.Windows.Forms.Button();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSavePath = new System.Windows.Forms.Label();
            this.PcBox = new System.Windows.Forms.PictureBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.txtpath = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSavePath = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PcBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbYear
            // 
            this.cmbYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(50, 12);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(107, 21);
            this.cmbYear.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Year";
            // 
            // btnGenarate
            // 
            this.btnGenarate.BackColor = System.Drawing.Color.Blue;
            this.btnGenarate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenarate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenarate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGenarate.Location = new System.Drawing.Point(532, 233);
            this.btnGenarate.Name = "btnGenarate";
            this.btnGenarate.Size = new System.Drawing.Size(84, 33);
            this.btnGenarate.TabIndex = 6;
            this.btnGenarate.Text = "Generate";
            this.btnGenarate.UseVisualStyleBackColor = false;
            this.btnGenarate.Click += new System.EventHandler(this.btnGenarate_Click);
            // 
            // cmbMonth
            // 
            this.cmbMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbMonth.Location = new System.Drawing.Point(218, 10);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(51, 21);
            this.cmbMonth.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(167, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Month";
            // 
            // lblSavePath
            // 
            this.lblSavePath.AutoSize = true;
            this.lblSavePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblSavePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSavePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSavePath.Location = new System.Drawing.Point(237, 65);
            this.lblSavePath.Name = "lblSavePath";
            this.lblSavePath.Size = new System.Drawing.Size(90, 18);
            this.lblSavePath.TabIndex = 10;
            this.lblSavePath.Text = "Save Path    : ";
            // 
            // PcBox
            // 
            this.PcBox.BackColor = System.Drawing.Color.White;
            this.PcBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PcBox.Location = new System.Drawing.Point(50, 105);
            this.PcBox.Name = "PcBox";
            this.PcBox.Size = new System.Drawing.Size(474, 160);
            this.PcBox.TabIndex = 11;
            this.PcBox.TabStop = false;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(3, 69);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(110, 16);
            this.lblCount.TabIndex = 12;
            this.lblCount.Text = "No Of Barcode";
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(119, 65);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(107, 20);
            this.txtCount.TabIndex = 13;
            this.txtCount.Text = "200";
            // 
            // txtpath
            // 
            this.txtpath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtpath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpath.Location = new System.Drawing.Point(328, 64);
            this.txtpath.Name = "txtpath";
            this.txtpath.Size = new System.Drawing.Size(184, 20);
            this.txtpath.TabIndex = 14;
            // 
            // btnSavePath
            // 
            this.btnSavePath.BackColor = System.Drawing.Color.Blue;
            this.btnSavePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavePath.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSavePath.Location = new System.Drawing.Point(532, 61);
            this.btnSavePath.Name = "btnSavePath";
            this.btnSavePath.Size = new System.Drawing.Size(74, 24);
            this.btnSavePath.TabIndex = 15;
            this.btnSavePath.Text = "Save Path";
            this.btnSavePath.UseVisualStyleBackColor = false;
            this.btnSavePath.Click += new System.EventHandler(this.txtSavePath_Click);
            // 
            // BarcodeGenaret
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(626, 274);
            this.Controls.Add(this.btnSavePath);
            this.Controls.Add(this.txtpath);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.PcBox);
            this.Controls.Add(this.lblSavePath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.btnGenarate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbYear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BarcodeGenaret";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barcode Genaret";
            this.Load += new System.EventHandler(this.BarcodeGenaret_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PcBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenarate;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSavePath;
        private System.Windows.Forms.PictureBox PcBox;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.TextBox txtpath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnSavePath;
    }
}
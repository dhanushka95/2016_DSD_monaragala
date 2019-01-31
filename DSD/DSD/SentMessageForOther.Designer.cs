namespace DSD
{
    partial class SentMessageForOther
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SentMessageForOther));
            this.txtSelectNo = new System.Windows.Forms.TextBox();
            this.txtText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.btnSent = new System.Windows.Forms.Button();
            this.lbError = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkbAllow = new System.Windows.Forms.CheckBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // txtSelectNo
            // 
            this.txtSelectNo.Location = new System.Drawing.Point(251, 91);
            this.txtSelectNo.Name = "txtSelectNo";
            this.txtSelectNo.ReadOnly = true;
            this.txtSelectNo.Size = new System.Drawing.Size(120, 20);
            this.txtSelectNo.TabIndex = 1;
            this.txtSelectNo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(377, 24);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(163, 215);
            this.txtText.TabIndex = 2;
            this.txtText.Text = "____DSD____";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Phone No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(169, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select No";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(424, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "TEXT";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(3, 23);
            this.txtPhoneNo.Multiline = true;
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(163, 210);
            this.txtPhoneNo.TabIndex = 6;
            this.txtPhoneNo.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btnSent
            // 
            this.btnSent.BackColor = System.Drawing.Color.Blue;
            this.btnSent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSent.ForeColor = System.Drawing.Color.White;
            this.btnSent.Location = new System.Drawing.Point(427, 250);
            this.btnSent.Name = "btnSent";
            this.btnSent.Size = new System.Drawing.Size(74, 27);
            this.btnSent.TabIndex = 7;
            this.btnSent.Text = "Send";
            this.btnSent.UseVisualStyleBackColor = false;
            this.btnSent.Click += new System.EventHandler(this.btnSent_Click);
            // 
            // lbError
            // 
            this.lbError.BackColor = System.Drawing.Color.Silver;
            this.lbError.FormattingEnabled = true;
            this.lbError.Location = new System.Drawing.Point(584, 29);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(117, 212);
            this.lbError.TabIndex = 8;
            this.lbError.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(585, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Error";
            // 
            // chkbAllow
            // 
            this.chkbAllow.AutoSize = true;
            this.chkbAllow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbAllow.ForeColor = System.Drawing.Color.Red;
            this.chkbAllow.Location = new System.Drawing.Point(175, 30);
            this.chkbAllow.Name = "chkbAllow";
            this.chkbAllow.Size = new System.Drawing.Size(195, 20);
            this.chkbAllow.TabIndex = 10;
            this.chkbAllow.Text = "Allow To Send Message";
            this.chkbAllow.UseVisualStyleBackColor = true;
            this.chkbAllow.CheckedChanged += new System.EventHandler(this.chkbAllow_CheckedChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(-4, 285);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(719, 17);
            this.progressBar1.TabIndex = 11;
            // 
            // SentMessageForOther
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(706, 307);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.chkbAllow);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.btnSent);
            this.Controls.Add(this.txtPhoneNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.txtSelectNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SentMessageForOther";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Send Message For Other";
            this.Load += new System.EventHandler(this.SentMessageForOther_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSelectNo;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.Button btnSent;
        private System.Windows.Forms.ListBox lbError;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkbAllow;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}
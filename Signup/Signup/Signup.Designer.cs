
namespace Signup
{
    partial class Signup
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
            this.labelFName = new System.Windows.Forms.Label();
            this.checkBoxSMS = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxFName = new System.Windows.Forms.TextBox();
            this.textBoxLName = new System.Windows.Forms.TextBox();
            this.labelLName = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.checkBoxReports = new System.Windows.Forms.CheckBox();
            this.checkBoxTransRep = new System.Windows.Forms.CheckBox();
            this.lblSMS = new System.Windows.Forms.Label();
            this.lblReports = new System.Windows.Forms.Label();
            this.lblTransReports = new System.Windows.Forms.Label();
            this.btnSignin = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelFName
            // 
            this.labelFName.AutoSize = true;
            this.labelFName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFName.Location = new System.Drawing.Point(41, 44);
            this.labelFName.Name = "labelFName";
            this.labelFName.Size = new System.Drawing.Size(107, 22);
            this.labelFName.TabIndex = 0;
            this.labelFName.Text = "First Name:";
            // 
            // checkBoxSMS
            // 
            this.checkBoxSMS.AutoSize = true;
            this.checkBoxSMS.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSMS.Location = new System.Drawing.Point(104, 42);
            this.checkBoxSMS.Name = "checkBoxSMS";
            this.checkBoxSMS.Size = new System.Drawing.Size(58, 21);
            this.checkBoxSMS.TabIndex = 1;
            this.checkBoxSMS.Text = "SMS";
            this.checkBoxSMS.UseVisualStyleBackColor = true;
            this.checkBoxSMS.CheckedChanged += new System.EventHandler(this.checkBoxSMS_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTransReports);
            this.groupBox1.Controls.Add(this.lblReports);
            this.groupBox1.Controls.Add(this.lblSMS);
            this.groupBox1.Controls.Add(this.checkBoxTransRep);
            this.groupBox1.Controls.Add(this.checkBoxReports);
            this.groupBox1.Controls.Add(this.checkBoxSMS);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(30, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 165);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Services";
            // 
            // textBoxFName
            // 
            this.textBoxFName.Location = new System.Drawing.Point(184, 44);
            this.textBoxFName.Name = "textBoxFName";
            this.textBoxFName.Size = new System.Drawing.Size(433, 20);
            this.textBoxFName.TabIndex = 3;
            // 
            // textBoxLName
            // 
            this.textBoxLName.Location = new System.Drawing.Point(184, 84);
            this.textBoxLName.Name = "textBoxLName";
            this.textBoxLName.Size = new System.Drawing.Size(433, 20);
            this.textBoxLName.TabIndex = 5;
            // 
            // labelLName
            // 
            this.labelLName.AutoSize = true;
            this.labelLName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLName.Location = new System.Drawing.Point(41, 84);
            this.labelLName.Name = "labelLName";
            this.labelLName.Size = new System.Drawing.Size(104, 22);
            this.labelLName.TabIndex = 4;
            this.labelLName.Text = "Last Name:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(184, 127);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(433, 20);
            this.textBoxEmail.TabIndex = 7;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(41, 127);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(63, 22);
            this.labelEmail.TabIndex = 6;
            this.labelEmail.Text = "Email:";
            // 
            // checkBoxReports
            // 
            this.checkBoxReports.AutoSize = true;
            this.checkBoxReports.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxReports.Location = new System.Drawing.Point(104, 83);
            this.checkBoxReports.Name = "checkBoxReports";
            this.checkBoxReports.Size = new System.Drawing.Size(80, 21);
            this.checkBoxReports.TabIndex = 2;
            this.checkBoxReports.Text = "Reports";
            this.checkBoxReports.UseVisualStyleBackColor = true;
            this.checkBoxReports.CheckedChanged += new System.EventHandler(this.checkBoxReports_CheckedChanged);
            // 
            // checkBoxTransRep
            // 
            this.checkBoxTransRep.AutoSize = true;
            this.checkBoxTransRep.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxTransRep.Location = new System.Drawing.Point(104, 123);
            this.checkBoxTransRep.Name = "checkBoxTransRep";
            this.checkBoxTransRep.Size = new System.Drawing.Size(160, 21);
            this.checkBoxTransRep.TabIndex = 3;
            this.checkBoxTransRep.Text = "Transactions Report";
            this.checkBoxTransRep.UseVisualStyleBackColor = true;
            this.checkBoxTransRep.CheckedChanged += new System.EventHandler(this.checkBoxTransRep_CheckedChanged);
            // 
            // lblSMS
            // 
            this.lblSMS.AutoSize = true;
            this.lblSMS.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSMS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblSMS.Location = new System.Drawing.Point(280, 40);
            this.lblSMS.Name = "lblSMS";
            this.lblSMS.Size = new System.Drawing.Size(32, 17);
            this.lblSMS.TabIndex = 4;
            this.lblSMS.Text = "......";
            // 
            // lblReports
            // 
            this.lblReports.AutoSize = true;
            this.lblReports.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReports.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblReports.Location = new System.Drawing.Point(280, 81);
            this.lblReports.Name = "lblReports";
            this.lblReports.Size = new System.Drawing.Size(32, 17);
            this.lblReports.TabIndex = 5;
            this.lblReports.Text = "......";
            // 
            // lblTransReports
            // 
            this.lblTransReports.AutoSize = true;
            this.lblTransReports.BackColor = System.Drawing.Color.Transparent;
            this.lblTransReports.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransReports.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTransReports.Location = new System.Drawing.Point(280, 121);
            this.lblTransReports.Name = "lblTransReports";
            this.lblTransReports.Size = new System.Drawing.Size(32, 17);
            this.lblTransReports.TabIndex = 6;
            this.lblTransReports.Text = "......";
            // 
            // btnSignin
            // 
            this.btnSignin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignin.Location = new System.Drawing.Point(526, 397);
            this.btnSignin.Name = "btnSignin";
            this.btnSignin.Size = new System.Drawing.Size(106, 37);
            this.btnSignin.TabIndex = 8;
            this.btnSignin.Text = "Sign in";
            this.btnSignin.UseVisualStyleBackColor = true;
            this.btnSignin.Click += new System.EventHandler(this.btnSignin_Click);
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 446);
            this.Controls.Add(this.btnSignin);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxLName);
            this.Controls.Add(this.labelLName);
            this.Controls.Add(this.textBoxFName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelFName);
            this.Name = "Signup";
            this.Text = "Sign up";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFName;
        private System.Windows.Forms.CheckBox checkBoxSMS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTransReports;
        private System.Windows.Forms.Label lblReports;
        private System.Windows.Forms.Label lblSMS;
        private System.Windows.Forms.CheckBox checkBoxTransRep;
        private System.Windows.Forms.CheckBox checkBoxReports;
        private System.Windows.Forms.TextBox textBoxFName;
        private System.Windows.Forms.TextBox textBoxLName;
        private System.Windows.Forms.Label labelLName;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Button btnSignin;
    }
}


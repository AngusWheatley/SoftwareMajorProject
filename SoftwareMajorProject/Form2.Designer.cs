namespace SoftwareMajorProject
{
    partial class NewAccountPage
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
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUserPassword = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.picBackPlate = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserEmail = new System.Windows.Forms.TextBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLogIn = new System.Windows.Forms.LinkLabel();
            this.btnTestEmail = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBackPlate)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(410, 265);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(176, 37);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "Password:";
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserPassword.Location = new System.Drawing.Point(418, 314);
            this.txtUserPassword.Multiline = true;
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.PasswordChar = '*';
            this.txtUserPassword.Size = new System.Drawing.Size(560, 80);
            this.txtUserPassword.TabIndex = 8;
            this.txtUserPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserPassword_KeyDown);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(411, 132);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(117, 37);
            this.lblUsername.TabIndex = 7;
            this.lblUsername.Text = "Name:";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(418, 181);
            this.txtUserName.Multiline = true;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(560, 80);
            this.txtUserName.TabIndex = 6;
            this.txtUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserName_KeyDown);
            // 
            // picBackPlate
            // 
            this.picBackPlate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picBackPlate.Location = new System.Drawing.Point(392, 5);
            this.picBackPlate.Name = "picBackPlate";
            this.picBackPlate.Size = new System.Drawing.Size(640, 800);
            this.picBackPlate.TabIndex = 5;
            this.picBackPlate.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(410, 397);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 37);
            this.label1.TabIndex = 11;
            this.label1.Text = "Email:";
            // 
            // txtUserEmail
            // 
            this.txtUserEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserEmail.Location = new System.Drawing.Point(418, 445);
            this.txtUserEmail.Multiline = true;
            this.txtUserEmail.Name = "txtUserEmail";
            this.txtUserEmail.Size = new System.Drawing.Size(560, 80);
            this.txtUserEmail.TabIndex = 10;
            this.txtUserEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserEmail_KeyDown);
            // 
            // btnSignUp
            // 
            this.btnSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.Location = new System.Drawing.Point(588, 548);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(267, 95);
            this.btnSignUp.TabIndex = 12;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.BtnSignUp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(456, 746);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Already Have an Account?";
            // 
            // linkLogIn
            // 
            this.linkLogIn.AutoSize = true;
            this.linkLogIn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.linkLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLogIn.Location = new System.Drawing.Point(797, 745);
            this.linkLogIn.Name = "linkLogIn";
            this.linkLogIn.Size = new System.Drawing.Size(131, 26);
            this.linkLogIn.TabIndex = 14;
            this.linkLogIn.TabStop = true;
            this.linkLogIn.Text = "Log In Here!";
            this.linkLogIn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLogIn_LinkClicked);
            // 
            // btnTestEmail
            // 
            this.btnTestEmail.Location = new System.Drawing.Point(1101, 290);
            this.btnTestEmail.Name = "btnTestEmail";
            this.btnTestEmail.Size = new System.Drawing.Size(139, 87);
            this.btnTestEmail.TabIndex = 15;
            this.btnTestEmail.Text = "button1";
            this.btnTestEmail.UseVisualStyleBackColor = true;
            this.btnTestEmail.Click += new System.EventHandler(this.BtnTestEmail_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(623, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 73);
            this.label3.TabIndex = 16;
            this.label3.Text = "Noter";
            // 
            // NewAccountPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1424, 821);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTestEmail);
            this.Controls.Add(this.linkLogIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUserEmail);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUserPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.picBackPlate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1440, 860);
            this.MinimumSize = new System.Drawing.Size(1440, 860);
            this.Name = "NewAccountPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Noter - New Account Page";
            this.Load += new System.EventHandler(this.NewAccountPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBackPlate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUserPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.PictureBox picBackPlate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserEmail;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLogIn;
        private System.Windows.Forms.Button btnTestEmail;
        private System.Windows.Forms.Label label3;
    }
}
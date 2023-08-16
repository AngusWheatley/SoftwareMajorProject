namespace SoftwareMajorProject
{
    partial class VerificationCodeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerificationCodeForm));
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSubmitCode = new System.Windows.Forms.Button();
            this.txtCodeEntered = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnCancelVerification = new System.Windows.Forms.Button();
            this.picBackPlate = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBackPlate)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "A verification code has been sent to your email.";
            // 
            // BtnSubmitCode
            // 
            this.BtnSubmitCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubmitCode.Location = new System.Drawing.Point(37, 132);
            this.BtnSubmitCode.Name = "BtnSubmitCode";
            this.BtnSubmitCode.Size = new System.Drawing.Size(160, 60);
            this.BtnSubmitCode.TabIndex = 1;
            this.BtnSubmitCode.Text = "Submit";
            this.BtnSubmitCode.UseVisualStyleBackColor = true;
            this.BtnSubmitCode.Click += new System.EventHandler(this.BtnSubmitCode_Click);
            // 
            // txtCodeEntered
            // 
            this.txtCodeEntered.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodeEntered.Location = new System.Drawing.Point(138, 98);
            this.txtCodeEntered.Multiline = true;
            this.txtCodeEntered.Name = "txtCodeEntered";
            this.txtCodeEntered.Size = new System.Drawing.Size(160, 28);
            this.txtCodeEntered.TabIndex = 2;
            this.txtCodeEntered.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodeEntered_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Please enter the code below.";
            // 
            // BtnCancelVerification
            // 
            this.BtnCancelVerification.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelVerification.Location = new System.Drawing.Point(237, 132);
            this.BtnCancelVerification.Name = "BtnCancelVerification";
            this.BtnCancelVerification.Size = new System.Drawing.Size(160, 60);
            this.BtnCancelVerification.TabIndex = 4;
            this.BtnCancelVerification.Text = "Cancel";
            this.BtnCancelVerification.UseVisualStyleBackColor = true;
            this.BtnCancelVerification.Click += new System.EventHandler(this.BtnCancelVerification_Click);
            // 
            // picBackPlate
            // 
            this.picBackPlate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picBackPlate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBackPlate.Location = new System.Drawing.Point(12, 12);
            this.picBackPlate.Name = "picBackPlate";
            this.picBackPlate.Size = new System.Drawing.Size(410, 192);
            this.picBackPlate.TabIndex = 7;
            this.picBackPlate.TabStop = false;
            // 
            // VerificationCodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(434, 216);
            this.Controls.Add(this.BtnCancelVerification);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodeEntered);
            this.Controls.Add(this.BtnSubmitCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBackPlate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VerificationCodeForm";
            this.Text = "Noter - Verification Code";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VerificationCodeForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.picBackPlate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSubmitCode;
        private System.Windows.Forms.TextBox txtCodeEntered;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnCancelVerification;
        private System.Windows.Forms.PictureBox picBackPlate;
    }
}
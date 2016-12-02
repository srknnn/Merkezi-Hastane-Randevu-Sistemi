namespace LoginForm
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.txtBxIdentitiyNumber = new System.Windows.Forms.TextBox();
            this.txtBxPassword = new System.Windows.Forms.TextBox();
            this.txtBxSecurityNumber = new System.Windows.Forms.TextBox();
            this.btnNotRemember = new System.Windows.Forms.Button();
            this.lblSecurityAnswer = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupLogin = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBxIdentitiyNumber
            // 
            this.txtBxIdentitiyNumber.Location = new System.Drawing.Point(14, 51);
            this.txtBxIdentitiyNumber.MaxLength = 11;
            this.txtBxIdentitiyNumber.Multiline = true;
            this.txtBxIdentitiyNumber.Name = "txtBxIdentitiyNumber";
            this.txtBxIdentitiyNumber.Size = new System.Drawing.Size(447, 30);
            this.txtBxIdentitiyNumber.TabIndex = 0;
            this.txtBxIdentitiyNumber.Text = "T.C Kimlik numaranızı giriniz";
            this.txtBxIdentitiyNumber.Click += new System.EventHandler(this.txtBxIdentitiyNumber_Click);
            this.txtBxIdentitiyNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBxIdentitiyNumber_KeyPress);
            // 
            // txtBxPassword
            // 
            this.txtBxPassword.Location = new System.Drawing.Point(15, 111);
            this.txtBxPassword.MaxLength = 15;
            this.txtBxPassword.Multiline = true;
            this.txtBxPassword.Name = "txtBxPassword";
            this.txtBxPassword.Size = new System.Drawing.Size(221, 33);
            this.txtBxPassword.TabIndex = 1;
            this.txtBxPassword.Text = "MHRS şifrenizi giriniz";
            this.txtBxPassword.Click += new System.EventHandler(this.txtBxPassword_Click);
            // 
            // txtBxSecurityNumber
            // 
            this.txtBxSecurityNumber.Location = new System.Drawing.Point(15, 161);
            this.txtBxSecurityNumber.MaxLength = 5;
            this.txtBxSecurityNumber.Multiline = true;
            this.txtBxSecurityNumber.Name = "txtBxSecurityNumber";
            this.txtBxSecurityNumber.Size = new System.Drawing.Size(221, 30);
            this.txtBxSecurityNumber.TabIndex = 2;
            this.txtBxSecurityNumber.Text = "Sağda ne yazıyor?";
            this.txtBxSecurityNumber.Click += new System.EventHandler(this.txtBxSecurityNumber_Click);
            // 
            // btnNotRemember
            // 
            this.btnNotRemember.BackColor = System.Drawing.Color.Teal;
            this.btnNotRemember.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNotRemember.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNotRemember.Location = new System.Drawing.Point(275, 111);
            this.btnNotRemember.Name = "btnNotRemember";
            this.btnNotRemember.Size = new System.Drawing.Size(189, 32);
            this.btnNotRemember.TabIndex = 5;
            this.btnNotRemember.Text = "Hatırlamıyorum";
            this.btnNotRemember.UseVisualStyleBackColor = false;
            this.btnNotRemember.Click += new System.EventHandler(this.btnNotRemember_Click_1);
            // 
            // lblSecurityAnswer
            // 
            this.lblSecurityAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSecurityAnswer.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline) 
                | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSecurityAnswer.Location = new System.Drawing.Point(313, 161);
            this.lblSecurityAnswer.Name = "lblSecurityAnswer";
            this.lblSecurityAnswer.Size = new System.Drawing.Size(148, 30);
            this.lblSecurityAnswer.TabIndex = 6;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogin.Location = new System.Drawing.Point(15, 213);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(446, 29);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Giriş";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRegister.Location = new System.Drawing.Point(15, 267);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(446, 26);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "Üye Ol";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.ErrorImage")));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(275, 161);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // groupLogin
            // 
            this.groupLogin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupLogin.Controls.Add(this.pictureBox3);
            this.groupLogin.Controls.Add(this.btnRegister);
            this.groupLogin.Controls.Add(this.btnLogin);
            this.groupLogin.Controls.Add(this.lblSecurityAnswer);
            this.groupLogin.Controls.Add(this.btnNotRemember);
            this.groupLogin.Controls.Add(this.txtBxSecurityNumber);
            this.groupLogin.Controls.Add(this.txtBxPassword);
            this.groupLogin.Controls.Add(this.txtBxIdentitiyNumber);
            this.groupLogin.Location = new System.Drawing.Point(113, 147);
            this.groupLogin.Name = "groupLogin";
            this.groupLogin.Size = new System.Drawing.Size(501, 326);
            this.groupLogin.TabIndex = 3;
            this.groupLogin.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(785, 536);
            this.Controls.Add(this.groupLogin);
            this.Name = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupLogin.ResumeLayout(false);
            this.groupLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtBxIdentitiyNumber;
        private System.Windows.Forms.TextBox txtBxPassword;
        private System.Windows.Forms.TextBox txtBxSecurityNumber;
        private System.Windows.Forms.Button btnNotRemember;
        private System.Windows.Forms.Label lblSecurityAnswer;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox groupLogin;


    }
}


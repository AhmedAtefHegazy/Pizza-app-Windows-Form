namespace Pizza_app
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
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassWord = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblShowPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.Blue;
            this.lblLogin.Location = new System.Drawing.Point(41, 29);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(91, 41);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(48, 138);
            this.txtUserName.MaxLength = 20;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(245, 22);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.Tag = "admin";
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClose.Location = new System.Drawing.Point(197, 338);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 41);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.chkShowPassword.Location = new System.Drawing.Point(48, 268);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new System.Drawing.Size(18, 17);
            this.chkShowPassword.TabIndex = 3;
            this.chkShowPassword.UseVisualStyleBackColor = true;
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.Blue;
            this.lblUserName.Location = new System.Drawing.Point(44, 114);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(85, 21);
            this.lblUserName.TabIndex = 5;
            this.lblUserName.Text = "User Name";
            // 
            // lblPassWord
            // 
            this.lblPassWord.AutoSize = true;
            this.lblPassWord.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassWord.ForeColor = System.Drawing.Color.Blue;
            this.lblPassWord.Location = new System.Drawing.Point(44, 216);
            this.lblPassWord.Name = "lblPassWord";
            this.lblPassWord.Size = new System.Drawing.Size(79, 21);
            this.lblPassWord.TabIndex = 6;
            this.lblPassWord.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(48, 240);
            this.txtPassword.MaxLength = 10;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(245, 22);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Tag = "1234";
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Yellow;
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLogin.Location = new System.Drawing.Point(48, 338);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(96, 41);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblShowPassword
            // 
            this.lblShowPassword.AutoSize = true;
            this.lblShowPassword.Font = new System.Drawing.Font("Impact", 8F);
            this.lblShowPassword.ForeColor = System.Drawing.Color.Blue;
            this.lblShowPassword.Location = new System.Drawing.Point(72, 267);
            this.lblShowPassword.Name = "lblShowPassword";
            this.lblShowPassword.Size = new System.Drawing.Size(96, 18);
            this.lblShowPassword.TabIndex = 7;
            this.lblShowPassword.Text = "Show Password";
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(349, 423);
            this.Controls.Add(this.lblShowPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassWord);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.chkShowPassword);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblLogin);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassWord;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblShowPassword;
    }
}
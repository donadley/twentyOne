namespace twentyone
{
    partial class Form1
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
            this.btnNewUser = new System.Windows.Forms.Button();
            this.btnExistingUser = new System.Windows.Forms.Button();
            this.panelUserLogin = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.panelUserLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNewUser
            // 
            this.btnNewUser.Location = new System.Drawing.Point(230, 224);
            this.btnNewUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(116, 68);
            this.btnNewUser.TabIndex = 0;
            this.btnNewUser.Text = "New User";
            this.btnNewUser.UseVisualStyleBackColor = true;
            this.btnNewUser.Click += new System.EventHandler(this.btnNewUser_Click);
            // 
            // btnExistingUser
            // 
            this.btnExistingUser.Location = new System.Drawing.Point(412, 224);
            this.btnExistingUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExistingUser.Name = "btnExistingUser";
            this.btnExistingUser.Size = new System.Drawing.Size(116, 68);
            this.btnExistingUser.TabIndex = 1;
            this.btnExistingUser.Text = "Existing User";
            this.btnExistingUser.UseVisualStyleBackColor = true;
            this.btnExistingUser.Click += new System.EventHandler(this.btnExistingUser_Click);
            // 
            // panelUserLogin
            // 
            this.panelUserLogin.Controls.Add(this.btnCancel);
            this.panelUserLogin.Controls.Add(this.btnLogin);
            this.panelUserLogin.Controls.Add(this.btnCreateUser);
            this.panelUserLogin.Controls.Add(this.tbPassword);
            this.panelUserLogin.Controls.Add(this.tbUsername);
            this.panelUserLogin.Controls.Add(this.lblPassword);
            this.panelUserLogin.Controls.Add(this.lblUsername);
            this.panelUserLogin.Location = new System.Drawing.Point(214, 115);
            this.panelUserLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelUserLogin.Name = "panelUserLogin";
            this.panelUserLogin.Size = new System.Drawing.Size(333, 319);
            this.panelUserLogin.TabIndex = 2;
            this.panelUserLogin.Visible = false;
            this.panelUserLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.panelUserLogin_Paint);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(114, 238);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 19);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(114, 199);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(140, 19);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Location = new System.Drawing.Point(114, 199);
            this.btnCreateUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(140, 19);
            this.btnCreateUser.TabIndex = 5;
            this.btnCreateUser.Text = "Create User";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(120, 126);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(134, 20);
            this.tbPassword.TabIndex = 4;
            this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(120, 87);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(134, 20);
            this.tbUsername.TabIndex = 3;
            this.tbUsername.TextChanged += new System.EventHandler(this.tbUsername_TextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(52, 126);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password:";
            this.lblPassword.Click += new System.EventHandler(this.lblPassword_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(50, 87);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(58, 13);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username:";
            this.lblUsername.Click += new System.EventHandler(this.lblUsername_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 510);
            this.Controls.Add(this.panelUserLogin);
            this.Controls.Add(this.btnNewUser);
            this.Controls.Add(this.btnExistingUser);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Start Screen";
            this.panelUserLogin.ResumeLayout(false);
            this.panelUserLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewUser;
        private System.Windows.Forms.Button btnExistingUser;
        private System.Windows.Forms.Panel panelUserLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.Button btnCancel;
    }
}


namespace EventCaterMgt
{
    partial class LoginEcm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usercombo = new System.Windows.Forms.ComboBox();
            this.pwd = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.quit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // usercombo
            // 
            this.usercombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.usercombo.FormattingEnabled = true;
            this.usercombo.Location = new System.Drawing.Point(115, 61);
            this.usercombo.Name = "usercombo";
            this.usercombo.Size = new System.Drawing.Size(121, 21);
            this.usercombo.TabIndex = 2;
            // 
            // pwd
            // 
            this.pwd.Location = new System.Drawing.Point(115, 100);
            this.pwd.Name = "pwd";
            this.pwd.Size = new System.Drawing.Size(121, 20);
            this.pwd.TabIndex = 3;
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(133, 153);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(75, 23);
            this.login.TabIndex = 4;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // quit
            // 
            this.quit.Location = new System.Drawing.Point(133, 214);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(75, 23);
            this.quit.TabIndex = 5;
            this.quit.Text = "Quit";
            this.quit.UseVisualStyleBackColor = true;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // LoginEcm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.login);
            this.Controls.Add(this.pwd);
            this.Controls.Add(this.usercombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginEcm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginEcm";
            this.Load += new System.EventHandler(this.LoginEcm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox usercombo;
        private System.Windows.Forms.TextBox pwd;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button quit;
    }
}
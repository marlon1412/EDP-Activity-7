namespace EDPact_4
{
    partial class Form2
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
            this.Login_buton = new System.Windows.Forms.Button();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.username_textBox = new System.Windows.Forms.TextBox();
            this.username_text = new System.Windows.Forms.Label();
            this.login_text = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.back2login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Login_buton
            // 
            this.Login_buton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Login_buton.BackColor = System.Drawing.Color.White;
            this.Login_buton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Login_buton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Login_buton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.Login_buton.Location = new System.Drawing.Point(100, 358);
            this.Login_buton.Name = "Login_buton";
            this.Login_buton.Size = new System.Drawing.Size(271, 48);
            this.Login_buton.TabIndex = 14;
            this.Login_buton.Text = "Reset Password";
            this.Login_buton.UseVisualStyleBackColor = false;
            this.Login_buton.Click += new System.EventHandler(this.Login_buton_Click);
            // 
            // password_textBox
            // 
            this.password_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.password_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.password_textBox.Location = new System.Drawing.Point(48, 211);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.PasswordChar = '*';
            this.password_textBox.Size = new System.Drawing.Size(374, 30);
            this.password_textBox.TabIndex = 12;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.Password.Location = new System.Drawing.Point(44, 180);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(135, 22);
            this.Password.TabIndex = 11;
            this.Password.Text = "New Password:";
            this.Password.Click += new System.EventHandler(this.Password_Click);
            // 
            // username_textBox
            // 
            this.username_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.username_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.username_textBox.Location = new System.Drawing.Point(48, 131);
            this.username_textBox.Name = "username_textBox";
            this.username_textBox.Size = new System.Drawing.Size(374, 30);
            this.username_textBox.TabIndex = 10;
            // 
            // username_text
            // 
            this.username_text.AutoSize = true;
            this.username_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.username_text.Location = new System.Drawing.Point(44, 106);
            this.username_text.Name = "username_text";
            this.username_text.Size = new System.Drawing.Size(97, 22);
            this.username_text.TabIndex = 9;
            this.username_text.Text = "Username:";
            // 
            // login_text
            // 
            this.login_text.AutoSize = true;
            this.login_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.8F);
            this.login_text.Location = new System.Drawing.Point(92, 36);
            this.login_text.Name = "login_text";
            this.login_text.Size = new System.Drawing.Size(279, 39);
            this.login_text.TabIndex = 17;
            this.login_text.Text = "Forgot Password";
            this.login_text.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.login_text.Click += new System.EventHandler(this.login_text_Click);
            // 
            // textBox1
            // 
            this.textBox1.AcceptsTab = true;
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.textBox1.Location = new System.Drawing.Point(48, 280);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(374, 30);
            this.textBox1.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label1.Location = new System.Drawing.Point(43, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 22);
            this.label1.TabIndex = 18;
            this.label1.Text = "Confirm New Password:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // back2login
            // 
            this.back2login.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.back2login.BackColor = System.Drawing.Color.White;
            this.back2login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.back2login.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.back2login.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.back2login.Location = new System.Drawing.Point(99, 449);
            this.back2login.Name = "back2login";
            this.back2login.Size = new System.Drawing.Size(271, 48);
            this.back2login.TabIndex = 22;
            this.back2login.Text = "Back to Log In";
            this.back2login.UseVisualStyleBackColor = false;
            this.back2login.Click += new System.EventHandler(this.back2login_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(489, 533);
            this.Controls.Add(this.back2login);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.login_text);
            this.Controls.Add(this.Login_buton);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.username_textBox);
            this.Controls.Add(this.username_text);
            this.Name = "Form2";
            this.Text = "Forgot Password";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Login_buton;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.TextBox username_textBox;
        private System.Windows.Forms.Label username_text;
        private System.Windows.Forms.Label login_text;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Button back2login;
    }
}
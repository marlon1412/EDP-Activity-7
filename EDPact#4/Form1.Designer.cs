using System.Windows.Forms;

namespace EDPact_4
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
            this.login_text = new System.Windows.Forms.Label();
            this.username_text = new System.Windows.Forms.Label();
            this.username_textBox = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Login_buton = new System.Windows.Forms.Button();
            this.FPassword_link = new System.Windows.Forms.LinkLabel();
            this.CreatenewAcc = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // login_text
            // 
            this.login_text.AutoSize = true;
            this.login_text.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_text.Location = new System.Drawing.Point(188, 21);
            this.login_text.Name = "login_text";
            this.login_text.Size = new System.Drawing.Size(122, 40);
            this.login_text.TabIndex = 0;
            this.login_text.Text = "Log In";
            this.login_text.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.login_text.Click += new System.EventHandler(this.login_text_Click);
            // 
            // username_text
            // 
            this.username_text.AutoSize = true;
            this.username_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.username_text.Location = new System.Drawing.Point(49, 104);
            this.username_text.Name = "username_text";
            this.username_text.Size = new System.Drawing.Size(97, 22);
            this.username_text.TabIndex = 1;
            this.username_text.Text = "Username:";
            // 
            // username_textBox
            // 
            this.username_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.username_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.username_textBox.Location = new System.Drawing.Point(49, 137);
            this.username_textBox.Name = "username_textBox";
            this.username_textBox.Size = new System.Drawing.Size(388, 30);
            this.username_textBox.TabIndex = 2;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.Password.Location = new System.Drawing.Point(49, 178);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(94, 22);
            this.Password.TabIndex = 3;
            this.Password.Text = "Password:";
            // 
            // password_textBox
            // 
            this.password_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.password_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.password_textBox.Location = new System.Drawing.Point(53, 209);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.PasswordChar = '*';
            this.password_textBox.Size = new System.Drawing.Size(383, 30);
            this.password_textBox.TabIndex = 4;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.checkBox1.Location = new System.Drawing.Point(60, 262);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(129, 22);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Remember Me";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Login_buton
            // 
            this.Login_buton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Login_buton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Login_buton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Login_buton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_buton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.Login_buton.Location = new System.Drawing.Point(166, 305);
            this.Login_buton.Name = "Login_buton";
            this.Login_buton.Size = new System.Drawing.Size(154, 48);
            this.Login_buton.TabIndex = 6;
            this.Login_buton.Text = "Log In";
            this.Login_buton.UseVisualStyleBackColor = false;
            this.Login_buton.Click += new System.EventHandler(this.Login_buton_Click);
            // 
            // FPassword_link
            // 
            this.FPassword_link.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FPassword_link.AutoSize = true;
            this.FPassword_link.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.FPassword_link.LinkColor = System.Drawing.Color.Black;
            this.FPassword_link.Location = new System.Drawing.Point(317, 265);
            this.FPassword_link.Name = "FPassword_link";
            this.FPassword_link.Size = new System.Drawing.Size(131, 18);
            this.FPassword_link.TabIndex = 7;
            this.FPassword_link.TabStop = true;
            this.FPassword_link.Text = "Forgot Password?";
            this.FPassword_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.FPassword_link_LinkClicked);
            // 
            // CreatenewAcc
            // 
            this.CreatenewAcc.AutoSize = true;
            this.CreatenewAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.CreatenewAcc.LinkColor = System.Drawing.Color.Black;
            this.CreatenewAcc.Location = new System.Drawing.Point(176, 372);
            this.CreatenewAcc.Name = "CreatenewAcc";
            this.CreatenewAcc.Size = new System.Drawing.Size(144, 18);
            this.CreatenewAcc.TabIndex = 8;
            this.CreatenewAcc.TabStop = true;
            this.CreatenewAcc.Text = "Create New Account";
            this.CreatenewAcc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CreatenewAcc_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(489, 453);
            this.Controls.Add(this.CreatenewAcc);
            this.Controls.Add(this.FPassword_link);
            this.Controls.Add(this.Login_buton);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.username_textBox);
            this.Controls.Add(this.username_text);
            this.Controls.Add(this.login_text);
            this.Name = "Form1";
            this.Text = "Log In/Sign Up";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Label login_text;
        private Label username_text;
        private TextBox username_textBox;
        private Label Password;
        private TextBox password_textBox;
        private CheckBox checkBox1;
        private Button Login_buton;
        private LinkLabel FPassword_link;
        private LinkLabel CreatenewAcc;

        #endregion

    }
}


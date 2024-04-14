namespace EDPact_4
{
    partial class Form6
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
            this.sign_in = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.name_text = new System.Windows.Forms.TextBox();
            this.email_text = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.password_text = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.Submit_btn = new System.Windows.Forms.Button();
            this.back2login = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.rec_answer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sign_in
            // 
            this.sign_in.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sign_in.AutoSize = true;
            this.sign_in.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sign_in.Location = new System.Drawing.Point(174, 33);
            this.sign_in.Name = "sign_in";
            this.sign_in.Size = new System.Drawing.Size(154, 46);
            this.sign_in.TabIndex = 0;
            this.sign_in.Text = "Sign In";
            this.sign_in.Click += new System.EventHandler(this.label1_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(59, 113);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(81, 18);
            this.name.TabIndex = 1;
            this.name.Text = "Username:";
            this.name.Click += new System.EventHandler(this.name_Click);
            // 
            // name_text
            // 
            this.name_text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.name_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_text.Location = new System.Drawing.Point(62, 148);
            this.name_text.Name = "name_text";
            this.name_text.Size = new System.Drawing.Size(370, 24);
            this.name_text.TabIndex = 2;
            this.name_text.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // email_text
            // 
            this.email_text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.email_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_text.Location = new System.Drawing.Point(62, 217);
            this.email_text.Name = "email_text";
            this.email_text.Size = new System.Drawing.Size(370, 24);
            this.email_text.TabIndex = 4;
            this.email_text.TextChanged += new System.EventHandler(this.email_text_TextChanged);
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(62, 186);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(49, 18);
            this.email.TabIndex = 3;
            this.email.Text = "Email:";
            // 
            // password_text
            // 
            this.password_text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.password_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_text.Location = new System.Drawing.Point(62, 287);
            this.password_text.Name = "password_text";
            this.password_text.PasswordChar = '*';
            this.password_text.Size = new System.Drawing.Size(370, 24);
            this.password_text.TabIndex = 6;
            this.password_text.TextChanged += new System.EventHandler(this.password_text_TextChanged);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(59, 254);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(79, 18);
            this.password.TabIndex = 5;
            this.password.Text = "Password:";
            this.password.Click += new System.EventHandler(this.password_Click);
            // 
            // Submit_btn
            // 
            this.Submit_btn.Location = new System.Drawing.Point(288, 472);
            this.Submit_btn.Name = "Submit_btn";
            this.Submit_btn.Size = new System.Drawing.Size(144, 47);
            this.Submit_btn.TabIndex = 9;
            this.Submit_btn.Text = "Submit";
            this.Submit_btn.UseVisualStyleBackColor = true;
            this.Submit_btn.Click += new System.EventHandler(this.Submit_btn_Click);
            // 
            // back2login
            // 
            this.back2login.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.back2login.BackColor = System.Drawing.Color.White;
            this.back2login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.back2login.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.back2login.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.back2login.Location = new System.Drawing.Point(62, 473);
            this.back2login.Name = "back2login";
            this.back2login.Size = new System.Drawing.Size(159, 46);
            this.back2login.TabIndex = 23;
            this.back2login.Text = "Back to Log In";
            this.back2login.UseVisualStyleBackColor = false;
            this.back2login.Click += new System.EventHandler(this.back2login_Click);
            // 
            // textBox2
            // 
            this.textBox2.AcceptsTab = true;
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.textBox2.Location = new System.Drawing.Point(63, 391);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(374, 30);
            this.textBox2.TabIndex = 25;
            // 
            // rec_answer
            // 
            this.rec_answer.AutoSize = true;
            this.rec_answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.rec_answer.Location = new System.Drawing.Point(58, 366);
            this.rec_answer.Name = "rec_answer";
            this.rec_answer.Size = new System.Drawing.Size(241, 22);
            this.rec_answer.TabIndex = 24;
            this.rec_answer.Text = "What is your favorite movie?:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Password Recovery Question:";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(495, 585);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.rec_answer);
            this.Controls.Add(this.back2login);
            this.Controls.Add(this.Submit_btn);
            this.Controls.Add(this.password_text);
            this.Controls.Add(this.password);
            this.Controls.Add(this.email_text);
            this.Controls.Add(this.email);
            this.Controls.Add(this.name_text);
            this.Controls.Add(this.name);
            this.Controls.Add(this.sign_in);
            this.Name = "Form6";
            this.Text = "Form6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sign_in;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox name_text;
        private System.Windows.Forms.TextBox email_text;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.TextBox password_text;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Button Submit_btn;
        private System.Windows.Forms.Button back2login;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label rec_answer;
        private System.Windows.Forms.Label label1;
    }
}
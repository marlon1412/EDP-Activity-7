namespace EDPact_4
{
    partial class Form7
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
            this.recovery_question = new System.Windows.Forms.Label();
            this.username_textBox = new System.Windows.Forms.TextBox();
            this.username_text = new System.Windows.Forms.Label();
            this.passrec_question = new System.Windows.Forms.Label();
            this.answer_passerec = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.back2login = new System.Windows.Forms.Button();
            this.Confim_buton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // recovery_question
            // 
            this.recovery_question.AutoSize = true;
            this.recovery_question.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recovery_question.Location = new System.Drawing.Point(83, 42);
            this.recovery_question.Name = "recovery_question";
            this.recovery_question.Size = new System.Drawing.Size(324, 38);
            this.recovery_question.TabIndex = 0;
            this.recovery_question.Text = "Recovery Question";
            // 
            // username_textBox
            // 
            this.username_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.username_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.username_textBox.Location = new System.Drawing.Point(46, 157);
            this.username_textBox.Name = "username_textBox";
            this.username_textBox.Size = new System.Drawing.Size(388, 30);
            this.username_textBox.TabIndex = 4;
            // 
            // username_text
            // 
            this.username_text.AutoSize = true;
            this.username_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.username_text.Location = new System.Drawing.Point(46, 124);
            this.username_text.Name = "username_text";
            this.username_text.Size = new System.Drawing.Size(97, 22);
            this.username_text.TabIndex = 3;
            this.username_text.Text = "Username:";
            // 
            // passrec_question
            // 
            this.passrec_question.AutoSize = true;
            this.passrec_question.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passrec_question.Location = new System.Drawing.Point(43, 237);
            this.passrec_question.Name = "passrec_question";
            this.passrec_question.Size = new System.Drawing.Size(195, 18);
            this.passrec_question.TabIndex = 15;
            this.passrec_question.Text = "What is your favorite movie?";
            // 
            // answer_passerec
            // 
            this.answer_passerec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.answer_passerec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer_passerec.Location = new System.Drawing.Point(43, 267);
            this.answer_passerec.Name = "answer_passerec";
            this.answer_passerec.PasswordChar = '*';
            this.answer_passerec.Size = new System.Drawing.Size(391, 30);
            this.answer_passerec.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Password Recovery Question:";
            // 
            // back2login
            // 
            this.back2login.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.back2login.BackColor = System.Drawing.Color.White;
            this.back2login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.back2login.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.back2login.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.back2login.Location = new System.Drawing.Point(114, 431);
            this.back2login.Name = "back2login";
            this.back2login.Size = new System.Drawing.Size(271, 48);
            this.back2login.TabIndex = 23;
            this.back2login.Text = "Back to Log In";
            this.back2login.UseVisualStyleBackColor = false;
            this.back2login.Click += new System.EventHandler(this.back2login_Click);
            // 
            // Confim_buton
            // 
            this.Confim_buton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Confim_buton.BackColor = System.Drawing.Color.White;
            this.Confim_buton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Confim_buton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Confim_buton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.Confim_buton.Location = new System.Drawing.Point(114, 362);
            this.Confim_buton.Name = "Confim_buton";
            this.Confim_buton.Size = new System.Drawing.Size(271, 48);
            this.Confim_buton.TabIndex = 24;
            this.Confim_buton.Text = "Confirm";
            this.Confim_buton.UseVisualStyleBackColor = false;
            this.Confim_buton.Click += new System.EventHandler(this.Confim_buton_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(512, 517);
            this.Controls.Add(this.Confim_buton);
            this.Controls.Add(this.back2login);
            this.Controls.Add(this.passrec_question);
            this.Controls.Add(this.answer_passerec);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.username_textBox);
            this.Controls.Add(this.username_text);
            this.Controls.Add(this.recovery_question);
            this.Name = "Form7";
            this.Text = "Recover";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label recovery_question;
        private System.Windows.Forms.TextBox username_textBox;
        private System.Windows.Forms.Label username_text;
        private System.Windows.Forms.Label passrec_question;
        private System.Windows.Forms.TextBox answer_passerec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back2login;
        private System.Windows.Forms.Button Confim_buton;
    }
}
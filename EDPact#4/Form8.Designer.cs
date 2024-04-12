namespace EDPact_4
{
    partial class Form8
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
            this.updatetxt = new System.Windows.Forms.Label();
            this.Submit_btn = new System.Windows.Forms.Button();
            this.back2dashboard = new System.Windows.Forms.Button();
            this.newUsername_textBox = new System.Windows.Forms.Label();
            this.oldUsername_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.newUsername_txtBox = new System.Windows.Forms.TextBox();
            this.oldPassword_textBox = new System.Windows.Forms.TextBox();
            this.oldpaass = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // updatetxt
            // 
            this.updatetxt.AutoSize = true;
            this.updatetxt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatetxt.Location = new System.Drawing.Point(136, 30);
            this.updatetxt.Name = "updatetxt";
            this.updatetxt.Size = new System.Drawing.Size(249, 38);
            this.updatetxt.TabIndex = 0;
            this.updatetxt.Text = "Update Profile";
            this.updatetxt.Click += new System.EventHandler(this.updatetxt_Click);
            // 
            // Submit_btn
            // 
            this.Submit_btn.Location = new System.Drawing.Point(315, 448);
            this.Submit_btn.Name = "Submit_btn";
            this.Submit_btn.Size = new System.Drawing.Size(144, 47);
            this.Submit_btn.TabIndex = 10;
            this.Submit_btn.Text = "Submit";
            this.Submit_btn.UseVisualStyleBackColor = true;
            this.Submit_btn.Click += new System.EventHandler(this.Submit_btn_Click);
            // 
            // back2dashboard
            // 
            this.back2dashboard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.back2dashboard.BackColor = System.Drawing.Color.White;
            this.back2dashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.back2dashboard.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.back2dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.back2dashboard.Location = new System.Drawing.Point(67, 449);
            this.back2dashboard.Name = "back2dashboard";
            this.back2dashboard.Size = new System.Drawing.Size(154, 46);
            this.back2dashboard.TabIndex = 24;
            this.back2dashboard.Text = "Back ";
            this.back2dashboard.UseVisualStyleBackColor = false;
            this.back2dashboard.Click += new System.EventHandler(this.back2dashboard_Click);
            // 
            // newUsername_textBox
            // 
            this.newUsername_textBox.AutoSize = true;
            this.newUsername_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newUsername_textBox.Location = new System.Drawing.Point(48, 122);
            this.newUsername_textBox.Name = "newUsername_textBox";
            this.newUsername_textBox.Size = new System.Drawing.Size(135, 20);
            this.newUsername_textBox.TabIndex = 25;
            this.newUsername_textBox.Text = "Old Username:";
            this.newUsername_textBox.Click += new System.EventHandler(this.label1_Click);
            // 
            // oldUsername_textBox
            // 
            this.oldUsername_textBox.Location = new System.Drawing.Point(52, 158);
            this.oldUsername_textBox.Name = "oldUsername_textBox";
            this.oldUsername_textBox.Size = new System.Drawing.Size(407, 22);
            this.oldUsername_textBox.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "New Username:";
            // 
            // newUsername_txtBox
            // 
            this.newUsername_txtBox.Location = new System.Drawing.Point(52, 240);
            this.newUsername_txtBox.Name = "newUsername_txtBox";
            this.newUsername_txtBox.Size = new System.Drawing.Size(403, 22);
            this.newUsername_txtBox.TabIndex = 28;
            this.newUsername_txtBox.TextChanged += new System.EventHandler(this.newUsername_txtBox_TextChanged);
            // 
            // oldPassword_textBox
            // 
            this.oldPassword_textBox.Location = new System.Drawing.Point(52, 316);
            this.oldPassword_textBox.Name = "oldPassword_textBox";
            this.oldPassword_textBox.Size = new System.Drawing.Size(403, 22);
            this.oldPassword_textBox.TabIndex = 30;
            // 
            // oldpaass
            // 
            this.oldpaass.AutoSize = true;
            this.oldpaass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldpaass.Location = new System.Drawing.Point(48, 280);
            this.oldpaass.Name = "oldpaass";
            this.oldpaass.Size = new System.Drawing.Size(132, 20);
            this.oldpaass.TabIndex = 29;
            this.oldpaass.Text = "Old Password:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(52, 388);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(403, 22);
            this.textBox1.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "New Password:";
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 530);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.oldPassword_textBox);
            this.Controls.Add(this.oldpaass);
            this.Controls.Add(this.newUsername_txtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.oldUsername_textBox);
            this.Controls.Add(this.newUsername_textBox);
            this.Controls.Add(this.back2dashboard);
            this.Controls.Add(this.Submit_btn);
            this.Controls.Add(this.updatetxt);
            this.Name = "Form8";
            this.Text = "Update Profile";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label updatetxt;
        private System.Windows.Forms.Button Submit_btn;
        private System.Windows.Forms.Button back2dashboard;
        private System.Windows.Forms.Label newUsername_textBox;
        private System.Windows.Forms.TextBox oldUsername_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newUsername_txtBox;
        private System.Windows.Forms.TextBox oldPassword_textBox;
        private System.Windows.Forms.Label oldpaass;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}
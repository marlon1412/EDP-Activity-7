namespace EDPact_4
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.backbtn = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.arch_btn = new System.Windows.Forms.Button();
            this.studentlistbtn = new System.Windows.Forms.Button();
            this.accountlistbtn = new System.Windows.Forms.Button();
            this.gridpanel = new System.Windows.Forms.Panel();
            this.generate_archieve = new System.Windows.Forms.Button();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.gnerate_stdnt_info = new System.Windows.Forms.Button();
            this.generatebtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.gridpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.backbtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-12, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1099, 111);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(344, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(403, 105);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(8, 117);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(165, 76);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(14, 117);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(162, 432);
            this.panel2.TabIndex = 3;
            // 
            // backbtn
            // 
            this.backbtn.AutoSize = true;
            this.backbtn.BackColor = System.Drawing.Color.Navy;
            this.backbtn.LinkColor = System.Drawing.Color.White;
            this.backbtn.Location = new System.Drawing.Point(24, 12);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(56, 16);
            this.backbtn.TabIndex = 1;
            this.backbtn.TabStop = true;
            this.backbtn.Text = "<- BACK";
            this.backbtn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.backbtn_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(24, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reports";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel4.Controls.Add(this.arch_btn);
            this.panel4.Controls.Add(this.studentlistbtn);
            this.panel4.Controls.Add(this.accountlistbtn);
            this.panel4.Location = new System.Drawing.Point(5, 110);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(184, 436);
            this.panel4.TabIndex = 3;
            // 
            // arch_btn
            // 
            this.arch_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.arch_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.arch_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.arch_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.arch_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arch_btn.Location = new System.Drawing.Point(6, 114);
            this.arch_btn.Name = "arch_btn";
            this.arch_btn.Size = new System.Drawing.Size(175, 39);
            this.arch_btn.TabIndex = 2;
            this.arch_btn.Text = "Student Archive";
            this.arch_btn.UseVisualStyleBackColor = false;
            this.arch_btn.Click += new System.EventHandler(this.arch_btn_Click);
            // 
            // studentlistbtn
            // 
            this.studentlistbtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.studentlistbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.studentlistbtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.studentlistbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.studentlistbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentlistbtn.Location = new System.Drawing.Point(3, 71);
            this.studentlistbtn.Name = "studentlistbtn";
            this.studentlistbtn.Size = new System.Drawing.Size(178, 37);
            this.studentlistbtn.TabIndex = 1;
            this.studentlistbtn.Text = "Student Info";
            this.studentlistbtn.UseVisualStyleBackColor = false;
            this.studentlistbtn.Click += new System.EventHandler(this.studentlistbtn_Click);
            // 
            // accountlistbtn
            // 
            this.accountlistbtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.accountlistbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.accountlistbtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.accountlistbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accountlistbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountlistbtn.Location = new System.Drawing.Point(3, 28);
            this.accountlistbtn.Name = "accountlistbtn";
            this.accountlistbtn.Size = new System.Drawing.Size(178, 37);
            this.accountlistbtn.TabIndex = 0;
            this.accountlistbtn.Text = "Account List";
            this.accountlistbtn.UseVisualStyleBackColor = false;
            this.accountlistbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // gridpanel
            // 
            this.gridpanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gridpanel.Controls.Add(this.generate_archieve);
            this.gridpanel.Controls.Add(this.dgv2);
            this.gridpanel.Controls.Add(this.gnerate_stdnt_info);
            this.gridpanel.Controls.Add(this.generatebtn);
            this.gridpanel.Location = new System.Drawing.Point(199, 120);
            this.gridpanel.Name = "gridpanel";
            this.gridpanel.Size = new System.Drawing.Size(876, 426);
            this.gridpanel.TabIndex = 4;
            // 
            // generate_archieve
            // 
            this.generate_archieve.BackColor = System.Drawing.SystemColors.Highlight;
            this.generate_archieve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.generate_archieve.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.generate_archieve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generate_archieve.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generate_archieve.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.generate_archieve.Location = new System.Drawing.Point(656, 32);
            this.generate_archieve.Name = "generate_archieve";
            this.generate_archieve.Size = new System.Drawing.Size(195, 50);
            this.generate_archieve.TabIndex = 6;
            this.generate_archieve.Text = "Generate Report";
            this.generate_archieve.UseVisualStyleBackColor = false;
            this.generate_archieve.Click += new System.EventHandler(this.generate_archieve_Click);
            // 
            // dgv2
            // 
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Location = new System.Drawing.Point(24, 15);
            this.dgv2.Name = "dgv2";
            this.dgv2.RowHeadersWidth = 51;
            this.dgv2.RowTemplate.Height = 24;
            this.dgv2.Size = new System.Drawing.Size(610, 378);
            this.dgv2.TabIndex = 0;
            // 
            // gnerate_stdnt_info
            // 
            this.gnerate_stdnt_info.BackColor = System.Drawing.SystemColors.Highlight;
            this.gnerate_stdnt_info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gnerate_stdnt_info.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gnerate_stdnt_info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gnerate_stdnt_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gnerate_stdnt_info.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gnerate_stdnt_info.Location = new System.Drawing.Point(656, 32);
            this.gnerate_stdnt_info.Name = "gnerate_stdnt_info";
            this.gnerate_stdnt_info.Size = new System.Drawing.Size(195, 50);
            this.gnerate_stdnt_info.TabIndex = 5;
            this.gnerate_stdnt_info.Text = "Generate Report";
            this.gnerate_stdnt_info.UseVisualStyleBackColor = false;
            this.gnerate_stdnt_info.Click += new System.EventHandler(this.gnerate_stdnt_info_Click);
            // 
            // generatebtn
            // 
            this.generatebtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.generatebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.generatebtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.generatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generatebtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.generatebtn.Location = new System.Drawing.Point(656, 32);
            this.generatebtn.Name = "generatebtn";
            this.generatebtn.Size = new System.Drawing.Size(195, 50);
            this.generatebtn.TabIndex = 1;
            this.generatebtn.Text = "Generate Report";
            this.generatebtn.UseVisualStyleBackColor = false;
            this.generatebtn.Click += new System.EventHandler(this.generatebtn_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1085, 589);
            this.Controls.Add(this.gridpanel);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.gridpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel backbtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button accountlistbtn;
        private System.Windows.Forms.Button studentlistbtn;
        private System.Windows.Forms.Button arch_btn;
        private System.Windows.Forms.Panel gridpanel;
        private System.Windows.Forms.Button generatebtn;
        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.Button gnerate_stdnt_info;
        private System.Windows.Forms.Button generate_archieve;
        private System.Windows.Forms.Button button1;
    }
}
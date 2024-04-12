using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDPact_4
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            richTextBox1.ReadOnly = true;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();

            // Show Form2
            f3.ShowDialog();

            // Close the current instance of Form1
            this.Close();
        }
    }
}

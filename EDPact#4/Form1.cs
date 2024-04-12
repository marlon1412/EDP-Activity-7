using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using MySql.Data.MySqlClient;
using EDPact_4;


namespace EDPact_4

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void login_text_Click(object sender, EventArgs e)
        {
        }

        private void FPassword_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form7 f7 = new Form7();
            this.Hide();

            // Show Form2
            f7.ShowDialog();

            // Close the current instance of Form1
            this.Close();
        }

        private void Login_buton_Click(object sender, EventArgs e)
        {
            string username = this.username_textBox.Text;
            string password = this.password_textBox.Text;

            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString;
            myConnectionString = "server=127.0.0.1;uid=root;" +
                "pwd=1234;database=student_db";
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();

                string sql = "SELECT COUNT(*) from accounts where name = @username AND password = @password";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count > 0)
                {
                    // Set the current username in the ApplicationContext
                    ApplicationContext.CurrentUsername = this.username_textBox.Text;

                    // Open the main application form
                    Form3 f3 = new Form3();
                    this.Hide();
                    f3.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid username/password");
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void CreatenewAcc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form6 f6 = new Form6();
            this.Hide();

            // Show Form2
            f6.ShowDialog();

            // Close the current instance of Form1
            this.Close();


        }
    }
}
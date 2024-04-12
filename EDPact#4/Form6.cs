using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EDPact_4
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_Click(object sender, EventArgs e)
        {

        }

        private void password_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void email_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void back2login_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();

            // Show Form2
            f1.ShowDialog();

            // Close the current instance of Form1
            this.Close();
        }

        private void Submit_btn_Click(object sender, EventArgs e)
        {
            string username = this.name_text.Text;
            string password = this.password_text.Text;
            string rec_answer = this.textBox2.Text;
            string email = this.email_text.Text;
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString;
            myConnectionString = "server=127.0.0.1;uid=root;" +
            "pwd=1234;database=student_db";

            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();

                // Check if the account with the given name already exists
                string checkIfExistsQuery = "SELECT COUNT(*) FROM accounts WHERE name = @name";
                MySqlCommand checkIfExistsCmd = new MySqlCommand(checkIfExistsQuery, conn);
                checkIfExistsCmd.Parameters.AddWithValue("@name", username);

                int existingAccountCount = Convert.ToInt32(checkIfExistsCmd.ExecuteScalar());

                if (existingAccountCount > 0)
                {
                    MessageBox.Show("Account with the given name already exists. Please choose a different name.");
                    return;
                }

                // Insert new account
                string insertQuery = "INSERT INTO accounts (name, password, rec_answer,email) VALUES (@name, @password, @rec_answer,@email)";
                MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn);
                insertCmd.Parameters.AddWithValue("@name", username);
                insertCmd.Parameters.AddWithValue("@password", password);
                insertCmd.Parameters.AddWithValue("@rec_answer", rec_answer);
                insertCmd.Parameters.AddWithValue("@email", email);

                int rowsAffected = insertCmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Account created successfully");
                }
                else
                {
                    MessageBox.Show("Failed to create account");
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
    }
}

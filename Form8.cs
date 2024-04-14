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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void updatetxt_Click(object sender, EventArgs e)
        {

        }

        private void new_usernametxt_Click(object sender, EventArgs e)
        {

        }

        private void newpasswordtxt_Click(object sender, EventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void Submit_btn_Click(object sender, EventArgs e)
        {
            string oldName = this.oldUsername_textBox.Text; // Assuming you have a textbox for old username input
            string newName = this.newUsername_txtBox.Text; // Assuming you have a textbox for new username input
            string oldPassword = this.oldPassword_textBox.Text;
            string newPassword = this.textBox1.Text;

            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString;
            myConnectionString = "server=127.0.0.1;uid=root;" +
            "pwd=1234;database=student_db";

            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();

                // Check if the old username and password match
                string checkOldUserAndPassQuery = "SELECT COUNT(*) FROM accounts WHERE name = @oldUsername AND password = @oldPassword";
                MySqlCommand checkOldUserAndPassCmd = new MySqlCommand(checkOldUserAndPassQuery, conn);
                checkOldUserAndPassCmd.Parameters.AddWithValue("@oldUsername", oldName);
                checkOldUserAndPassCmd.Parameters.AddWithValue("@oldPassword", oldPassword);

                int userAndPassMatchCount = Convert.ToInt32(checkOldUserAndPassCmd.ExecuteScalar());

                if (userAndPassMatchCount > 0)
                {
                    // Old username and password are correct, proceed to update the username and password
                    string updateQuery = "UPDATE accounts SET name = @newUsername, password = @newPassword WHERE name = @oldUsername";
                    MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn);
                    updateCmd.Parameters.AddWithValue("@newUsername", newName);
                    updateCmd.Parameters.AddWithValue("@newPassword", newPassword);
                    updateCmd.Parameters.AddWithValue("@oldUsername", oldName);

                    int rowsAffected = updateCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Username and password updated successfully");
                    }
                    else
                    {
                        MessageBox.Show("Failed to update username and password. Please try again later.");
                    }
                }
                else
                {
                    MessageBox.Show("Failed to update username and password. Incorrect old username or password.");
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


        }

        private void back2dashboard_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();

            // Show Form2
            f3.ShowDialog();

            // Close the current instance of Form1
            this.Close();
        }

        private void oldpassword_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void newUsername_txtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

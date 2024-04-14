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
using MySql.Data;
using EDPact_4;
using System.Data.SqlClient;

namespace EDPact_4
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

        
    }
        private string GetCurrentUsername()
        {
            // Retrieve the current username from your application context or session
            return ApplicationContext.CurrentUsername;
        }

        private void admindashboardtext_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dashboardsidepanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void abt_btn_Click(object sender, EventArgs e)
        {

            Form4 f2 = new Form4();
            this.Hide();

            // Show Form2
            f2.ShowDialog();

            // Close the current instance of Form1
            this.Close();
        }

        private void report_btn_Click(object sender, EventArgs e)
        {
            Form5 f3 = new Form5();
            this.Hide();

            // Show Form2
            f3.ShowDialog();

            // Close the current instance of Form1
            this.Close();
        }

        private void account_Click(object sender, EventArgs e)
        {
            panel1.Visible = !panel1.Visible;
        }

        private void Logout_button_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();

            // Show Form2
            f1.ShowDialog();

            // Close the current instance of Form1
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            this.Hide();

            // Show Form2
            f8.ShowDialog();

            // Close the current instance of Form1
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void status_btn_CheckedChanged(object sender, EventArgs e)
        {
            string currentUsername = GetCurrentUsername();

            if (!string.IsNullOrEmpty(currentUsername))
            {
                // Determine the new status based on the checked state of the radio button
                int newStatus = status_btn.Checked ? 1 : 0;

                // Update the status in the database
                UpdateStatusInDatabase(currentUsername, newStatus);
            }
            else
            {
                MessageBox.Show("Failed to retrieve the current username.");
            }
        }


        private void UpdateStatusInDatabase(string username, int newStatus)
        {
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString;
            myConnectionString = "server=127.0.0.1;uid=root;" +
                "pwd=1234;database=student_db";

            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();

                // Update the status for the specified username
                string updateStatusQuery = "UPDATE accounts SET acc_status = @newStatus WHERE name = @username";
                MySqlCommand updateStatusCmd = new MySqlCommand(updateStatusQuery, conn);
                updateStatusCmd.Parameters.AddWithValue("@newStatus", newStatus);
                updateStatusCmd.Parameters.AddWithValue("@username", username);

                int rowsAffected = updateStatusCmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Status updated successfully");
                }
                else
                {
                    MessageBox.Show("Failed to update status. Username not found.");
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        
        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void acounts_Click(object sender, EventArgs e)
        {
            panel2.Visible = !panel2.Visible;
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString;
            myConnectionString = "server=127.0.0.1;uid=root;" +
                "pwd=1234;database=student_db";

            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();

                // Query to retrieve data from the view account_details
                string selectQuery = "SELECT * FROM account_details";

                using (MySqlCommand selectCmd = new MySqlCommand(selectQuery, conn))
                {
                    // Create a DataTable to store the results
                    DataTable dataTable = new DataTable();

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(selectCmd))
                    {
                        // Fill the DataTable with the results from the view
                        adapter.Fill(dataTable);
                    }

                    // Set the DataTable as the DataSource for the DataGridView
                    dgv1.DataSource = dataTable;
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
           

        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
       
        }
    


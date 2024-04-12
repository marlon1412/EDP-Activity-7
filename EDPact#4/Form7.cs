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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Confim_buton_Click(object sender, EventArgs e)
        {
            string username = this.username_textBox.Text;
            string answer = this.answer_passerec.Text;
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString;
            myConnectionString = "server=127.0.0.1;uid=root;" +
            "pwd=1234;database=student_db";
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();
                string sql = "SELECT COUNT(*) from accounts where name = @username AND rec_answer = @rec_answer";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@rec_answer", answer);
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count > 0)
                {


                    Form2 g = new Form2();
                    this.Hide();

                    // Show Form2
                    g.ShowDialog();

                    // Close the current instance of Form1
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Incorrect Answer");
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void back2login_Click(object sender, EventArgs e)
        {
            Form1 f1= new Form1();
            this.Hide();

            // Show Form2
            f1.ShowDialog();

            // Close the current instance of Form1
            this.Close();
        }
    }
    
}

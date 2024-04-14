using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using ClosedXML.Excel;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using OfficeOpenXml.Drawing;
using DocumentFormat.OpenXml.Bibliography;


namespace EDPact_4

{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            generate_archieve.Visible = false;
            gnerate_stdnt_info.Visible = false;
            generatebtn.Visible = false;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void backbtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();

            // Show Form2
            f3.ShowDialog();

            // Close the current instance of Form1
            this.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            gridpanel.Visible = !gridpanel.Visible;

            generate_archieve.Visible = false;
            gnerate_stdnt_info.Visible = false;
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
                    dgv2.DataSource = dataTable;
                }
                generatebtn.Visible = true;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


        }

        private void studentlistbtn_Click(object sender, EventArgs e)
        {
            gridpanel.Visible = !gridpanel.Visible;
            generatebtn.Visible = false;
            generate_archieve.Visible = false;
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
                string selectQuery = "SELECT * FROM studentcategoryviewandgpa";

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
                    dgv2.DataSource = dataTable;
                }
                gnerate_stdnt_info.Visible = true;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void arch_btn_Click(object sender, EventArgs e)
        {
            gridpanel.Visible = !gridpanel.Visible;
            gnerate_stdnt_info.Visible = false;
            generatebtn.Visible = false;
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
                string selectQuery = "SELECT * FROM archieved";

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
                    dgv2.DataSource = dataTable;
                }
                generate_archieve.Visible = true;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void generatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dataTable = (DataTable)dgv2.DataSource;

                // Set license context to non-commercial to avoid license check
                OfficeOpenXml.ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

                string templatePath = @"C:\Users\User\Desktop\template.xlsx";
                string savePath = @"C:\Users\User\Desktop\account_list.xlsx";

                using (var templatePackage = new ExcelPackage(new FileInfo(templatePath)))
                {
                    // Access the worksheet in the template
                    var worksheet = templatePackage.Workbook.Worksheets["Sheet1"];

                    // Insert DataTable into worksheet starting at cell A12
                    worksheet.Cells["A12"].LoadFromDataTable(dataTable, true);


                    // Save the modified Excel file
                    templatePackage.SaveAs(new FileInfo(savePath));

                    MessageBox.Show("Excel file generated successfully at: " + savePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating Excel file: " + ex.Message);
            }
        }

        private void generate_archieve_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dataTable = (DataTable)dgv2.DataSource;

                // Set license context to non-commercial to avoid license check
                OfficeOpenXml.ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

                string templatePath = @"C:\Users\User\Desktop\template.xlsx";
                string savePath = @"C:\Users\User\Desktop\archive.xlsx";

                using (var templatePackage = new ExcelPackage(new FileInfo(templatePath)))
                {
                    // Access the worksheet in the template
                    var worksheet = templatePackage.Workbook.Worksheets["Sheet1"];

                    // Insert DataTable into worksheet starting at cell A12
                    worksheet.Cells["A12"].LoadFromDataTable(dataTable, true);

                   
                    // Save the modified Excel file
                    templatePackage.SaveAs(new FileInfo(savePath));

                    MessageBox.Show("Excel file generated successfully at: " + savePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating Excel file: " + ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void gnerate_stdnt_info_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dataTable = (DataTable)dgv2.DataSource;

                // Set license context to non-commercial to avoid license check
                OfficeOpenXml.ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

                string templatePath = @"C:\Users\User\Desktop\template.xlsx";
                string savePath = @"C:\Users\User\Desktop\student_info.xlsx";

                using (var templatePackage = new ExcelPackage(new FileInfo(templatePath)))
                {
                    // Access the worksheet in the template
                    var worksheet = templatePackage.Workbook.Worksheets["Sheet1"];

                    // Insert DataTable into worksheet starting at cell A12
                    worksheet.Cells["A12"].LoadFromDataTable(dataTable, true);


                    // Save the modified Excel file
                    templatePackage.SaveAs(new FileInfo(savePath));

                    MessageBox.Show("Excel file generated successfully at: " + savePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating Excel file: " + ex.Message);
            }
        }
    }
}


    



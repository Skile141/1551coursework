using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _1551coursework
{
    public partial class AdminInfo : Form
    {
        private string username;
        // Database connection string
        static string currentDirectory = Path.Combine(Directory.GetCurrentDirectory(), "..", "..");
        static string fullPath = Path.GetFullPath(currentDirectory);
        static public string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={fullPath}\Person.mdf;Integrated Security=True";


        // Constructor to initialize the form
        public AdminInfo(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        // Event handler for form load event
        private void AdminInfo_Load(object sender, EventArgs e)
        {
            try
            {
                // Establishing connection to the database
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL query to fetch administrator information based on username
                    string query = "SELECT p.*, A.Salary, A.Employee_Type, A.Working_Hours " +
                                   "FROM person p " +
                                   "INNER JOIN Administrator A ON p.PersonID = A.PersonID " +
                                   "WHERE p.username = @username";

                    // Creating SqlCommand object with the query and connection
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Username", username); // Parameterized query to prevent SQL injection

                    // Executing the query and reading the results
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Displaying administrator information in the form's text boxes
                            StudentID.Text = reader.GetValue(0).ToString();
                            AdminFN.Text = reader.GetValue(1).ToString();
                            AdminLN.Text = reader.GetValue(2).ToString();
                            AdminEmail.Text = reader.GetValue(3).ToString();
                            AdminTelephone.Text = reader.GetValue(4).ToString();
                            AdminSalary.Text = reader.GetValue(8).ToString();
                            Admin_worker.Text = reader.GetValue(9).ToString();
                            Hours.Text = reader.GetValue(10).ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Displaying error message in case of an exception
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        // Event handler for button click to return to the admin dashboard
        private void button1_Click(object sender, EventArgs e)
        {
            // Creating a new instance of the admin dashboard form and displaying it
            Admin1 admin1 = new Admin1(username);
            admin1.Show();
            this.Hide(); // Hiding the current form
        }
    }
}
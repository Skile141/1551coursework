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
    public partial class StudentInformation : Form
    {
        private string username;

        // Database connection string
        static string currentDirectory = Path.Combine(Directory.GetCurrentDirectory(), "..", "..");
        static string fullPath = Path.GetFullPath(currentDirectory);
        static public string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={fullPath}\Person.mdf;Integrated Security=True";

        // Constructor to initialize the form
        public StudentInformation(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        // Event handler for form load event
        private void StudentInformation_Load(object sender, EventArgs e)
        { 
            try
            {
                // Establishing connection to the database
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL query to fetch student information based on username
                    string query = "SELECT p.*, S.Current_Subject_1, S.Current_Subject_2, S.Previous_Subject_1, S.Previous_Subject_2 " +
                                   "FROM person p " +
                                   "INNER JOIN Student S ON p.PersonID = S.PersonID " +
                                   "WHERE p.username = @username";

                    // Creating SqlCommand object with the query and connection
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Username", username); // Parameterized query to prevent SQL injection

                    // Executing the query and reading the results
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Displaying student information in the form's text boxes
                            StudentID.Text = reader.GetValue(0).ToString();
                            studentFN.Text = reader.GetValue(1).ToString();
                            StudentLN.Text = reader.GetValue(2).ToString();
                            StudentEmail.Text = reader.GetValue(3).ToString();
                            StudentTelephone.Text = reader.GetValue(4).ToString();
                            StudentSubject1.Text = reader.GetValue(8).ToString();
                            StudentSubject2.Text = reader.GetValue(9).ToString();
                            OldSubject1.Text = reader.GetValue(10).ToString();
                            OldSubject2.Text = reader.GetValue(11).ToString();
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

        // Event handler for logout button click
        private void logout_pic_Click(object sender, EventArgs e)
        {
            // Creating a new instance of the login form and displaying it
            Login_form login = new Login_form();
            login.Show();
            this.Hide(); // Hiding the current form
        }
    }
}


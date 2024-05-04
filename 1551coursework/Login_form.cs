using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace _1551coursework
{
    public partial class Login_form : Form
    {
        // Establishing connection to the database
        static string currentDirectory = Path.Combine(Directory.GetCurrentDirectory(), "..", "..");
        static string fullPath = Path.GetFullPath(currentDirectory);
        static public string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={fullPath}\Person.mdf;Integrated Security=True";

        SqlConnection connect = new SqlConnection(connectionString);
        public Login_form()
        {
            InitializeComponent();
            // Setting password character to '*' for security
            password.PasswordChar = '*';
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            // Checking if the connection to the database is not already open
            if (connect.State != ConnectionState.Open)
            {
                // Validating username and password fields
                if (username_text.Text == "" || password.Text == "")
                {
                    MessageBox.Show("Username and password are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    connect.Open();
                    // Query to check username and password in the database
                    string checkPersonQuery = "SELECT * FROM person WHERE username = @username AND [password] = @password";
                    using (SqlCommand checkPerson = new SqlCommand(checkPersonQuery, connect))
                    {
                        checkPerson.Parameters.AddWithValue("@username", username_text.Text.Trim());
                        checkPerson.Parameters.AddWithValue("@password", password.Text.Trim());

                        SqlDataAdapter personAdapter = new SqlDataAdapter(checkPerson);
                        DataTable personTable = new DataTable();
                        personAdapter.Fill(personTable);
                        if (personTable.Rows.Count == 1)
                        {
                            // Getting the role of the user and redirecting accordingly
                            string role = personTable.Rows[0]["role"].ToString();
                            switch (role)
                            {
                                case "Student":
                                    StudentInformation studentInformation = new StudentInformation(username_text.Text);
                                    studentInformation.Show();
                                    this.Hide();
                                    break;
                                case "Teacher":
                                    TeacherInformation teacherInformation = new TeacherInformation(username_text.Text);
                                    teacherInformation.Show();
                                    this.Hide();
                                    break;
                                case "Administrator":
                                    Admin1 admin1 = new Admin1(username_text.Text);
                                    admin1.Show();
                                    this.Hide();
                                    break;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Username or password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Closing the database connection
                    connect.Close();
                }
            }
        }

        private void show_password_CheckedChanged(object sender, EventArgs e)
        {
            // Showing/hiding password characters based on checkbox state
            if (show_password.Checked)
            {
                password.PasswordChar = '\0'; // Show password characters
            }
            else
            {
                password.PasswordChar = '*'; // Hide password characters
            }
        }
    }
}

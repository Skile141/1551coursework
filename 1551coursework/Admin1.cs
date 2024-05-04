using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1551coursework
{
    public partial class Admin1 : Form
    {
        private string username;

        // Database connection string
        static string currentDirectory = Path.Combine(Directory.GetCurrentDirectory(), "..", "..");
        static string fullPath = Path.GetFullPath(currentDirectory);
        static public string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={fullPath}\Person.mdf;Integrated Security=True";

        // Constructor to initialize the form with the username
        public Admin1(string username)
        {
            InitializeComponent();
            this.username = username;
        }
        // Logout button click event handler
        private void admin_logout_Click(object sender, EventArgs e)
        {
            // Creating a new instance of the login form and showing it
            Login_form login = new Login_form();
            login.Show();
            this.Close(); // Closing the current admin form
        }
        // Button click event handler to manage students
        private void Manage_student_Click(object sender, EventArgs e)
        {
            // Creating a new instance of the ManageStudent form and showing it
            ManageStudent manage_students = new ManageStudent();
            manage_students.Show();
            this.Hide(); // Hiding the current admin form
        }
        // Button click event handler to manage teachers
        private void Manage_teacher_Click(object sender, EventArgs e)
        {
            // Creating a new instance of the ManageTeachingStaff form and showing it
            ManageTeachingStaff manage_staff = new ManageTeachingStaff();
            manage_staff.Show();
            this.Hide(); // Hiding the current admin form
        }
        // Button click event handler to manage administrators
        private void Manage_admin_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string checkAdmin = "SELECT * FROM person WHERE username = @username";
                    SqlCommand cmd = new SqlCommand(checkAdmin, connection);
                    cmd.Parameters.AddWithValue("@Username", username);

                    // Checking if the logged-in user is an admin
                    if (username == "admin1")
                    {
                        // Creating a new instance of the ManageAdmin form for admin management
                        ManageAdmin manageAdmin = new ManageAdmin();
                        MessageBox.Show("Welcome Admin!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        manageAdmin.Show();
                        this.Hide(); // Hiding the current admin form
                    }
                    else
                    {
                        MessageBox.Show("Unauthorized Access!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Button click event handler to view admin information
        private void Admin_info_Click(object sender, EventArgs e)
        {
            // Creating a new instance of the AdminInfo form and showing it
            AdminInfo adminInfo = new AdminInfo(username);
            adminInfo.Show();
            this.Hide(); // Hiding the current admin form
        }
    }
}

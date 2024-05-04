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
using static _1551coursework.Person;

namespace _1551coursework
{
    public partial class ManageAdmin : Form
    {
        private string username;

        // Database connection string
        static string currentDirectory = Path.Combine(Directory.GetCurrentDirectory(), "..", "..");
        static string fullPath = Path.GetFullPath(currentDirectory);
        static public string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={fullPath}\Person.mdf;Integrated Security=True";
        // Constructor
        public ManageAdmin()
        {
            InitializeComponent();
        }

        // Button click event handler to add a new admin record
        private void add_admin_button_Click(object sender, EventArgs e)
        {
            // Check if all fields are filled
            if (ID_admin.Text == "" ||
                First_name_admin.Text == "" ||
                Last_name_admin.Text == "" ||
                Email_admin.Text == "" ||
                Phone_admin.Text == "" ||
                username_admin.Text == "" ||
                password_admin.Text == "" ||
                admin_salary.Text == "" ||
                admin_combobox1.SelectedItem == null ||
                admin_hours.Text == "")
            {
                MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string newID = ID_admin.Text.Trim();
                    // Check if ID starts with "AD"
                    if (!newID.StartsWith("AD"))
                    {
                        MessageBox.Show("ID should start with 'AD'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Check if username already exists
                    string checkUsername = "SELECT * FROM person WHERE username = @username AND PersonID = @PersonID";
                    using (SqlCommand checkUser = new SqlCommand(checkUsername, connection))
                    {
                        checkUser.Parameters.AddWithValue("@username", username_admin.Text.Trim());
                        checkUser.Parameters.AddWithValue("PersonID", ID_admin.Text.Trim());
                        SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count == 1)
                        {
                            MessageBox.Show(username_admin.Text + "is already exist", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            // Create an administrator object to add
                            Administrator administrator = new Administrator(newID,
                                                                            First_name_admin.Text,
                                                                            Last_name_admin.Text,
                                                                            Email_admin.Text,
                                                                            Phone_admin.Text,
                                                                            username_admin.Text,
                                                                            password_admin.Text,
                                                                            Role.Administrator,
                                                                            Convert.ToInt32(admin_salary.Text),
                                                                            admin_combobox1.SelectedItem.ToString(),
                                                                            Convert.ToInt32(admin_hours.Text)
                                                                            );
                            // Call add method
                            administrator.AddPerson(connectionString);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Reload data
            load_button_Click(null, null);
        }

        // Button click event handler to update an admin record
        private void update_admin_button_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dataGridView1.SelectedRows.Count == 1)
            {
                // Get the selected row
                DataGridViewRow row = dataGridView1.SelectedRows[0];

                string personID = row.Cells[0].Value.ToString();
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        decimal salary;
                        // Validate and parse salary
                        if (decimal.TryParse(admin_salary.Text, out salary))
                        {
                            // Create a teacher object to update
                            Teacher teacher = new Teacher(personID,
                                                            First_name_admin.Text,
                                                            Last_name_admin.Text,
                                                            Email_admin.Text,
                                                            Phone_admin.Text,
                                                            username_admin.Text,
                                                            password_admin.Text,
                                                            Role.Administrator,
                                                            salary,
                                                            admin_combobox1.SelectedItem.ToString(),
                                                            admin_hours.Text
                                                            );
                            // Call update method
                            teacher.UpdatePerson(connectionString);
                        }
                        else
                        {
                            MessageBox.Show("Invalid salary value. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        MessageBox.Show("Record updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error:{ex.Message}");
                }
                // Reload data
                load_button_Click(null, null);
            }
            else
            {
                MessageBox.Show("Select a row to update", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Button click event handler to delete an admin record
        private void delete_admin_button_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dataGridView1.SelectedRows.Count == 1)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string personID = Convert.ToString(selectedRow.Cells[0].Value);

                // Confirmation dialog for deletion
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                { 
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        try
                        {
                            // Create a teacher object to delete
                            Teacher teacher = new Teacher(personID,
                                                          First_name_admin.Text,
                                                          Last_name_admin.Text,
                                                          Email_admin.Text,
                                                          Phone_admin.Text,
                                                          username_admin.Text,
                                                          password_admin.Text,
                                                          Role.Administrator,
                                                          Convert.ToInt32(admin_salary.Text),
                                                          admin_combobox1.SelectedItem.ToString(),
                                                          admin_hours.Text);
                            // Call delete method
                            teacher.DeletePerson(connectionString);
                            // Reload data
                            load_button_Click(null, null);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occurred: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        // Button click event handler to load admin data
        private void load_button_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    // SQL query to fetch admin data
                    string query = "SELECT p.*, A.Salary, A.Employee_Type, A.Working_Hours " +
                                   "FROM person p " +
                                   "INNER JOIN Administrator A ON p.PersonID = A.PersonID ";
                    // Execute the query and fill data into DataTable
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    // Set DataGridView data source
                    dataGridView1.DataSource = dataTable;
                    // Set column headers
                    dataGridView1.Columns[0].HeaderText = "ID";
                    dataGridView1.Columns[1].HeaderText = "First Name";
                    dataGridView1.Columns[2].HeaderText = "Last Name";
                    dataGridView1.Columns[3].HeaderText = "Email";
                    dataGridView1.Columns[4].HeaderText = "Telephone";
                    dataGridView1.Columns[5].HeaderText = "Username";
                    dataGridView1.Columns[6].HeaderText = "Password";
                    dataGridView1.Columns[7].HeaderText = "Role";
                    dataGridView1.Columns[8].HeaderText = "Salary";
                    dataGridView1.Columns[9].HeaderText = "Employee Type";
                    dataGridView1.Columns[10].HeaderText = "Working Hours";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        // Event handler for changing selected row in DataGridView
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Populate text boxes with selected row data
                ID_admin.Text = selectedRow.Cells[0].Value.ToString();
                First_name_admin.Text = selectedRow.Cells[1].Value.ToString();
                Last_name_admin.Text = selectedRow.Cells[2].Value.ToString();
                Email_admin.Text = selectedRow.Cells[3].Value.ToString();
                Phone_admin.Text = selectedRow.Cells[4].Value.ToString();
                username_admin.Text = selectedRow.Cells[5].Value.ToString();
                password_admin.Text = selectedRow.Cells[6].Value.ToString();
                admin_salary.Text = selectedRow.Cells[8].Value.ToString();
                admin_combobox1.SelectedItem = selectedRow.Cells[9].Value.ToString();
                admin_hours.Text = selectedRow.Cells[10].Value.ToString();
            }
            else
            {
                // Clear text boxes if no row is selected
                ID_admin.Text = "";
                First_name_admin.Text = "";
                Last_name_admin.Text = "";
                Email_admin.Text = "";
                Phone_admin.Text = "";
                username_admin.Text = "";
                password_admin.Text = "";
                admin_salary.Text = "";
                admin_combobox1.SelectedItem = null;
                admin_hours.Text = "";
            }
        }

        // Button click event handler to exit to admin form
        private void exit_button_Click(object sender, EventArgs e)
        {
            // Show admin form
            Admin1 admin1 = new Admin1(username);
            admin1.Show();
            this.Hide(); // Hide current form
        }
    }
}

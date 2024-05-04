using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static _1551coursework.Person;

namespace _1551coursework
{
    public partial class ManageTeachingStaff : Form
    {
        private string username;

        // Database connection string
        static string currentDirectory = Path.Combine(Directory.GetCurrentDirectory(), "..", "..");
        static string fullPath = Path.GetFullPath(currentDirectory);
        static public string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={fullPath}\Person.mdf;Integrated Security=True";

        // Constructor
        public ManageTeachingStaff()
        {
            InitializeComponent();
        }

        // Button click event handler to load teacher data
        private void load_teacher_Click(object sender, EventArgs e)
        {
            
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    // SQL query to fetch teacher data
                    string query = "select p.*, T.Salary, T.Subject_1, T.Subject_2 " +
                                   "from person p " +
                                   "inner join Teacher T on p.PersonID = T.PersonID ";
                    // Data adapter to execute the query
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    // Binding the data to the DataGridView
                    dataGridView1.DataSource = dataTable;
                    // Setting column headers
                    dataGridView1.Columns[0].HeaderText = "ID";
                    dataGridView1.Columns[1].HeaderText = "First Name";
                    dataGridView1.Columns[2].HeaderText = "Last Name";
                    dataGridView1.Columns[3].HeaderText = "Email";
                    dataGridView1.Columns[4].HeaderText = "Telephone";
                    dataGridView1.Columns[5].HeaderText = "Username";
                    dataGridView1.Columns[6].HeaderText = "Password";
                    dataGridView1.Columns[7].HeaderText = "Role";
                    dataGridView1.Columns[8].HeaderText = "Salary";
                    dataGridView1.Columns[9].HeaderText = "Subject 1";
                    dataGridView1.Columns[10].HeaderText = "Subject 2";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void delete_teacher_Click(object sender, EventArgs e)
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
                                                          First_name_Text.Text,
                                                          Last_name_Text.Text,
                                                          Email_Text.Text,
                                                          Phone_text.Text,
                                                          username_text.Text,
                                                          password_text.Text,
                                                          Role.Teacher,
                                                          Convert.ToInt32(salary_textbox.Text),
                                                          Subject_combobox1.SelectedItem.ToString(),
                                                          Subject_combobox2.SelectedItem.ToString());
                            // Call delete method
                            teacher.DeletePerson(connectionString);
                            // Reload data
                            load_teacher_Click(null, null);
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

        // Button click event handler to update a teacher record
        private void update_teacher_Click(object sender, EventArgs e)
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
                        if (decimal.TryParse(salary_textbox.Text, out salary))
                        {
                            // Create a teacher object to update
                            Teacher teacher = new Teacher(personID,
                                                        First_name_Text.Text,
                                                        Last_name_Text.Text,
                                                        Email_Text.Text,
                                                        Phone_text.Text,
                                                        username_text.Text,
                                                        password_text.Text,
                                                        Role.Teacher,
                                                        salary,
                                                        Subject_combobox1.SelectedItem.ToString(),
                                                        Subject_combobox2.SelectedItem.ToString());
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
                load_teacher_Click(null, null);
            }
            else
            {
                MessageBox.Show("Select a row to update", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Button click event handler to add a new teacher record
        private void add_teacher_Click(object sender, EventArgs e)
        {
            // Check if all fields are filled
            if (ID_textbox.Text == "" ||
                First_name_Text.Text == "" ||
                Last_name_Text.Text == "" ||
                Email_Text.Text == "" ||
                Phone_text.Text == "" ||
                username_text.Text == "" ||
                password_text.Text == "" ||
                salary_textbox.Text == "" ||
                Subject_combobox1.SelectedItem == null ||
                Subject_combobox2.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string newID = ID_textbox.Text.Trim();
                    // Check if ID starts with "GV"
                    if (!newID.StartsWith("GV"))
                    {
                        MessageBox.Show("ID should start with 'GV'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Check if username already exists
                    string checkUsername = "SELECT * FROM person WHERE username = @username AND PersonID = @PersonID";
                    using (SqlCommand checkUser = new SqlCommand(checkUsername, connection))
                    {
                        checkUser.Parameters.AddWithValue("@username", username_text.Text.Trim());
                        checkUser.Parameters.AddWithValue("PersonID", ID_textbox.Text.Trim());
                        SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count == 1)
                        {
                            MessageBox.Show(username_text.Text + "is already exist", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            // Create a teacher object to add
                            Teacher teacher = new Teacher(newID,
                                                          First_name_Text.Text,
                                                          Last_name_Text.Text,
                                                          Email_Text.Text,
                                                          Phone_text.Text,
                                                          username_text.Text,
                                                          password_text.Text,
                                                          Role.Teacher,
                                                          Convert.ToInt32(salary_textbox.Text),
                                                          Subject_combobox1.SelectedItem.ToString(),
                                                          Subject_combobox2.SelectedItem.ToString());
                            // Call add method
                            teacher.AddPerson(connectionString);

                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Reload data
            load_teacher_Click(null, null);
        }

        // Event handler for changing selected row in DataGridView
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Populate text boxes with selected row data
                ID_textbox.Text = selectedRow.Cells[0].Value.ToString();
                First_name_Text.Text = selectedRow.Cells[1].Value.ToString();
                Last_name_Text.Text = selectedRow.Cells[2].Value.ToString();
                Email_Text.Text = selectedRow.Cells[3].Value.ToString();
                Phone_text.Text = selectedRow.Cells[4].Value.ToString();
                username_text.Text = selectedRow.Cells[5].Value.ToString();
                password_text.Text = selectedRow.Cells[6].Value.ToString();
                salary_textbox.Text = selectedRow.Cells[8].Value.ToString();
                Subject_combobox1.SelectedItem = selectedRow.Cells[9].Value.ToString();
                Subject_combobox2.SelectedItem = selectedRow.Cells[10].Value.ToString();

            }
            else
            {
                // Clear text boxes if no row is selected
                ID_textbox.Text = "";
                First_name_Text.Text = "";
                Last_name_Text.Text = "";
                Email_Text.Text = "";
                Phone_text.Text = "";
                username_text.Text = "";
                password_text.Text = "";
                salary_textbox.Text = "";
                Subject_combobox1.SelectedItem = null;
                Subject_combobox2.SelectedItem = null;
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
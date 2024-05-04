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
    public partial class ManageStudent : Form
    {
        private string username;

        // Database connection string
        static string currentDirectory = Path.Combine(Directory.GetCurrentDirectory(), "..", "..");
        static string fullPath = Path.GetFullPath(currentDirectory);
        static public string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={fullPath}\Person.mdf;Integrated Security=True";

        // Constructor
        public ManageStudent()
        {
            InitializeComponent();
        }

        // Button click event handler to load student data
        private void load_button_Click(object sender, EventArgs e)
        {
            // Database connection string
            
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    // SQL query to fetch student data
                    string query = "select p.*, S.Current_Subject_1, S.Current_Subject_2, S.Previous_Subject_1, S.Previous_Subject_2 " +
                                   "from person p " +
                                   "inner join Student S on p.PersonID = S.PersonID ";
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
                    dataGridView1.Columns[4].HeaderText = "Phone Number";
                    dataGridView1.Columns[5].HeaderText = "Username";
                    dataGridView1.Columns[6].HeaderText = "Password";
                    dataGridView1.Columns[7].HeaderText = "Role";
                    dataGridView1.Columns[8].HeaderText = "Current Subject 1";
                    dataGridView1.Columns[9].HeaderText = "Current Subject 2";
                    dataGridView1.Columns[10].HeaderText = "Previous Subject 1";
                    dataGridView1.Columns[11].HeaderText = "Previous Subject 2";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        // Button click event handler to delete a student record
        private void delete_button_Click(object sender, EventArgs e)
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
                    // Database connection string
                    

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        try
                        {
                            // Create a student object to delete
                            Student studentDeleted = new Student(personID,
                                                        First_name_Text.Text,
                                                        Last_name_Text.Text,
                                                        Email_Text.Text,
                                                        Phone_text.Text,
                                                        username_text.Text,
                                                        password_text.Text,
                                                        Role.Student,
                                                        Subject_combobox1.SelectedItem.ToString(),
                                                        Subject_combobox2.SelectedItem.ToString(),
                                                        selectedRow.Cells[10].ToString(),
                                                        selectedRow.Cells[11].ToString()
                                                        );
                            // Call delete method
                            studentDeleted.DeletePerson(connectionString);
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

        // Button click event handler to update a student record
        private void update_button_Click(object sender, EventArgs e)
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
                        // Check if subject selection is valid
                        if (Subject_combobox1.Text == Subject_combobox2.Text)
                        {
                            MessageBox.Show("Subject cannot be the same", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        // Query to get previous subjects
                        string get_current_subjects_query = "SELECT Current_Subject_1, Current_Subject_2 FROM Student WHERE PersonID = @PersonID";
                        SqlCommand get_current_subjects_command = new SqlCommand(get_current_subjects_query, connection);
                        get_current_subjects_command.Parameters.AddWithValue("@PersonID", personID);
                        SqlDataReader reader = get_current_subjects_command.ExecuteReader();
                        reader.Read();
                        string previousSubject_1 = reader.GetString(0);
                        string previousSubject_2 = reader.GetString(1);
                        reader.Close();
                        // Create student object to update
                        Student studentUpdated = new Student(personID,
                                                    First_name_Text.Text,
                                                    Last_name_Text.Text,
                                                    Email_Text.Text,
                                                    Phone_text.Text,
                                                    username_text.Text,
                                                    password_text.Text,
                                                    Role.Student,
                                                    Subject_combobox1.SelectedItem.ToString(),
                                                    Subject_combobox2.SelectedItem.ToString(),
                                                    previousSubject_1,
                                                    previousSubject_2
                                                    );
                        // Call update method
                        studentUpdated.UpdatePerson(connectionString);
                        MessageBox.Show("Record updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error:{ex.Message}");
                }
                // Reload data
                load_button_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Select a row to update", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Button click event handler to add a new student record
        private void add_button_Click(object sender, EventArgs e)
        {
            // Validate input fields
            if (ID_textbox.Text == "" ||
                First_name_Text.Text == "" ||
                Last_name_Text.Text == "" ||
                Email_Text.Text == "" ||
                Phone_text.Text == "" ||
                username_text.Text == "" ||
                password_text.Text == "")
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
                    // Check if ID starts with "HS"
                    if (!newID.StartsWith("HS"))
                    {
                        MessageBox.Show("ID should start with 'HS'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Check if subject selection is valid
                    if (Subject_combobox1.Text == Subject_combobox2.Text)
                    {
                        MessageBox.Show("Subject cannot be the same", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                            // Create student object to add
                            Student student = new Student(newID,
                                                            First_name_Text.Text,
                                                            Last_name_Text.Text,
                                                            Email_Text.Text,
                                                            Phone_text.Text,
                                                            username_text.Text,
                                                            password_text.Text,
                                                            Role.Student,
                                                            Subject_combobox1.SelectedItem.ToString(),
                                                            Subject_combobox2.SelectedItem.ToString(),
                                                            "", // Previous subjects initially empty
                                                            ""
                                                            );
                            // Call add method
                            student.AddPerson(connectionString);

                            MessageBox.Show(username_text.Text + " is registered as a student", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        connection.Close();
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

        // Event handler for changing selected row in DataGridView
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                ID_textbox.Text = selectedRow.Cells[0].Value.ToString();
                First_name_Text.Text = selectedRow.Cells[1].Value.ToString();
                Last_name_Text.Text = selectedRow.Cells[2].Value.ToString();
                Email_Text.Text = selectedRow.Cells[3].Value.ToString();
                Phone_text.Text = selectedRow.Cells[4].Value.ToString();
                username_text.Text = selectedRow.Cells[5].Value.ToString();
                password_text.Text = selectedRow.Cells[6].Value.ToString();
                Subject_combobox1.SelectedItem = selectedRow.Cells[8].Value.ToString();
                Subject_combobox2.SelectedItem = selectedRow.Cells[9].Value.ToString();
            }
            else
            {
                // Clear fields if no row is selected
                ID_textbox.Text = "";
                First_name_Text.Text = "";
                Last_name_Text.Text = "";
                Email_Text.Text = "";
                Phone_text.Text = "";
                username_text.Text = "";
                Subject_combobox1.SelectedItem = null;
                Subject_combobox2.SelectedItem = null;
            }
        }

        // Button click event handler to exit to admin form
        private void exit_button_Click(object sender, EventArgs e)
        {
            // Show admin form
            Admin1 admin = new Admin1(username);
            admin.Show();
            this.Hide(); // Hide current form
        }
    }
}

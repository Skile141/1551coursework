using System;
using System.Data.SqlClient;

namespace _1551coursework
{
    // Enum to represent different roles
    public enum Role
    {
        Student,
        Teacher,
        Administrator
    }
    // Base class representing a Person
    public class Person
    {
        // Properties
        public string PersonID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        private string _username;
        private string _password;
        public Role role { get; set; }
        // Properties for username and password
        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        // Constructor
        public Person(string personID, string firstName, string lastName, string email, string phoneNumber, string username, string password, Role roleS)
        {
            PersonID = personID;
            FirstName = firstName;
            LastName = lastName;
            _username = username;
            _password = password;
            Email = email;
            PhoneNumber = phoneNumber;
            role = roleS;
        }
        // Method to add a person to the database
        public virtual void AddPerson(string connectionString)
        {
            // SQL query to insert data into the person table
            string insertData = $"INSERT INTO person(PersonID,first_name, last_name, email, telephone, username, [password], [role]) " +
                                "VALUES(@PersonID,@first_name, @last_name, @email, @telephone, @username, @password, @role)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand insertCommand = new SqlCommand(insertData, connection);
                // Set parameters for the SQL query
                insertCommand.Parameters.AddWithValue("@PersonID", PersonID);
                insertCommand.Parameters.AddWithValue("@first_name", FirstName);
                insertCommand.Parameters.AddWithValue("@last_name", LastName);
                insertCommand.Parameters.AddWithValue("@email", Email);
                insertCommand.Parameters.AddWithValue("@telephone", PhoneNumber);
                insertCommand.Parameters.AddWithValue("@username", Username);
                insertCommand.Parameters.AddWithValue("@password", Password);
                insertCommand.Parameters.AddWithValue("@role", role.ToString());
                // Execute the SQL command
                insertCommand.ExecuteNonQuery();
            }
        }
        // Method to update a person's information in the database
        public virtual void UpdatePerson(string connectionString)
        {
            // SQL query to update data in the person table
            string update_query = "UPDATE person SET first_name = @first_name, last_name = @last_name, email = @email,"
                            + "telephone = @telephone, [password] = @password WHERE PersonID = @PersonID";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand update_command = new SqlCommand(update_query, connection);
                // Set parameters for the SQL query
                update_command.Parameters.AddWithValue("@first_name", FirstName);
                update_command.Parameters.AddWithValue("@last_name", LastName);
                update_command.Parameters.AddWithValue("@email", Email);
                update_command.Parameters.AddWithValue("@telephone", PhoneNumber);
                update_command.Parameters.AddWithValue("@password", Password);
                update_command.Parameters.AddWithValue("@PersonID", PersonID);
                // Execute the SQL command
                update_command.ExecuteNonQuery();
            }
        }
        public virtual void DeletePerson(string connectionString)
        {
            // SQL query to delete data from the person table
            string deleteQuery = "DELETE FROM person WHERE PersonID = @PersonID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                {
                    // Set parameters for the SQL query
                    command.Parameters.AddWithValue("@PersonID", PersonID);
                    // Execute the SQL command
                    command.ExecuteNonQuery();
                }
            }
        }
        // Class representing a Student, inheriting from Person
        public class Student : Person
        {
            // Properties specific to Student
            public string CurrentSubject_1 { get; set; }
            public string CurrentSubject_2 { get; set; }
            public string PreviousSubject_1 { get; set; }
            public string PreviousSubject_2 { get; set; }

            // Constructor
            public Student(string personID, string firstName, string lastName, string email, string phoneNumber, string username, string password, Role roleS,
                 string currentSubject_1, string currentSubject_2, string previousSubject_1, string previousSubject_2)
                : base(personID, firstName, lastName, email, phoneNumber, username, password, roleS)
            {
                CurrentSubject_1 = currentSubject_1;
                CurrentSubject_2 = currentSubject_2;
                PreviousSubject_1 = previousSubject_1;
                PreviousSubject_2 = previousSubject_2;
            }

            // Method to add a student to the database
            public override void AddPerson(string connectionString)
            {
                base.AddPerson(connectionString);

                // SQL query to insert data into the Student table
                string insertStudentQuery = "INSERT INTO Student (PersonID, Current_Subject_1, Current_Subject_2, Previous_Subject_1, Previous_Subject_2) " +
                                            "VALUES (@PersonID, @Current_Subject_1, @Current_Subject_2, @Previous_Subject_1, @Previous_Subject_2)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(insertStudentQuery, connection))
                    {
                        // Set parameters for the SQL query
                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        command.Parameters.AddWithValue("@Current_Subject_1", CurrentSubject_1);
                        command.Parameters.AddWithValue("@Current_Subject_2", CurrentSubject_2);
                        command.Parameters.AddWithValue("@Previous_Subject_1", PreviousSubject_1);
                        command.Parameters.AddWithValue("@Previous_Subject_2", PreviousSubject_2);
                        // Execute the SQL command
                        command.ExecuteNonQuery();
                    }
                }
            }
            // Method to update a student's information to the database
            public override void UpdatePerson(string connectionString)
            {
                base.UpdatePerson(connectionString);
                // SQL query to update data in the Student table
                string update_student_query = "UPDATE Student SET Current_Subject_1 = @Current_Subject_1, Current_Subject_2 = @Current_Subject_2," +
                                    "Previous_Subject_1 = @Previous_Subject_1, Previous_Subject_2 = @Previous_Subject_2 WHERE PersonID = @PersonID";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand update_student_command = new SqlCommand(update_student_query, connection);
                    // Set parameters for the SQL query
                    update_student_command.Parameters.AddWithValue("@Current_Subject_1", CurrentSubject_1);
                    update_student_command.Parameters.AddWithValue("@Current_Subject_2", CurrentSubject_2);
                    update_student_command.Parameters.AddWithValue("@Previous_Subject_1", PreviousSubject_1);
                    update_student_command.Parameters.AddWithValue("@Previous_Subject_2", PreviousSubject_2);
                    update_student_command.Parameters.AddWithValue("@PersonID", PersonID);
                    // Execute the SQL command
                    update_student_command.ExecuteNonQuery();
                }
            }
            // Method to delete a student data in the database
            public override void DeletePerson(string connectionString)
            {
                // SQL query to delete data in the Student table
                string deleteStudent = "DELETE FROM Student WHERE PersonID = @PersonID";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(deleteStudent, connection))
                    {
                        // Set parameters for the SQL query
                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        // Execute the SQL command
                        command.ExecuteNonQuery();
                    }
                }
                base.DeletePerson(connectionString);
            }
        }
        // Class representing a Teacher, inheriting from Person
        public class Teacher : Person
        {
            // Properties specific to Teacher
            private decimal _salary;

            public decimal Salary
            {
                get { return _salary; }
                set
                {
                    if (value < 0 || value > 10000)
                        throw new ArgumentException("Invalid Salary value.");
                    _salary = value;
                }
            }
            public string Subject_1 { get; set; }
            public string Subject_2 { get; set; }

            // Constructor
            public Teacher(string personID, string firstName, string lastName, string email, string phoneNumber, string username, string password, Role roleS,
                decimal salary, string subject_1, string subject_2)
                : base(personID, firstName, lastName, email, phoneNumber, username, password, roleS)
            {
                Salary = salary;
                Subject_1 = subject_1;
                Subject_2 = subject_2;
            }

            // Method to add a teacher to the database
            public override void AddPerson(string connectionString)
            {
                base.AddPerson(connectionString);
                // SQL query to insert data into the Teacher table
                string insertTeacherQuery = "INSERT INTO Teacher (PersonID, Salary, Subject_1, Subject_2) " +
                                "VALUES (@PersonID, @Salary, @Subject_1, @Subject_2)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand insertTeacherCommand = new SqlCommand(insertTeacherQuery, connection);
                    // Set parameters for the SQL query
                    insertTeacherCommand.Parameters.AddWithValue("@PersonID", PersonID);
                    insertTeacherCommand.Parameters.AddWithValue("@Salary", Salary);
                    insertTeacherCommand.Parameters.AddWithValue("@Subject_1", Subject_1);
                    insertTeacherCommand.Parameters.AddWithValue("@Subject_2", Subject_2);
                    // Execute the SQL command
                    insertTeacherCommand.ExecuteNonQuery();
                }
            }
            // Method to update a teacher data to the database
            public override void UpdatePerson(string connectionString)
            {
                base.UpdatePerson(connectionString);
                // SQL query to update data in the Teacher table
                string update_teacher_query = "UPDATE Teacher SET Salary = @Salary, Subject_1 = @Subject_1, Subject_2 = @Subject_2 " +
                                              "WHERE PersonID = @PersonID";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand update_teacher_command = new SqlCommand(update_teacher_query, connection);
                    // Set parameters for the SQL query
                    update_teacher_command.Parameters.AddWithValue("@Salary", Salary);
                    update_teacher_command.Parameters.AddWithValue("@Subject_1", Subject_1);
                    update_teacher_command.Parameters.AddWithValue("@Subject_2", Subject_2);
                    update_teacher_command.Parameters.AddWithValue("@PersonID", PersonID);
                    // Execute the SQL command
                    update_teacher_command.ExecuteNonQuery();
                }
            }
            // Method to delete a teacher data in the database
            public override void DeletePerson(string connectionString)
            {
                // SQL query to delete data in the Teacher table
                string deleteTeacher = "DELETE FROM Teacher WHERE PersonID = @PersonID";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(deleteTeacher, connection))
                    {
                        // Set parameters for the SQL query
                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        // Execute the SQL command
                        command.ExecuteNonQuery();
                    }
                }
                base.DeletePerson(connectionString);

            }
        }
        // Class representing an Administrator, inheriting from Person
        public class Administrator : Person
        {
            // Properties specific to Administrator
            private decimal _salary;
            public decimal Salary
            {
                get { return _salary; }
                set
                {
                    if (value < 0 || value > 10000)
                        throw new ArgumentException("Invalid Salary value.");
                    _salary = value;
                }
            }
            public string EmployeeType { get; set; }
            public int WorkingHours { get; set; }

            // Constructor
            public Administrator(string personID, string firstName, string lastName, string email, string phoneNumber, string username, string password,
                Role roleS, decimal salary, string employeetype, int workinghours)
                : base(personID, firstName, lastName, email, phoneNumber, username, password, roleS)
            {
                Salary = salary;
                EmployeeType = employeetype;
                WorkingHours = workinghours;
            }

            // Method to add an administrator to the database
            public override void AddPerson(string connectionString)
            {
                base.AddPerson(connectionString);
                // SQL query to insert data into the Administrator table
                string insertAdminQuery = "INSERT INTO Administrator (PersonID, Salary, Employee_Type, Working_Hours) " +
                                            "VALUES (@PersonID, @Salary, @Employee_Type, @Working_Hours)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand insertAdminCommand = new SqlCommand(insertAdminQuery, connection);
                    // Set parameters for the SQL query
                    insertAdminCommand.Parameters.AddWithValue("@PersonID", PersonID);
                    insertAdminCommand.Parameters.AddWithValue("@Salary", Salary);
                    insertAdminCommand.Parameters.AddWithValue("@Employee_Type", EmployeeType);
                    insertAdminCommand.Parameters.AddWithValue("@Working_Hours", WorkingHours);
                    // Execute the SQL command
                    insertAdminCommand.ExecuteNonQuery();
                }
            }
            // Method to update an administrator data in the Administrator table
            public override void UpdatePerson(string connectionString)
            {
                base.UpdatePerson(connectionString);
                // SQL query to update an administrator data in the Administrator table
                string update_admin_query = "UPDATE Administrator SET Salary = @Salary, Employee_Type = @Employee_Type, Working_Hours = @Working_Hours " +
                                              "WHERE PersonID = @PersonID";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand update_admin_command = new SqlCommand(update_admin_query, connection);
                    // Set parameters for the SQL query
                    update_admin_command.Parameters.AddWithValue("@Salary", Salary);
                    update_admin_command.Parameters.AddWithValue("@Employee_Type", EmployeeType);
                    update_admin_command.Parameters.AddWithValue("@Working_Hours", WorkingHours);
                    update_admin_command.Parameters.AddWithValue("@PersonID", PersonID);
                    // Execute the SQL command
                    update_admin_command.ExecuteNonQuery();
                }
            }
            // Method to delete an administrator data in the database
            public override void DeletePerson(string connectionString)
            {
                // SQL query to delete an administrator data in the Administrator table
                string deleteAdmin = "DELETE FROM Administrator WHERE PersonID = @PersonID";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(deleteAdmin, connection))
                    {
                        // Set parameters for the SQL query
                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        // Execute the SQL command
                        command.ExecuteNonQuery();
                    }
                }
                base.DeletePerson(connectionString);
            }
        }
    }
}

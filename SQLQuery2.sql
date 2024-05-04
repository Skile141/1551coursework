CREATE TABLE person
(
	PersonID VARCHAR(50) NOT NULL PRIMARY KEY, 
    first_name NVARCHAR(MAX) NOT NULL, 
    last_name NVARCHAR(MAX) NOT NULL, 
    email NVARCHAR(MAX) NOT NULL, 
    telephone NVARCHAR(MAX) NOT NULL, 
    username NVARCHAR(MAX) NOT NULL, 
    [password] NVARCHAR(MAX) NOT NULL, 
    [role] NVARCHAR(MAX) NOT NULL
    
);

-- Create Student Table
CREATE TABLE Student (
    StudentID INT PRIMARY KEY IDENTITY(1,1),
    PersonID VARCHAR(50),
    Current_Subject_1 VARCHAR(50),
    Current_Subject_2 VARCHAR(50),
    Previous_Subject_1 VARCHAR(50),
    Previous_Subject_2 VARCHAR(50),
    FOREIGN KEY (PersonID) REFERENCES Person(PersonID)
);

-- Create Administrator Table
CREATE TABLE Administrator (
    AdminID INT PRIMARY KEY IDENTITY(1,1),
    PersonID VARCHAR(50),
    Salary DECIMAL(10,2),
    Employee_Type VARCHAR(20),
    Working_Hours INT,
    FOREIGN KEY (PersonID) REFERENCES Person(PersonID)
);

-- Create Teacher Table
CREATE TABLE Teacher (
    TeacherID INT PRIMARY KEY IDENTITY(1,1),
    PersonID VARCHAR(50),
    Salary DECIMAL(10,2),
    Subject_1 VARCHAR(50),
    Subject_2 VARCHAR(50)
    FOREIGN KEY (PersonID) REFERENCES Person(PersonID)
);

-- Create person Table


drop table person
drop table Teacher
drop table Administrator
drop table Student

INSERT INTO person (first_name, last_name, email, telephone, username, [password], [role])
VALUES 
('John', 'Doe', 'john.doe@example.com', '123456789', 'johndoe', 'password123', 'Student'),
('Alice', 'Smith', 'alice.smith@example.com', '987654321', 'alicesmith', 'password456', 'Student')
('Michael', 'Johnson', 'michael.johnson@example.com', '555123456', 'michaelj', 'pass789', 'Student'),
('Emily', 'Brown', 'emily.brown@example.com', '333987654', 'emilyb', 'pword', 'Student'),
('Daniel', 'Lee', 'daniel.lee@example.com', '111222333', 'danlee', 'letmein', 'Student');
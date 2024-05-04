namespace _1551coursework
{
    partial class Admin1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.admin_logout = new System.Windows.Forms.Button();
            this.Admin_info = new System.Windows.Forms.Button();
            this.manage_student = new System.Windows.Forms.Button();
            this.Manage_teacher = new System.Windows.Forms.Button();
            this.Manage_admin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(278, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 41);
            this.label1.TabIndex = 5;
            this.label1.Text = "Welcome, Admin";
            // 
            // admin_logout
            // 
            this.admin_logout.BackColor = System.Drawing.Color.Red;
            this.admin_logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.admin_logout.FlatAppearance.BorderSize = 0;
            this.admin_logout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.admin_logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.admin_logout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_logout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.admin_logout.Location = new System.Drawing.Point(330, 385);
            this.admin_logout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.admin_logout.Name = "admin_logout";
            this.admin_logout.Size = new System.Drawing.Size(123, 45);
            this.admin_logout.TabIndex = 4;
            this.admin_logout.Text = "Logout";
            this.admin_logout.UseVisualStyleBackColor = false;
            this.admin_logout.Click += new System.EventHandler(this.admin_logout_Click);
            // 
            // Admin_info
            // 
            this.Admin_info.BackColor = System.Drawing.Color.White;
            this.Admin_info.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.Admin_info.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.Admin_info.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin_info.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Admin_info.Location = new System.Drawing.Point(442, 244);
            this.Admin_info.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Admin_info.Name = "Admin_info";
            this.Admin_info.Size = new System.Drawing.Size(233, 99);
            this.Admin_info.TabIndex = 8;
            this.Admin_info.Text = "Admin\'s information";
            this.Admin_info.UseVisualStyleBackColor = false;
            this.Admin_info.Click += new System.EventHandler(this.Admin_info_Click);
            // 
            // manage_student
            // 
            this.manage_student.BackColor = System.Drawing.Color.White;
            this.manage_student.FlatAppearance.BorderSize = 10;
            this.manage_student.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.manage_student.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.manage_student.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manage_student.ForeColor = System.Drawing.Color.Black;
            this.manage_student.Location = new System.Drawing.Point(108, 103);
            this.manage_student.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.manage_student.Name = "manage_student";
            this.manage_student.Size = new System.Drawing.Size(233, 99);
            this.manage_student.TabIndex = 6;
            this.manage_student.Text = "Manage Students";
            this.manage_student.UseVisualStyleBackColor = false;
            this.manage_student.Click += new System.EventHandler(this.Manage_student_Click);
            // 
            // Manage_teacher
            // 
            this.Manage_teacher.BackColor = System.Drawing.Color.White;
            this.Manage_teacher.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.Manage_teacher.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.Manage_teacher.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Manage_teacher.ForeColor = System.Drawing.Color.Black;
            this.Manage_teacher.Location = new System.Drawing.Point(108, 244);
            this.Manage_teacher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Manage_teacher.Name = "Manage_teacher";
            this.Manage_teacher.Size = new System.Drawing.Size(233, 99);
            this.Manage_teacher.TabIndex = 7;
            this.Manage_teacher.Text = "Manage Teachers";
            this.Manage_teacher.UseVisualStyleBackColor = false;
            this.Manage_teacher.Click += new System.EventHandler(this.Manage_teacher_Click);
            // 
            // Manage_admin
            // 
            this.Manage_admin.BackColor = System.Drawing.Color.White;
            this.Manage_admin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.Manage_admin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.Manage_admin.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Manage_admin.ForeColor = System.Drawing.Color.Black;
            this.Manage_admin.Location = new System.Drawing.Point(442, 103);
            this.Manage_admin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Manage_admin.Name = "Manage_admin";
            this.Manage_admin.Size = new System.Drawing.Size(233, 99);
            this.Manage_admin.TabIndex = 9;
            this.Manage_admin.Text = "Manage Administrator";
            this.Manage_admin.UseVisualStyleBackColor = false;
            this.Manage_admin.Click += new System.EventHandler(this.Manage_admin_Click);
            // 
            // Admin1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(786, 441);
            this.Controls.Add(this.Manage_admin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.admin_logout);
            this.Controls.Add(this.Admin_info);
            this.Controls.Add(this.manage_student);
            this.Controls.Add(this.Manage_teacher);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button admin_logout;
        private System.Windows.Forms.Button Admin_info;
        private System.Windows.Forms.Button manage_student;
        private System.Windows.Forms.Button Manage_teacher;
        private System.Windows.Forms.Button Manage_admin;
    }
}
namespace _1551coursework
{
    partial class ManageAdmin
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.studentTableAdapter1 = new _1551coursework.PersonDataSet1TableAdapters.StudentTableAdapter();
            this.personDataSet3 = new _1551coursework.PersonDataSet3();
            this.personBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.personTableAdapter = new _1551coursework.PersonDataSet3TableAdapters.personTableAdapter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.exit_button = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.studentTableAdapter = new _1551coursework.PersonDataSetTableAdapters.StudentTableAdapter();
            this.password_admin = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.username_admin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.admin_combobox1 = new System.Windows.Forms.ComboBox();
            this.label0 = new System.Windows.Forms.Label();
            this.add_admin_button = new System.Windows.Forms.Button();
            this.load_button = new System.Windows.Forms.Button();
            this.delete_admin_button = new System.Windows.Forms.Button();
            this.update_admin_button = new System.Windows.Forms.Button();
            this.Phone_admin = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Email_admin = new System.Windows.Forms.TextBox();
            this.Last_name_admin = new System.Windows.Forms.TextBox();
            this.First_name_admin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.admin_hours = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.admin_salary = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AdminFN = new System.Windows.Forms.Label();
            this.personDataSet = new _1551coursework.PersonDataSet();
            this.studentBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.personDataSet1 = new _1551coursework.PersonDataSet1();
            this.studentBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.studentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.personDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ID_admin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.personDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource2)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // studentTableAdapter1
            // 
            this.studentTableAdapter1.ClearBeforeFill = true;
            // 
            // personDataSet3
            // 
            this.personDataSet3.DataSetName = "PersonDataSet3";
            this.personDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personBindingSource2
            // 
            this.personBindingSource2.DataMember = "person";
            this.personBindingSource2.DataSource = this.personDataSet3;
            // 
            // personTableAdapter
            // 
            this.personTableAdapter.ClearBeforeFill = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.exit_button);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(-2, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1508, 39);
            this.panel3.TabIndex = 9;
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.Color.White;
            this.exit_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.exit_button.FlatAppearance.BorderSize = 0;
            this.exit_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.exit_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_button.Location = new System.Drawing.Point(1444, 3);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(34, 30);
            this.exit_button.TabIndex = 1;
            this.exit_button.Text = "X";
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(184, 22);
            this.label10.TabIndex = 0;
            this.label10.Text = "Manage Administrator";
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // password_admin
            // 
            this.password_admin.Location = new System.Drawing.Point(167, 253);
            this.password_admin.Name = "password_admin";
            this.password_admin.Size = new System.Drawing.Size(215, 22);
            this.password_admin.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label8.Location = new System.Drawing.Point(39, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 28);
            this.label8.TabIndex = 26;
            this.label8.Text = "Password:";
            // 
            // username_admin
            // 
            this.username_admin.Location = new System.Drawing.Point(167, 215);
            this.username_admin.Name = "username_admin";
            this.username_admin.Size = new System.Drawing.Size(215, 22);
            this.username_admin.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(39, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Working type:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label9.Location = new System.Drawing.Point(39, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 28);
            this.label9.TabIndex = 24;
            this.label9.Text = "Username:";
            // 
            // admin_combobox1
            // 
            this.admin_combobox1.FormattingEnabled = true;
            this.admin_combobox1.Items.AddRange(new object[] {
            "Part-time",
            "Full-time"});
            this.admin_combobox1.Location = new System.Drawing.Point(180, 331);
            this.admin_combobox1.Name = "admin_combobox1";
            this.admin_combobox1.Size = new System.Drawing.Size(215, 24);
            this.admin_combobox1.TabIndex = 18;
            // 
            // label0
            // 
            this.label0.Location = new System.Drawing.Point(0, 0);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(100, 23);
            this.label0.TabIndex = 0;
            // 
            // add_admin_button
            // 
            this.add_admin_button.Location = new System.Drawing.Point(543, 26);
            this.add_admin_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_admin_button.Name = "add_admin_button";
            this.add_admin_button.Size = new System.Drawing.Size(94, 32);
            this.add_admin_button.TabIndex = 21;
            this.add_admin_button.Text = "Add";
            this.add_admin_button.UseVisualStyleBackColor = true;
            this.add_admin_button.Click += new System.EventHandler(this.add_admin_button_Click);
            // 
            // load_button
            // 
            this.load_button.Location = new System.Drawing.Point(543, 184);
            this.load_button.Name = "load_button";
            this.load_button.Size = new System.Drawing.Size(94, 32);
            this.load_button.TabIndex = 17;
            this.load_button.Text = "Load";
            this.load_button.UseVisualStyleBackColor = true;
            this.load_button.Click += new System.EventHandler(this.load_button_Click);
            // 
            // delete_admin_button
            // 
            this.delete_admin_button.Location = new System.Drawing.Point(543, 132);
            this.delete_admin_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delete_admin_button.Name = "delete_admin_button";
            this.delete_admin_button.Size = new System.Drawing.Size(94, 32);
            this.delete_admin_button.TabIndex = 7;
            this.delete_admin_button.Text = "Delete";
            this.delete_admin_button.UseVisualStyleBackColor = true;
            this.delete_admin_button.Click += new System.EventHandler(this.delete_admin_button_Click);
            // 
            // update_admin_button
            // 
            this.update_admin_button.Location = new System.Drawing.Point(543, 77);
            this.update_admin_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.update_admin_button.Name = "update_admin_button";
            this.update_admin_button.Size = new System.Drawing.Size(94, 32);
            this.update_admin_button.TabIndex = 5;
            this.update_admin_button.Text = "Update";
            this.update_admin_button.UseVisualStyleBackColor = true;
            this.update_admin_button.Click += new System.EventHandler(this.update_admin_button_Click);
            // 
            // Phone_admin
            // 
            this.Phone_admin.Location = new System.Drawing.Point(167, 175);
            this.Phone_admin.Name = "Phone_admin";
            this.Phone_admin.Size = new System.Drawing.Size(215, 22);
            this.Phone_admin.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label7.Location = new System.Drawing.Point(39, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 28);
            this.label7.TabIndex = 14;
            this.label7.Text = "Phone:";
            // 
            // Email_admin
            // 
            this.Email_admin.Location = new System.Drawing.Point(167, 137);
            this.Email_admin.Name = "Email_admin";
            this.Email_admin.Size = new System.Drawing.Size(215, 22);
            this.Email_admin.TabIndex = 11;
            // 
            // Last_name_admin
            // 
            this.Last_name_admin.Location = new System.Drawing.Point(167, 100);
            this.Last_name_admin.Name = "Last_name_admin";
            this.Last_name_admin.Size = new System.Drawing.Size(215, 22);
            this.Last_name_admin.TabIndex = 10;
            // 
            // First_name_admin
            // 
            this.First_name_admin.Location = new System.Drawing.Point(167, 65);
            this.First_name_admin.Name = "First_name_admin";
            this.First_name_admin.Size = new System.Drawing.Size(215, 22);
            this.First_name_admin.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label6.Location = new System.Drawing.Point(39, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 28);
            this.label6.TabIndex = 6;
            this.label6.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(39, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.ID_admin);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.admin_hours);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.admin_salary);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.password_admin);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.username_admin);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.admin_combobox1);
            this.panel2.Controls.Add(this.add_admin_button);
            this.panel2.Controls.Add(this.load_button);
            this.panel2.Controls.Add(this.delete_admin_button);
            this.panel2.Controls.Add(this.update_admin_button);
            this.panel2.Controls.Add(this.Phone_admin);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.Email_admin);
            this.panel2.Controls.Add(this.Last_name_admin);
            this.panel2.Controls.Add(this.First_name_admin);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.AdminFN);
            this.panel2.Location = new System.Drawing.Point(13, 63);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(669, 421);
            this.panel2.TabIndex = 8;
            // 
            // admin_hours
            // 
            this.admin_hours.Location = new System.Drawing.Point(180, 368);
            this.admin_hours.Name = "admin_hours";
            this.admin_hours.Size = new System.Drawing.Size(215, 22);
            this.admin_hours.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label11.Location = new System.Drawing.Point(39, 362);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(145, 28);
            this.label11.TabIndex = 30;
            this.label11.Text = "Working hours:";
            // 
            // admin_salary
            // 
            this.admin_salary.Location = new System.Drawing.Point(167, 291);
            this.admin_salary.Name = "admin_salary";
            this.admin_salary.Size = new System.Drawing.Size(215, 22);
            this.admin_salary.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.Location = new System.Drawing.Point(39, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 28);
            this.label5.TabIndex = 28;
            this.label5.Text = "Salary:";
            // 
            // AdminFN
            // 
            this.AdminFN.AutoSize = true;
            this.AdminFN.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.AdminFN.Location = new System.Drawing.Point(39, 57);
            this.AdminFN.Name = "AdminFN";
            this.AdminFN.Size = new System.Drawing.Size(110, 28);
            this.AdminFN.TabIndex = 1;
            this.AdminFN.Text = "First Name:";
            // 
            // personDataSet
            // 
            this.personDataSet.DataSetName = "PersonDataSet";
            this.personDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentBindingSource3
            // 
            this.studentBindingSource3.DataMember = "Student";
            this.studentBindingSource3.DataSource = this.personDataSet;
            // 
            // personDataSet1
            // 
            this.personDataSet1.DataSetName = "PersonDataSet1";
            this.personDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentBindingSource4
            // 
            this.studentBindingSource4.DataMember = "Student";
            this.studentBindingSource4.DataSource = this.personDataSet1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(713, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(763, 421);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // studentBindingSource1
            // 
            this.studentBindingSource1.DataMember = "Student";
            // 
            // personBindingSource1
            // 
            this.personBindingSource1.DataMember = "person";
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataMember = "person";
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            // 
            // studentBindingSource2
            // 
            this.studentBindingSource2.DataMember = "Student";
            // 
            // ID_admin
            // 
            this.ID_admin.Location = new System.Drawing.Point(167, 32);
            this.ID_admin.Name = "ID_admin";
            this.ID_admin.Size = new System.Drawing.Size(215, 22);
            this.ID_admin.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(39, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 28);
            this.label1.TabIndex = 32;
            this.label1.Text = "ID:";
            // 
            // ManageAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1490, 511);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.personDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private PersonDataSet1TableAdapters.StudentTableAdapter studentTableAdapter1;
        private PersonDataSet3 personDataSet3;
        private System.Windows.Forms.BindingSource personBindingSource2;
        private PersonDataSet3TableAdapters.personTableAdapter personTableAdapter;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Label label10;
        private PersonDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.TextBox password_admin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox username_admin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox admin_combobox1;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.Button add_admin_button;
        private System.Windows.Forms.Button load_button;
        private System.Windows.Forms.Button delete_admin_button;
        private System.Windows.Forms.Button update_admin_button;
        private System.Windows.Forms.BindingSource studentBindingSource1;
        private System.Windows.Forms.BindingSource personDataSetBindingSource;
        private System.Windows.Forms.BindingSource personBindingSource1;
        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.TextBox Phone_admin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Email_admin;
        private System.Windows.Forms.TextBox Last_name_admin;
        private System.Windows.Forms.TextBox First_name_admin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource studentBindingSource2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label AdminFN;
        private PersonDataSet personDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource3;
        private PersonDataSet1 personDataSet1;
        private System.Windows.Forms.BindingSource studentBindingSource4;
        private System.Windows.Forms.TextBox admin_salary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox admin_hours;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox ID_admin;
        private System.Windows.Forms.Label label1;
    }
}
namespace _1551coursework
{
    partial class ManageStudent
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.personDataSet1 = new _1551coursework.PersonDataSet1();
            this.studentBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.personDataSet = new _1551coursework.PersonDataSet();
            this.delete_button = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.password_text = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.username_text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Subject_combobox1 = new System.Windows.Forms.ComboBox();
            this.ID_textbox = new System.Windows.Forms.TextBox();
            this.Subject_combobox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.add_button = new System.Windows.Forms.Button();
            this.load_button = new System.Windows.Forms.Button();
            this.Phone_text = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Email_Text = new System.Windows.Forms.TextBox();
            this.Last_name_Text = new System.Windows.Forms.TextBox();
            this.First_name_Text = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.studentTableAdapter = new _1551coursework.PersonDataSetTableAdapters.StudentTableAdapter();
            this.studentTableAdapter1 = new _1551coursework.PersonDataSet1TableAdapters.StudentTableAdapter();
            this.personDataSet3 = new _1551coursework.PersonDataSet3();
            this.personBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.personTableAdapter = new _1551coursework.PersonDataSet3TableAdapters.personTableAdapter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.exit_button = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.studentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.personDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(12, 39);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1463, 396);
            this.panel1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1463, 396);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // studentBindingSource4
            // 
            this.studentBindingSource4.DataMember = "Student";
            this.studentBindingSource4.DataSource = this.personDataSet1;
            // 
            // personDataSet1
            // 
            this.personDataSet1.DataSetName = "PersonDataSet1";
            this.personDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentBindingSource3
            // 
            this.studentBindingSource3.DataMember = "Student";
            this.studentBindingSource3.DataSource = this.personDataSet;
            // 
            // personDataSet
            // 
            this.personDataSet.DataSetName = "PersonDataSet";
            this.personDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(862, 195);
            this.delete_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(94, 32);
            this.delete_button.TabIndex = 7;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(709, 195);
            this.update_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(94, 32);
            this.update_button.TabIndex = 5;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.password_text);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.username_text);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.Subject_combobox1);
            this.panel2.Controls.Add(this.ID_textbox);
            this.panel2.Controls.Add(this.Subject_combobox2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.add_button);
            this.panel2.Controls.Add(this.load_button);
            this.panel2.Controls.Add(this.delete_button);
            this.panel2.Controls.Add(this.update_button);
            this.panel2.Controls.Add(this.Phone_text);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.Email_Text);
            this.panel2.Controls.Add(this.Last_name_Text);
            this.panel2.Controls.Add(this.First_name_Text);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 452);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1463, 235);
            this.panel2.TabIndex = 5;
            // 
            // password_text
            // 
            this.password_text.Location = new System.Drawing.Point(630, 71);
            this.password_text.Name = "password_text";
            this.password_text.Size = new System.Drawing.Size(215, 22);
            this.password_text.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label8.Location = new System.Drawing.Point(502, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 28);
            this.label8.TabIndex = 26;
            this.label8.Text = "Password:";
            // 
            // username_text
            // 
            this.username_text.Location = new System.Drawing.Point(630, 33);
            this.username_text.Name = "username_text";
            this.username_text.Size = new System.Drawing.Size(215, 22);
            this.username_text.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(921, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Subject 1:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.Location = new System.Drawing.Point(921, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Subject 2:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label9.Location = new System.Drawing.Point(502, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 28);
            this.label9.TabIndex = 24;
            this.label9.Text = "Username:";
            // 
            // Subject_combobox1
            // 
            this.Subject_combobox1.FormattingEnabled = true;
            this.Subject_combobox1.Items.AddRange(new object[] {
            "None",
            "Math",
            "Literature",
            "History",
            "Physics",
            "Geography",
            "Chemistry"});
            this.Subject_combobox1.Location = new System.Drawing.Point(1024, 35);
            this.Subject_combobox1.Name = "Subject_combobox1";
            this.Subject_combobox1.Size = new System.Drawing.Size(302, 24);
            this.Subject_combobox1.TabIndex = 18;
            // 
            // ID_textbox
            // 
            this.ID_textbox.Location = new System.Drawing.Point(167, 26);
            this.ID_textbox.Name = "ID_textbox";
            this.ID_textbox.Size = new System.Drawing.Size(215, 22);
            this.ID_textbox.TabIndex = 23;
            // 
            // Subject_combobox2
            // 
            this.Subject_combobox2.FormattingEnabled = true;
            this.Subject_combobox2.Items.AddRange(new object[] {
            "None",
            "Math",
            "Literature",
            "History",
            "Physics",
            "Geography",
            "Chemistry"});
            this.Subject_combobox2.Location = new System.Drawing.Point(1024, 78);
            this.Subject_combobox2.Name = "Subject_combobox2";
            this.Subject_combobox2.Size = new System.Drawing.Size(302, 24);
            this.Subject_combobox2.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(39, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 28);
            this.label1.TabIndex = 22;
            this.label1.Text = "ID:";
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(564, 195);
            this.add_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(94, 32);
            this.add_button.TabIndex = 21;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // load_button
            // 
            this.load_button.Location = new System.Drawing.Point(981, 195);
            this.load_button.Name = "load_button";
            this.load_button.Size = new System.Drawing.Size(75, 32);
            this.load_button.TabIndex = 17;
            this.load_button.Text = "Load";
            this.load_button.UseVisualStyleBackColor = true;
            this.load_button.Click += new System.EventHandler(this.load_button_Click);
            // 
            // Phone_text
            // 
            this.Phone_text.Location = new System.Drawing.Point(167, 175);
            this.Phone_text.Name = "Phone_text";
            this.Phone_text.Size = new System.Drawing.Size(215, 22);
            this.Phone_text.TabIndex = 15;
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
            // Email_Text
            // 
            this.Email_Text.Location = new System.Drawing.Point(167, 137);
            this.Email_Text.Name = "Email_Text";
            this.Email_Text.Size = new System.Drawing.Size(215, 22);
            this.Email_Text.TabIndex = 11;
            // 
            // Last_name_Text
            // 
            this.Last_name_Text.Location = new System.Drawing.Point(167, 100);
            this.Last_name_Text.Name = "Last_name_Text";
            this.Last_name_Text.Size = new System.Drawing.Size(215, 22);
            this.Last_name_Text.TabIndex = 10;
            // 
            // First_name_Text
            // 
            this.First_name_Text.Location = new System.Drawing.Point(167, 65);
            this.First_name_Text.Name = "First_name_Text";
            this.First_name_Text.Size = new System.Drawing.Size(215, 22);
            this.First_name_Text.TabIndex = 9;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(39, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
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
            this.panel3.Location = new System.Drawing.Point(-3, -2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1508, 36);
            this.panel3.TabIndex = 6;
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
            this.label10.Location = new System.Drawing.Point(15, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 22);
            this.label10.TabIndex = 0;
            this.label10.Text = "Manage Student";
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
            // studentBindingSource2
            // 
            this.studentBindingSource2.DataMember = "Student";
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            // 
            // ManageStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 721);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageStudent";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource personDataSetBindingSource;
        private System.Windows.Forms.BindingSource personBindingSource1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.BindingSource studentBindingSource2;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.BindingSource studentBindingSource1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Phone_text;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Email_Text;
        private System.Windows.Forms.TextBox Last_name_Text;
        private System.Windows.Forms.TextBox First_name_Text;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PersonDataSet personDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource3;
        private PersonDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.Button load_button;
        private System.Windows.Forms.ComboBox Subject_combobox2;
        private System.Windows.Forms.ComboBox Subject_combobox1;
        private PersonDataSet1 personDataSet1;
        private System.Windows.Forms.BindingSource studentBindingSource4;
        private PersonDataSet1TableAdapters.StudentTableAdapter studentTableAdapter1;
        private PersonDataSet3 personDataSet3;
        private System.Windows.Forms.BindingSource personBindingSource2;
        private PersonDataSet3TableAdapters.personTableAdapter personTableAdapter;
        private System.Windows.Forms.TextBox password_text;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox username_text;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ID_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Label label10;
    }
}
﻿namespace SchoolOfFineArts
{
    partial class Form1 : Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.btnAddTeacher = new System.Windows.Forms.Button();
            this.dtStudentDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.numId = new System.Windows.Forms.NumericUpDown();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.lblAge = new System.Windows.Forms.Label();
            this.numTeacherAge = new System.Windows.Forms.NumericUpDown();
            this.btnLoadTeachers = new System.Windows.Forms.Button();
            this.rdoTeacher = new System.Windows.Forms.RadioButton();
            this.rdoStudent = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLoadStudents = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnResetCourseForm = new System.Windows.Forms.Button();
            this.txtCourseId = new System.Windows.Forms.Label();
            this.dgvCourses = new System.Windows.Forms.DataGridView();
            this.cboxNumOfCredits = new System.Windows.Forms.ComboBox();
            this.cboxInstructors = new System.Windows.Forms.ComboBox();
            this.txtAbbreviation = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRemoveCourse = new System.Windows.Forms.Button();
            this.btnLoadCourse = new System.Windows.Forms.Button();
            this.btnAddUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTeacherAge)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(6, 109);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(78, 15);
            this.lblDateOfBirth.TabIndex = 6;
            this.lblDateOfBirth.Text = "Date Of Birth:";
            this.lblDateOfBirth.Visible = false;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(82, 49);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 23);
            this.txtFirstName.TabIndex = 8;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(82, 78);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 23);
            this.txtLastName.TabIndex = 9;
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.Location = new System.Drawing.Point(31, 154);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size = new System.Drawing.Size(101, 23);
            this.btnAddTeacher.TabIndex = 14;
            this.btnAddTeacher.Text = "Add/Update";
            this.btnAddTeacher.UseVisualStyleBackColor = true;
            this.btnAddTeacher.Click += new System.EventHandler(this.btnAddTeacher_Click);
            // 
            // dtStudentDateOfBirth
            // 
            this.dtStudentDateOfBirth.Location = new System.Drawing.Point(105, 107);
            this.dtStudentDateOfBirth.Name = "dtStudentDateOfBirth";
            this.dtStudentDateOfBirth.Size = new System.Drawing.Size(200, 23);
            this.dtStudentDateOfBirth.TabIndex = 16;
            this.dtStudentDateOfBirth.Visible = false;
            // 
            // numId
            // 
            this.numId.Enabled = false;
            this.numId.Location = new System.Drawing.Point(62, 19);
            this.numId.Maximum = new decimal(new int[] {
            2147000000,
            0,
            0,
            0});
            this.numId.Name = "numId";
            this.numId.ReadOnly = true;
            this.numId.Size = new System.Drawing.Size(120, 23);
            this.numId.TabIndex = 17;
            this.numId.ValueChanged += new System.EventHandler(this.numId_ValueChanged);
            // 
            // dgvResults
            // 
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Location = new System.Drawing.Point(21, 273);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.RowTemplate.Height = 25;
            this.dgvResults.Size = new System.Drawing.Size(453, 147);
            this.dgvResults.TabIndex = 18;
            this.dgvResults.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResults_CellContentClick);
            this.dgvResults.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResults_CellContentClick);
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(21, 109);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(31, 15);
            this.lblAge.TabIndex = 19;
            this.lblAge.Text = "Age:";
            // 
            // numTeacherAge
            // 
            this.numTeacherAge.Location = new System.Drawing.Point(62, 107);
            this.numTeacherAge.Maximum = new decimal(new int[] {
            2147000000,
            0,
            0,
            0});
            this.numTeacherAge.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTeacherAge.Name = "numTeacherAge";
            this.numTeacherAge.Size = new System.Drawing.Size(120, 23);
            this.numTeacherAge.TabIndex = 20;
            this.numTeacherAge.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnLoadTeachers
            // 
            this.btnLoadTeachers.Location = new System.Drawing.Point(138, 154);
            this.btnLoadTeachers.Name = "btnLoadTeachers";
            this.btnLoadTeachers.Size = new System.Drawing.Size(100, 23);
            this.btnLoadTeachers.TabIndex = 21;
            this.btnLoadTeachers.Text = "LoadTeachers";
            this.btnLoadTeachers.UseVisualStyleBackColor = true;
            this.btnLoadTeachers.Click += new System.EventHandler(this.btnLoadTeachers_Click);
            // 
            // rdoTeacher
            // 
            this.rdoTeacher.AutoSize = true;
            this.rdoTeacher.Checked = true;
            this.rdoTeacher.Location = new System.Drawing.Point(24, 9);
            this.rdoTeacher.Name = "rdoTeacher";
            this.rdoTeacher.Size = new System.Drawing.Size(65, 19);
            this.rdoTeacher.TabIndex = 22;
            this.rdoTeacher.TabStop = true;
            this.rdoTeacher.Text = "Teacher";
            this.rdoTeacher.UseVisualStyleBackColor = true;
            this.rdoTeacher.CheckedChanged += new System.EventHandler(this.rdoTeacher_CheckedChanged);
            // 
            // rdoStudent
            // 
            this.rdoStudent.AutoSize = true;
            this.rdoStudent.Location = new System.Drawing.Point(23, 31);
            this.rdoStudent.Name = "rdoStudent";
            this.rdoStudent.Size = new System.Drawing.Size(66, 19);
            this.rdoStudent.TabIndex = 23;
            this.rdoStudent.Text = "Student";
            this.rdoStudent.UseVisualStyleBackColor = true;
            this.rdoStudent.CheckedChanged += new System.EventHandler(this.rdoStudent_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdoTeacher);
            this.panel1.Controls.Add(this.rdoStudent);
            this.panel1.Location = new System.Drawing.Point(326, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 78);
            this.panel1.TabIndex = 24;
            // 
            // btnLoadStudents
            // 
            this.btnLoadStudents.Location = new System.Drawing.Point(138, 183);
            this.btnLoadStudents.Name = "btnLoadStudents";
            this.btnLoadStudents.Size = new System.Drawing.Size(100, 23);
            this.btnLoadStudents.TabIndex = 25;
            this.btnLoadStudents.Text = "LoadStudents";
            this.btnLoadStudents.UseVisualStyleBackColor = true;
            this.btnLoadStudents.Click += new System.EventHandler(this.btnLoadStudents_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(28, 183);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(101, 23);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnResetForm
            // 
            this.btnResetForm.Location = new System.Drawing.Point(54, 212);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(75, 23);
            this.btnResetForm.TabIndex = 27;
            this.btnResetForm.Text = "Reset Form";
            this.btnResetForm.UseVisualStyleBackColor = true;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(138, 212);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(78, 23);
            this.btnSearch.TabIndex = 28;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(832, 615);
            this.tabControl1.TabIndex = 29;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.btnResetForm);
            this.tabPage1.Controls.Add(this.btnSearch);
            this.tabPage1.Controls.Add(this.dgvResults);
            this.tabPage1.Controls.Add(this.numId);
            this.tabPage1.Controls.Add(this.btnLoadStudents);
            this.tabPage1.Controls.Add(this.btnDelete);
            this.tabPage1.Controls.Add(this.btnLoadTeachers);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtFirstName);
            this.tabPage1.Controls.Add(this.txtLastName);
            this.tabPage1.Controls.Add(this.btnAddTeacher);
            this.tabPage1.Controls.Add(this.dtStudentDateOfBirth);
            this.tabPage1.Controls.Add(this.lblAge);
            this.tabPage1.Controls.Add(this.numTeacherAge);
            this.tabPage1.Controls.Add(this.lblDateOfBirth);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(824, 587);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Teachers/Students";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnResetCourseForm);
            this.tabPage2.Controls.Add(this.txtCourseId);
            this.tabPage2.Controls.Add(this.dgvCourses);
            this.tabPage2.Controls.Add(this.cboxNumOfCredits);
            this.tabPage2.Controls.Add(this.cboxInstructors);
            this.tabPage2.Controls.Add(this.txtAbbreviation);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txtDepartment);
            this.tabPage2.Controls.Add(this.txtCourseName);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.btnRemoveCourse);
            this.tabPage2.Controls.Add(this.btnLoadCourse);
            this.tabPage2.Controls.Add(this.btnAddUpdate);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(824, 587);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Courses";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnResetCourseForm
            // 
            this.btnResetCourseForm.Location = new System.Drawing.Point(23, 397);
            this.btnResetCourseForm.Name = "btnResetCourseForm";
            this.btnResetCourseForm.Size = new System.Drawing.Size(130, 36);
            this.btnResetCourseForm.TabIndex = 17;
            this.btnResetCourseForm.Text = "Reset Form";
            this.btnResetCourseForm.UseVisualStyleBackColor = true;
            // 
            // txtCourseId
            // 
            this.txtCourseId.AutoSize = true;
            this.txtCourseId.Location = new System.Drawing.Point(135, 34);
            this.txtCourseId.Name = "txtCourseId";
            this.txtCourseId.Size = new System.Drawing.Size(107, 15);
            this.txtCourseId.TabIndex = 16;
            this.txtCourseId.Text = "CourseIdToBeFilled";
            // 
            // dgvCourses
            // 
            this.dgvCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourses.Location = new System.Drawing.Point(361, 34);
            this.dgvCourses.Name = "dgvCourses";
            this.dgvCourses.RowTemplate.Height = 25;
            this.dgvCourses.Size = new System.Drawing.Size(457, 344);
            this.dgvCourses.TabIndex = 15;
            // 
            // cboxNumOfCredits
            // 
            this.cboxNumOfCredits.FormattingEnabled = true;
            this.cboxNumOfCredits.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cboxNumOfCredits.Location = new System.Drawing.Point(135, 162);
            this.cboxNumOfCredits.Name = "cboxNumOfCredits";
            this.cboxNumOfCredits.Size = new System.Drawing.Size(121, 23);
            this.cboxNumOfCredits.TabIndex = 14;
            // 
            // cboxInstructors
            // 
            this.cboxInstructors.FormattingEnabled = true;
            this.cboxInstructors.Location = new System.Drawing.Point(135, 191);
            this.cboxInstructors.Name = "cboxInstructors";
            this.cboxInstructors.Size = new System.Drawing.Size(121, 23);
            this.cboxInstructors.TabIndex = 13;
            // 
            // txtAbbreviation
            // 
            this.txtAbbreviation.Location = new System.Drawing.Point(137, 94);
            this.txtAbbreviation.Name = "txtAbbreviation";
            this.txtAbbreviation.Size = new System.Drawing.Size(100, 23);
            this.txtAbbreviation.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 15);
            this.label9.TabIndex = 10;
            this.label9.Text = "Abbreviation:";
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(137, 126);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(100, 23);
            this.txtDepartment.TabIndex = 9;
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(137, 63);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(100, 23);
            this.txtCourseName.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Instructor:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Number of Credits:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Department:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Course Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "ID:";
            // 
            // btnRemoveCourse
            // 
            this.btnRemoveCourse.Location = new System.Drawing.Point(23, 355);
            this.btnRemoveCourse.Name = "btnRemoveCourse";
            this.btnRemoveCourse.Size = new System.Drawing.Size(130, 36);
            this.btnRemoveCourse.TabIndex = 2;
            this.btnRemoveCourse.Text = "Remove Course";
            this.btnRemoveCourse.UseVisualStyleBackColor = true;
            // 
            // btnLoadCourse
            // 
            this.btnLoadCourse.Location = new System.Drawing.Point(23, 271);
            this.btnLoadCourse.Name = "btnLoadCourse";
            this.btnLoadCourse.Size = new System.Drawing.Size(130, 35);
            this.btnLoadCourse.TabIndex = 1;
            this.btnLoadCourse.Text = "Loaded Courses";
            this.btnLoadCourse.UseVisualStyleBackColor = true;
            // 
            // btnAddUpdate
            // 
            this.btnAddUpdate.Location = new System.Drawing.Point(23, 312);
            this.btnAddUpdate.Name = "btnAddUpdate";
            this.btnAddUpdate.Size = new System.Drawing.Size(132, 37);
            this.btnAddUpdate.TabIndex = 0;
            this.btnAddUpdate.Text = "Add/Update Course";
            this.btnAddUpdate.UseVisualStyleBackColor = true;
            this.btnAddUpdate.Click += new System.EventHandler(this.btnAddUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 639);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTeacherAge)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblDateOfBirth;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Button btnAddTeacher;
        private DateTimePicker dtStudentDateOfBirth;
        private NumericUpDown numId;
        private DataGridView dgvResults;
        private Label lblAge;
        private NumericUpDown numTeacherAge;
        private Button btnLoadTeachers;
        private RadioButton rdoTeacher;
        private RadioButton rdoStudent;
        private Panel panel1;
        private Button btnLoadStudents;
        private Button btnDelete;
        private Button btnResetForm;
        private Button btnSearch;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dgvCourses;
        private ComboBox cboxNumOfCredits;
        private ComboBox cboxInstructors;
        private TextBox txtAbbreviation;
        private Label label9;
        private TextBox txtDepartment;
        private TextBox txtCourseName;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btnRemoveCourse;
        private Button btnLoadCourse;
        private Button btnAddUpdate;
        private Button btnResetCourseForm;
        private Label txtCourseId;
    }
}
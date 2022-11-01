using Microsoft.EntityFrameworkCore;
using SchoolOfFineArtsModels;
using SchoolOfFireArtsDB;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace SchoolOfFineArts
{
    public partial class Form1 : Form
    {
        private readonly string _cnstr;
        private readonly DbContextOptionsBuilder _optionsBuilder;
        public Form1()
        {
            InitializeComponent();
            dgvResults.DataSource = listTeachers;
            _cnstr = Program._configuration["ConnectionStrings:SchoolOfFineArtsDB"];
            _optionsBuilder = new DbContextOptionsBuilder<SchoolOfFineArtsDBContext>().UseSqlServer(_cnstr);

        }
        //use readonly as they are only set at form creation

        BindingList<Teacher> listTeachers = new BindingList<Teacher>();
        public void btnAddTeacher_Click(object sender, EventArgs e)
        {
            bool modified = false;
            if (rdoTeacher.Checked)
            {
                var teacher = new Teacher();
                teacher.Id = Convert.ToInt32(Math.Round(numId.Value));
                teacher.FirstName = txtFirstName.Text;
                teacher.LastName = txtLastName.Text;
                teacher.Age = (int)numTeacherAge.Value;
                //Ensure teacher not in database
                using (var context = new SchoolOfFineArtsDBContext(_optionsBuilder.Options))
                {

                    //if exists post error "did you mean to update"
                    if (teacher.Id > 0)
                    {
                        var existingTeacher = context.Teachers.SingleOrDefault(t => t.Id == teacher.Id);
                        modified = false;
                        if (existingTeacher != null)
                        {
                            existingTeacher.FirstName = teacher.FirstName;
                            existingTeacher.LastName = teacher.LastName;
                            existingTeacher.Age = teacher.Age;
                            context.SaveChanges();
                            modified = true;
                        }
                        else
                        {
                            MessageBox.Show("Teacher not found. Could not update.");
                        }

                    }
                    else
                    {
                         var existingTeacher = context.Teachers.SingleOrDefault(t => t.FirstName.ToLower() == teacher.FirstName.ToLower()
                            && t.LastName.ToLower() == teacher.LastName.ToLower()
                            && t.Age == teacher.Age);
                        //if not add teacher
                        if (existingTeacher == null)
                        {
                            context.Teachers.Add(teacher);
                            context.SaveChanges();
                            modified = true;

                        }
                        else
                        {
                            MessageBox.Show("Teacher already exists, did you mean to update?");
                        }
                    }

                    if (modified)
                    {
                        ResetForm();
                        //var dbTeachers = new BindingList<Teacher>(context.Teachers.ToList());
                        //dgvResults.DataSource = dbTeachers;
                        //dgvResults.Refresh();
                        LoadTeachers();
                    }
                }
            }
            else if (rdoStudent.Checked)
            {

                var student = new Student();
                student.Id = 0;
                student.FirstName = txtFirstName.Text;
                student.LastName = txtLastName.Text;
                student.DateOfBirth = (DateTime)dtStudentDateOfBirth.Value;
                //Ensure teacher not in database
                using (var context = new SchoolOfFineArtsDBContext(_optionsBuilder.Options))
                {
                    var existingStudent = context.Students.SingleOrDefault(s => s.FirstName.ToLower() == s.FirstName.ToLower()
                    && s.LastName.ToLower() == student.LastName.ToLower()
                    && s.DateOfBirth == student.DateOfBirth);
                    //if exists post error "did you mean to update"
                    if (existingStudent is not null)
                    {
                        modified = false;
                        MessageBox.Show("Student already exists, did you mean to update?");
                    }
                    else
                    {
                        //if not add teacher
                        context.Students.Add(student);
                        context.SaveChanges();
                        modified = true;
                        //reload teachers
                        //var dbStudents = new BindingList<Student>(context.Students.ToList());
                        //dgvResults.DataSource = dbStudents;
                        //dgvResults.Refresh();
                        LoadStudents();
                    }
                }
            }
        }

        private void btnLoadTeachers_Click(object sender, EventArgs e)
        {
            LoadTeachers();
        }

        private void LoadTeachers(bool isSearch=false)
        {
            using (var context = new SchoolOfFineArtsDBContext(_optionsBuilder.Options))
            {
                var dbTeachers = new BindingList<Teacher>(context.Teachers.ToList());
                dgvResults.DataSource = dbTeachers;
                dgvResults.Refresh();
                //ResetForm();
            }
            if (!isSearch)
            {
                cboxInstructors.SelectedIndex = -1;
                cboxInstructors.Items.Clear();
                var tList = dgvResults.DataSource as BindingList<Teacher>;
                cboxInstructors.Items.AddRange(tList.ToArray<Teacher>());
                cboxInstructors.DisplayMember = "FriendlyName";
                cboxInstructors.ValueMember = " Id";
            }
        }

        private void rdoTeacher_CheckedChanged(object sender, EventArgs e)
        {
            ToggleControlVisibility();
            if (rdoTeacher.Checked)
            {
                LoadTeachers();
            }
        }

        private void ToggleControlVisibility()
        {
            lblAge.Visible = rdoTeacher.Checked;
            lblDateOfBirth.Visible = rdoStudent.Checked;
            numTeacherAge.Visible = rdoTeacher.Checked;
            dtStudentDateOfBirth.Visible = rdoStudent.Checked;
        }

        private void rdoStudent_CheckedChanged(object sender, EventArgs e)
        {
            ToggleControlVisibility();
            if (rdoStudent.Checked)
            {
                LoadStudents();
            }
        }

        private void btnLoadStudents_Click(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void LoadStudents()
        {
            using (var context = new SchoolOfFineArtsDBContext(_optionsBuilder.Options))
            {
                var dbStudent = new BindingList<Student>(context.Students.ToList());
                dgvResults.DataSource = dbStudent;
                dgvResults.Refresh();
                lstStudents.Items.Clear();
                lstStudents.Items.AddRange(dbStudent.ToArray());
                //ResetForm();
            }
        }

        private void dgvResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dataId = 0;
            bool isTeacher = false;
            bool isStudent = false;
            var theRow = dgvResults.Rows[e.RowIndex];
            //var theCell = theRow.Cells[0];

            foreach (DataGridViewTextBoxCell cell in theRow.Cells)
            {
                Debug.WriteLine(cell.ColumnIndex);
                Debug.WriteLine(cell.Value);
                Debug.WriteLine(cell.OwningColumn.Name);
                if (cell.OwningColumn.Name.Equals("Id", StringComparison.OrdinalIgnoreCase))
                {
                     dataId = (int)cell.Value;
                    if(dataId == 0)
                    {
                        MessageBox.Show("Bad Row clicked");
                        ResetForm();
                        return;
                    }
                }
                if (cell.OwningColumn.Name.Equals("Age", StringComparison.OrdinalIgnoreCase))
                {
                    isTeacher = true;
                }
                if (cell.OwningColumn.Name.Equals("DateOfBirth", StringComparison.OrdinalIgnoreCase))
                {
                    isStudent = true;
                }
                if (isTeacher)
                {
                   
                }
                else if (isStudent)
                {

                }

                using (var context = new SchoolOfFineArtsDBContext(_optionsBuilder.Options))
                {
                    if (isTeacher)
                    {
                        var t = context.Teachers.SingleOrDefault(t => t.Id == dataId);
                        if(t != null)
                        {
                            txtFirstName.Text = t.FirstName;
                            txtLastName.Text = t.LastName;
                            numTeacherAge.Value = t.Age;
                            numId.Value = t.Id;

                            rdoTeacher.Checked = true;
                            rdoStudent.Checked = false;
                            ToggleControlVisibility();

                        }
                    }
                    else if (isStudent)
                    {
                        var s = context.Students.SingleOrDefault(s => s.Id == dataId);
                        if (s != null)
                        {
                            txtFirstName.Text = s.FirstName;
                            txtLastName.Text = s.LastName;
                            dtStudentDateOfBirth.Value = s.DateOfBirth;
                            numId.Value = s.Id;

                            rdoTeacher.Checked = false;
                            rdoStudent.Checked = true;
                            ToggleControlVisibility();

                        }
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var id = (int)numId.Value;
            var confirmDelete = MessageBox.Show("Are you sure you want to delete this Item",
                "Are you sure?",
                MessageBoxButtons.YesNo);
            if (confirmDelete == DialogResult.Yes)
                using (var context = new SchoolOfFineArtsDBContext(_optionsBuilder.Options))
                {
                    if (rdoTeacher.Checked)
                    {
                        var d = context.Teachers.SingleOrDefault(t => t.Id == id);
                        if (d != null)
                        {
                            context.Teachers.Remove(d);
                            context.SaveChanges();
                            //var databaseTeachers = new BindingList<Teacher>(context.Teachers.ToList());
                            //dgvResults.DataSource = databaseTeachers;
                            LoadTeachers();
                        }
                        else
                        {
                            MessageBox.Show("Teacher not found, could not Delete.");
                        }
                    }
                    else if (rdoStudent.Checked)
                    {
                        var d = context.Students.SingleOrDefault(t => t.Id == id);
                        if (d != null)
                        {
                            context.Students.Remove(d);
                            context.SaveChanges();
                            //var databaseStudents = new BindingList<Student>(context.Students.ToList());
                            //dgvResults.DataSource = databaseStudents;
                            LoadStudents();
                        }
                        else
                        {
                            MessageBox.Show("Student not found, could not Delete.");
                        }
                    }
                }
            dgvResults.Refresh();

        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void ResetForm()
        {
            numId.Value = 0;
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            dgvResults.ClearSelection();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadTeachers();
            LoadStudents();
            ResetForm();
            ResetCourseForm();
            LoadCourses();


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (rdoTeacher.Checked)
            {
                LoadTeachers(true);
                var tList = dgvResults.DataSource as BindingList<Teacher>;
                var fList = tList.Where(x => x.LastName.ToLower().Contains(txtLastName.Text.ToLower()) &&
                                             x.FirstName.ToLower().Contains(txtFirstName.Text.ToLower())).ToList();
                dgvResults.DataSource = new BindingList<Teacher>(fList);
                dgvResults.ClearSelection();
            }
            else if (rdoStudent.Checked)
            {
                LoadStudents();
                var tList = dgvResults.DataSource as BindingList<Student>;
                var fList = tList.Where(x => x.LastName.ToLower().Contains(txtLastName.Text.ToLower()) &&
                                             x.FirstName.ToLower().Contains(txtFirstName.Text.ToLower())).ToList();
                dgvResults.DataSource = new BindingList<Student>(fList);
                dgvResults.ClearSelection();
            }
        }

        private void numId_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            var teacher = ((Teacher)cboxInstructors.SelectedItem).Id;
            //var teacher = (Teacher)cboInstructors.SelectedItem;
            //var teacherId = teacher.Id;
            //var teacherIdOneLine = ((Teacher)cboInstructors.SelectedItem).Id;

            bool modified = false;
            var newCourse = new Course();
            newCourse.Id = Convert.ToInt32(txtCourseId.Text);
            newCourse.NumCredits = Convert.ToInt32(cboxNumOfCredits.SelectedItem);
            newCourse.Abbreviation = txtAbbreviation.Text;
            newCourse.Department = txtDepartment.Text;
            newCourse.TeacherId = teacher;
            newCourse.Name = txtCourseName.Text;
            //Ensure teacher not in database
            //using (var context = new SchoolOfFineArtsDBContext(_optionsBuilder.Options))
            {

                //if exists post error "did you mean to update"
                if (newCourse.Id > 0)
                {
                    using (var context = new SchoolOfFineArtsDBContext(_optionsBuilder.Options))
                    {

                        var existingCourse = context.Courses.SingleOrDefault(t => t.Id == newCourse.Id);
                        modified = false;

                        if (existingCourse != null)
                        {
                            existingCourse.NumCredits = newCourse.NumCredits;
                            existingCourse.Abbreviation = newCourse.Abbreviation;
                            existingCourse.TeacherId = newCourse.TeacherId;
                            existingCourse.Name = newCourse.Name;
                            context.SaveChanges();
                            modified = true;
                        }
                        else
                        {
                            MessageBox.Show("Teacher not found. Could not update.");
                        }
                    }
                }
                else
                {
                    using (var context = new SchoolOfFineArtsDBContext(_optionsBuilder.Options))
                    {
                        var existingCourse = context.Courses.SingleOrDefault(t =>
                            t.Name.ToLower() == newCourse.Name.ToLower()
                            && t.Abbreviation.ToLower() == newCourse.Abbreviation.ToLower()
                            && t.TeacherId == newCourse.TeacherId);
                        //if not add teacher
                        if (existingCourse == null)
                        {
                            context.Courses.Add(newCourse);
                            context.SaveChanges();
                            modified = true;

                        }
                        else
                        {
                            MessageBox.Show("That course already exists, did you mean to update?");
                        }

                    }
                }

                if (modified)
                {
                    ResetCourseForm();
                    //var dbTeachers = new BindingList<Teacher>(context.Teachers.ToList());
                    //dgvResults.DataSource = dbTeachers;
                    //dgvResults.Refresh();
                    LoadCourses();
                }
            }
        }

        private void LoadCourses()
        {
            using (var context = new SchoolOfFineArtsDBContext(_optionsBuilder.Options))
            {
                var Courses = new BindingList<Course>(context.Courses.Include(x=>x.Teacher).ToList());
                //var otherCourses= context.Courses.Include(x=> x.Teacher)
                //                        .Select(y=> new
                //                        {
                //                            Id = y.Id,
                //                            Name = y.Name,
                //                            TeacherId = y.TeacherId, 
                //                            Abbreviation = y.Abbreviation,
                //                            Instructor = y.Teacher.FriendlyName.ToList(),
                //                            NumCredits = y.NumCredits,
                //                         }).ToList();
                dgvCourses.DataSource = Courses;
                dgvCourses.Refresh();
                dgvCourseAssignments.DataSource = Courses;
                dgvCourseAssignments.Refresh();
                //ResetForm();
            }
        }

        private void ResetCourseForm()
        {
            txtCourseId.Text = "0";
            txtCourseName.Text = string.Empty;
            txtDepartment.Text = string.Empty;
            txtAbbreviation.Text = string.Empty;
            cboxInstructors.SelectedIndex = -1;
            cboxNumOfCredits.SelectedIndex = 2;

            
        }

        private void btnResetCourseForm_Click(object sender, EventArgs e)
        {
            ResetCourseForm();
        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            var selIndex = ((TabControl)sender).SelectedIndex;
            switch (selIndex)
            {
                case 0:
                    LoadTeachers();
                    ResetForm();   
                    break;
                case 1:
                    LoadCourses();
                    ResetCourseForm();
                    break;
                default:
                    break;
            }
        }

        private void dgvCourse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var theRow = dgvCourses.Rows[e.RowIndex];
            int dataId = 0;

            //int dataId = 0;
            //bool isTeacher = false;
            //bool isStudent = false;
            //var theRow = dgvResults.Rows[e.RowIndex];
            ////var theCell = theRow.Cells[0];

            foreach (DataGridViewTextBoxCell cell in theRow.Cells)
            {
                if (cell.OwningColumn.Name.Equals("Id", StringComparison.OrdinalIgnoreCase))
                {
                    dataId = (int)cell.Value;
                    if (dataId == 0)
                    {
                        MessageBox.Show("Bad row clicked");
                        ResetForm();
                        return;
                    }
                }
            }

            using (var context = new SchoolOfFineArtsDBContext(_optionsBuilder.Options))
            {
                var d = context.Courses.SingleOrDefault(x => x.Id == dataId);
                if (d is not null)
                {
                    txtCourseId.Text = d.Id.ToString();
                    txtCourseName.Text = d.Name;
                    txtAbbreviation.Text = d.Abbreviation;
                    txtDepartment.Text = d.Department;
                    foreach (var item in cboxNumOfCredits.Items)
                    {
                        if (Convert.ToInt32(item) == d.NumCredits)
                        {
                            cboxNumOfCredits.SelectedItem = item;
                        }

                    }
                    foreach (var item in cboxInstructors.Items)
                    {
                        var t = (Teacher)item;
                        if (t.Id == d.TeacherId)
                        {
                            cboxInstructors.SelectedItem = item;
                        }

                    }

                }

            }

        }

        private void btnRemoveCourse_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(txtCourseId.Text);
            var name = txtCourseName.Text;
            var confirmDelete = MessageBox.Show($"Are you sure you want to delete this course: {Name}",
                "Are you sure?",
                MessageBoxButtons.YesNo);
            if (confirmDelete == DialogResult.Yes)
                using (var context = new SchoolOfFineArtsDBContext(_optionsBuilder.Options))
                {
                        var d = context.Courses.SingleOrDefault(t => t.Id == id);
                        if (d != null)
                        {
                            context.Courses.Remove(d);
                            context.SaveChanges();
                            //var databaseTeachers = new BindingList<Teacher>(context.Teachers.ToList());
                            //dgvResults.DataSource = databaseTeachers;
                            LoadCourses();
                        }
                        else
                        {
                            MessageBox.Show("Course not found, could not Delete.");
                        }
                    

                }
            dgvResults.Refresh();
            ResetCourseForm();

        }

        private void btnLoadCourse_Click(object sender, EventArgs e)
        {

        }
    }
}
   
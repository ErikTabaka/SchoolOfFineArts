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
                        var dbTeachers = new BindingList<Teacher>(context.Teachers.ToList());
                        dgvResults.DataSource = dbTeachers;
                        dgvResults.Refresh();
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
                        var dbStudents = new BindingList<Student>(context.Students.ToList());
                        dgvResults.DataSource = dbStudents;
                        dgvResults.Refresh();
                    }
                }
            }
        }

        private void btnLoadTeachers_Click(object sender, EventArgs e)
        {
            using(var context = new SchoolOfFineArtsDBContext(_optionsBuilder.Options))
            {
                var dbTeachers = new BindingList<Teacher>(context.Teachers.ToList());
                dgvResults.DataSource = dbTeachers;
                dgvResults.Refresh();
            }
        }

        private void rdoTeacher_CheckedChanged(object sender, EventArgs e)
        {
            ToggleControlVisibility();
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
        }

        private void btnLoadStudents_Click(object sender, EventArgs e)
        {
            using (var context = new SchoolOfFineArtsDBContext(_optionsBuilder.Options))
            {
                var dbStudent = new BindingList<Student>(context.Students.ToList());
                dgvResults.DataSource = dbStudent;
                dgvResults.Refresh();
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
                            var databaseTeachers = new BindingList<Teacher>(context.Teachers.ToList());
                            dgvResults.DataSource = databaseTeachers;
                        }
                    }
                    else if (rdoStudent.Checked)
                    {
                        var d = context.Students.SingleOrDefault(t => t.Id == id);
                        if (d != null)
                        {
                            context.Students.Remove(d);
                            context.SaveChanges();
                            var databaseStudents = new BindingList<Student>(context.Students.ToList());
                            dgvResults.DataSource = databaseStudents;
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
    }
}
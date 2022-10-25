using Microsoft.EntityFrameworkCore;
using SchoolOfFineArtsModels;
using SchoolOfFireArtsDB;
using System.ComponentModel;


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
            bool newObject = true;
            if (rdoTeacher.Checked)
            {
                var teacher = new Teacher();
                teacher.Id = 0;
                teacher.FirstName = txtFirstName.Text;
                teacher.LastName = txtLastName.Text;
                teacher.Age = (int)numTeacherAge.Value;
                //Ensure teacher not in database
                using (var context = new SchoolOfFineArtsDBContext(_optionsBuilder.Options))
                {
                    var exists = context.Teachers.SingleOrDefault(t => t.FirstName.ToLower() == teacher.FirstName.ToLower()
                                                                 && t.LastName.ToLower() == teacher.LastName.ToLower()
                                                                 && t.Age == teacher.Age);
                    //if exists post error "did you mean to update"
                    if (exists is not null)
                    {
                        newObject = false;
                        MessageBox.Show("Teacher already exists, did you mean to update?");
                    }
                    else
                    {
                        //if not add teacher
                        context.Teachers.Add(teacher);
                        context.SaveChanges();
                        //reload teachers
                        var dbTeachers = new BindingList<Teacher>(context.Teachers.ToList());
                        dgvResults.DataSource = dbTeachers;
                        dgvResults.Refresh();
                    }
                }
            }
            else if (rdoStudent.Checked)
            {
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
    }
}
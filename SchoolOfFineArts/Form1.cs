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
            //Converting strings to Int or Int to Strings
            //Converting decimal to Int for TeacherID
            string mytext = Convert.ToString(32);
            int myNumber = Convert.ToInt32("32");
            var teacher1 = new Teacher();
            teacher1.FirstName = txtTeacherFirstName.Text;
            teacher1.LastName = txtTeacherLastName.Text;
            teacher1.Id = Convert.ToInt32(Math.Round(numTeacherId.Value));
            teacher1.Age = Convert.ToInt32(Math.Round(numTeacherAge.Value));
            bool validId = true;

            //does list contain id?
            foreach (var item in listTeachers)
            {
                if (item.Id == teacher1.Id)
                {
                    MessageBox.Show("This ID already Exists");
                    validId = false;
                }
                if (item.FirstName.Equals(teacher1.FirstName,StringComparison.OrdinalIgnoreCase) 
                    && item.LastName.Equals(teacher1.LastName,StringComparison.OrdinalIgnoreCase)
                    && item.Age == teacher1.Age)
                {
                    MessageBox.Show("This User already exists.");
                    validId=false;
                }

            }
            if (validId)
            {
                dgvResults.Refresh();
                listTeachers.Add(teacher1);
            }
            //if so msg box MUST BE UNIQUE ID
            //IF NOT CONTINUE

            
            //dgvResults.Refresh();
            //listTeachers.Add(teacher1);
            //MessageBox.Show($"FirstName: {teacher1.FirstName} , Last Name: {teacher1.LastName} , ID: {teacher1.Id}");
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
    }
}
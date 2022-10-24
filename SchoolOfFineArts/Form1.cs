using SchoolOfFineArtsModels;
using System.ComponentModel;


namespace SchoolOfFineArts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dgvResults.DataSource = listTeachers;

        }

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
                if (item.FirstName == teacher1.FirstName && item.LastName == teacher1.LastName && item.Age == teacher1.Age)
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
    }
}
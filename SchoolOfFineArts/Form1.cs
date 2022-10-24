using SchoolOfFineArtsModels;

namespace SchoolOfFineArts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            //Converting strings to Int or Int to Strings
            //Converting decimal to Int for TeacherID
            string mytext = Convert.ToString(32);
            int myNumber = Convert.ToInt32("32");
            var teacher1 = new Teacher();
            teacher1.FirstName = txtTeacherFirstName.Text;
            teacher1.LastName = txtTeacherLastName.Text;
            teacher1.Id = Convert.ToInt32(numTeacherId.Value);
            //teacher1.FirstName = 
            MessageBox.Show("Add Teacher");
        }
    }
}
using System.ComponentModel.DataAnnotations;

namespace SchoolOfFineArtsModels
{
    public class Teacher
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }
        [Required, Range(1, 130)]
        public int Age { get; set; }
        public virtual List<Course> Courses { get; set; } = new List<Course>();

        public string FriendlyName => $"{FirstName} {LastName} {Id}";
  
        public override string ToString()
        {
            return $"{FirstName},{LastName}";
        }
    }
}
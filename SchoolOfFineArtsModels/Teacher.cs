﻿namespace SchoolOfFineArtsModels
{
    public class Teacher
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return $"First Name: {FirstName}, Last Name: {LastName}. ID:{Id}, Age: {Age}";
        }
    }
}
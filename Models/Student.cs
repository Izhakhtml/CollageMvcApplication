using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CollageMvcApplication.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Room { get; set; }
        public int[] Grades { get; set; }
        public int BirthYear { get; set; }
        static public List<Student> listStudent = new List<Student>();
        static public int counter = 0;

        public Student( string firstName, string lastName, string room, int[] grades, int birthYear)
        {
            Id = counter++;
            FirstName = firstName;
            LastName = lastName;
            Room = room;
            Grades = grades;
            BirthYear = birthYear;
        }
    }
}
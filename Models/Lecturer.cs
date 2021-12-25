using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CollageMvcApplication.Models
{
    public class Lecturer
    {      
        static int counter = 0;
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Salary { get; set; }
        public string[] Professions { get; set; }

        public int InitialYar { get; set; }
        static public List<Lecturer> listLectore = new List<Lecturer>();

        public Lecturer(string firstName, string lastName, int salary, string[] professions, int initialYar)
        {
            Id = counter++;
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
            Professions = professions;
            InitialYar = initialYar;
        }
    }
}
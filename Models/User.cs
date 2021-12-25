using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CollageMvcApplication.Models
{
    public class Userr
    {

        public Userr(string firstName, string lastName, int yearBirth, bool ifConnect)
        {
            Id = counter++;
            FirstName = firstName;
            LastName = lastName;
            YearBirth = yearBirth;
            IfConnect = ifConnect;
        }
        public Userr() { }
        static public List<Userr>list = new List<Userr>();
        static int counter = 0;
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int YearBirth { get; set; }
        public bool IfConnect { get; set; }

    }
}
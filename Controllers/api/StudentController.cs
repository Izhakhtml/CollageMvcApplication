using CollageMvcApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CollageMvcApplication.Controllers.api
{
    public class StudentController : ApiController
    {
        // GET: api/Student
        public IHttpActionResult Get()
        {
            CreateStudent();
            return Ok(Student.listStudent)
;        }
        // GET: api/Student/5
        public IHttpActionResult Get(int id)
        {
            CreateStudent();
            return Ok(Student.listStudent.Find(itemId => itemId.Id == id));
        }
        // POST: api/Student
        public IHttpActionResult Post([FromBody]Student value)
        {
            CreateStudent();
            Student.listStudent.Add(value);
            return Ok(Student.listStudent);
        }
        // PUT: api/Student/5
        public IHttpActionResult Put(int id, [FromBody]Student value)
        {
            CreateStudent();
            Student newStudent = Student.listStudent.Find(itemId => itemId.Id == id);
            Student.listStudent[Student.listStudent.IndexOf(newStudent)].FirstName = value.FirstName;
            Student.listStudent[Student.listStudent.IndexOf(newStudent)].LastName = value.LastName;
            Student.listStudent[Student.listStudent.IndexOf(newStudent)].Room = value.Room;
            Student.listStudent[Student.listStudent.IndexOf(newStudent)].Grades = value.Grades;
            Student.listStudent[Student.listStudent.IndexOf(newStudent)].BirthYear = value.BirthYear;
            return Ok(Student.listStudent);
        }
        // DELETE: api/Student/5
        public IHttpActionResult Delete(int id)
        {
            CreateStudent();
            Student deleteStudent = Student.listStudent.Find(itemId => itemId.Id == id);
            Student.listStudent.Remove(deleteStudent);
            return Ok(Student.listStudent);
        }
        public void CreateStudent()
        {
            Student.listStudent.AddRange(new Student[]
            {
                new Student("izhak","lijalem","F1",new int[]{90,50,90},1996),
                new Student("lial","izhak","F3",new int[]{95,79,80},1994),
                new Student("eden","genet","F4",new int[]{54,65,76},1995),
            });
        }
    }
}

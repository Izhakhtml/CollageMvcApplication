using CollageMvcApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CollageMvcApplication.Controllers.api
{
    public class LecturerController : ApiController
    {
        // GET: api/Lecturer
        public IHttpActionResult Get()
        {
            CreateLecturers();
            return Ok(Lecturer.listLectore);
        }
        // GET: api/Lecturer/5
        public IHttpActionResult Get(int id)
        {
            CreateLecturers();
            return Ok(Lecturer.listLectore.Find(item => item.Id == id));

        }
        // POST: api/Lecturer
        public IHttpActionResult Post([FromBody]Lecturer value)
        {
            Lecturer.listLectore.Add(value);
            return Ok(Lecturer.listLectore);
        }
        // PUT: api/Lecturer/5
        public IHttpActionResult Put(int id, [FromBody]Lecturer value)
        {
            CreateLecturers();
            Lecturer newLecturer = Lecturer.listLectore.Find(item => item.Id == id);
            Lecturer.listLectore[Lecturer.listLectore.IndexOf(newLecturer)].FirstName = value.FirstName;
            Lecturer.listLectore[Lecturer.listLectore.IndexOf(newLecturer)].LastName = value.LastName;
            Lecturer.listLectore[Lecturer.listLectore.IndexOf(newLecturer)].Salary = value.Salary;
            Lecturer.listLectore[Lecturer.listLectore.IndexOf(newLecturer)].Professions = value.Professions;
            Lecturer.listLectore[Lecturer.listLectore.IndexOf(newLecturer)].InitialYar = value.InitialYar;
            return Ok(Lecturer.listLectore);
        }
        // DELETE: api/Lecturer/5
        public IHttpActionResult Delete(int id)
        {
            CreateLecturers();
            Lecturer deleteLecturer = Lecturer.listLectore.Find(item => item.Id == id);
            Lecturer.listLectore.Remove(deleteLecturer);
            return Ok(Lecturer.listLectore);
        }
        void CreateLecturers()
        {
            Lecturer[] lecturerArray = new Lecturer[]
            {
                new Lecturer("izhak","lijalem",5000,new string[]{"math","sport","dance"},2003),
                new Lecturer("haim","ayano",8000,new string[]{"math","sport","dance"},2005),
                new Lecturer("jacob","or",10000,new string[]{"math","sport","dance"},2006),
            };
            Lecturer.listLectore.AddRange(lecturerArray);
        }
    }
}

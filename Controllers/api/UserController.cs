using CollageMvcApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CollageMvcApplication.Controllers.api
{
    public class UserController : ApiController
    {
        // GET: api/User
        public IHttpActionResult Get()
        {
            CreateList();
            return Ok(Userr.list);
        }
        // GET: api/User/5
        public IHttpActionResult Get(int id)
        {
            CreateList();
            return Ok(Userr.list.Find(itemId=>itemId.Id==id));
        }
        // POST: api/User
        public IHttpActionResult Post([FromBody]Userr value)
        {
            CreateList();
            Userr.list.Add(value);
            return Ok(Userr.list);
        }
        // PUT: api/User/5
        public IHttpActionResult Put(int id, [FromBody]Userr value)
        {
            CreateList();
            Userr newUser = Userr.list.Find(itemId => itemId.Id == id);
            Userr.list[Userr.list.IndexOf(newUser)].FirstName = value.FirstName;
            Userr.list[Userr.list.IndexOf(newUser)].LastName = value.LastName;
            Userr.list[Userr.list.IndexOf(newUser)].YearBirth = value.YearBirth;
            Userr.list[Userr.list.IndexOf(newUser)].IfConnect = value.IfConnect;
            return Ok(Userr.list);
        }
        // DELETE: api/User/5
        public IHttpActionResult Delete(int id)
        {
            CreateList();
            Userr deleteUser = Userr.list.Find(itemId=> itemId.Id==id);
            Userr.list.Remove(deleteUser);
            return Ok(Userr.list);
        }
        private void CreateList()
        {
            Userr.list.AddRange(new Userr[]
            {
               new Userr("izhak","lijalem",1999,true),
               new Userr("kobi","rauvan",2000,false),
               new Userr("jacob","oded",1994,true),
               new Userr("moti","loli",2003,false),
            });
        }
    }
}

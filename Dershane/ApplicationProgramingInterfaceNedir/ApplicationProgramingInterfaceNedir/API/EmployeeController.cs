using ApplicationProgramingInterfaceNedir.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApplicationProgramingInterfaceNedir.API
{
    public class EmployeeController : ApiController
    {
        NORTHWNDEntities DB = new NORTHWNDEntities();

        // GET: api/Employee
        public IEnumerable<Employees> Get()
        {
            return DB.Employees;
        }

        // GET: api/Employee/5
        public Employees Get(int id)
        {
            return DB.Employees.Find(id);
        }

        // POST: api/Employee
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Employee/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Employee/5
        public void Delete(int id)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApplicationProgramingInterfaceNedir.API
{
    public class ListeliVerilerController : ApiController
    {
        // GET: api/ListeliVeriler
        public IEnumerable<string> Get()
        {
            List<string> Isimler = new List<string>();
            Isimler.AddRange(new string[] { "Armağan", "Alperen Efe", "Kaan", "Poraz", "Murtaza", "Şuayip" });

            return Isimler;
        }

        // GET: api/ListeliVeriler/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/ListeliVeriler
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/ListeliVeriler/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ListeliVeriler/5
        public void Delete(int id)
        {
        }
    }
}

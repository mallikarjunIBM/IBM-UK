using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ConnectorAPI.Controllers
{
    public class TM1ConnectorAPIController : ApiController
    {
        // GET: api/TM1ConnectorAPI
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/TM1ConnectorAPI/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/TM1ConnectorAPI
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/TM1ConnectorAPI/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/TM1ConnectorAPI/5
        public void Delete(int id)
        {
        }
    }
}

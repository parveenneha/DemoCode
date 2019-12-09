using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Swaggerwebapi.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        /// <summary>
        /// This is an example of swaggerUI
        /// This will list all details
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        /// <summary>
        /// This will provide details for id
        /// </summary>
        /// <param name="id">This is mandatory</param>
        /// <returns></returns>
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        /// <summary>
        /// This is for posting data
        /// </summary>
        /// <param name="value"></param>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        /// <summary>
        /// This is for udpation
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        /// <summary>
        /// This is to delete
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
        }
    }
}

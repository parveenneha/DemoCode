using RestSharpDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RestSharpDemo.Controllers
{
    public class myapiController : ApiController
    {
        public IHttpActionResult Get()
        {
            var models = new List<Students>()
            {
                new Students(){ Id=1,name="tom"},
                new Students(){ Id=1,name="jerry"},

            };
            return Ok(models);
        }
    }
}

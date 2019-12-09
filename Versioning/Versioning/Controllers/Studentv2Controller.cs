using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Versioning.Models;

namespace Versioning.Controllers
{
    public class Studentv2Controller : ApiController
    {
        List<Studentv2> studentv2s = new List<Studentv2>()
        {
            new Studentv2(){ id=1,Firstname="tom",Lastname="cat"},
            new Studentv2(){ id=2,Firstname="jerry",Lastname="mouse"},
        };
        public IEnumerable<Studentv2>Get()
        {
            return studentv2s;
        }
        public Studentv2 Get(int id)
        {
            return studentv2s.FirstOrDefault(s => s.id == id);
        }
    }
}

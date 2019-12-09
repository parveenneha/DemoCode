using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Versioning.Models;

namespace Versioning.Controllers
{
    public class Studentv1Controller : ApiController
    {
        List<Studentv1> studentv1s = new List<Studentv1>()
        {
            new Studentv1(){ id=1,name="tom"},
            new Studentv1(){ id=2,name="jerry"},
        };
        public IEnumerable<Studentv1>Get()
        {
            return studentv1s;
        }
        public Studentv1 Get(int id)
        {
            return studentv1s.FirstOrDefault(s => s.id == id);
        }
    }
}

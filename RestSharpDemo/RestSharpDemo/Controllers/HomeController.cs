using Newtonsoft.Json;
using RestSharp;
using RestSharpDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestSharpDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var apiurl = @"http://localhost:44308/api/myapi";
            var client = new RestClient(apiurl);
            var req = new RestRequest(Method.GET);
            req.AddHeader("Accept", "application/json");
            var result = client.Execute(req).Content;
            var finalresult = JsonConvert.DeserializeObject<List<Students>>(result);
            return View();
        }
    }
}

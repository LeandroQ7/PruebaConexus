using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestConexus.Models;

namespace TestConexus.Controllers
{
    public class HomeController : Controller
    {
        List<Person> personList;
        public ActionResult Index()
        {
            GetJsonData();
           
            return View();
        }

        private void GetJsonData()
        {
            var json = System.IO.File.ReadAllText(Server.MapPath(@"~/json/Datos_Prueba_Dev.json"));
            personList = JsonConvert.DeserializeObject<List<Person>>(json);

            ViewBag.personList = personList;
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
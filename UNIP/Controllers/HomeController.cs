using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Reflection;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace UNIP.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        public partial class Portadore
        {
            public string nome { get; set; }
            public string cpf { get; set; }
            public int logradouro { get; set; }
            public string numero { get; set; }
            public string cep { get; set; }
            public string bairro { get; set; }
            public string cidade { get; set; }
            public string numerotelefone { get; set; }
            public int ddd { get; set; }
            public string tipo { get; set; }
            
        }

    }
}
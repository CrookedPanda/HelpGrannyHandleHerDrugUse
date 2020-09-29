using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MaakJeNietDrug.Controllers
{ 
    public class HomeController : Controller
    {
        [Route("Home")]
        [Route("Home/Index")]
        [Route("Home/Index/{id?}")]
        public string Index(int? id)
        {
            string test = "Dit is home";
            test = test + id.ToString();
            return test;
        }

        [Route("Home/About")]
        [Route("Home/About/{id?}")]
        public string About(int? id)
        {
            string test = "Dit is about";
            test = test + id.ToString();
            return test;
        }
    }
}


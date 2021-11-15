using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMvcproject.Controllers
{
    public class HomeController : Controller
    {
        // GET: Default
        
        public string Index()
        {
            return "The world is very small in era";
        }
    }
}
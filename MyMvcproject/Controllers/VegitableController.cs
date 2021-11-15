using MyMvcproject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMvcproject.Controllers
{
    public class VegitableController : Controller
    {
        // GET: Vegitable
        static IList<Vegitable> VegitableList = new List<Vegitable>{
                new Vegitable() { id = 1, VegiName = "Carrot", VegiType ="Root"  } ,
               new Vegitable() { id = 1, VegiName = "Onion", VegiType ="Root"  } ,
               new Vegitable() { id = 1, VegiName = "Patato", VegiType ="Root"  } ,
               new Vegitable() { id = 1, VegiName = "Cummber", VegiType ="Plant"  } ,

            };
        public ActionResult Index()
        {
            return View(VegitableList);
        }
       
       
        public ActionResult Edit(int Id)
        {
            //here, get the student from the database in the real application

            //getting a student from collection for demo purpose
            var std = VegitableList.Where(s => s.id == Id).FirstOrDefault();

            return View(std);

            
        }
        [HttpPost]

        public ActionResult Edit(Vegitable std)
        {
            //update student in DB using EntityFramework in real-life application

            //update list by removing old student and adding updated student for demo purpose
            var st = VegitableList.Where(s => s.id == std.id).FirstOrDefault();
            VegitableList.Remove(st);
            VegitableList.Add(std);

            return RedirectToAction("Index");
        }
        public ActionResult Delete(int Id)
        {
            //here, get the student from the database in the real application

            //getting a student from collection for demo purpose
            var std = VegitableList.Where(s => s.id == Id).FirstOrDefault();

            return View(std);


        }
        [HttpPost]

        public ActionResult Delete(Vegitable std)
        {
            //update student in DB using EntityFramework in real-life application

            //update list by removing old student and adding updated student for demo purpose
            var st = VegitableList.Where(s => s.id == std.id).FirstOrDefault();
            VegitableList.Remove(st);
            

            return RedirectToAction("Index");
        }

    }
}
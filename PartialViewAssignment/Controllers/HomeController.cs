using PartialViewAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartialViewAssignment.Controllers
{
    public class HomeController : Controller
    {

        List<People> People = new List<Models.People>()
            {
                new People{Id=1,Name="Name1",City="City1",Phone="Phone1"},
                new People{Id=1,Name="Name2",City="City2",Phone="Phone2"},
                new People{Id=1,Name="Name3",City="City3",Phone="Phone3"},
                new People{Id=1,Name="Name4",City="City4",Phone="Phone4"},
                new People{Id=1,Name="Name5",City="City5",Phone="Phone5"},
                new People{Id=1,Name="Name6",City="City6",Phone="Phone6"},
                new People{Id=1,Name="Name7",City="City7",Phone="Phone7"}
            };
        public ActionResult Index()
        {
            return View(People);
        }

        public PartialViewResult All()
        {
            return PartialView("_People",People);
        }

        public PartialViewResult First3()
        {
            var model = People.OrderBy(x => x.Name).Take(3).ToList();
            return PartialView("_People", model);
        }

        public PartialViewResult Last3()
        {
            var model = People.OrderByDescending(x => x.Name).Take(3).ToList();
            return PartialView("_People", model);
        }

    }
}
using MvcModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcModels.Controllers
{
    public class HomeController : Controller
    {

        private Person[] personData =
      {
            new Person {PersonId = 1, FirstName = "John", LastName = "Doe", Role = Role.Admin},
            new Person {PersonId = 2, FirstName = "Sarah", LastName = "Key", Role = Role.User},
            new Person {PersonId = 3, FirstName = "Boris", LastName = "Low", Role = Role.Guest},
            new Person {PersonId = 4, FirstName = "Kate", LastName = "Bush", Role = Role.User}
        };
        // GET: Home

        //action invoker will check Index method and find int parameter (id), then it will find a model binder responsible for int values and call its BindModel method
        public ActionResult Index(int id = 1)
        {
            Person dataItem = personData.Where(p => p.PersonId == id).First();
            return View(dataItem);
        }

        public ActionResult CreatePerson()
        {
            return View(new Person());
        }

        [HttpPost]
        public ActionResult CreatePerson(Person model)
        {
            return View("Index", model);
        }

        public ActionResult DisplaySummary([Bind(Prefix ="HomeAddress")]AddressSummary summary)
        {
            return View(summary);
        }

        public ActionResult Names(string[] names)
        {
            //creates empty array
            names = names ?? new string[0];
            return View(names);
        }
    }
}
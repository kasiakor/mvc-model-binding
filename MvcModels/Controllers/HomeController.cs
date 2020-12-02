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
        public ActionResult Index(int id)
        {
            Person dataItem = personData.Where(p => p.PersonId == id).First();
            return View(dataItem);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewsDemonstration_3.Models;

namespace ViewsDemonstration_3.Controllers
{
    public class HomeController : Controller
    {
        [NonAction]
        public string TestData()
        {
            return "Getting Test Data";
        }

        // GET: Home
        public ActionResult Index()
        {
            Employee emp = new Employee()
            {
                Id = 101,
                Name = "Abhinav",
                Location = "Banglore",
                Salary = 12345
            };

            ViewBag.ControllerName = "Home";

            return View(emp);
        }

        [ChildActionOnly]
        public ActionResult LoadEmployees()
        {
            List<Employee> empList = new List<Employee>
            {
                new Employee {Id=101,Name="Abhinav",Location="Bangalore",Salary=12345 },
                new Employee {Id=102,Name="Abhishek",Location="Chennai",Salary=23456 },
                new Employee {Id=103,Name="Ajay",Location="Bangalore",Salary=34567 }
            };

            return PartialView("_LoadEmployees", empList);
        }
    }
}
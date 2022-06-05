using BookMyShow.Models;
using BookMyShow.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookMyShow.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customer = GetCustomers();
           return View(customer);
        }

        public ActionResult Details(int? id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);

            //if (customer == null)
            //    return Content("We don't have any customer with that Id.");
            //else
                return View(customer);
        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer{ Id = 1, Name = "John Wick"},
                new Customer{Id = 2, Name = "John Rambo"}
            };
        }
    }
}
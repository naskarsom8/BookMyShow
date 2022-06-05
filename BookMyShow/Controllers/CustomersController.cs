using BookMyShow.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace BookMyShow.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        //Properly disposing the dbContext object.
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Customers
        public ActionResult Index()
        {
            //This is the eager loading method where the related types or 
            //related tables are included along with the primary table using
            //their relationship key or foreign key.
            var customer = _context.Customers.Include(c => c.MembershipType).ToList();
           return View(customer);
        }

        public ActionResult Details(int? id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

            //if (customer == null)
            //    return Content("We don't have any customer with that Id.");
            //else
                return View(customer);
        }

    }
}
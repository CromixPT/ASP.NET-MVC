using System.Collections.Generic;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController:Controller
    {
        List<Customer> customers = new List<Customer>
        {
            new Customer { Id = 1 ,  Name = "Jonh Smith" },
            new Customer { Id = 2 , Name = "Mary Williams" }
        };

        // GET: Customers
        public ActionResult Index()
        {
            var customersList = new CustomerListViewModel
            {
                Customers = customers
            };
            return View(customersList);
        }

        public ActionResult Details(int Id)
        {
            var customer = customers.Find(i => i.Id == Id);

            if(customer != null)
                return View(customer);
            else
                return HttpNotFound();
        }
    }
}

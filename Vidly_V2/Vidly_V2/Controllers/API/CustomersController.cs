using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using Vidly_V2.Models;

namespace Vidly_V2.Controllers.API
{
    public class CustomersController:ApiController
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        //will respond to GET api/custommers
        public IEnumerable<Customer> GetCustomers()
        {
            return _context.Customers.ToList();
        }

        //response to GET api/customer/{id}
        public Customer GetCustomer(int id)
        {
            var customer = _context.Customers.Where(c => c.Id == id).SingleOrDefault();

            if(customer == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return customer;
        }

        //response to POST api/customers
        [HttpPost] // can use the PostCustomer name and avoid the [httpPost] but it is better to explicit apply
        public Customer CreateCustomer(Customer customer)
        {
            if(!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
            _context.Customers.Add(customer);
            _context.SaveChanges();

            return customer;
        }

        //response to PUT api/customer/{id}
        [HttpPut]
        public void UpdateCustomer(int id, Customer customer)
        {
            if(!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
            var customerInDB = _context.Customers.Where(c => c.Id == id).SingleOrDefault();

            if(customerInDB == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            customerInDB.Name = customer.Name;
            customerInDB.BirthDate = customer.BirthDate;
            customerInDB.IsSubscribedToNewsletter = customer.IsSubscribedToNewsletter;
            customerInDB.MembershipTypeId = customer.MembershipTypeId;

            _context.SaveChanges();

        }

        //response to DELETE api/customer/{id}
        [HttpDelete]
        public void DeleteCustomer(int id)
        {
            if(!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }

            var customerInDB = _context.Customers.Where(c => c.Id == id).SingleOrDefault();

            if(customerInDB == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            _context.Customers.Remove(customerInDB);
            _context.SaveChanges();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using AutoMapper;
using Vidly_V2.Dtos;
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
        public IEnumerable<CustomerDto> GetCustomers()
        {
            return _context.Customers.ToList().Select(Mapper.Map<Customer, CustomerDto>);
        }

        //response to GET api/customer/{id}
        public IHttpActionResult GetCustomer(int id)
        {
            var customer = _context.Customers.Where(c => c.Id == id).SingleOrDefault();

            if(customer == null)
            {
                return NotFound();
            }
            return Ok(Mapper.Map<Customer, CustomerDto>(customer));
        }

        //response to POST api/customers
        [HttpPost] // can use the PostCustomer name and avoid the [httpPost] but it is better to explicit apply
        public IHttpActionResult CreateCustomer(CustomerDto customerDto)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }
            var customer = Mapper.Map<CustomerDto, Customer>(customerDto);
            _context.Customers.Add(customer);
            _context.SaveChanges();

            customerDto.Id = customer.Id;

            return Created(new Uri(Request.RequestUri + "/" + customer.Id), customerDto);
        }

        //response to PUT api/customer/{id}
        [HttpPut]
        public void UpdateCustomer(int id, CustomerDto customerDto)
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
            Mapper.Map(customerDto, customerInDB);

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

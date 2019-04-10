using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using vidz.DTOs;
using vidz.Models;
using System.Data.Entity;

namespace vidz.Controllers.Api
{
    public class CustomersController : ApiController
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        // GET /api/customers
        public IHttpActionResult GetCustomers()
        {
            var customersDto =_context.Customers
                .Include(c => c.MembershipType)
                .ToList()
                .Select(Mapper.Map<Customer, CustomerDto>);

            return Ok(customersDto);
        }

        // GET /api/customers/{id}
        public IHttpActionResult GetCustomer(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return NotFound();

            var customerDto =  Mapper.Map<Customer, CustomerDto>(customer);
            return Ok(customerDto);
        }

        // POST /api/customers
        [HttpPost]
        public IHttpActionResult CreateCustomer(CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var customer = Mapper.Map<CustomerDto, Customer>(customerDto);
            _context.Customers.Add(customer);
            _context.SaveChanges();
            customerDto.Id = customer.Id;

            return Created(new Uri(Request.RequestUri + customer.Id.ToString()), customerDto );
        }

        // PUT /api/customers/{id}
        [HttpPut]
        public IHttpActionResult UpdateCustomer(int id, CustomerDto customerDto)
        {
            // Make sure the model passed was valid
            if (!ModelState.IsValid)
                return BadRequest();
            
            // query database for instance of model with the passed ID
            var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == id);

            // if no customer in database with that id, return 404
            if (customerInDb == null)
                return NotFound();

            Mapper.Map(customerDto, customerInDb);
            
             // save changes to instance
            _context.SaveChanges();
            return StatusCode(HttpStatusCode.NoContent);
        }

        // DELETE /api/customers/{id}
        [HttpDelete]
        public IHttpActionResult DeleteCustomer(int id)
        {
            var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customerInDb == null)
                return NotFound();

            _context.Customers.Remove(customerInDb);
            _context.SaveChanges();
            return StatusCode(HttpStatusCode.NoContent);
        }
    }
}

using Club.ApiNew.Models;
using Club.Core.Models;
using Club.Core.Services;
using Club.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Club.ApiNew.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        // GET: api/<CustomerController>
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        public List<Customer> Get()
        {
            return _customerService.Get();
        }

        // GET api/<CustomerController>/5
        [HttpGet("customer/{id}")]
        public Customer Get(int id)
        {
            return _customerService.Get(id);
        }

        // POST api/<CustomerController>
        [HttpPost]
        public void Post([FromBody] CustomerDTO customer)
        {
            var customerToAdd = new Customer { Name = customer.Name, Phone = customer.Phone, Address = customer.Address, City = customer.City, BirthDay = customer.BirthDay };
          
            _customerService.Post(customerToAdd);
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}/{adress}")]
        public void Put(int id, [FromBody] string value)
        {
            _customerService.Put(id, value);
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _customerService.Delete(id);
        }
    }
}

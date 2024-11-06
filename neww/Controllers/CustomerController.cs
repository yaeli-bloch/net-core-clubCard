using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace neww.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        // GET: api/<CustomerController>
        [HttpGet]
        public List<Customer> Get()
        {
            return help.listCustomer;
        }

        // GET api/<CustomerController>/5
        [HttpGet("customer/{id}")]
        public Customer Get(string id)
        {
            return help.listCustomer.Find(customer=> customer.Id == id);
        }

        // POST api/<CustomerController>
        [HttpPost("/{id}/{name}/{phone}/{city}/{adress}")]
        public void Post(string id, string name, string phone, string city, string adress)
        {
            Customer c = new Customer(id, name, phone, city, adress, new DateTime());            
            help.listCustomer.Add(c);
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

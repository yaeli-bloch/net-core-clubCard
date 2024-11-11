using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace neww.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IDataContext? _context;
        public CustomerController(IDataContext? context)
        {
            _context = context;
        }
        // GET: api/<CustomerController>
        [HttpGet]
        public List<Customer> Get()
        {
            return _context.listCustomer;
        }

        // GET api/<CustomerController>/5
        [HttpGet("customer/{id}")]
        public Customer Get(string id)
        {
            return _context.listCustomer.Find(customer=> customer.Id == id);
        }

        // POST api/<CustomerController>
        [HttpPost("/{id}/{name}/{phone}/{city}/{adress}")]
        public void Post(string id, string name, string phone, string city, string adress)
        {
            Customer c = new Customer(id, name, phone, city, adress, new DateTime());
            _context.listCustomer.Add(c);
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

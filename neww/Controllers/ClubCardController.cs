using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace neww.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClubCardController : ControllerBase
    {
        private readonly IDataContext _context;
        public ClubCardController(IDataContext context)
        {
            _context=context;
        }
        // GET: api/<ClubCardController>
        [HttpGet]
        public IEnumerable<Clubcard> Get()
        {
            return _context.ClubCards;
        }

        // GET api/<ClubCardController>/5
        [HttpGet("customer/{id}")]
        public ActionResult Get(string id)
        {
            Clubcard c1 = _context.ClubCards.Find(club => club.Customer.Id == id);
            if (c1 == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(c1);
            }
        }
        [HttpGet("manager/{password}")]
        public List<Clubcard> Get(int password)
        {
            if (password == _context.PassWord)
                return _context.ClubCards;
            return new List<Clubcard>();
        }
        //POST api/<ClubCardController>
        [HttpPost("/{id}/{name}/{phone}/{city}/{adress}/{worker}")]
        public void Post(string id,string name ,string phone,string city,string adress,string workerId)
        {
            Customer c = new Customer(id,name,phone,city,adress, new DateTime());
            Clubcard newcard = new Clubcard(_context.ClubCards.Count(),c,new DateTime());
            foreach (var work in _context.listWorkers)
            {
              if(work.Id == id)
              {
                    work.NumCustomer++;
              }
            }
            _context.ClubCards.Add(newcard);
        }

        // PUT api/<ClubCardController>/5
        [HttpPut("/{id}/{sum}")]
        public void Put( string id, double sum)
        {
            Clubcard clubCard = _context.ClubCards.Find(club => club.Customer.Id == id);
            if (clubCard != null)
            {
                clubCard.NumPoint += (int)sum / 50;
            }
            else
            {
                Console.WriteLine("there isnt");
            }
            
           
        }
        // DELETE api/<ClubCardController>/5
        [HttpDelete("/{id}")]
        public void Delete(int id)
        {
        }
    }
}

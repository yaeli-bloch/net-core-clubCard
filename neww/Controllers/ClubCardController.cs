using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace neww.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClubCardController : ControllerBase
    {                      
        // GET: api/<ClubCardController>
        [HttpGet]
        public List<Clubcard> Get()
        {
            return help.ClubCards;
        }

        // GET api/<ClubCardController>/5
        [HttpGet("customer/{id}")]
        public Clubcard Get( string id)
        {
            return help.ClubCards.Find(club => club.Customer.Id == id);
        }
        [HttpGet("manager/{password}")]
        public List<Clubcard> Get(int password)
        {
            if (password == help.PassWord)
                return help.ClubCards; 
           return new List<Clubcard>();
        }
        // POST api/<ClubCardController>
        [HttpPost("/{id}/{name}/{phone}/{city}/{adress}/{worker}")]
        public void Post(string id,string name ,string phone,string city,string adress,string workerId)
        {
            Customer c = new Customer(id,name,phone,city,adress, new DateTime());
            Clubcard newcard = new Clubcard(help.ClubCards.Count(),c,new DateTime());
            foreach (var work in help.listWorkers)
            {
              if(work.Id == id)
              {
                    work.NumCustomer++;
              }
            }
            help.ClubCards.Add(newcard);
        }

        // PUT api/<ClubCardController>/5
        [HttpPut("/{id}/{sum}")]
        public void Put( string id, double sum)
        {
            Clubcard clubCard = help.ClubCards.Find(club => club.Customer.Id == id);
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

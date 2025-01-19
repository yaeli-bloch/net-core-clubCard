using Microsoft.AspNetCore.Mvc;
using Club.Core.Models;
using Club.Core.Services;
using Club.ApiNew.Models;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Club.ApiNew.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClubCardController : ControllerBase
    {
        private readonly IClubCardService clubCardService;
        public ClubCardController(IClubCardService clubCardService)
        {
            this.clubCardService = clubCardService;
        }

        // GET: api/<ClubCardController>
        [HttpGet]
        public IEnumerable<Clubcard> Get()
        {
            return clubCardService.Get();
        }

        // GET api/<ClubCardController>/5
        [HttpGet("customer/{identity}")]
        public ActionResult Get(int id)
        {
            Clubcard c1 = clubCardService.Get(id);
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
        public List<Clubcard> Get1(int password)
        {
            return clubCardService.Get1(password);
        }
        //POST api/<ClubCardController>
        [HttpPost]
        public void Post([FromBody] ClubCardDTO clubCard)
        {
            var newcard = new Clubcard { IdCustomer = clubCard.IdCustomer, DateOfJoin = new DateTime(), WorkerId = clubCard.WorkerId };

            clubCardService.Post(newcard);
        }

        // PUT api/<ClubCardController>/5
        [HttpPut("/{id}/{sum}")]
        public void Put(int id, double sum)
        {
          clubCardService.Put(id, sum);
        }
        // DELETE api/<ClubCardController>/5
        [HttpDelete("/{id}")]
        public void Delete(int id)
        {

        }
    }
}

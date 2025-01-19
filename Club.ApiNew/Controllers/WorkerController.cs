using Club.ApiNew.Models;
using Club.Core.Models;
using Club.Core.Services;
using Microsoft.AspNetCore.Mvc;



// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Club.ApiNew.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkerController : ControllerBase
    {
        private readonly IWorkerService _iworkerService;
        public WorkerController(IWorkerService iworkerService)
        {
            _iworkerService = iworkerService;
        }
        // GET: api/<WorkerController>
        [HttpGet]
        public List<Worker> Get()
        {
            return _iworkerService.Get1();
        }

        // GET api/<WorkerController>/5
        [HttpGet("{id}")]
        public Worker Get(int id)
        {
            return _iworkerService.Get(id);
        }
        [HttpGet("point/{id}")]
        public List<Clubcard> Getp(int id)
        {
            return _iworkerService.Getp(id);
        }

        // POST api/<WorkerController>
        [HttpPost]
        public void Post([FromBody] WorkerDTO worker)
        {
            //var workerToAdd = new Worker { Name = worker.Name, Phone = worker.Phone, City = worker.City, Address = worker.Address };
            var workerToAdd = new Worker
            {
                Name = worker.Name,
                Phone = worker.Phone,
                City = worker.City,
                Address = worker.Address
            };
            _iworkerService.Post(workerToAdd);
        }

        // PUT api/<WorkerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            _iworkerService.Put(id, value);
        }

        // DELETE api/<WorkerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _iworkerService.Delete(id);
        }
    }
}

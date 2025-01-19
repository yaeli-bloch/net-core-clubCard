using Club.Core.Models;
using Club.Core.Repsitories;
using Club.Core.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Club.ApiNew.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class saleController : ControllerBase
    {
        private readonly ISaleService _isaleService;
        public saleController(ISaleService isaleService)
        {
            _isaleService = isaleService;
        }
        // GET: api/<saleController>
        [HttpGet]
        public List<Sale> Get()
        {
            return _isaleService.Get();
        }

        // GET api/<saleController>/5
        [HttpGet("{id}")]
        public Sale Get(int id)
        {
            return _isaleService.Get(id);
        }

        // POST api/<saleController>
        [HttpPost("{password}")]
        public void Post(int password, [FromBody] Sale sale)
        {
            _isaleService.Post(password, sale);
        }

        // PUT api/<saleController>/5
        [HttpPut("{id}/{password}")]
        public void Put(int id, int password, [FromBody] Sale sale)
        {
            _isaleService.Put(id, password, sale);
        }

        // DELETE api/<saleController>/5
        [HttpDelete("{id}/{password}")]
        public void Delete(int id, int password)
        {
            _isaleService.Delete(id, password);
        }
    }
}

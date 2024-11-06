using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace neww.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class saleController : ControllerBase
    {
        // GET: api/<saleController>
        [HttpGet]
        public List<Sale> Get()
        {
            return help.listSales;
        }

        // GET api/<saleController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<saleController>
        [HttpPost("{password}")]
        public void Post(int password,[FromBody] Sale sale)
        {
            if (password == help.PassWord)
            {
               help.listSales.Add(sale);
            }
            
        }

        // PUT api/<saleController>/5
        [HttpPut("{id}/{password}")]
        public void Put(int id,int password, [FromBody] Sale sale)
        {
          if(password == help.PassWord)
            {
              Sale s1 = help.listSales.Find(sale => sale.Id == id);
                if (s1 != null)
                {
                    s1.Start = sale.Start; 
                    s1.End = sale.End;
                    s1.Saledetail = sale.Saledetail;

                }
            }
        }

        // DELETE api/<saleController>/5
        [HttpDelete("{id}/{password}")]
        public void Delete(int id,int password)
        {
            Sale s1 = help.listSales.Find(sale => sale.Id == id);
            if (s1 != null)
            {
                s1.Status = false;
            }
        }
    }
}

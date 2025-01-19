using Club.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Club.Core.Repositories
{
    public interface ISaleRepository
    {
        public List<Sale> Get();
        public Sale Get(int id);
        public void Post(int password, Sale sale);
        public void Put(int id, int password, Sale sale);
        public void Delete(int id, int password);
       
    }
}

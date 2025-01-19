using Club.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Club.Core.Repositories
{
    public interface IWorkerRepository
    {
        public List<Worker> Get();

        public Worker Get(int id);


        public List<Clubcard> Getp(int id);


        public void Post(Worker worker);

        public void Put(int id, string value);

        public void Delete(int id);
        
    }
}

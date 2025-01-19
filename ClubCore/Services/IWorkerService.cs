using Club.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Club.Core.Services
{
    public interface IWorkerService
    {
        public List<Worker> Get1();

        public Worker Get(int id);


        public List<Clubcard> Getp(int id);


        public void Post(Worker worker);

        public void Put(int id, string value);

        public void Delete(int id);
        
    }
}

using Club.Core.Models;
using Club.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Club.Core.Services
{
    public interface IClubCardService
    {
        public IEnumerable<Clubcard> Get();

        public Clubcard Get(int id);

        public List<Clubcard> Get1(int password);

        public void Post(Clubcard clubCard);

        public void Put(int id, double sum);

        public void Delete(int id);
        
    }
}

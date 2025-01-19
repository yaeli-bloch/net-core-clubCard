using Club.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Club.Core.Repositories
{
    public interface IClubCardRepository
    {
         IEnumerable<Clubcard> Get();
         Clubcard Get(int id);
         List<Clubcard> Get1(int password);
         void Post(Clubcard clubCard);
         void Put(int id, double sum);
         void Delete(int id);
    }
}

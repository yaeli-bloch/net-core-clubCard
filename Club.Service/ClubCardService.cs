
using Club.Core.Models;
using Club.Core.Repositories;
using Club.Core.Services;

namespace Club.Service
{
    public class ClubCardService:IClubCardService
    {
        private readonly IClubCardRepository _IclubCardRepository;
        public ClubCardService(IClubCardRepository IclubCardRepository)
        {
            _IclubCardRepository= IclubCardRepository;
        }
         public IEnumerable<Clubcard> Get()
         {
            return _IclubCardRepository.Get();
         }
        public Clubcard Get(int id)
        {
            return _IclubCardRepository.Get(id);
        }
        public List<Clubcard> Get1(int password)
        {
            return _IclubCardRepository.Get1(password);
        }
        public void Post(Clubcard clubCard)
        {
             _IclubCardRepository.Post( clubCard);
        }
        public void Put(int id, double sum)
        {
             _IclubCardRepository.Put(id, sum);
        }
        public void Delete(int id)
        {
            
        }
    }
}

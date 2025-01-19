using Club.Core.Repositories;
using Club.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Club.Data.Repositories
{
    public class ClubCardRepository : IClubCardRepository
    {
        private readonly DataContext _context;
        public ClubCardRepository(DataContext context)
        {
            _context =context;
        }
        public IEnumerable<Clubcard> Get()
        {
            return _context.ClubCards.Include(u=>u.Worker);
        }
        public Clubcard Get(int id)
        {
            return _context.ClubCards
               .Include(u => u.Worker)
                .FirstOrDefault(club => club.IdCustomer== id);           
        }
        public List<Clubcard> Get1(int password)
        {
            if (password == _context.PassWord)
                return _context.ClubCards
                    .Include(u => u.Worker)
                    .ToList();
            return new List<Clubcard>();
        }
        public void Post(Clubcard clubCard)
        {            
           // Clubcard newcard = new Clubcard { IdCustomer = id, DateOfJoin= new DateTime() , WorkerId =worker.Id};
            foreach (var work in _context.listWorkers)
            {
                if (work.Id == clubCard.WorkerId)
                {
                    if (work.ClubCards == null)
                    {
                        work.ClubCards = new List<Clubcard>(); // אתחול הרשימה אם היא לא קיימת
                    }
                    work.ClubCards.Add(clubCard);
                }
            }
            _context.ClubCards.Add(clubCard);
            _context.SaveChanges();
        }
        public void Put(int id, double sum)
        {
            Clubcard clubCard = _context.ClubCards.FirstOrDefault(club => club.IdCustomer == id);
            if (clubCard != null)
            {
                clubCard.NumPoint += (int)sum / 50;
            }
            else
            {
                Console.WriteLine("there isnt");
            }
            _context.SaveChanges();

        }
        public void Delete(int id)
        {
            _context.SaveChanges();

        }

    }
}

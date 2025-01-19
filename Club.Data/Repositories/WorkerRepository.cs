using Club.Core.Models;
using Club.Core.Repositories;
using Club.Core.Repsitories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Club.Data.Repositories
{
    public class WorkerRepository: IWorkerRepository 
    {
        private readonly DataContext _context;
        public WorkerRepository(DataContext context)
        {
            _context = context;
        }       
        public List<Worker> Get()
        {
            return _context.listWorkers.Include(p=>p.ClubCards).ToList();
        }
        public Worker Get(int id)
        {
            return _context.listWorkers.Include(p => p.ClubCards).FirstOrDefault(work => work.Id == id);
        }
        public List<Clubcard> Getp(int id)
        {
             return _context.listWorkers.FirstOrDefault(work => work.Id == id).ClubCards.ToList();
           
        }
        
        public void Post( Worker worker)
        {
            _context.listWorkers.Add(worker);
            _context.SaveChanges();

        }
        public void Put(int id, string value)
        {
            _context.SaveChanges();

        }
        public void Delete(int id)
        {
            _context.SaveChanges();

        }
    }
}

using Club.Core.Models;
using Club.Core.Repositories;
using Club.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Club.Service
{
    public class WorkerService:IWorkerService
    {
        private IWorkerRepository _WorkerService;
        public WorkerService(IWorkerRepository workerRepository)
        {
            _WorkerService = workerRepository;
        }
        
        public List<Worker> Get1()
        {
            return _WorkerService.Get();
        }
        public Worker Get(int id)
        {
            return _WorkerService.Get(id);
        }

        public List<Clubcard> Getp(int id)
        {
            return _WorkerService.Getp(id);
        }

        public void Post(Worker worker)
        {
            _WorkerService.Post(worker);
        }
        public void Put(int id, string value)
        {
            _WorkerService.Put(id, value);
        }
        public void Delete(int id)
        {
            _WorkerService.Delete(id);
        }
    }
}

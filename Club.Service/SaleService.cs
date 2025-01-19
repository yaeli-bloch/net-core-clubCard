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
    public class SaleService:ISaleService
    {
        private readonly ISaleRepository _isaleRepository;
        public SaleService(ISaleRepository saleRepository)
        {
            _isaleRepository = saleRepository;
        }
        public List<Sale> Get()
        {
            return _isaleRepository.Get();
        }
        public Sale Get(int id)
        {
            return _isaleRepository.Get(id);
        }

        public void Post(int password, Sale sale)
        {
            _isaleRepository.Post(password, sale);

        }

        public void Put(int id, int password, Sale sale)
        {
            _isaleRepository.Put(id, password, sale);
        }
        public void Delete(int id, int password)
        {
            _isaleRepository.Delete(id, password);
        }
    }
}

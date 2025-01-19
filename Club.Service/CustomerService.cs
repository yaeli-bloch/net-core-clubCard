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
    public class CustomerService:ICustomerService
    {
        private readonly ICustomerRepository _icustomerRepository;
        public CustomerService(ICustomerRepository icustomerRepository)
        {
            _icustomerRepository = icustomerRepository;
        }
        public List<Customer> Get()
        {
           return _icustomerRepository.Get();
        }
        public Customer Get(int id)
        {
           return _icustomerRepository.Get(id);
        }
        public void Post(Customer customer)
        {
            _icustomerRepository.Post(customer);
        }
        public void Put(int id, string value)
        {
            _icustomerRepository.Put(id, value);
        }
        public void Delete(int id)
        {
            _icustomerRepository.Delete(id);
        }
    }
}

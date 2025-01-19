using Club.Core.Models;
using Club.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Club.Core.Services
{
    public interface ICustomerService
    {
        public List<Customer> Get();

        public Customer Get(int id);

        public void Post(Customer customer);

        public void Put(int id, string value);

        public void Delete(int id);
        
    }
}

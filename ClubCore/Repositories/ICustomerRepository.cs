using Club.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Club.Core.Repositories
{
    public interface ICustomerRepository
    {
        public List<Customer> Get();
        public Customer Get(int id);
        public void Post(Customer customer);
        public void Put(int id, string value);
        public void Delete(int id);
    }
}

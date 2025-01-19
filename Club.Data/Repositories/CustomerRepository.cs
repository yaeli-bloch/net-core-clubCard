using Club.Core.Models;
using Club.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Club.Data.Repositories
{
    public class CustomerRepository: ICustomerRepository
    {
        private DataContext _context;
        public CustomerRepository(DataContext context)
        {
            _context = context;
        }
        public List<Customer> Get()
        {
            return _context.listCustomer.ToList();
        }
        public Customer Get(int id)
        {
            return _context.listCustomer.FirstOrDefault(customer => customer.Id == id);
        }
        public void Post(Customer customer)
        {
            //Customer c = new Customer(id, name, phone, city, adress, new DateTime());
            _context.listCustomer.Add(customer);
            _context.SaveChanges();
        }
        public void Put(int id,  string value)
        {
            _context.listCustomer.FirstOrDefault(customer => customer.Id == id).SetAdress(value);
            _context.SaveChanges();

        }
        public void Delete(int id)
        {
            _context.SaveChanges();

        }
    }
}

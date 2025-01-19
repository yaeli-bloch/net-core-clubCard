using Club.Core.Models;
using Club.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Club.Data.Repositories
{
    public class SaleRepository:ISaleRepository
    {
        private DataContext _context;
        public SaleRepository(DataContext context)
        {
            _context = context;
        }
        public List<Sale> Get()
        {
            return _context.listSales.ToList();
        }               
        public Sale Get(int id)
        {
            return _context.listSales.FirstOrDefault(sale => sale.Id == id);
        }       
        
        public void Post(int password, Sale sale)
        {
            //if (password == _context.PassWord)
            //{
                _context.listSales.Add(sale);
            //}
            _context.SaveChanges();
        }

        public void Put(int id, int password, Sale sale)
        {
            //if (password == _context.PassWord)
            //{
                Sale s1 = _context.listSales.FirstOrDefault(sale => sale.Id == id);
                if (s1 != null)
                {
                    s1.Start = sale.Start;
                    s1.End = sale.End;
                    s1.Saledetail = sale.Saledetail;
                }
            //}
            _context.SaveChanges();

        }
        public void Delete(int id, int password)
        {
            Sale s1 = _context.listSales.FirstOrDefault(sale => sale.Id == id);
            if (s1 != null)
            {
                s1.Status = false;
            }
            _context.SaveChanges();

        }
    }
}

using neww;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    internal class FakeContext : IDataContext
    {
        public  List<Clubcard> ClubCards { get; set; }
        public  int Num { get; set; }
        public  int PassWord { get; set; }
        public  List<Sale> listSales { get; set; }
        public  List<Customer> listCustomer { get; set; }
        public  List<Worker> listWorkers { get; set; }
        public FakeContext() 
        {
           ClubCards= new List<Clubcard>() {
            new Clubcard(1,
            new Customer("1","moshe","099","bb","lando",new DateTime()),new DateTime()) };
            Num = 0;
            PassWord = 123;
            listSales = new List<Sale>() { new Sale() };
            listCustomer = new List<Customer>()
           { new Customer("1","moshe","099","bb","lando",new DateTime())};
            listWorkers = new List<Worker>()
            { new Worker("2","levi","088","bb","lando",0)};
        }
    }
}

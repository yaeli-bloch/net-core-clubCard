using System.ComponentModel.DataAnnotations;

namespace Club.Core.Models
{
    public class Worker
    {       
        public int Id { get; set; }
        public string Name { get; set; }   
        public string Phone { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public  List<Clubcard> ClubCards{ get; set; }
        public Worker() { } 

        public Worker( string name, string phone, string city, string address)
        {
           
            Name = name;
            Phone = phone;
            City = city;
            Address = address; 
            ClubCards= new List<Clubcard> { new Clubcard()};
        }

        public Worker Include(Func<object, object> value)
        {
            throw new NotImplementedException();
        }
    }
}

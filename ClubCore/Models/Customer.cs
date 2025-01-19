using System.ComponentModel.DataAnnotations;

namespace Club.Core.Models
{
    public class Customer
    {
        [Key]
        public int Id {get; set;}
        public string Name {get; set;}
        public string Phone {get; set;}
        public string City {get; set;}
        public string Address {get; set;}
        public DateTime BirthDay {get; set;}
        public Clubcard Clubcard {get; set;}
        public Customer(){ }
        public Customer(int id, string name, string phone, string city, string address, DateTime birthDay)
        {
            Id = id;
            Name = name;
            Phone = phone;
            City = city;
            Address = address;
            BirthDay = birthDay;            
        }
        public void SetAdress(string adress)
        {
            this.Address = adress;
        }
    }
}


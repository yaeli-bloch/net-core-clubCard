namespace neww
{
    public class Customer
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public string Address { get; set;}
        public DateTime BirthDay { get; set;}

        public Customer(string id, string name, string phone, string city, string address, DateTime birthDay)
        {
            Id = id;
            Name = name;
            Phone = phone;
            City = city;
            Address = address;
            BirthDay = birthDay;
        }
    }
}


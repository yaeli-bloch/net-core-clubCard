namespace neww
{
    public class Worker
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public Worker(string id, string name, string phone, string city, string address, int numCustomer)
        {
            Id = id;
            Name = name;
            Phone = phone;
            City = city;
            Address = address;
            NumCustomer = numCustomer;
        }

        public string Phone { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public int NumCustomer { get; set; }
    }
}

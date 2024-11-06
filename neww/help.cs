namespace neww
{
    public static class help
    {
        public static List<Clubcard> ClubCards { get; set; } = new List<Clubcard>();
        //List<Clubcard> clubCards = new List<Clubcard>();
        public static int Num { get; set; } = 0;
        public static int PassWord { get; set; } = 123;
        public static List<Sale> listSales { get; set; } = new List<Sale>();
        public static List<Customer> listCustomer { get; set; }= new List<Customer>();
        public static List<Worker> listWorkers { get; set; } = new List<Worker>();
    }
}

namespace neww
{
    public interface IDataContext
    {
          List<Clubcard> ClubCards { get; set; }
          int Num { get; set; }
          int PassWord { get; set; }
          List<Sale>? listSales { get; set; }
          List<Customer>? listCustomer { get; set; }
          List<Worker>? listWorkers { get; set; }
    }
}

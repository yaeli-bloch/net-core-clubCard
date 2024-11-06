namespace neww
{
    public class Clubcard
    {
        
            public int NumCard { get; set; }
            public Customer Customer { get; set; }
            public int NumPoint { get; set; }
            public DateTime DateOfJoin { get; set; }
            public string worker { get; set; }

            public Clubcard(int numCard, Customer customer,  DateTime dateOfJoin)
            {
                this.NumCard = numCard;
                this.Customer = customer;
                this.NumPoint = 0;
                this.DateOfJoin = dateOfJoin;
            }
        
    }
}

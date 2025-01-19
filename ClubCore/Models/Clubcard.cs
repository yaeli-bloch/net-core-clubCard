using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Club.Core.Models
{
    public class Clubcard
    {
            [Key]
            public int Id { get; set; }
            public int IdCustomer { get; set; }
            public Customer Customer { get; set;}
            public int NumPoint { get; set;}
            public DateTime DateOfJoin { get; set; }
           public int WorkerId  { get; set; }           
        public Worker Worker { get; set; }
           public Clubcard() { }
            public Clubcard(int numCard, int idCustomer,Worker worker,DateTime dateOfJoin)
            {
                this.Id = numCard;
                this.IdCustomer = idCustomer;
                this.NumPoint = 0;
                this.DateOfJoin = dateOfJoin;
                this.Worker = worker;
            }

        public Clubcard Include(Func<object, object> value)
        {
            throw new NotImplementedException();
        }
    }
}

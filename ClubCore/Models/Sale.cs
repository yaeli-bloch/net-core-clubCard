using System.ComponentModel.DataAnnotations;

namespace Club.Core.Models
{
    public class Sale
    {
        [Key]
        public int Id { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string Saledetail { get; set; }
        public bool Status { get; set; }
        public Sale() { }
        public Sale(int id, DateTime start, DateTime end, string sale, bool status)
        {
            Id = id;
            Start = start;
            End = end;
            Saledetail = sale;
            Status = status;
        }
    }
}

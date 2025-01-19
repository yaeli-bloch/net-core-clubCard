using Club.Core.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Club.Core.Repsitories
{
    public interface IDataContext
    {
        DbSet<Clubcard> ClubCards { get; set; }
        int Num { get; set; }
        int PassWord { get; set; }
        DbSet<Sale>? listSales { get; set; }
        DbSet<Customer>? listCustomer { get; set; }
        DbSet<Worker>? listWorkers { get; set; }
    }
}

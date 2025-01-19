using Club.Core.Models;
using Club.Core.Repsitories;
using Microsoft.EntityFrameworkCore;

namespace Club.Data 
{
    public class DataContext : DbContext, IDataContext
    {
        public DbSet<Clubcard> ClubCards {get; set;}
        public int Num { get; set;}
        public int PassWord { get; set;}
        public DbSet<Sale> listSales {get; set;}
        public DbSet<Customer> listCustomer {get; set;}
        public DbSet<Worker> listWorkers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=sample_db");
            optionsBuilder.UseSqlServer("Server=localhost;Database=sample_db;Integrated Security=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clubcard>()
                .HasOne(c => c.Customer)
                .WithOne(c => c.Clubcard)
                .HasForeignKey<Clubcard>(c => c.IdCustomer);
        }

    }
}

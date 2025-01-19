//using Club.Core.Models;
using Club.Core.Repositories;
using Club.Core.Services;
using Club.Data;
using Club.Data.Repositories;
using Club.Service;
using System.Text.Json.Serialization;

namespace Club.ApiNew
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            // Add services to the container.

            // לוג מידע שמודיע שהאפליקציה מתחילה

            builder.Services.AddControllers().AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
                options.JsonSerializerOptions.WriteIndented = true;
            });
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            // builder.Services.AddScoped<IDataContext, DataContext>();
            builder.Services.AddScoped<IClubCardService, ClubCardService>();
            builder.Services.AddScoped<ICustomerService, CustomerService>();
            builder.Services.AddScoped<IClubCardRepository, ClubCardRepository>();
            builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
            builder.Services.AddScoped<ISaleRepository, SaleRepository>();
            builder.Services.AddScoped<ISaleService, SaleService>();
            builder.Services.AddScoped<IWorkerRepository, WorkerRepository>();
            builder.Services.AddScoped<IWorkerService, WorkerService>();
            builder.Services.AddDbContext<DataContext>();
           // builder.Services.AddSingleton<DataContext>();           

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}

using JobHunt_Interface.Implementation;
using JobHunt_Interface.Interface;
using JobHunt_Models.Database;
using Microsoft.EntityFrameworkCore;

namespace JonHunt_API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //databse connection
            /*#getting the connection string from appsettings*/
            string? con = builder.Configuration.GetConnectionString("DefaultConnection");
            //connecting db
            builder.Services.AddDbContext<jobHuntContext>(builder => { builder.UseSqlServer(con);  }) ;
            // Add services to the container.
           
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            //adding serivices
            builder.Services.AddScoped<IUser, UserImplementation>();

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
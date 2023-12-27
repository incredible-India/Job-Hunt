
using JobHunt_Interface.Implementation;
using JobHunt_Interface.Interface;
using JobHunt_Models.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using JonHunt_API.Authentication;

namespace JonHunt_API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            //adding authentication
            builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(option =>
            {
                option.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidIssuer = builder.Configuration["jwt:Issuer"],
                    ValidAudience = builder.Configuration["jwt:Audience"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["jwt:Key"]))

                };
            });
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
            builder.Services.AddScoped<IJobSeeker, JobSeekerImplementation>();
            builder.Services.AddScoped<IJobProvider, JobProviderImplementation>();
            builder.Services.AddScoped<IAuthentication, JonHunt_API.Authentication.Authentication>();
            builder.Services.AddCors();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseCors();
            app.UseCors(builder => builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());
            app.MapControllers();

            app.Run();
        }
    }
}

using Car_Rental_APIs.Models;
using Car_Rental_APIs.Services;
using Car_Rental_APIs.UnitOfWorks;
using CarRentalWebAPI.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace Car_Rental_APIs
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string allowCors = "";
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<RentalDbContext>(option => option.UseLazyLoadingProxies().UseSqlServer(builder.Configuration.GetConnectionString("CarRentalConnection")));
            builder.Services.AddIdentity<ApplicationUser, IdentityRole>().AddEntityFrameworkStores<RentalDbContext>();
            builder.Services.AddHostedService<NotificationScheduler>();

            builder.Services.AddCors(options =>
            { 
                options.AddPolicy(allowCors, builder =>
                {
                    builder.AllowAnyOrigin();
                    builder.AllowAnyMethod();
                    builder.AllowAnyHeader();
                });
            });

            builder.Services.AddAuthentication(options => options.DefaultAuthenticateScheme = "my schema")
            .AddJwtBearer("my schema", opt =>
            {
                string keyString = "StrongKey5369854426ForHashingClaims8856";
                var key = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(keyString));
                opt.TokenValidationParameters = new TokenValidationParameters()
                {
                    IssuerSigningKey = key,
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });

            builder.Services.AddScoped<UnitOfWork>();
            builder.Services.AddScoped<CarService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.UseCors(allowCors);

            app.MapControllers();

            app.Run();
        }
    }
}

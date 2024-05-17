
using Car_Rental_APIs.GenericRepo;
using Car_Rental_APIs.Models;
using Car_Rental_APIs.Services;
using Car_Rental_APIs.UnitOfWorks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using PayPal;
using System.Collections.Generic;
using System.Text;
using PayPal.Api;

namespace Car_Rental_APIs
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string allowCors = "";

            var builder = WebApplication.CreateBuilder(args);
            var configuration = builder.Configuration;

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<RentalDbContext>(option => option.UseLazyLoadingProxies().UseSqlServer(builder.Configuration.GetConnectionString("CarRentalConnection")));
            builder.Services.AddIdentity<ApplicationUser, IdentityRole>().AddEntityFrameworkStores<RentalDbContext>();

            builder.Services.AddCors(options =>
            {
                options.AddPolicy(allowCors, builder =>
                {
                    builder.AllowAnyOrigin();
                    builder.AllowAnyMethod();
                    builder.AllowAnyHeader();
                });
            });
            //for jwt token [authorize]

            builder.Services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            }

            ).AddJwtBearer(options =>
            {
                options.SaveToken = true;
                options.RequireHttpsMetadata = false;
                options.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuer = true,
                    ValidIssuer = configuration["JWT:ValidIssuer"],
                    ValidateAudience = true,
                    ValidAudience = configuration["JWT:ValidAudiance"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:Secret"]))
                };
            }
            );

            ///swagger configuration
            ///

            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Car_Rental_Api", Version = "v1" });
                // Define the BearerAuth security scheme
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description = "JWT Authorization header using the Bearer scheme. Example: \"Authorization: Bearer {token}\"",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.Http,
                    Scheme = "bearer",
                    BearerFormat = "JWT"
                });
                // Apply the security globally
                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            }
                        },
                        Array.Empty<string>()
                    }
                });
            });

            builder.Services.AddScoped<UnitOfWork>();

            var clientid = configuration["paypal:clientid"];
            var clientsecret = configuration["paypal:clientsecret"];
            var config = new Dictionary<string, string>
            {
                { "mode", configuration["paypal:mode"] },
                { "clientid", configuration["paypal:clientid"] },
                { "clientsecret", configuration["paypal:clientsecret"] },
                { "url", configuration["paypal:url"] },
                { "connectiontimeout", configuration["paypal:connectiontimeout"] },
                { "requestretries", configuration["paypal:requestretries"] }
            };

            var accesstoken = new PayPal.Api.OAuthTokenCredential(clientid, clientsecret, config).GetAccessToken();
            var apicontext = new PayPal.Api.APIContext(accesstoken)
            {
                Config = config
            };

            builder.Services.AddSingleton(apicontext);
            builder.Services.AddScoped<PaypalRepo, PaypalService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
                    // Enable the UI to include the JWT token input field
                    c.OAuthClientId("your-client-id"); // This is not used in the JWT flow, but is required for the UI
                    c.OAuthAppName("Swagger UI");
                    c.OAuthUsePkce();
                });
            }
            app.UseStaticFiles();

            app.UseCors(allowCors);

            app.UseAuthentication();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}

using Car_Rental_APIs.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Drawing;
using static Car_Rental_APIs.Models.Utilities;

namespace Car_Rental_APIs.Models
{
    public class RentalDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<CustomerRentCar> customerRentCars { get; set; }
        public DbSet<purchase> purchases { get; set; }

        public RentalDbContext() { }
        public RentalDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Car Records...
            modelBuilder.Entity<Car>().HasData(
                    new Car
                    {
                        PlateNumber = "ABC123",
                        ChassisNumber = "CHS123",
                        Make = "Toyota",
                        Color = "Red",
                        RentalPrice = 100,
                        Model = "Camry",
                        Variant = "LE",
                        State = StateEnum.Available,
                        Transmission = TransmissionEnum.Automatic,
                        Type = TypeEnum.Sedan,
                        Mileage = 10000,
                        NumberOfPassengers = 4,
                       
                    },
                   new Car
                   {
                       PlateNumber = "BBB001",
                       ChassisNumber = "CHS021",
                       Make = "BMW",
                       Color = "Black",
                       RentalPrice = 2500,
                       Model = "X7",
                       Variant = "xDrive40i",
                       State = StateEnum.Available,
                       Transmission = TransmissionEnum.Automatic,
                       Type = TypeEnum.SUV,
                       Mileage = 1500,
                       NumberOfPassengers = 7,
                       PhotoUrl = "EZ-Wheels//wwwroot//uploads//bmw-m3-4d-black-2022.png"
                   },
                 new Car
                 {
                     PlateNumber = "BBB002",
                     ChassisNumber = "CHS022",
                     Make = "Jeep",
                     Color = "White",
                     RentalPrice = 3000,
                     Model = "Wrangler",
                     Variant = "Sport",
                     State = StateEnum.Rented,
                     Transmission = TransmissionEnum.Automatic,
                     Type = TypeEnum.SUV,
                     Mileage = 20000,
                     NumberOfPassengers = 4,
                     PhotoUrl = "EZ-Wheel//wwwroot//uploads//jeep-grand-cherokee-5d-weiss-2018.png"
                 },
                 new Car
                 {
                     PlateNumber = "BBB003",
                     ChassisNumber = "CHS023",
                     Make = "Hyundai",
                     Color = "Black",
                     RentalPrice = 2200,
                     Model = "Santa Cruz",
                     Variant = "SE",
                     State = StateEnum.Available,
                     Transmission = TransmissionEnum.Automatic,
                     Type = TypeEnum.SUV,
                     Mileage = 5000,
                     NumberOfPassengers = 5,
                     PhotoUrl = "EZ-Wheels//wwwroot//uploads//hyundai-kona-suv-black-2024.png"
                 },
                 new Car
                 {
                     PlateNumber = "BBB004",
                     ChassisNumber = "CHS024",
                     Make = "Chevrolet",
                     Color = "Black",
                     RentalPrice = 3500,
                     Model = "Suburban",
                     Variant = "Premier",
                     State = StateEnum.Maintenance,
                     Transmission = TransmissionEnum.Automatic,
                     Type = TypeEnum.SUV,
                     Mileage = 10000,
                     NumberOfPassengers = 8,
                     PhotoUrl = "EZ-Wheels//wwwroot//uploads//chevrolet-trailblazer-suv-black-2021.png"
                 },
                 new Car
                 {
                     PlateNumber = "BBB005",
                     ChassisNumber = "CHS025",
                     Make = "BMW",
                     Color = "White",
                     RentalPrice = 2800,
                     Model = "5 Series",
                     Variant = "530i",
                     State = StateEnum.Available,
                     Transmission = TransmissionEnum.Automatic,
                     Type = TypeEnum.Sedan,
                     Mileage = 8000,
                     NumberOfPassengers = 5,
                     PhotoUrl = "EZ-Wheels//wwwroot//uploads//bmw-x5-40i-4d-suv-white-2021.png"
                 },
                 new Car
                 {
                     PlateNumber = "BBB006",
                     ChassisNumber = "CHS026",
                     Make = "Jeep",
                     Color = "Brown",
                     RentalPrice = 3200,
                     Model = "Cherokee",
                     Variant = "Trailhawk",
                     State = StateEnum.Available,
                     Transmission = TransmissionEnum.Automatic,
                     Type = TypeEnum.SUV,
                     Mileage = 12000,
                     NumberOfPassengers = 5,
                     PhotoUrl = "EZ-Wheels//wwwroot//uploads//jeep-wrangler-5d-braun-2018.png"
                 },
                 new Car
                 {
                     PlateNumber = "BBB008",
                     ChassisNumber = "CHS028",
                     Make = "Chevrolet",
                     Color = "White",
                     RentalPrice = 2500,
                     Model = "Blazer",
                     Variant = "RS",
                     State = StateEnum.Available,
                     Transmission = TransmissionEnum.Automatic,
                     Type = TypeEnum.SUV,
                     Mileage = 15000,
                     NumberOfPassengers = 5,
                     PhotoUrl = "EZ-Wheels//wwwroot//uploads//chevrolet-tahoe-suv-white-US-2021.png"
                 },
                 new Car
                 {
                     PlateNumber = "BBB009",
                     ChassisNumber = "CHS029",
                     Make = "BMW",
                     Color = "Blue",
                     RentalPrice = 3000,
                     Model = "X6",
                     Variant = "xDrive40i",
                     State = StateEnum.Available,
                     Transmission = TransmissionEnum.Automatic,
                     Type = TypeEnum.SUV,
                     Mileage = 4000,
                     NumberOfPassengers = 5,
                     PhotoUrl = "EZ-Wheels//wwwroot//uploads//bmw-m8-competition-convertible-2d-blue-2019-JV.png"
                 },
                 new Car
                 {
                     PlateNumber = "BBB012",
                     ChassisNumber = "CHS032",
                     Make = "Chevrolet",
                     Color = "White",
                     RentalPrice = 2400,
                     Model = "Traverse",
                     Variant = "LS",
                     State = StateEnum.Available,
                     Transmission = TransmissionEnum.Automatic,
                     Type = TypeEnum.SUV,
                     Mileage = 7000,
                     NumberOfPassengers = 7,
                     PhotoUrl = "EZ-Wheels//wwwroot//uploads//chevrolet-blazer-suv-white-2023.png"
                 },
                 new Car
                 {
                     PlateNumber = "BBB013",
                     ChassisNumber = "CHS033",
                     Make = "BMW",
                     Color = "Black",
                     RentalPrice = 2800,
                     Model = "X1",
                     Variant = "sDrive28i",
                     State = StateEnum.Available,
                     Transmission = TransmissionEnum.Automatic,
                     Type = TypeEnum.SUV,
                     Mileage = 10000,
                     NumberOfPassengers = 5,
                     PhotoUrl = "EZ-Wheels//wwwroot//uploads//bmw-x5m-suv-4d-black-2023-JV.png"
                 },
                 new Car
                 {
                     PlateNumber = "BBB017",
                     ChassisNumber = "CHS037",
                     Make = "BMW",
                     Color = "Blue",
                     RentalPrice = 2900,
                     Model = "7 Series",
                     Variant = "750i xDrive",
                     State = StateEnum.Maintenance,
                     Transmission = TransmissionEnum.Automatic,
                     Type = TypeEnum.Sedan,
                     Mileage = 15000,
                     NumberOfPassengers = 5,
                     PhotoUrl = "EZ-Wheels//wwwroot//uploads//bmw-x3m-suv-blue-2023.png"
                 },
                 new Car
                 {
                     PlateNumber = "BBB020",
                     ChassisNumber = "CHS040",
                     Make = "BMW",
                     Color = "Silver",
                     RentalPrice = 2300,
                     Model = "Spark",
                     Variant = "LS",
                     State = StateEnum.Available,
                     Transmission = TransmissionEnum.Automatic,
                     Type = TypeEnum.Hatchback,
                     Mileage = 12000,
                     NumberOfPassengers = 4,
                     PhotoUrl = "EZ-Wheels//wwwroot//uploads//bmw-7-4d-silver-2021.png"
                 }



            );

            // Role Records...
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = "1",
                    Name = "SuperAdmin",
                    NormalizedName = "SUPERADMIN"
                },
                new IdentityRole
                {
                    Id = "2",
                    Name = "Employee",
                    NormalizedName = "EMPLOYEE"
                },
                new IdentityRole
                {
                    Id = "3",
                    Name = "Client",
                    NormalizedName = "CLIENT"
                }
            );

            // User Records...
            modelBuilder.Entity<ApplicationUser>().HasData(
               new ApplicationUser
               {
                   Id = "1",
                   Age = 28,
                   PhoneNumber ="01100200300",
                   UserName = "user1@example.com",
                   NormalizedUserName = "USER1@EXAMPLE.COM",
                   Email = "user1@example.com",
                   NormalizedEmail = "USER1@EXAMPLE.COM",
                   EmailConfirmed = true,
                   PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "Password123!") // Hash the password
               },
               new ApplicationUser
               {
                   Id = "2",
                   Age = 30,
                   PhoneNumber = "01020304050",
                   UserName = "user2@example.com",
                   NormalizedUserName = "USER2@EXAMPLE.COM",
                   Email = "user2@example.com",
                   NormalizedEmail = "USER2@EXAMPLE.COM",
                   EmailConfirmed = true,
                   PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "Password123!") // Hash the password
               },
               new ApplicationUser
               {
                   Id = "3",
                   Age = 32,
                   PhoneNumber = "01234567890",
                   UserName = "user3@example.com",
                   NormalizedUserName = "USER3@EXAMPLE.COM",
                   Email = "user3@example.com",
                   NormalizedEmail = "USER3@EXAMPLE.COM",
                   EmailConfirmed = true,
                   PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "Password123!") // Hash the password
               }
            );

            // UserRole Records
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    UserId = "1",
                    RoleId = "1" 
                },
                new IdentityUserRole<string>
                {
                    UserId = "2",
                    RoleId = "2"
                },
                new IdentityUserRole<string>
                {
                    UserId = "3",
                    RoleId = "3"
                });
        }
    }
}
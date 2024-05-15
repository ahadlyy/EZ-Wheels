﻿using Car_Rental_APIs.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using static Car_Rental_APIs.Models.Utilities;

namespace Car_Rental_APIs.Models
{
    public class RentalDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<CustomerRentCar> customerRentCars { get; set; }

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
                    NumberOfPassengers = 4
                },
                new Car
                {
                    PlateNumber = "DEF456",
                    ChassisNumber = "CHS456",
                    Make = "Honda",
                    Color = "Blue",
                    RentalPrice = 120,
                    Model = "Accord",
                    Variant = "EX",
                    State = StateEnum.Available,
                    Transmission = TransmissionEnum.Automatic,
                    Type = TypeEnum.Sedan,
                    Mileage = 12000,
                    NumberOfPassengers = 4
                },
                new Car
                {
                    PlateNumber = "GHI789",
                    ChassisNumber = "CHS789",
                    Make = "Ford",
                    Color = "Black",
                    RentalPrice = 110,
                    Model = "Focus",
                    Variant = "SE",
                    State = StateEnum.Available,
                    Transmission = TransmissionEnum.Automatic,
                    Type = TypeEnum.Sedan,
                    Mileage = 8000,
                    NumberOfPassengers = 4
                },
                new Car
                {
                    PlateNumber = "JKL321",
                    ChassisNumber = "CHS321",
                    Make = "Ford",
                    Color = "Silver",
                    RentalPrice = 90,
                    Model = "Fiesta",
                    Variant = "SE",
                    State = StateEnum.Available,
                    Transmission = TransmissionEnum.Automatic,
                    Type = TypeEnum.Hatchback,
                    Mileage = 7000,
                    NumberOfPassengers = 4
                },
                new Car
                {
                    PlateNumber = "XYZ999",
                    ChassisNumber = "CHS999",
                    Make = "Chevrolet",
                    Color = "White",
                    RentalPrice = 130,
                    Model = "Malibu",
                    Variant = "LT",
                    State = StateEnum.Available,
                    Transmission = TransmissionEnum.Automatic,
                    Type = TypeEnum.Sedan,
                    Mileage = 15000,
                    NumberOfPassengers = 4
                }
            );

            // Customer Rent Car Records...
            modelBuilder.Entity<CustomerRentCar>().HasData(
                new CustomerRentCar
                {
                    ReservationNumber = "RES001",
                    StartingDate = DateTime.UtcNow.AddDays(1),
                    EndingDate = DateTime.UtcNow.AddDays(5),
                    PickUpLatitude = 52.5200,
                    PickUpLongitude = 13.4050,
                    DropOffLatitude = 52.2297,
                    DropOffLongitude = 21.0122
                },
                new CustomerRentCar
                {
                    ReservationNumber = "RES002",
                    StartingDate = DateTime.UtcNow.AddDays(2),
                    EndingDate = DateTime.UtcNow.AddDays(6),
                    PickUpLatitude = 37.7749,
                    PickUpLongitude = -122.4194,
                    DropOffLatitude = 34.0522,
                    DropOffLongitude = -118.2437
                },
                new CustomerRentCar
                {
                    ReservationNumber = "RES003",
                    StartingDate = DateTime.UtcNow.AddDays(3),
                    EndingDate = DateTime.UtcNow.AddDays(7),
                    PickUpLatitude = 40.7128,
                    PickUpLongitude = -74.0060,
                    DropOffLatitude = 33.7490,
                    DropOffLongitude = -84.3880
                },
                new CustomerRentCar
                {
                    ReservationNumber = "RES004",
                    StartingDate = DateTime.UtcNow.AddDays(4),
                    EndingDate = DateTime.UtcNow.AddDays(8),
                    PickUpLatitude = 51.5074,
                    PickUpLongitude = -0.1278,
                    DropOffLatitude = 48.8566,
                    DropOffLongitude = 2.3522
                },
                new CustomerRentCar
                {
                    ReservationNumber = "RES005",
                    StartingDate = DateTime.UtcNow.AddDays(5),
                    EndingDate = DateTime.UtcNow.AddDays(9),
                    PickUpLatitude = 48.8566,
                    PickUpLongitude = 2.3522,
                    DropOffLatitude = 40.7128,
                    DropOffLongitude = -74.0060
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
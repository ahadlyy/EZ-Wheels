﻿// <auto-generated />
using System;
using Car_Rental_APIs.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EZ_Wheels.Migrations
{
    [DbContext(typeof(RentalDbContext))]
    [Migration("20240517123125_seeding all cars")]
    partial class seedingallcars
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Car_Rental_APIs.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "1",
                            AccessFailedCount = 0,
                            Age = 28,
                            ConcurrencyStamp = "dff04722-6e44-40fc-8389-a2eb672365b1",
                            Email = "user1@example.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "USER1@EXAMPLE.COM",
                            NormalizedUserName = "USER1@EXAMPLE.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEB7+O5VTwCm6Tf+RouD4bG7DPB8IMf/oqKk/XfptDTeFsRrfW7TwdLtHHyLKr5PMfg==",
                            PhoneNumber = "01100200300",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "1584503b-8603-4094-b97e-473fb41c2897",
                            TwoFactorEnabled = false,
                            UserName = "user1@example.com"
                        },
                        new
                        {
                            Id = "2",
                            AccessFailedCount = 0,
                            Age = 30,
                            ConcurrencyStamp = "338c52dd-50e5-451f-bb89-1b7853900929",
                            Email = "user2@example.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "USER2@EXAMPLE.COM",
                            NormalizedUserName = "USER2@EXAMPLE.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEPu9JK5HOkaNzSFAqyOqCroD+94di1I4A8XXkuhf0T+9Fp03Lyzcn1RCOVZ9bPc21w==",
                            PhoneNumber = "01020304050",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "4cc69e73-3591-406f-a504-8b639737dcff",
                            TwoFactorEnabled = false,
                            UserName = "user2@example.com"
                        },
                        new
                        {
                            Id = "3",
                            AccessFailedCount = 0,
                            Age = 32,
                            ConcurrencyStamp = "191fd5e7-d0a1-4719-a585-38f34c5999c7",
                            Email = "user3@example.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "USER3@EXAMPLE.COM",
                            NormalizedUserName = "USER3@EXAMPLE.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEGDxEByIn3n6QNfo7vekZd/bRpHCscBYzrzGPIuPpTgPXAxfA748Bcs4B3AKtQSntA==",
                            PhoneNumber = "01234567890",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "82a4674b-ee2a-4d65-b164-f3ae931e475d",
                            TwoFactorEnabled = false,
                            UserName = "user3@example.com"
                        });
                });

            modelBuilder.Entity("Car_Rental_APIs.Models.Car", b =>
                {
                    b.Property<string>("PlateNumber")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ChassisNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Make")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Mileage")
                        .HasColumnType("int");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfPassengers")
                        .HasColumnType("int");

                    b.Property<string>("PhotoUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RentalPrice")
                        .HasColumnType("int");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.Property<int>("Transmission")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<string>("Variant")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PlateNumber");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            PlateNumber = "BBB001",
                            ChassisNumber = "CHS021",
                            Color = "Black",
                            Make = "BMW",
                            Mileage = 1500,
                            Model = "X7",
                            NumberOfPassengers = 7,
                            PhotoUrl = "https://localhost:7108/uploads/bmw-m3-4d-black-2022.png",
                            RentalPrice = 2500,
                            State = 0,
                            Transmission = 1,
                            Type = 0,
                            Variant = "xDrive40i"
                        },
                        new
                        {
                            PlateNumber = "BBB002",
                            ChassisNumber = "CHS022",
                            Color = "White",
                            Make = "Jeep",
                            Mileage = 20000,
                            Model = "Wrangler",
                            NumberOfPassengers = 4,
                            PhotoUrl = "https://localhost:7108/uploads/jeep-grand-cherokee-5d-weiss-2018.png",
                            RentalPrice = 3000,
                            State = 2,
                            Transmission = 1,
                            Type = 0,
                            Variant = "Sport"
                        },
                        new
                        {
                            PlateNumber = "BBB003",
                            ChassisNumber = "CHS023",
                            Color = "Black",
                            Make = "Hyundai",
                            Mileage = 5000,
                            Model = "Santa Cruz",
                            NumberOfPassengers = 5,
                            PhotoUrl = "https://localhost:7108/uploads/hyundai-kona-suv-black-2024.png",
                            RentalPrice = 2200,
                            State = 0,
                            Transmission = 1,
                            Type = 0,
                            Variant = "SE"
                        },
                        new
                        {
                            PlateNumber = "BBB004",
                            ChassisNumber = "CHS024",
                            Color = "Black",
                            Make = "Chevrolet",
                            Mileage = 10000,
                            Model = "Suburban",
                            NumberOfPassengers = 8,
                            PhotoUrl = "https://localhost:7108/uploads/chevrolet-trailblazer-suv-black-2021.png",
                            RentalPrice = 3500,
                            State = 1,
                            Transmission = 1,
                            Type = 0,
                            Variant = "Premier"
                        },
                        new
                        {
                            PlateNumber = "BBB005",
                            ChassisNumber = "CHS025",
                            Color = "White",
                            Make = "BMW",
                            Mileage = 8000,
                            Model = "5 Series",
                            NumberOfPassengers = 5,
                            PhotoUrl = "https://localhost:7108/uploads/bmw-x5-40i-4d-suv-white-2021.png",
                            RentalPrice = 2800,
                            State = 0,
                            Transmission = 1,
                            Type = 1,
                            Variant = "530i"
                        },
                        new
                        {
                            PlateNumber = "BBB006",
                            ChassisNumber = "CHS026",
                            Color = "Brown",
                            Make = "Jeep",
                            Mileage = 12000,
                            Model = "Cherokee",
                            NumberOfPassengers = 5,
                            PhotoUrl = "https://localhost:7108/uploads/jeep-wrangler-5d-braun-2018.png",
                            RentalPrice = 3200,
                            State = 0,
                            Transmission = 1,
                            Type = 0,
                            Variant = "Trailhawk"
                        },
                        new
                        {
                            PlateNumber = "BBB008",
                            ChassisNumber = "CHS028",
                            Color = "White",
                            Make = "Chevrolet",
                            Mileage = 15000,
                            Model = "Blazer",
                            NumberOfPassengers = 5,
                            PhotoUrl = "https://localhost:7108/uploads/chevrolet-tahoe-suv-white-US-2021.png",
                            RentalPrice = 2500,
                            State = 0,
                            Transmission = 1,
                            Type = 0,
                            Variant = "RS"
                        },
                        new
                        {
                            PlateNumber = "BBB009",
                            ChassisNumber = "CHS029",
                            Color = "Blue",
                            Make = "BMW",
                            Mileage = 4000,
                            Model = "X6",
                            NumberOfPassengers = 5,
                            PhotoUrl = "https://localhost:7108/uploads/bmw-m8-competition-convertible-2d-blue-2019-JV.png",
                            RentalPrice = 3000,
                            State = 0,
                            Transmission = 1,
                            Type = 0,
                            Variant = "xDrive40i"
                        },
                        new
                        {
                            PlateNumber = "BBB012",
                            ChassisNumber = "CHS032",
                            Color = "White",
                            Make = "Chevrolet",
                            Mileage = 7000,
                            Model = "Traverse",
                            NumberOfPassengers = 7,
                            PhotoUrl = "https://localhost:7108/uploads/chevrolet-blazer-suv-white-2023.png",
                            RentalPrice = 2400,
                            State = 0,
                            Transmission = 1,
                            Type = 0,
                            Variant = "LS"
                        },
                        new
                        {
                            PlateNumber = "BBB013",
                            ChassisNumber = "CHS033",
                            Color = "Black",
                            Make = "BMW",
                            Mileage = 10000,
                            Model = "X1",
                            NumberOfPassengers = 5,
                            PhotoUrl = "https://localhost:7108/uploads/bmw-x5m-suv-4d-black-2023-JV.png",
                            RentalPrice = 2800,
                            State = 0,
                            Transmission = 1,
                            Type = 0,
                            Variant = "sDrive28i"
                        },
                        new
                        {
                            PlateNumber = "BBB017",
                            ChassisNumber = "CHS037",
                            Color = "Blue",
                            Make = "BMW",
                            Mileage = 15000,
                            Model = "7 Series",
                            NumberOfPassengers = 5,
                            PhotoUrl = "https://localhost:7108/uploads/bmw-x3m-suv-blue-2023.png",
                            RentalPrice = 2900,
                            State = 1,
                            Transmission = 1,
                            Type = 1,
                            Variant = "750i xDrive"
                        },
                        new
                        {
                            PlateNumber = "BBB020",
                            ChassisNumber = "CHS040",
                            Color = "Silver",
                            Make = "BMW",
                            Mileage = 12000,
                            Model = "Spark",
                            NumberOfPassengers = 4,
                            PhotoUrl = "https://localhost:7108/uploads/bmw-7-4d-silver-2021.png",
                            RentalPrice = 2300,
                            State = 0,
                            Transmission = 1,
                            Type = 2,
                            Variant = "LS"
                        },
                        new
                        {
                            PlateNumber = "BBB021",
                            ChassisNumber = "CHS041",
                            Color = "Orange",
                            Make = "Nissan",
                            Mileage = 9000,
                            Model = "Camry",
                            NumberOfPassengers = 5,
                            PhotoUrl = "https://localhost:7108/uploads/nissan-sentra-4d-orange-2020.png",
                            RentalPrice = 2700,
                            State = 0,
                            Transmission = 1,
                            Type = 1,
                            Variant = "SE"
                        },
                        new
                        {
                            PlateNumber = "BBB022",
                            ChassisNumber = "CHS042",
                            Color = "White",
                            Make = "Audi",
                            Mileage = 10000,
                            Model = "Civic",
                            NumberOfPassengers = 5,
                            PhotoUrl = "https://localhost:7108/uploads/audi-a6-quattro-4d-white-2021.png",
                            RentalPrice = 2800,
                            State = 2,
                            Transmission = 1,
                            Type = 1,
                            Variant = "Touring"
                        },
                        new
                        {
                            PlateNumber = "BBB023",
                            ChassisNumber = "CHS043",
                            Color = "Red",
                            Make = "Ford",
                            Mileage = 8000,
                            Model = "Mustang",
                            NumberOfPassengers = 4,
                            PhotoUrl = "https://localhost:7108/uploads/ford-mustang-cabrio-2d-rot-geschl-2016.png",
                            RentalPrice = 2500,
                            State = 0,
                            Transmission = 0,
                            Type = 5,
                            Variant = "GT"
                        },
                        new
                        {
                            PlateNumber = "BBB024",
                            ChassisNumber = "CHS044",
                            Color = "Brown",
                            Make = "Nissan",
                            Mileage = 15000,
                            Model = "Altima",
                            NumberOfPassengers = 5,
                            PhotoUrl = "https://localhost:7108/uploads/nissan-sunny-4d-braun-2011.png",
                            RentalPrice = 2600,
                            State = 1,
                            Transmission = 1,
                            Type = 1,
                            Variant = "SL"
                        },
                        new
                        {
                            PlateNumber = "BBB025",
                            ChassisNumber = "CHS045",
                            Color = "Gray",
                            Make = "Nissan-versa",
                            Mileage = 7000,
                            Model = "Sorento",
                            NumberOfPassengers = 7,
                            PhotoUrl = "https://localhost:7108/uploads/nissan-versa-4d-grey-2023.png",
                            RentalPrice = 2900,
                            State = 0,
                            Transmission = 1,
                            Type = 0,
                            Variant = "SX"
                        },
                        new
                        {
                            PlateNumber = "BBB026",
                            ChassisNumber = "CHS046",
                            Color = "Blue",
                            Make = "Subaru",
                            Mileage = 6000,
                            Model = "Outback",
                            NumberOfPassengers = 5,
                            PhotoUrl = "https://localhost:7108/uploads/subaru-xv-5d-blau-2019.png",
                            RentalPrice = 2800,
                            State = 0,
                            Transmission = 1,
                            Type = 3,
                            Variant = "Limited"
                        },
                        new
                        {
                            PlateNumber = "BBB027",
                            ChassisNumber = "CHS047",
                            Color = "Grey",
                            Make = "Audi",
                            Mileage = 9000,
                            Model = "CX-5",
                            NumberOfPassengers = 5,
                            PhotoUrl = "https://localhost:7108/uploads/audi-a3-4d-grey-2021.png",
                            RentalPrice = 2700,
                            State = 2,
                            Transmission = 1,
                            Type = 0,
                            Variant = "Grand Touring"
                        },
                        new
                        {
                            PlateNumber = "BBB028",
                            ChassisNumber = "CHS048",
                            Color = "Silver",
                            Make = "Skoda-octavia",
                            Mileage = 8000,
                            Model = "Passat",
                            NumberOfPassengers = 5,
                            PhotoUrl = "https://localhost:7108/uploads/skoda-octavia-4d-silber-2020.png",
                            RentalPrice = 2600,
                            State = 0,
                            Transmission = 1,
                            Type = 1,
                            Variant = "R-Line"
                        },
                        new
                        {
                            PlateNumber = "BBB029",
                            ChassisNumber = "CHS049",
                            Color = "Blue",
                            Make = "Audi",
                            Mileage = 7000,
                            Model = "Q5",
                            NumberOfPassengers = 5,
                            PhotoUrl = "https://localhost:7108/uploads/audi-a4-avant-stw-4d-blue-2023-JV.png",
                            RentalPrice = 3500,
                            State = 2,
                            Transmission = 1,
                            Type = 0,
                            Variant = "Premium Plus"
                        },
                        new
                        {
                            PlateNumber = "BBB030",
                            ChassisNumber = "CHS050",
                            Color = "Grey",
                            Make = "Peugeot",
                            Mileage = 5000,
                            Model = "C-Class",
                            NumberOfPassengers = 5,
                            PhotoUrl = "https://localhost:7108/uploads/peugeot-208-hatch-4d-grey-2020-JV.png",
                            RentalPrice = 4000,
                            State = 0,
                            Transmission = 1,
                            Type = 1,
                            Variant = "C300"
                        });
                });

            modelBuilder.Entity("Car_Rental_APIs.Models.CustomerRentCar", b =>
                {
                    b.Property<string>("ReservationNumber")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CustomerCarPlateNumber")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CustomerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("DropOffLatitude")
                        .HasColumnType("float");

                    b.Property<double>("DropOffLongitude")
                        .HasColumnType("float");

                    b.Property<DateTime>("EndingDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("PickUpLatitude")
                        .HasColumnType("float");

                    b.Property<double>("PickUpLongitude")
                        .HasColumnType("float");

                    b.Property<DateTime>("StartingDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("isInProgress")
                        .HasColumnType("bit");

                    b.Property<bool>("isOnlinePaid")
                        .HasColumnType("bit");

                    b.Property<int>("numberofRentDays")
                        .HasColumnType("int");

                    b.Property<float>("totalRentPrice")
                        .HasColumnType("real");

                    b.HasKey("ReservationNumber");

                    b.HasIndex("CustomerCarPlateNumber");

                    b.HasIndex("CustomerId");

                    b.ToTable("customerRentCars");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "1",
                            Name = "SuperAdmin",
                            NormalizedName = "SUPERADMIN"
                        },
                        new
                        {
                            Id = "2",
                            Name = "Employee",
                            NormalizedName = "EMPLOYEE"
                        },
                        new
                        {
                            Id = "3",
                            Name = "Client",
                            NormalizedName = "CLIENT"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "1",
                            RoleId = "1"
                        },
                        new
                        {
                            UserId = "2",
                            RoleId = "2"
                        },
                        new
                        {
                            UserId = "3",
                            RoleId = "3"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Car_Rental_APIs.Models.CustomerRentCar", b =>
                {
                    b.HasOne("Car_Rental_APIs.Models.Car", "CustomerCar")
                        .WithMany("CustomerCarRentals")
                        .HasForeignKey("CustomerCarPlateNumber");

                    b.HasOne("Car_Rental_APIs.Models.ApplicationUser", "Customer")
                        .WithMany("CustomerCarRentals")
                        .HasForeignKey("CustomerId");

                    b.Navigation("Customer");

                    b.Navigation("CustomerCar");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Car_Rental_APIs.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Car_Rental_APIs.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Car_Rental_APIs.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Car_Rental_APIs.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Car_Rental_APIs.Models.ApplicationUser", b =>
                {
                    b.Navigation("CustomerCarRentals");
                });

            modelBuilder.Entity("Car_Rental_APIs.Models.Car", b =>
                {
                    b.Navigation("CustomerCarRentals");
                });
#pragma warning restore 612, 618
        }
    }
}

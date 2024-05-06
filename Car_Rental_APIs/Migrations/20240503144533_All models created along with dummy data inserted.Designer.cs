﻿// <auto-generated />
using System;
using Car_Rental_APIs.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Car_Rental_APIs.Migrations
{
    [DbContext(typeof(RentalDbContext))]
    [Migration("20240503144533_All models created along with dummy data inserted")]
    partial class Allmodelscreatedalongwithdummydatainserted
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
                            PlateNumber = "ABC123",
                            ChassisNumber = "CHS123",
                            Color = "Red",
                            Make = "Toyota",
                            Mileage = 10000,
                            Model = "Camry",
                            NumberOfPassengers = 4,
                            RentalPrice = 100,
                            State = 0,
                            Transmission = 1,
                            Type = 1,
                            Variant = "LE"
                        },
                        new
                        {
                            PlateNumber = "DEF456",
                            ChassisNumber = "CHS456",
                            Color = "Blue",
                            Make = "Honda",
                            Mileage = 12000,
                            Model = "Accord",
                            NumberOfPassengers = 4,
                            RentalPrice = 120,
                            State = 0,
                            Transmission = 1,
                            Type = 1,
                            Variant = "EX"
                        },
                        new
                        {
                            PlateNumber = "GHI789",
                            ChassisNumber = "CHS789",
                            Color = "Black",
                            Make = "Ford",
                            Mileage = 8000,
                            Model = "Focus",
                            NumberOfPassengers = 4,
                            RentalPrice = 110,
                            State = 0,
                            Transmission = 1,
                            Type = 1,
                            Variant = "SE"
                        },
                        new
                        {
                            PlateNumber = "JKL321",
                            ChassisNumber = "CHS321",
                            Color = "Silver",
                            Make = "Ford",
                            Mileage = 7000,
                            Model = "Fiesta",
                            NumberOfPassengers = 4,
                            RentalPrice = 90,
                            State = 0,
                            Transmission = 1,
                            Type = 2,
                            Variant = "SE"
                        },
                        new
                        {
                            PlateNumber = "XYZ999",
                            ChassisNumber = "CHS999",
                            Color = "White",
                            Make = "Chevrolet",
                            Mileage = 15000,
                            Model = "Malibu",
                            NumberOfPassengers = 4,
                            RentalPrice = 130,
                            State = 0,
                            Transmission = 1,
                            Type = 1,
                            Variant = "LT"
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

                    b.HasKey("ReservationNumber");

                    b.HasIndex("CustomerCarPlateNumber");

                    b.HasIndex("CustomerId");

                    b.ToTable("customerRentCars");

                    b.HasData(
                        new
                        {
                            ReservationNumber = "RES001",
                            DropOffLatitude = 52.229700000000001,
                            DropOffLongitude = 21.0122,
                            EndingDate = new DateTime(2024, 5, 8, 14, 45, 32, 431, DateTimeKind.Utc).AddTicks(3245),
                            PickUpLatitude = 52.520000000000003,
                            PickUpLongitude = 13.404999999999999,
                            StartingDate = new DateTime(2024, 5, 4, 14, 45, 32, 431, DateTimeKind.Utc).AddTicks(3232)
                        },
                        new
                        {
                            ReservationNumber = "RES002",
                            DropOffLatitude = 34.052199999999999,
                            DropOffLongitude = -118.2437,
                            EndingDate = new DateTime(2024, 5, 9, 14, 45, 32, 431, DateTimeKind.Utc).AddTicks(3248),
                            PickUpLatitude = 37.774900000000002,
                            PickUpLongitude = -122.4194,
                            StartingDate = new DateTime(2024, 5, 5, 14, 45, 32, 431, DateTimeKind.Utc).AddTicks(3247)
                        },
                        new
                        {
                            ReservationNumber = "RES003",
                            DropOffLatitude = 33.749000000000002,
                            DropOffLongitude = -84.388000000000005,
                            EndingDate = new DateTime(2024, 5, 10, 14, 45, 32, 431, DateTimeKind.Utc).AddTicks(3250),
                            PickUpLatitude = 40.712800000000001,
                            PickUpLongitude = -74.006,
                            StartingDate = new DateTime(2024, 5, 6, 14, 45, 32, 431, DateTimeKind.Utc).AddTicks(3250)
                        },
                        new
                        {
                            ReservationNumber = "RES004",
                            DropOffLatitude = 48.8566,
                            DropOffLongitude = 2.3521999999999998,
                            EndingDate = new DateTime(2024, 5, 11, 14, 45, 32, 431, DateTimeKind.Utc).AddTicks(3252),
                            PickUpLatitude = 51.507399999999997,
                            PickUpLongitude = -0.1278,
                            StartingDate = new DateTime(2024, 5, 7, 14, 45, 32, 431, DateTimeKind.Utc).AddTicks(3252)
                        },
                        new
                        {
                            ReservationNumber = "RES005",
                            DropOffLatitude = 40.712800000000001,
                            DropOffLongitude = -74.006,
                            EndingDate = new DateTime(2024, 5, 12, 14, 45, 32, 431, DateTimeKind.Utc).AddTicks(3255),
                            PickUpLatitude = 48.8566,
                            PickUpLongitude = 2.3521999999999998,
                            StartingDate = new DateTime(2024, 5, 8, 14, 45, 32, 431, DateTimeKind.Utc).AddTicks(3254)
                        });
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

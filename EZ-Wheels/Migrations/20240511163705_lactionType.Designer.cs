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
    [Migration("20240511163705_lactionType")]
    partial class lactionType
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
                            ConcurrencyStamp = "d3b90190-ca76-469d-95b5-16fd9525d437",
                            Email = "user1@example.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "USER1@EXAMPLE.COM",
                            NormalizedUserName = "USER1@EXAMPLE.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEMUncwB/gGeFN91/03NqEIRtVgS/xlcrbhLxpUDSJrF7AYD70rgj08X8hq9HCdVqng==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "52c11926-3bbc-48b6-8a42-02b0e1f21528",
                            TwoFactorEnabled = false,
                            UserName = "user1@example.com"
                        },
                        new
                        {
                            Id = "2",
                            AccessFailedCount = 0,
                            Age = 30,
                            ConcurrencyStamp = "a9529fbe-0e9b-4bb3-8a78-f2687a6c84f4",
                            Email = "user2@example.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "USER2@EXAMPLE.COM",
                            NormalizedUserName = "USER2@EXAMPLE.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEFB0wVEN9HKowh89cSyDX2F/HObaFN2/Mx/ds+qqVRLdW8bcV6fotods6QYa4T6hKw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "10c773ff-8637-4fd5-836a-d42f73b641d9",
                            TwoFactorEnabled = false,
                            UserName = "user2@example.com"
                        },
                        new
                        {
                            Id = "3",
                            AccessFailedCount = 0,
                            Age = 32,
                            ConcurrencyStamp = "d1f5a4a3-9cce-432c-a754-931b0e1503a8",
                            Email = "user3@example.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "USER3@EXAMPLE.COM",
                            NormalizedUserName = "USER3@EXAMPLE.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEFGeLHEy981y53NdPMo/ZfQ2u8Rtne1fs8fdcIpe/Casc+yFE6IyuBNJfCKRZ+iNjQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "94e6409c-d1aa-4cb8-835d-346ccdcec317",
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

                    b.Property<decimal>("DropOffLatitude")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("DropOffLongitude")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("EndingDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("PickUpLatitude")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PickUpLongitude")
                        .HasColumnType("decimal(18,2)");

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
                            DropOffLatitude = 52.2297m,
                            DropOffLongitude = 21.0122m,
                            EndingDate = new DateTime(2024, 5, 16, 16, 37, 2, 338, DateTimeKind.Utc).AddTicks(5605),
                            PickUpLatitude = 52.5200m,
                            PickUpLongitude = 13.4050m,
                            StartingDate = new DateTime(2024, 5, 12, 16, 37, 2, 338, DateTimeKind.Utc).AddTicks(5598)
                        },
                        new
                        {
                            ReservationNumber = "RES002",
                            DropOffLatitude = 34.0522m,
                            DropOffLongitude = -118.2437m,
                            EndingDate = new DateTime(2024, 5, 17, 16, 37, 2, 338, DateTimeKind.Utc).AddTicks(5612),
                            PickUpLatitude = 37.7749m,
                            PickUpLongitude = -122.4194m,
                            StartingDate = new DateTime(2024, 5, 13, 16, 37, 2, 338, DateTimeKind.Utc).AddTicks(5611)
                        },
                        new
                        {
                            ReservationNumber = "RES003",
                            DropOffLatitude = 33.7490m,
                            DropOffLongitude = -84.3880m,
                            EndingDate = new DateTime(2024, 5, 18, 16, 37, 2, 338, DateTimeKind.Utc).AddTicks(5616),
                            PickUpLatitude = 40.7128m,
                            PickUpLongitude = -74.0060m,
                            StartingDate = new DateTime(2024, 5, 14, 16, 37, 2, 338, DateTimeKind.Utc).AddTicks(5615)
                        },
                        new
                        {
                            ReservationNumber = "RES004",
                            DropOffLatitude = 48.8566m,
                            DropOffLongitude = 2.3522m,
                            EndingDate = new DateTime(2024, 5, 19, 16, 37, 2, 338, DateTimeKind.Utc).AddTicks(5620),
                            PickUpLatitude = 51.5074m,
                            PickUpLongitude = -0.1278m,
                            StartingDate = new DateTime(2024, 5, 15, 16, 37, 2, 338, DateTimeKind.Utc).AddTicks(5619)
                        },
                        new
                        {
                            ReservationNumber = "RES005",
                            DropOffLatitude = 40.7128m,
                            DropOffLongitude = -74.0060m,
                            EndingDate = new DateTime(2024, 5, 20, 16, 37, 2, 338, DateTimeKind.Utc).AddTicks(5623),
                            PickUpLatitude = 48.8566m,
                            PickUpLongitude = 2.3522m,
                            StartingDate = new DateTime(2024, 5, 16, 16, 37, 2, 338, DateTimeKind.Utc).AddTicks(5622)
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

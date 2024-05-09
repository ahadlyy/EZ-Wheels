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
    [Migration("20240508161843_Seeding data complete")]
    partial class Seedingdatacomplete
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
                            ConcurrencyStamp = "61657547-aa93-47f0-937f-7818e38be4a2",
                            Email = "user1@example.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "USER1@EXAMPLE.COM",
                            NormalizedUserName = "USER1@EXAMPLE.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEGQKmW8bdfjv4ozdhE6uuESCXK7goTn0mKB2k/bi+zx+AyvXKo6xH4VTOkh8Xta4jw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "a35e8c5f-ec39-4255-a6b1-12d3e7abf2ed",
                            TwoFactorEnabled = false,
                            UserName = "user1@example.com"
                        },
                        new
                        {
                            Id = "2",
                            AccessFailedCount = 0,
                            Age = 30,
                            ConcurrencyStamp = "a5f16fe1-e1a6-4426-a23e-fc1e32f11f0f",
                            Email = "user2@example.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "USER2@EXAMPLE.COM",
                            NormalizedUserName = "USER2@EXAMPLE.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEDakMAThCNEMbvBaI8/sQNIhYuLFzEiFkXXSFeXxDICoPinoz4orSCFlmQ35hcXQBQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "ba3bb051-3704-43f7-8ba9-627590f30f35",
                            TwoFactorEnabled = false,
                            UserName = "user2@example.com"
                        },
                        new
                        {
                            Id = "3",
                            AccessFailedCount = 0,
                            Age = 32,
                            ConcurrencyStamp = "05ef0c89-0314-48c6-aa86-66569893d951",
                            Email = "user3@example.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "USER3@EXAMPLE.COM",
                            NormalizedUserName = "USER3@EXAMPLE.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEHkBo2bumzz9YFFw19tRB0Lg7jsQHtY+wKiOPr/QA/mOY6Jyw3gHRo1+zdTjgOAHow==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "ef85437e-af44-43c3-a5e8-d5a6f200fb99",
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
                            EndingDate = new DateTime(2024, 5, 13, 16, 18, 42, 214, DateTimeKind.Utc).AddTicks(9407),
                            PickUpLatitude = 52.520000000000003,
                            PickUpLongitude = 13.404999999999999,
                            StartingDate = new DateTime(2024, 5, 9, 16, 18, 42, 214, DateTimeKind.Utc).AddTicks(9387)
                        },
                        new
                        {
                            ReservationNumber = "RES002",
                            DropOffLatitude = 34.052199999999999,
                            DropOffLongitude = -118.2437,
                            EndingDate = new DateTime(2024, 5, 14, 16, 18, 42, 214, DateTimeKind.Utc).AddTicks(9411),
                            PickUpLatitude = 37.774900000000002,
                            PickUpLongitude = -122.4194,
                            StartingDate = new DateTime(2024, 5, 10, 16, 18, 42, 214, DateTimeKind.Utc).AddTicks(9410)
                        },
                        new
                        {
                            ReservationNumber = "RES003",
                            DropOffLatitude = 33.749000000000002,
                            DropOffLongitude = -84.388000000000005,
                            EndingDate = new DateTime(2024, 5, 15, 16, 18, 42, 214, DateTimeKind.Utc).AddTicks(9413),
                            PickUpLatitude = 40.712800000000001,
                            PickUpLongitude = -74.006,
                            StartingDate = new DateTime(2024, 5, 11, 16, 18, 42, 214, DateTimeKind.Utc).AddTicks(9413)
                        },
                        new
                        {
                            ReservationNumber = "RES004",
                            DropOffLatitude = 48.8566,
                            DropOffLongitude = 2.3521999999999998,
                            EndingDate = new DateTime(2024, 5, 16, 16, 18, 42, 214, DateTimeKind.Utc).AddTicks(9416),
                            PickUpLatitude = 51.507399999999997,
                            PickUpLongitude = -0.1278,
                            StartingDate = new DateTime(2024, 5, 12, 16, 18, 42, 214, DateTimeKind.Utc).AddTicks(9415)
                        },
                        new
                        {
                            ReservationNumber = "RES005",
                            DropOffLatitude = 40.712800000000001,
                            DropOffLongitude = -74.006,
                            EndingDate = new DateTime(2024, 5, 17, 16, 18, 42, 214, DateTimeKind.Utc).AddTicks(9418),
                            PickUpLatitude = 48.8566,
                            PickUpLongitude = 2.3521999999999998,
                            StartingDate = new DateTime(2024, 5, 13, 16, 18, 42, 214, DateTimeKind.Utc).AddTicks(9417)
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
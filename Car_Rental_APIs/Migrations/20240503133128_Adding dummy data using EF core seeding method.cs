using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Car_Rental_APIs.Migrations
{
    /// <inheritdoc />
    public partial class AddingdummydatausingEFcoreseedingmethod : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "PlateNumber", "ChassisNumber", "Color", "Make", "Mileage", "Model", "NumberOfPassengers", "RentalPrice", "State", "Transmission", "Type", "Variant" },
                values: new object[,]
                {
                    { "ABC123", "CHS123", "Red", "Toyota", 10000, "Camry", 4, 100, 0, 1, 1, "LE" },
                    { "DEF456", "CHS456", "Blue", "Honda", 12000, "Accord", 4, 120, 0, 1, 1, "EX" },
                    { "GHI789", "CHS789", "Black", "Ford", 8000, "Focus", 4, 110, 0, 1, 1, "SE" },
                    { "JKL321", "CHS321", "Silver", "Ford", 7000, "Fiesta", 4, 90, 0, 1, 2, "SE" },
                    { "XYZ999", "CHS999", "White", "Chevrolet", 15000, "Malibu", 4, 130, 0, 1, 1, "LT" }
                });

            migrationBuilder.InsertData(
                table: "customerRentCars",
                columns: new[] { "ReservationNumber", "CustomerCarPlateNumber", "CustomerId", "DropOffLatitude", "DropOffLongitude", "EndingDate", "PickUpLatitude", "PickUpLongitude", "StartingDate" },
                values: new object[,]
                {
                    { "RES001", null, null, 52.229700000000001, 21.0122, new DateTime(2024, 5, 8, 13, 31, 27, 582, DateTimeKind.Utc).AddTicks(5582), 52.520000000000003, 13.404999999999999, new DateTime(2024, 5, 4, 13, 31, 27, 582, DateTimeKind.Utc).AddTicks(5572) },
                    { "RES002", null, null, 34.052199999999999, -118.2437, new DateTime(2024, 5, 9, 13, 31, 27, 582, DateTimeKind.Utc).AddTicks(5586), 37.774900000000002, -122.4194, new DateTime(2024, 5, 5, 13, 31, 27, 582, DateTimeKind.Utc).AddTicks(5585) },
                    { "RES003", null, null, 33.749000000000002, -84.388000000000005, new DateTime(2024, 5, 10, 13, 31, 27, 582, DateTimeKind.Utc).AddTicks(5588), 40.712800000000001, -74.006, new DateTime(2024, 5, 6, 13, 31, 27, 582, DateTimeKind.Utc).AddTicks(5587) },
                    { "RES004", null, null, 48.8566, 2.3521999999999998, new DateTime(2024, 5, 11, 13, 31, 27, 582, DateTimeKind.Utc).AddTicks(5590), 51.507399999999997, -0.1278, new DateTime(2024, 5, 7, 13, 31, 27, 582, DateTimeKind.Utc).AddTicks(5589) },
                    { "RES005", null, null, 40.712800000000001, -74.006, new DateTime(2024, 5, 12, 13, 31, 27, 582, DateTimeKind.Utc).AddTicks(5592), 48.8566, 2.3521999999999998, new DateTime(2024, 5, 8, 13, 31, 27, 582, DateTimeKind.Utc).AddTicks(5591) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "PlateNumber",
                keyValue: "ABC123");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "PlateNumber",
                keyValue: "DEF456");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "PlateNumber",
                keyValue: "GHI789");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "PlateNumber",
                keyValue: "JKL321");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "PlateNumber",
                keyValue: "XYZ999");

            migrationBuilder.DeleteData(
                table: "customerRentCars",
                keyColumn: "ReservationNumber",
                keyValue: "RES001");

            migrationBuilder.DeleteData(
                table: "customerRentCars",
                keyColumn: "ReservationNumber",
                keyValue: "RES002");

            migrationBuilder.DeleteData(
                table: "customerRentCars",
                keyColumn: "ReservationNumber",
                keyValue: "RES003");

            migrationBuilder.DeleteData(
                table: "customerRentCars",
                keyColumn: "ReservationNumber",
                keyValue: "RES004");

            migrationBuilder.DeleteData(
                table: "customerRentCars",
                keyColumn: "ReservationNumber",
                keyValue: "RES005");
        }
    }
}

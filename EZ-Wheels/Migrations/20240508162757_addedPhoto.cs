using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EZ_Wheels.Migrations
{
    /// <inheritdoc />
    public partial class addedPhoto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PhotoUrl",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "PlateNumber",
                keyValue: "ABC123",
                column: "PhotoUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "PlateNumber",
                keyValue: "DEF456",
                column: "PhotoUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "PlateNumber",
                keyValue: "GHI789",
                column: "PhotoUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "PlateNumber",
                keyValue: "JKL321",
                column: "PhotoUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "PlateNumber",
                keyValue: "XYZ999",
                column: "PhotoUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "customerRentCars",
                keyColumn: "ReservationNumber",
                keyValue: "RES001",
                columns: new[] { "EndingDate", "StartingDate" },
                values: new object[] { new DateTime(2024, 5, 13, 16, 27, 55, 693, DateTimeKind.Utc).AddTicks(372), new DateTime(2024, 5, 9, 16, 27, 55, 693, DateTimeKind.Utc).AddTicks(366) });

            migrationBuilder.UpdateData(
                table: "customerRentCars",
                keyColumn: "ReservationNumber",
                keyValue: "RES002",
                columns: new[] { "EndingDate", "StartingDate" },
                values: new object[] { new DateTime(2024, 5, 14, 16, 27, 55, 693, DateTimeKind.Utc).AddTicks(377), new DateTime(2024, 5, 10, 16, 27, 55, 693, DateTimeKind.Utc).AddTicks(376) });

            migrationBuilder.UpdateData(
                table: "customerRentCars",
                keyColumn: "ReservationNumber",
                keyValue: "RES003",
                columns: new[] { "EndingDate", "StartingDate" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 27, 55, 693, DateTimeKind.Utc).AddTicks(380), new DateTime(2024, 5, 11, 16, 27, 55, 693, DateTimeKind.Utc).AddTicks(379) });

            migrationBuilder.UpdateData(
                table: "customerRentCars",
                keyColumn: "ReservationNumber",
                keyValue: "RES004",
                columns: new[] { "EndingDate", "StartingDate" },
                values: new object[] { new DateTime(2024, 5, 16, 16, 27, 55, 693, DateTimeKind.Utc).AddTicks(382), new DateTime(2024, 5, 12, 16, 27, 55, 693, DateTimeKind.Utc).AddTicks(382) });

            migrationBuilder.UpdateData(
                table: "customerRentCars",
                keyColumn: "ReservationNumber",
                keyValue: "RES005",
                columns: new[] { "EndingDate", "StartingDate" },
                values: new object[] { new DateTime(2024, 5, 17, 16, 27, 55, 693, DateTimeKind.Utc).AddTicks(385), new DateTime(2024, 5, 13, 16, 27, 55, 693, DateTimeKind.Utc).AddTicks(384) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhotoUrl",
                table: "Cars");

            migrationBuilder.UpdateData(
                table: "customerRentCars",
                keyColumn: "ReservationNumber",
                keyValue: "RES001",
                columns: new[] { "EndingDate", "StartingDate" },
                values: new object[] { new DateTime(2024, 5, 12, 16, 14, 10, 922, DateTimeKind.Utc).AddTicks(7511), new DateTime(2024, 5, 8, 16, 14, 10, 922, DateTimeKind.Utc).AddTicks(7503) });

            migrationBuilder.UpdateData(
                table: "customerRentCars",
                keyColumn: "ReservationNumber",
                keyValue: "RES002",
                columns: new[] { "EndingDate", "StartingDate" },
                values: new object[] { new DateTime(2024, 5, 13, 16, 14, 10, 922, DateTimeKind.Utc).AddTicks(7518), new DateTime(2024, 5, 9, 16, 14, 10, 922, DateTimeKind.Utc).AddTicks(7517) });

            migrationBuilder.UpdateData(
                table: "customerRentCars",
                keyColumn: "ReservationNumber",
                keyValue: "RES003",
                columns: new[] { "EndingDate", "StartingDate" },
                values: new object[] { new DateTime(2024, 5, 14, 16, 14, 10, 922, DateTimeKind.Utc).AddTicks(7520), new DateTime(2024, 5, 10, 16, 14, 10, 922, DateTimeKind.Utc).AddTicks(7519) });

            migrationBuilder.UpdateData(
                table: "customerRentCars",
                keyColumn: "ReservationNumber",
                keyValue: "RES004",
                columns: new[] { "EndingDate", "StartingDate" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 14, 10, 922, DateTimeKind.Utc).AddTicks(7522), new DateTime(2024, 5, 11, 16, 14, 10, 922, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "customerRentCars",
                keyColumn: "ReservationNumber",
                keyValue: "RES005",
                columns: new[] { "EndingDate", "StartingDate" },
                values: new object[] { new DateTime(2024, 5, 16, 16, 14, 10, 922, DateTimeKind.Utc).AddTicks(7524), new DateTime(2024, 5, 12, 16, 14, 10, 922, DateTimeKind.Utc).AddTicks(7524) });
        }
    }
}

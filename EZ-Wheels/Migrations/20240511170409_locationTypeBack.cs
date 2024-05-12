using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EZ_Wheels.Migrations
{
    /// <inheritdoc />
    public partial class locationTypeBack : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<double>(
                name: "PickUpLongitude",
                table: "customerRentCars",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<double>(
                name: "PickUpLatitude",
                table: "customerRentCars",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<double>(
                name: "DropOffLongitude",
                table: "customerRentCars",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<double>(
                name: "DropOffLatitude",
                table: "customerRentCars",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a5a9383-7d9e-425c-ab58-a429b7f2db1d", "AQAAAAIAAYagAAAAEPhglFe81LHO43BJQqgbwnPhjnOAho/m2hIiDXvasO1mURrWtOXD63J1FYTGc0U2Ug==", "345c27f1-278f-4f2a-82fe-75a832ae070b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c1f70e9f-80ba-4585-bed1-83b050daf5f4", "AQAAAAIAAYagAAAAEDEA1zJ1rm9JrwG/kLgVGric+QqGrADjV8IK83nylQEZpX1bhpZ7+IHgsJ6RT6v50Q==", "39af2ebd-a44a-4a79-8fd9-19b2839dd63a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "595f1e44-5f79-43f8-b9ae-d05fe5db3a77", "AQAAAAIAAYagAAAAEKshzuVTr7HzrlVqQGEwk20AWlKwShRyun4zhuUamLbXrR4DMTFxuz6sl5ukeJUNxg==", "00f03e79-e052-47a6-a4fd-03101b26dd66" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "PickUpLongitude",
                table: "customerRentCars",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<decimal>(
                name: "PickUpLatitude",
                table: "customerRentCars",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<decimal>(
                name: "DropOffLongitude",
                table: "customerRentCars",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<decimal>(
                name: "DropOffLatitude",
                table: "customerRentCars",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d3b90190-ca76-469d-95b5-16fd9525d437", "AQAAAAIAAYagAAAAEMUncwB/gGeFN91/03NqEIRtVgS/xlcrbhLxpUDSJrF7AYD70rgj08X8hq9HCdVqng==", "52c11926-3bbc-48b6-8a42-02b0e1f21528" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a9529fbe-0e9b-4bb3-8a78-f2687a6c84f4", "AQAAAAIAAYagAAAAEFB0wVEN9HKowh89cSyDX2F/HObaFN2/Mx/ds+qqVRLdW8bcV6fotods6QYa4T6hKw==", "10c773ff-8637-4fd5-836a-d42f73b641d9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d1f5a4a3-9cce-432c-a754-931b0e1503a8", "AQAAAAIAAYagAAAAEFGeLHEy981y53NdPMo/ZfQ2u8Rtne1fs8fdcIpe/Casc+yFE6IyuBNJfCKRZ+iNjQ==", "94e6409c-d1aa-4cb8-835d-346ccdcec317" });

            migrationBuilder.InsertData(
                table: "customerRentCars",
                columns: new[] { "ReservationNumber", "CustomerCarPlateNumber", "CustomerId", "DropOffLatitude", "DropOffLongitude", "EndingDate", "PickUpLatitude", "PickUpLongitude", "StartingDate" },
                values: new object[,]
                {
                    { "RES001", null, null, 52.2297m, 21.0122m, new DateTime(2024, 5, 16, 16, 37, 2, 338, DateTimeKind.Utc).AddTicks(5605), 52.5200m, 13.4050m, new DateTime(2024, 5, 12, 16, 37, 2, 338, DateTimeKind.Utc).AddTicks(5598) },
                    { "RES002", null, null, 34.0522m, -118.2437m, new DateTime(2024, 5, 17, 16, 37, 2, 338, DateTimeKind.Utc).AddTicks(5612), 37.7749m, -122.4194m, new DateTime(2024, 5, 13, 16, 37, 2, 338, DateTimeKind.Utc).AddTicks(5611) },
                    { "RES003", null, null, 33.7490m, -84.3880m, new DateTime(2024, 5, 18, 16, 37, 2, 338, DateTimeKind.Utc).AddTicks(5616), 40.7128m, -74.0060m, new DateTime(2024, 5, 14, 16, 37, 2, 338, DateTimeKind.Utc).AddTicks(5615) },
                    { "RES004", null, null, 48.8566m, 2.3522m, new DateTime(2024, 5, 19, 16, 37, 2, 338, DateTimeKind.Utc).AddTicks(5620), 51.5074m, -0.1278m, new DateTime(2024, 5, 15, 16, 37, 2, 338, DateTimeKind.Utc).AddTicks(5619) },
                    { "RES005", null, null, 40.7128m, -74.0060m, new DateTime(2024, 5, 20, 16, 37, 2, 338, DateTimeKind.Utc).AddTicks(5623), 48.8566m, 2.3522m, new DateTime(2024, 5, 16, 16, 37, 2, 338, DateTimeKind.Utc).AddTicks(5622) }
                });
        }
    }
}

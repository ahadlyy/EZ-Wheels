using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EZ_Wheels.Migrations
{
    /// <inheritdoc />
    public partial class lactionType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "customerRentCars",
                keyColumn: "ReservationNumber",
                keyValue: "RES001",
                columns: new[] { "DropOffLatitude", "DropOffLongitude", "EndingDate", "PickUpLatitude", "PickUpLongitude", "StartingDate" },
                values: new object[] { 52.2297m, 21.0122m, new DateTime(2024, 5, 16, 16, 37, 2, 338, DateTimeKind.Utc).AddTicks(5605), 52.5200m, 13.4050m, new DateTime(2024, 5, 12, 16, 37, 2, 338, DateTimeKind.Utc).AddTicks(5598) });

            migrationBuilder.UpdateData(
                table: "customerRentCars",
                keyColumn: "ReservationNumber",
                keyValue: "RES002",
                columns: new[] { "DropOffLatitude", "DropOffLongitude", "EndingDate", "PickUpLatitude", "PickUpLongitude", "StartingDate" },
                values: new object[] { 34.0522m, -118.2437m, new DateTime(2024, 5, 17, 16, 37, 2, 338, DateTimeKind.Utc).AddTicks(5612), 37.7749m, -122.4194m, new DateTime(2024, 5, 13, 16, 37, 2, 338, DateTimeKind.Utc).AddTicks(5611) });

            migrationBuilder.UpdateData(
                table: "customerRentCars",
                keyColumn: "ReservationNumber",
                keyValue: "RES003",
                columns: new[] { "DropOffLatitude", "DropOffLongitude", "EndingDate", "PickUpLatitude", "PickUpLongitude", "StartingDate" },
                values: new object[] { 33.7490m, -84.3880m, new DateTime(2024, 5, 18, 16, 37, 2, 338, DateTimeKind.Utc).AddTicks(5616), 40.7128m, -74.0060m, new DateTime(2024, 5, 14, 16, 37, 2, 338, DateTimeKind.Utc).AddTicks(5615) });

            migrationBuilder.UpdateData(
                table: "customerRentCars",
                keyColumn: "ReservationNumber",
                keyValue: "RES004",
                columns: new[] { "DropOffLatitude", "DropOffLongitude", "EndingDate", "PickUpLatitude", "PickUpLongitude", "StartingDate" },
                values: new object[] { 48.8566m, 2.3522m, new DateTime(2024, 5, 19, 16, 37, 2, 338, DateTimeKind.Utc).AddTicks(5620), 51.5074m, -0.1278m, new DateTime(2024, 5, 15, 16, 37, 2, 338, DateTimeKind.Utc).AddTicks(5619) });

            migrationBuilder.UpdateData(
                table: "customerRentCars",
                keyColumn: "ReservationNumber",
                keyValue: "RES005",
                columns: new[] { "DropOffLatitude", "DropOffLongitude", "EndingDate", "PickUpLatitude", "PickUpLongitude", "StartingDate" },
                values: new object[] { 40.7128m, -74.0060m, new DateTime(2024, 5, 20, 16, 37, 2, 338, DateTimeKind.Utc).AddTicks(5623), 48.8566m, 2.3522m, new DateTime(2024, 5, 16, 16, 37, 2, 338, DateTimeKind.Utc).AddTicks(5622) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                values: new object[] { "61657547-aa93-47f0-937f-7818e38be4a2", "AQAAAAIAAYagAAAAEGQKmW8bdfjv4ozdhE6uuESCXK7goTn0mKB2k/bi+zx+AyvXKo6xH4VTOkh8Xta4jw==", "a35e8c5f-ec39-4255-a6b1-12d3e7abf2ed" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a5f16fe1-e1a6-4426-a23e-fc1e32f11f0f", "AQAAAAIAAYagAAAAEDakMAThCNEMbvBaI8/sQNIhYuLFzEiFkXXSFeXxDICoPinoz4orSCFlmQ35hcXQBQ==", "ba3bb051-3704-43f7-8ba9-627590f30f35" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "05ef0c89-0314-48c6-aa86-66569893d951", "AQAAAAIAAYagAAAAEHkBo2bumzz9YFFw19tRB0Lg7jsQHtY+wKiOPr/QA/mOY6Jyw3gHRo1+zdTjgOAHow==", "ef85437e-af44-43c3-a5e8-d5a6f200fb99" });

            migrationBuilder.UpdateData(
                table: "customerRentCars",
                keyColumn: "ReservationNumber",
                keyValue: "RES001",
                columns: new[] { "DropOffLatitude", "DropOffLongitude", "EndingDate", "PickUpLatitude", "PickUpLongitude", "StartingDate" },
                values: new object[] { 52.229700000000001, 21.0122, new DateTime(2024, 5, 13, 16, 18, 42, 214, DateTimeKind.Utc).AddTicks(9407), 52.520000000000003, 13.404999999999999, new DateTime(2024, 5, 9, 16, 18, 42, 214, DateTimeKind.Utc).AddTicks(9387) });

            migrationBuilder.UpdateData(
                table: "customerRentCars",
                keyColumn: "ReservationNumber",
                keyValue: "RES002",
                columns: new[] { "DropOffLatitude", "DropOffLongitude", "EndingDate", "PickUpLatitude", "PickUpLongitude", "StartingDate" },
                values: new object[] { 34.052199999999999, -118.2437, new DateTime(2024, 5, 14, 16, 18, 42, 214, DateTimeKind.Utc).AddTicks(9411), 37.774900000000002, -122.4194, new DateTime(2024, 5, 10, 16, 18, 42, 214, DateTimeKind.Utc).AddTicks(9410) });

            migrationBuilder.UpdateData(
                table: "customerRentCars",
                keyColumn: "ReservationNumber",
                keyValue: "RES003",
                columns: new[] { "DropOffLatitude", "DropOffLongitude", "EndingDate", "PickUpLatitude", "PickUpLongitude", "StartingDate" },
                values: new object[] { 33.749000000000002, -84.388000000000005, new DateTime(2024, 5, 15, 16, 18, 42, 214, DateTimeKind.Utc).AddTicks(9413), 40.712800000000001, -74.006, new DateTime(2024, 5, 11, 16, 18, 42, 214, DateTimeKind.Utc).AddTicks(9413) });

            migrationBuilder.UpdateData(
                table: "customerRentCars",
                keyColumn: "ReservationNumber",
                keyValue: "RES004",
                columns: new[] { "DropOffLatitude", "DropOffLongitude", "EndingDate", "PickUpLatitude", "PickUpLongitude", "StartingDate" },
                values: new object[] { 48.8566, 2.3521999999999998, new DateTime(2024, 5, 16, 16, 18, 42, 214, DateTimeKind.Utc).AddTicks(9416), 51.507399999999997, -0.1278, new DateTime(2024, 5, 12, 16, 18, 42, 214, DateTimeKind.Utc).AddTicks(9415) });

            migrationBuilder.UpdateData(
                table: "customerRentCars",
                keyColumn: "ReservationNumber",
                keyValue: "RES005",
                columns: new[] { "DropOffLatitude", "DropOffLongitude", "EndingDate", "PickUpLatitude", "PickUpLongitude", "StartingDate" },
                values: new object[] { 40.712800000000001, -74.006, new DateTime(2024, 5, 17, 16, 18, 42, 214, DateTimeKind.Utc).AddTicks(9418), 48.8566, 2.3521999999999998, new DateTime(2024, 5, 13, 16, 18, 42, 214, DateTimeKind.Utc).AddTicks(9417) });
        }
    }
}

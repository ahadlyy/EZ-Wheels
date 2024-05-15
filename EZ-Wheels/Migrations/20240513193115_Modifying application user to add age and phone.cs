using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EZ_Wheels.Migrations
{
    /// <inheritdoc />
    public partial class Modifyingapplicationusertoaddageandphone : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "c59190c0-ad65-4226-a7bb-a9a44254e4eb", "AQAAAAIAAYagAAAAEPUwGax3oy6LmDBcSAwCMZlXPjdQvFWzRIleveY+al2Fky1oiSfSzaOu2oJfB6TKeQ==", "01100200300", "7eba2ae0-fc87-4561-8224-dcf6341cc5f0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "f76d33c1-db4b-42df-9670-091ac00eb02e", "AQAAAAIAAYagAAAAEAFtQ7qdUZOke7KKdk3ymwxYdiGD7D8ehfY+b2YChCI37kRQunckW6F0bnCg3sg9HQ==", "01020304050", "2f1c5206-3232-4b04-b349-d4ed6efad62a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "7d3934c1-afa3-4657-bc0e-475247fd3380", "AQAAAAIAAYagAAAAEDoaf3lbFVdzalFbVYqu8rGvTJ7B2jAHZItS3RiMCQw6jmQvfk0bSnMDBD4lfRHzKA==", "01234567890", "8c7e1156-8c02-4348-896d-579a0f233a10" });

            migrationBuilder.UpdateData(
                table: "customerRentCars",
                keyColumn: "ReservationNumber",
                keyValue: "RES001",
                columns: new[] { "EndingDate", "StartingDate" },
                values: new object[] { new DateTime(2024, 5, 18, 19, 31, 14, 542, DateTimeKind.Utc).AddTicks(3017), new DateTime(2024, 5, 14, 19, 31, 14, 542, DateTimeKind.Utc).AddTicks(3006) });

            migrationBuilder.UpdateData(
                table: "customerRentCars",
                keyColumn: "ReservationNumber",
                keyValue: "RES002",
                columns: new[] { "EndingDate", "StartingDate" },
                values: new object[] { new DateTime(2024, 5, 19, 19, 31, 14, 542, DateTimeKind.Utc).AddTicks(3021), new DateTime(2024, 5, 15, 19, 31, 14, 542, DateTimeKind.Utc).AddTicks(3020) });

            migrationBuilder.UpdateData(
                table: "customerRentCars",
                keyColumn: "ReservationNumber",
                keyValue: "RES003",
                columns: new[] { "EndingDate", "StartingDate" },
                values: new object[] { new DateTime(2024, 5, 20, 19, 31, 14, 542, DateTimeKind.Utc).AddTicks(3024), new DateTime(2024, 5, 16, 19, 31, 14, 542, DateTimeKind.Utc).AddTicks(3023) });

            migrationBuilder.UpdateData(
                table: "customerRentCars",
                keyColumn: "ReservationNumber",
                keyValue: "RES004",
                columns: new[] { "EndingDate", "StartingDate" },
                values: new object[] { new DateTime(2024, 5, 21, 19, 31, 14, 542, DateTimeKind.Utc).AddTicks(3026), new DateTime(2024, 5, 17, 19, 31, 14, 542, DateTimeKind.Utc).AddTicks(3025) });

            migrationBuilder.UpdateData(
                table: "customerRentCars",
                keyColumn: "ReservationNumber",
                keyValue: "RES005",
                columns: new[] { "EndingDate", "StartingDate" },
                values: new object[] { new DateTime(2024, 5, 22, 19, 31, 14, 542, DateTimeKind.Utc).AddTicks(3028), new DateTime(2024, 5, 18, 19, 31, 14, 542, DateTimeKind.Utc).AddTicks(3027) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "61657547-aa93-47f0-937f-7818e38be4a2", "AQAAAAIAAYagAAAAEGQKmW8bdfjv4ozdhE6uuESCXK7goTn0mKB2k/bi+zx+AyvXKo6xH4VTOkh8Xta4jw==", null, "a35e8c5f-ec39-4255-a6b1-12d3e7abf2ed" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "a5f16fe1-e1a6-4426-a23e-fc1e32f11f0f", "AQAAAAIAAYagAAAAEDakMAThCNEMbvBaI8/sQNIhYuLFzEiFkXXSFeXxDICoPinoz4orSCFlmQ35hcXQBQ==", null, "ba3bb051-3704-43f7-8ba9-627590f30f35" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "05ef0c89-0314-48c6-aa86-66569893d951", "AQAAAAIAAYagAAAAEHkBo2bumzz9YFFw19tRB0Lg7jsQHtY+wKiOPr/QA/mOY6Jyw3gHRo1+zdTjgOAHow==", null, "ef85437e-af44-43c3-a5e8-d5a6f200fb99" });

            migrationBuilder.UpdateData(
                table: "customerRentCars",
                keyColumn: "ReservationNumber",
                keyValue: "RES001",
                columns: new[] { "EndingDate", "StartingDate" },
                values: new object[] { new DateTime(2024, 5, 13, 16, 18, 42, 214, DateTimeKind.Utc).AddTicks(9407), new DateTime(2024, 5, 9, 16, 18, 42, 214, DateTimeKind.Utc).AddTicks(9387) });

            migrationBuilder.UpdateData(
                table: "customerRentCars",
                keyColumn: "ReservationNumber",
                keyValue: "RES002",
                columns: new[] { "EndingDate", "StartingDate" },
                values: new object[] { new DateTime(2024, 5, 14, 16, 18, 42, 214, DateTimeKind.Utc).AddTicks(9411), new DateTime(2024, 5, 10, 16, 18, 42, 214, DateTimeKind.Utc).AddTicks(9410) });

            migrationBuilder.UpdateData(
                table: "customerRentCars",
                keyColumn: "ReservationNumber",
                keyValue: "RES003",
                columns: new[] { "EndingDate", "StartingDate" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 18, 42, 214, DateTimeKind.Utc).AddTicks(9413), new DateTime(2024, 5, 11, 16, 18, 42, 214, DateTimeKind.Utc).AddTicks(9413) });

            migrationBuilder.UpdateData(
                table: "customerRentCars",
                keyColumn: "ReservationNumber",
                keyValue: "RES004",
                columns: new[] { "EndingDate", "StartingDate" },
                values: new object[] { new DateTime(2024, 5, 16, 16, 18, 42, 214, DateTimeKind.Utc).AddTicks(9416), new DateTime(2024, 5, 12, 16, 18, 42, 214, DateTimeKind.Utc).AddTicks(9415) });

            migrationBuilder.UpdateData(
                table: "customerRentCars",
                keyColumn: "ReservationNumber",
                keyValue: "RES005",
                columns: new[] { "EndingDate", "StartingDate" },
                values: new object[] { new DateTime(2024, 5, 17, 16, 18, 42, 214, DateTimeKind.Utc).AddTicks(9418), new DateTime(2024, 5, 13, 16, 18, 42, 214, DateTimeKind.Utc).AddTicks(9417) });
        }
    }
}

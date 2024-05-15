using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EZ_Wheels.Migrations
{
    /// <inheritdoc />
    public partial class Seedingdatacomplete : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", null, "SuperAdmin", "SUPERADMIN" },
                    { "2", null, "Employee", "EMPLOYEE" },
                    { "3", null, "Client", "CLIENT" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Age", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, 28, "61657547-aa93-47f0-937f-7818e38be4a2", "user1@example.com", true, false, null, "USER1@EXAMPLE.COM", "USER1@EXAMPLE.COM", "AQAAAAIAAYagAAAAEGQKmW8bdfjv4ozdhE6uuESCXK7goTn0mKB2k/bi+zx+AyvXKo6xH4VTOkh8Xta4jw==", null, false, "a35e8c5f-ec39-4255-a6b1-12d3e7abf2ed", false, "user1@example.com" },
                    { "2", 0, 30, "a5f16fe1-e1a6-4426-a23e-fc1e32f11f0f", "user2@example.com", true, false, null, "USER2@EXAMPLE.COM", "USER2@EXAMPLE.COM", "AQAAAAIAAYagAAAAEDakMAThCNEMbvBaI8/sQNIhYuLFzEiFkXXSFeXxDICoPinoz4orSCFlmQ35hcXQBQ==", null, false, "ba3bb051-3704-43f7-8ba9-627590f30f35", false, "user2@example.com" },
                    { "3", 0, 32, "05ef0c89-0314-48c6-aa86-66569893d951", "user3@example.com", true, false, null, "USER3@EXAMPLE.COM", "USER3@EXAMPLE.COM", "AQAAAAIAAYagAAAAEHkBo2bumzz9YFFw19tRB0Lg7jsQHtY+wKiOPr/QA/mOY6Jyw3gHRo1+zdTjgOAHow==", null, false, "ef85437e-af44-43c3-a5e8-d5a6f200fb99", false, "user3@example.com" }
                });

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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1", "1" },
                    { "2", "2" },
                    { "3", "3" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "3" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3");

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

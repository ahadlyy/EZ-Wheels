using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EZ_Wheels.Migrations
{
    /// <inheritdoc />
    public partial class updatetables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "purchases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PayerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<float>(type: "real", nullable: false),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExecutedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_purchases", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5d9f8569-91af-4f4a-9d0b-ecd460907892", "AQAAAAIAAYagAAAAEC+mmTb4MYXImNF2Y5CdcIJbqJZszjLt0GZGOjSK2mkCZ3QBIPa5eaI6VpnoIL2kbg==", "e308a270-3995-425a-97e7-2c931f97745b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "33332cdc-fed2-4f93-bd00-2840377d2539", "AQAAAAIAAYagAAAAECyQ43AwiYOxdDL30y50sW70fupHqKfwDfMCqLOIV4oSNkqxCZFTy2nMyvYwUM3w0A==", "e13cebf8-c6e0-4e48-a6bc-f43e4f8b9356" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4de55e3a-6177-445c-b29d-e694079354ee", "AQAAAAIAAYagAAAAEFdqmWslMdYtpTH9FC8HJmPilexJ7bG9vzq1Rp96BcclPKOHiJK1G9/tl0JooAaKCA==", "ad39dfbc-2ae6-44fc-97e7-a3f1de4ad6e7" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "purchases");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "787df263-7be5-47ed-80ca-2cb0a6c74808", "AQAAAAIAAYagAAAAEMYcZtg6YR2iDYBg2IpPzDU39U54ZdtgYxnlyGM86/UVj1Q1pnvWWLuQwJtvSunmKg==", "6c1ec791-fdcf-4861-8265-9c2f67ce1d9a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9483809a-f945-4cda-bdcf-2ee035e5b805", "AQAAAAIAAYagAAAAEI3BYnDs+LJTwUQ7MTbIPzvJ9C2XEBK3MsPh1oNhihr5IGWB0f6ld+xaX08rpfpwiw==", "8eaa54cd-bdb0-419a-8163-01e745541a60" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "38da9b99-8683-42a2-b896-3e16145b3b01", "AQAAAAIAAYagAAAAEHOUOkokn1Ztd28+qFVcnxYGNHsioFyxWz41aDvbxh4Tu/4nc8VwEkbzqfZQQiaghg==", "37e5ea80-e48e-4218-911a-3b6a50edb1be" });
        }
    }
}

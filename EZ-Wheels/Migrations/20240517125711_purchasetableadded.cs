using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EZ_Wheels.Migrations
{
    /// <inheritdoc />
    public partial class purchasetableadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ba192a34-5e39-4537-9ee9-39897619bef2", "AQAAAAIAAYagAAAAENarZoGTJTbEI5FtYtV/mqLAcGa/qz5TSAnFx00trMWQoFHkp/ckc1fmwpgWfoVBaA==", "321d5ec3-0135-459f-83bd-cb761d2443fa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "70af17fb-3735-49b5-a6b1-04ba8dbc2402", "AQAAAAIAAYagAAAAEA88DUTH35XlTrYlccB6xLVBP0BQoyJdIlWNs24+keig8DBe1f70OGiXl3AeQoVtgw==", "c99171ea-2331-428e-9935-c6abd57798f4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "84494528-346c-4568-9acb-df8a3230297a", "AQAAAAIAAYagAAAAEPxvndOiHM5SHPyUfnJQRMQeb94lZA4xiqfzSP2Sdn7K7GBSORCT5sq9E26Mqwk9FA==", "31f44df9-776c-4c20-ad70-6f3b01687cdb" });
        }
    }
}

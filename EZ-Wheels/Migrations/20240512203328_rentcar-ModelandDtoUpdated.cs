using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EZ_Wheels.Migrations
{
    /// <inheritdoc />
    public partial class rentcarModelandDtoUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isInProgress",
                table: "customerRentCars",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isOnlinePaid",
                table: "customerRentCars",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "numberofRentDays",
                table: "customerRentCars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "totalRentPrice",
                table: "customerRentCars",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7196efb7-9773-4994-a363-57b5d11ed823", "AQAAAAIAAYagAAAAEAIGs6H/4ROePqxVDHQEdJDJhYC8CaoTc9US4/JjMPhJTeZgkSxp3N94/vWC9naqiw==", "a9cf027a-3d28-4aea-b356-630b40fb6ff9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b9a71c40-9f3e-4b3a-8be5-c055875836d9", "AQAAAAIAAYagAAAAEDc+irLTJ0Qlxh6KbTsoOQEE7Ct+R4f0d6JXi5JzIJN26zMYfdHeby/aVq4PnylB0A==", "8794616b-df0d-49f8-8796-03ef7aae404b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "869f8734-c39d-463a-868f-7207c4e108ca", "AQAAAAIAAYagAAAAEMvzM5LsodtbDFYsMNjsv/qj2KXuXSfM8ULj+18epxSP579SofBLpmuM7zEg3E/Pqw==", "5f2060e0-d123-477b-979c-2d0e91f179d9" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isInProgress",
                table: "customerRentCars");

            migrationBuilder.DropColumn(
                name: "isOnlinePaid",
                table: "customerRentCars");

            migrationBuilder.DropColumn(
                name: "numberofRentDays",
                table: "customerRentCars");

            migrationBuilder.DropColumn(
                name: "totalRentPrice",
                table: "customerRentCars");

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
    }
}

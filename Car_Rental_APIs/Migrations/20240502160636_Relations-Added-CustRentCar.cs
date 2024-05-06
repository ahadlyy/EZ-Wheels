using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Car_Rental_APIs.Migrations
{
    /// <inheritdoc />
    public partial class RelationsAddedCustRentCar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndingDate",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "StartingDate",
                table: "Cars");

            migrationBuilder.AddColumn<int>(
                name: "Mileage",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfPassengers",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "customerRentCars",
                columns: table => new
                {
                    ReservationNumber = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StartingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PickUpLatitude = table.Column<double>(type: "float", nullable: false),
                    PickUpLongitude = table.Column<double>(type: "float", nullable: false),
                    DropOffLatitude = table.Column<double>(type: "float", nullable: false),
                    DropOffLongitude = table.Column<double>(type: "float", nullable: false),
                    CustomerId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CustomerCarPlateNumber = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customerRentCars", x => x.ReservationNumber);
                    table.ForeignKey(
                        name: "FK_customerRentCars_AspNetUsers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_customerRentCars_Cars_CustomerCarPlateNumber",
                        column: x => x.CustomerCarPlateNumber,
                        principalTable: "Cars",
                        principalColumn: "PlateNumber");
                });

            migrationBuilder.CreateIndex(
                name: "IX_customerRentCars_CustomerCarPlateNumber",
                table: "customerRentCars",
                column: "CustomerCarPlateNumber");

            migrationBuilder.CreateIndex(
                name: "IX_customerRentCars_CustomerId",
                table: "customerRentCars",
                column: "CustomerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "customerRentCars");

            migrationBuilder.DropColumn(
                name: "Mileage",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "NumberOfPassengers",
                table: "Cars");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndingDate",
                table: "Cars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "StartingDate",
                table: "Cars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}

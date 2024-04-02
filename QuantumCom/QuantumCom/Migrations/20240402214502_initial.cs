using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QuantumCom.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Billings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Billings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomerPlans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerPlans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardNumber = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CCV = table.Column<int>(type: "int", nullable: false),
                    PlansId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_CustomerPlans_PlansId",
                        column: x => x.PlansId,
                        principalTable: "CustomerPlans",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Plans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DeviceLimit = table.Column<int>(type: "int", nullable: false),
                    CustomerPlanId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Plans_CustomerPlans_CustomerPlanId",
                        column: x => x.CustomerPlanId,
                        principalTable: "CustomerPlans",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Devices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    CustId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devices", x => new { x.Id, x.CustId });
                    table.ForeignKey(
                        name: "FK_Devices_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Billings",
                columns: new[] { "Id", "Amount", "CustId" },
                values: new object[,]
                {
                    { 1, 200m, 1 },
                    { 2, 500m, 2 },
                    { 3, 1299m, 3 },
                    { 4, 350m, 4 },
                    { 5, 699m, 5 }
                });

            migrationBuilder.InsertData(
                table: "CustomerPlans",
                column: "Id",
                values: new object[]
                {
                    1,
                    2,
                    3,
                    4,
                    5
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CCV", "CardNumber", "CardType", "Email", "ExpirationDate", "FirstName", "LastName", "PlansId" },
                values: new object[,]
                {
                    { 1, 111, "0000000000000000", "Visa", "JohnTest@example.com", new DateTime(2010, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "John", "Test", null },
                    { 2, 123, "1234123412341234", "Mastercard", "Arod@example.com", new DateTime(2024, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aaron", "Rodgers", null },
                    { 3, 111, "9999999999999999", "Amex", "KimMC123@example.com", new DateTime(2026, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kim", "Mccrary", null },
                    { 4, 421, "8888888888888888", "Discover", "MarcusPeters@example.com", new DateTime(2023, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marcus", "Peters", null },
                    { 5, 232, "4321432143214321", "Apple", "LTaylor@example.com", new DateTime(2027, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorenzo", "Taylot", null }
                });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "CustId", "Id", "CustomerId", "Name", "Number" },
                values: new object[,]
                {
                    { 1, 1, null, "Iphone 14", "1111111111" },
                    { 1, 2, null, "Iphone 12 SE", "9012219981" },
                    { 2, 3, null, "Samsung Galaxy S22 Ultra", "9332910021" },
                    { 3, 4, null, "Motorola Edge", "4121229921" },
                    { 4, 5, null, "Iphone 11 S", "3329990192" },
                    { 5, 6, null, "Blackberry OG", "91119119111" }
                });

            migrationBuilder.InsertData(
                table: "Plans",
                columns: new[] { "Id", "CustomerPlanId", "DeviceLimit", "Name", "Price" },
                values: new object[,]
                {
                    { 1, null, 2, "Basic", 100m },
                    { 2, null, 5, "Family", 400m },
                    { 3, null, 15, "Unlimited", 700m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_PlansId",
                table: "Customers",
                column: "PlansId");

            migrationBuilder.CreateIndex(
                name: "IX_Devices_CustomerId",
                table: "Devices",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Plans_CustomerPlanId",
                table: "Plans",
                column: "CustomerPlanId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Billings");

            migrationBuilder.DropTable(
                name: "Devices");

            migrationBuilder.DropTable(
                name: "Plans");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "CustomerPlans");
        }
    }
}

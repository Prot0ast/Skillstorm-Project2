﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QuantumCom.Migrations
{
    /// <inheritdoc />
    public partial class newMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Billings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Billings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Billings",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Billings",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Billings",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CustomerPlans",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CustomerPlans",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CustomerPlans",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CustomerPlans",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CustomerPlans",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumns: new[] { "CustId", "Id" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumns: new[] { "CustId", "Id" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumns: new[] { "CustId", "Id" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumns: new[] { "CustId", "Id" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumns: new[] { "CustId", "Id" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumns: new[] { "CustId", "Id" },
                keyValues: new object[] { 5, 6 });

            migrationBuilder.DeleteData(
                table: "Plans",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Plans",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Plans",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<Guid>(
                name: "CustomerPlanId",
                table: "Plans",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Plans",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<Guid>(
                name: "CustomerId",
                table: "Devices",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "CustId",
                table: "Devices",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Devices",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<Guid>(
                name: "PlansId",
                table: "Customers",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Customers",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "CustomerPlans",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<Guid>(
                name: "CustId",
                table: "Billings",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Billings",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8e196366-7ee5-4f92-8313-8cbb4fd32fb8", null, "Admin", "ADMIN" },
                    { "f0c51658-f60d-4c05-ad9e-3327e5737140", null, "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "Billings",
                columns: new[] { "Id", "Amount", "CustId" },
                values: new object[,]
                {
                    { new Guid("aa62935f-3b2b-4121-8448-c494e55530a7"), 500m, new Guid("dea1f480-6a7e-4efd-9e26-f4387ee99398") },
                    { new Guid("d6a3feb0-6e6c-472b-82fd-ae97b94922af"), 350m, new Guid("d576cdc7-927a-408f-833b-dc12fba5c579") },
                    { new Guid("df7108b0-0222-480b-8fb6-fa039e5aebd5"), 400m, new Guid("54e5ce77-c784-42ab-84d0-0b11d5ec43c3") },
                    { new Guid("ec87d4af-74c3-40f5-9add-a430dd551073"), 699m, new Guid("207e2d46-5364-4b83-b45c-0c27321f3a88") },
                    { new Guid("ff07f3cb-7589-4e77-b1a9-bf90d0e6faab"), 1299m, new Guid("5d1d8eac-2cb6-4f34-9e59-25a3a5ae3473") }
                });

            migrationBuilder.InsertData(
                table: "CustomerPlans",
                column: "Id",
                values: new object[]
                {
                    new Guid("0b5c7ab7-b0e6-4265-a8e4-ef6037f03214"),
                    new Guid("0f321dd1-45bd-45ee-861b-cae561131c61"),
                    new Guid("7d728329-e865-480c-8b50-93ec58617d8f"),
                    new Guid("8d373114-e2fe-449f-9c36-eb50dcb02874"),
                    new Guid("91aca162-93ed-4359-b8e0-22ac8a7998b3")
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CCV", "CardNumber", "CardType", "Email", "ExpirationDate", "FirstName", "LastName", "PlansId" },
                values: new object[,]
                {
                    { new Guid("207e2d46-5364-4b83-b45c-0c27321f3a88"), 232, "4321432143214321", "Apple", "LTaylor@example.com", new DateTime(2027, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorenzo", "Taylor", null },
                    { new Guid("54e5ce77-c784-42ab-84d0-0b11d5ec43c3"), 111, "0000000000000000", "Visa", "JohnTest@example.com", new DateTime(2010, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "John", "Test", null },
                    { new Guid("5d1d8eac-2cb6-4f34-9e59-25a3a5ae3473"), 111, "9999999999999999", "Amex", "KimMC123@example.com", new DateTime(2026, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kim", "Mccrary", null },
                    { new Guid("d576cdc7-927a-408f-833b-dc12fba5c579"), 421, "8888888888888888", "Discover", "MarcusPeters@example.com", new DateTime(2023, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marcus", "Peters", null },
                    { new Guid("dea1f480-6a7e-4efd-9e26-f4387ee99398"), 123, "1234123412341234", "Mastercard", "Arod@example.com", new DateTime(2024, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aaron", "Rodgers", null }
                });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "CustId", "Id", "CustomerId", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("dea1f480-6a7e-4efd-9e26-f4387ee99398"), new Guid("067e0b3f-78db-4f7d-b7eb-d2b803d48418"), null, "Iphone 12 SE", "9012219981" },
                    { new Guid("5d1d8eac-2cb6-4f34-9e59-25a3a5ae3473"), new Guid("28f8bf3e-a6e5-44f7-963a-109404b3b8ce"), null, "Samsung Galaxy S22 Ultra", "9332910021" },
                    { new Guid("d576cdc7-927a-408f-833b-dc12fba5c579"), new Guid("5bbf569d-a79c-424c-b077-9b6dff481c6b"), null, "Motorola Edge", "4121229921" },
                    { new Guid("207e2d46-5364-4b83-b45c-0c27321f3a88"), new Guid("75f89763-1484-456e-a819-3d868343d0c0"), null, "Blackberry OG", "91119119111" },
                    { new Guid("207e2d46-5364-4b83-b45c-0c27321f3a88"), new Guid("a6cbc0d9-d7a8-47ee-95e7-beecb671613d"), null, "Iphone 11 S", "3329990192" },
                    { new Guid("54e5ce77-c784-42ab-84d0-0b11d5ec43c3"), new Guid("eb8fa05e-3380-4e4a-bd5e-bc69b401e110"), null, "Iphone 14", "1111111111" }
                });

            migrationBuilder.InsertData(
                table: "Plans",
                columns: new[] { "Id", "CustomerPlanId", "DeviceLimit", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("37efdae3-1f3d-46e0-8a7b-66a3f6bb5ff3"), null, 15, "Unlimited", 700m },
                    { new Guid("ad449f26-1106-417d-9d96-6c4b962b64a8"), null, 2, "Basic", 100m },
                    { new Guid("d944707b-e51f-4986-9cb5-ab80a87925ea"), null, 5, "Family", 400m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "Billings",
                keyColumn: "Id",
                keyValue: new Guid("aa62935f-3b2b-4121-8448-c494e55530a7"));

            migrationBuilder.DeleteData(
                table: "Billings",
                keyColumn: "Id",
                keyValue: new Guid("d6a3feb0-6e6c-472b-82fd-ae97b94922af"));

            migrationBuilder.DeleteData(
                table: "Billings",
                keyColumn: "Id",
                keyValue: new Guid("df7108b0-0222-480b-8fb6-fa039e5aebd5"));

            migrationBuilder.DeleteData(
                table: "Billings",
                keyColumn: "Id",
                keyValue: new Guid("ec87d4af-74c3-40f5-9add-a430dd551073"));

            migrationBuilder.DeleteData(
                table: "Billings",
                keyColumn: "Id",
                keyValue: new Guid("ff07f3cb-7589-4e77-b1a9-bf90d0e6faab"));

            migrationBuilder.DeleteData(
                table: "CustomerPlans",
                keyColumn: "Id",
                keyValue: new Guid("0b5c7ab7-b0e6-4265-a8e4-ef6037f03214"));

            migrationBuilder.DeleteData(
                table: "CustomerPlans",
                keyColumn: "Id",
                keyValue: new Guid("0f321dd1-45bd-45ee-861b-cae561131c61"));

            migrationBuilder.DeleteData(
                table: "CustomerPlans",
                keyColumn: "Id",
                keyValue: new Guid("7d728329-e865-480c-8b50-93ec58617d8f"));

            migrationBuilder.DeleteData(
                table: "CustomerPlans",
                keyColumn: "Id",
                keyValue: new Guid("8d373114-e2fe-449f-9c36-eb50dcb02874"));

            migrationBuilder.DeleteData(
                table: "CustomerPlans",
                keyColumn: "Id",
                keyValue: new Guid("91aca162-93ed-4359-b8e0-22ac8a7998b3"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("207e2d46-5364-4b83-b45c-0c27321f3a88"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("54e5ce77-c784-42ab-84d0-0b11d5ec43c3"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("5d1d8eac-2cb6-4f34-9e59-25a3a5ae3473"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("d576cdc7-927a-408f-833b-dc12fba5c579"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("dea1f480-6a7e-4efd-9e26-f4387ee99398"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumns: new[] { "CustId", "Id" },
                keyValues: new object[] { new Guid("dea1f480-6a7e-4efd-9e26-f4387ee99398"), new Guid("067e0b3f-78db-4f7d-b7eb-d2b803d48418") });

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumns: new[] { "CustId", "Id" },
                keyValues: new object[] { new Guid("5d1d8eac-2cb6-4f34-9e59-25a3a5ae3473"), new Guid("28f8bf3e-a6e5-44f7-963a-109404b3b8ce") });

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumns: new[] { "CustId", "Id" },
                keyValues: new object[] { new Guid("d576cdc7-927a-408f-833b-dc12fba5c579"), new Guid("5bbf569d-a79c-424c-b077-9b6dff481c6b") });

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumns: new[] { "CustId", "Id" },
                keyValues: new object[] { new Guid("207e2d46-5364-4b83-b45c-0c27321f3a88"), new Guid("75f89763-1484-456e-a819-3d868343d0c0") });

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumns: new[] { "CustId", "Id" },
                keyValues: new object[] { new Guid("207e2d46-5364-4b83-b45c-0c27321f3a88"), new Guid("a6cbc0d9-d7a8-47ee-95e7-beecb671613d") });

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumns: new[] { "CustId", "Id" },
                keyValues: new object[] { new Guid("54e5ce77-c784-42ab-84d0-0b11d5ec43c3"), new Guid("eb8fa05e-3380-4e4a-bd5e-bc69b401e110") });

            migrationBuilder.DeleteData(
                table: "Plans",
                keyColumn: "Id",
                keyValue: new Guid("37efdae3-1f3d-46e0-8a7b-66a3f6bb5ff3"));

            migrationBuilder.DeleteData(
                table: "Plans",
                keyColumn: "Id",
                keyValue: new Guid("ad449f26-1106-417d-9d96-6c4b962b64a8"));

            migrationBuilder.DeleteData(
                table: "Plans",
                keyColumn: "Id",
                keyValue: new Guid("d944707b-e51f-4986-9cb5-ab80a87925ea"));

            migrationBuilder.AlterColumn<int>(
                name: "CustomerPlanId",
                table: "Plans",
                type: "int",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Plans",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Devices",
                type: "int",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CustId",
                table: "Devices",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Devices",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<int>(
                name: "PlansId",
                table: "Customers",
                type: "int",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Customers",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "CustomerPlans",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "CustId",
                table: "Billings",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Billings",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier")
                .Annotation("SqlServer:Identity", "1, 1");

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
        }
    }
}

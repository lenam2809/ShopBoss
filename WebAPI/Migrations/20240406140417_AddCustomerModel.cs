using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddCustomerModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("154b5838-09b0-447f-af36-390be7d32cd2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("637c8696-ace9-4c54-8a02-b861ff9f4222"));

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Orders",
                newName: "CustomerId");

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Address", "Email", "Name" },
                values: new object[,]
                {
                    { new Guid("1958dc9e-742f-4377-85e9-fec4b6a6442a"), "Paris", "john@example.com", "John Doe" },
                    { new Guid("2958dc9e-742f-4377-85e9-fec4b6a6442a"), "New York", "jane@example.com", "Jane Smith" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Description", "Name", "Price", "StockQuantity" },
                values: new object[,]
                {
                    { new Guid("74b08587-2a38-4375-907c-496b78dd6d1c"), new Guid("3958dc9e-742f-4377-85e9-fec4b6a6442a"), "Description of Product 1", "Product 1", 10.99m, 100 },
                    { new Guid("7c5f7003-3cce-4a7d-93a2-a054d8b641fc"), new Guid("3958dc9e-742f-4377-85e9-fec4b6a6442b"), "Description of Product 2", "Product 2", 20.49m, 50 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("74b08587-2a38-4375-907c-496b78dd6d1c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("7c5f7003-3cce-4a7d-93a2-a054d8b641fc"));

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Orders",
                newName: "UserId");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Description", "Name", "Price", "StockQuantity" },
                values: new object[,]
                {
                    { new Guid("154b5838-09b0-447f-af36-390be7d32cd2"), new Guid("3958dc9e-742f-4377-85e9-fec4b6a6442b"), "Description of Product 2", "Product 2", 20.49m, 50 },
                    { new Guid("637c8696-ace9-4c54-8a02-b861ff9f4222"), new Guid("3958dc9e-742f-4377-85e9-fec4b6a6442a"), "Description of Product 1", "Product 1", 10.99m, 100 }
                });
        }
    }
}

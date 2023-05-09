using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkClassLibrary.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(nullable: false),
                    CategoryName = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    Description = table.Column<string>(unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__categori__19093A2B5A1AE066", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "customers",
                columns: table => new
                {
                    CustomerID = table.Column<int>(nullable: false),
                    CustomerName = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    ContactName = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    Address = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    City = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    PostalCode = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    Country = table.Column<string>(unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__customer__A4AE64B8DFBCDF38", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(nullable: false),
                    LastName = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    FirstName = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    BirthDate = table.Column<DateTime>(type: "date", nullable: true),
                    Photo = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    Notes = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__employee__7AD04FF1F8CF4C1C", x => x.EmployeeID);
                });

            migrationBuilder.CreateTable(
                name: "orders",
                columns: table => new
                {
                    OrderID = table.Column<int>(nullable: false),
                    CustomerID = table.Column<int>(nullable: true),
                    EmployeeID = table.Column<int>(nullable: true),
                    OrderDate = table.Column<DateTime>(type: "date", nullable: true),
                    ShipperID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__orders__C3905BAFFF7C4C68", x => x.OrderID);
                });

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    ProductID = table.Column<int>(nullable: false),
                    ProductName = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    SupplierID = table.Column<int>(nullable: true),
                    CategoryID = table.Column<int>(nullable: true),
                    Unit = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18, 0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__products__B40CC6ED3FE12840", x => x.ProductID);
                });

            migrationBuilder.CreateTable(
                name: "shippers",
                columns: table => new
                {
                    ShipperID = table.Column<int>(nullable: false),
                    ShipperName = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    Phone = table.Column<string>(unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "suppliers",
                columns: table => new
                {
                    SupplierID = table.Column<int>(nullable: false),
                    SupplierName = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    ContactName = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    Address = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    City = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    PostalCode = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    Country = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    Phone = table.Column<string>(unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__supplier__4BE666944E339601", x => x.SupplierID);
                });

            migrationBuilder.CreateTable(
                name: "order_details",
                columns: table => new
                {
                    OrderDetailID = table.Column<int>(nullable: false),
                    OrderID = table.Column<int>(nullable: true),
                    ProductID = table.Column<int>(nullable: true),
                    Quantity = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK__order_det__Order__6477ECF3",
                        column: x => x.OrderID,
                        principalTable: "orders",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__order_det__Produ__656C112C",
                        column: x => x.ProductID,
                        principalTable: "products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_order_details_OrderID",
                table: "order_details",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_order_details_ProductID",
                table: "order_details",
                column: "ProductID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "categories");

            migrationBuilder.DropTable(
                name: "customers");

            migrationBuilder.DropTable(
                name: "employees");

            migrationBuilder.DropTable(
                name: "order_details");

            migrationBuilder.DropTable(
                name: "shippers");

            migrationBuilder.DropTable(
                name: "suppliers");

            migrationBuilder.DropTable(
                name: "orders");

            migrationBuilder.DropTable(
                name: "products");
        }
    }
}

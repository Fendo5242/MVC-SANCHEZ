using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_SANCHEZ.Migrations
{
    /// <inheritdoc />
    public partial class v1_crearbasededatos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    IdCustomers = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DocumentNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.IdCustomers);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    IdProducts = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.IdProducts);
                });

            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    IdInvoices = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Customers_IdCustomers = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InvoiceNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Total = table.Column<float>(type: "real", nullable: false),
                    CustomerIdCustomers = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.IdInvoices);
                    table.ForeignKey(
                        name: "FK_Invoices_Customers_CustomerIdCustomers",
                        column: x => x.CustomerIdCustomers,
                        principalTable: "Customers",
                        principalColumn: "IdCustomers",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Details",
                columns: table => new
                {
                    IdDetails = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Products_IdProducts = table.Column<int>(type: "int", nullable: false),
                    Invoices_IdInvoices = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    SubTotal = table.Column<float>(type: "real", nullable: false),
                    ProductIdProducts = table.Column<int>(type: "int", nullable: false),
                    InvoiceIdInvoices = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Details", x => x.IdDetails);
                    table.ForeignKey(
                        name: "FK_Details_Invoices_InvoiceIdInvoices",
                        column: x => x.InvoiceIdInvoices,
                        principalTable: "Invoices",
                        principalColumn: "IdInvoices",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Details_Products_ProductIdProducts",
                        column: x => x.ProductIdProducts,
                        principalTable: "Products",
                        principalColumn: "IdProducts",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Details_InvoiceIdInvoices",
                table: "Details",
                column: "InvoiceIdInvoices");

            migrationBuilder.CreateIndex(
                name: "IX_Details_ProductIdProducts",
                table: "Details",
                column: "ProductIdProducts");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_CustomerIdCustomers",
                table: "Invoices",
                column: "CustomerIdCustomers");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Details");

            migrationBuilder.DropTable(
                name: "Invoices");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}

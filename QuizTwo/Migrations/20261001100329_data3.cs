using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuizTwo.Migrations
{
    /// <inheritdoc />
    public partial class data3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Sales_SaleId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Vehicles");

            migrationBuilder.RenameIndex(
                name: "IX_Products_VIN",
                table: "Vehicles",
                newName: "IX_Vehicles_VIN");

            migrationBuilder.RenameIndex(
                name: "IX_Products_SaleId",
                table: "Vehicles",
                newName: "IX_Vehicles_SaleId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_CategoryId",
                table: "Vehicles",
                newName: "IX_Vehicles_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vehicles",
                table: "Vehicles",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "CustomerProfiles",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2026, 10, 1, 13, 3, 28, 301, DateTimeKind.Local).AddTicks(9218));

            migrationBuilder.UpdateData(
                table: "CustomerProfiles",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(2026, 10, 1, 13, 3, 28, 301, DateTimeKind.Local).AddTicks(9358));

            migrationBuilder.UpdateData(
                table: "CustomerProfiles",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfBirth",
                value: new DateTime(2026, 10, 1, 13, 3, 28, 301, DateTimeKind.Local).AddTicks(9367));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2026, 10, 1, 13, 3, 28, 301, DateTimeKind.Local).AddTicks(9435));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "HireDate",
                value: new DateTime(2026, 10, 1, 13, 3, 28, 301, DateTimeKind.Local).AddTicks(9444));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "HireDate",
                value: new DateTime(2026, 10, 1, 13, 3, 28, 301, DateTimeKind.Local).AddTicks(9449));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 1,
                column: "SalesDate",
                value: new DateTime(2026, 10, 1, 13, 3, 28, 301, DateTimeKind.Local).AddTicks(9508));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 2,
                column: "SalesDate",
                value: new DateTime(2026, 10, 1, 13, 3, 28, 301, DateTimeKind.Local).AddTicks(9515));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 3,
                column: "SalesDate",
                value: new DateTime(2026, 10, 1, 13, 3, 28, 301, DateTimeKind.Local).AddTicks(9520));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Color",
                value: "blue");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Color",
                value: "blue");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Color",
                value: "blue");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Categories_CategoryId",
                table: "Vehicles",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Sales_SaleId",
                table: "Vehicles",
                column: "SaleId",
                principalTable: "Sales",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Categories_CategoryId",
                table: "Vehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Sales_SaleId",
                table: "Vehicles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vehicles",
                table: "Vehicles");

            migrationBuilder.RenameTable(
                name: "Vehicles",
                newName: "Products");

            migrationBuilder.RenameIndex(
                name: "IX_Vehicles_VIN",
                table: "Products",
                newName: "IX_Products_VIN");

            migrationBuilder.RenameIndex(
                name: "IX_Vehicles_SaleId",
                table: "Products",
                newName: "IX_Products_SaleId");

            migrationBuilder.RenameIndex(
                name: "IX_Vehicles_CategoryId",
                table: "Products",
                newName: "IX_Products_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "CustomerProfiles",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2026, 10, 1, 13, 1, 29, 556, DateTimeKind.Local).AddTicks(8016));

            migrationBuilder.UpdateData(
                table: "CustomerProfiles",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(2026, 10, 1, 13, 1, 29, 556, DateTimeKind.Local).AddTicks(8150));

            migrationBuilder.UpdateData(
                table: "CustomerProfiles",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfBirth",
                value: new DateTime(2026, 10, 1, 13, 1, 29, 556, DateTimeKind.Local).AddTicks(8155));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2026, 10, 1, 13, 1, 29, 556, DateTimeKind.Local).AddTicks(8213));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "HireDate",
                value: new DateTime(2026, 10, 1, 13, 1, 29, 556, DateTimeKind.Local).AddTicks(8220));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "HireDate",
                value: new DateTime(2026, 10, 1, 13, 1, 29, 556, DateTimeKind.Local).AddTicks(8226));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Color",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Color",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Color",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 1,
                column: "SalesDate",
                value: new DateTime(2026, 10, 1, 13, 1, 29, 556, DateTimeKind.Local).AddTicks(8289));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 2,
                column: "SalesDate",
                value: new DateTime(2026, 10, 1, 13, 1, 29, 556, DateTimeKind.Local).AddTicks(8300));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 3,
                column: "SalesDate",
                value: new DateTime(2026, 10, 1, 13, 1, 29, 556, DateTimeKind.Local).AddTicks(8304));

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Sales_SaleId",
                table: "Products",
                column: "SaleId",
                principalTable: "Sales",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

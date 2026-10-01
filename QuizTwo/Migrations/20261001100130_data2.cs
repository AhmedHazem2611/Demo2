using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuizTwo.Migrations
{
    /// <inheritdoc />
    public partial class data2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerProfiles_Customers_CustomerId",
                table: "CustomerProfiles");

            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Products_VehicleId",
                table: "Sales");

            migrationBuilder.DropIndex(
                name: "IX_Sales_VehicleId",
                table: "Sales");

            migrationBuilder.DropIndex(
                name: "IX_CustomerProfiles_CustomerId",
                table: "CustomerProfiles");

            migrationBuilder.DropColumn(
                name: "VehicleId",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "CustomerProfiles");

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
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CustomerProfileId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CustomerProfileId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CustomerProfileId",
                value: 3);

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
                column: "SaleId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "SaleId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "SaleId",
                value: 3);

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

            migrationBuilder.CreateIndex(
                name: "IX_Products_SaleId",
                table: "Products",
                column: "SaleId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CustomerProfileId",
                table: "Customers",
                column: "CustomerProfileId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_CustomerProfiles_CustomerProfileId",
                table: "Customers",
                column: "CustomerProfileId",
                principalTable: "CustomerProfiles",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_CustomerProfiles_CustomerProfileId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Sales_SaleId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_SaleId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Customers_CustomerProfileId",
                table: "Customers");

            migrationBuilder.AddColumn<int>(
                name: "VehicleId",
                table: "Sales",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "CustomerProfiles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "CustomerProfiles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CustomerId", "DateOfBirth" },
                values: new object[] { 1, new DateTime(2026, 10, 1, 12, 53, 30, 833, DateTimeKind.Local).AddTicks(2649) });

            migrationBuilder.UpdateData(
                table: "CustomerProfiles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CustomerId", "DateOfBirth" },
                values: new object[] { 2, new DateTime(2026, 10, 1, 12, 53, 30, 833, DateTimeKind.Local).AddTicks(2808) });

            migrationBuilder.UpdateData(
                table: "CustomerProfiles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CustomerId", "DateOfBirth" },
                values: new object[] { 3, new DateTime(2026, 10, 1, 12, 53, 30, 833, DateTimeKind.Local).AddTicks(2812) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CustomerProfileId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CustomerProfileId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CustomerProfileId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2026, 10, 1, 12, 53, 30, 833, DateTimeKind.Local).AddTicks(2878));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "HireDate",
                value: new DateTime(2026, 10, 1, 12, 53, 30, 833, DateTimeKind.Local).AddTicks(2886));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "HireDate",
                value: new DateTime(2026, 10, 1, 12, 53, 30, 833, DateTimeKind.Local).AddTicks(2891));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "SaleId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "SaleId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "SaleId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "SalesDate", "VehicleId" },
                values: new object[] { new DateTime(2026, 10, 1, 12, 53, 30, 833, DateTimeKind.Local).AddTicks(2948), 1 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "SalesDate", "VehicleId" },
                values: new object[] { new DateTime(2026, 10, 1, 12, 53, 30, 833, DateTimeKind.Local).AddTicks(2957), 2 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "SalesDate", "VehicleId" },
                values: new object[] { new DateTime(2026, 10, 1, 12, 53, 30, 833, DateTimeKind.Local).AddTicks(2962), 3 });

            migrationBuilder.CreateIndex(
                name: "IX_Sales_VehicleId",
                table: "Sales",
                column: "VehicleId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CustomerProfiles_CustomerId",
                table: "CustomerProfiles",
                column: "CustomerId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerProfiles_Customers_CustomerId",
                table: "CustomerProfiles",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Products_VehicleId",
                table: "Sales",
                column: "VehicleId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

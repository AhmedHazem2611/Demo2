using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuizTwo.Migrations
{
    /// <inheritdoc />
    public partial class saleidNull : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Sales_SaleId",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_SaleId",
                table: "Vehicles");

            migrationBuilder.AlterColumn<int>(
                name: "SaleId",
                table: "Vehicles",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "CustomerProfiles",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2026, 10, 4, 12, 8, 47, 139, DateTimeKind.Local).AddTicks(4505));

            migrationBuilder.UpdateData(
                table: "CustomerProfiles",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(2026, 10, 4, 12, 8, 47, 139, DateTimeKind.Local).AddTicks(4686));

            migrationBuilder.UpdateData(
                table: "CustomerProfiles",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfBirth",
                value: new DateTime(2026, 10, 4, 12, 8, 47, 139, DateTimeKind.Local).AddTicks(4699));

            migrationBuilder.UpdateData(
                table: "CustomerProfiles",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfBirth",
                value: new DateTime(2026, 10, 4, 12, 8, 47, 139, DateTimeKind.Local).AddTicks(4709));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2026, 10, 4, 12, 8, 47, 139, DateTimeKind.Local).AddTicks(4807));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "HireDate",
                value: new DateTime(2026, 10, 4, 12, 8, 47, 139, DateTimeKind.Local).AddTicks(4823));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "HireDate",
                value: new DateTime(2026, 10, 4, 12, 8, 47, 139, DateTimeKind.Local).AddTicks(4835));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 1,
                column: "SalesDate",
                value: new DateTime(2026, 10, 4, 12, 8, 47, 139, DateTimeKind.Local).AddTicks(4916));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 2,
                column: "SalesDate",
                value: new DateTime(2026, 10, 4, 12, 8, 47, 139, DateTimeKind.Local).AddTicks(4934));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 3,
                column: "SalesDate",
                value: new DateTime(2026, 10, 4, 12, 8, 47, 139, DateTimeKind.Local).AddTicks(4944));

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_SaleId",
                table: "Vehicles",
                column: "SaleId",
                unique: true,
                filter: "[SaleId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Sales_SaleId",
                table: "Vehicles",
                column: "SaleId",
                principalTable: "Sales",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Sales_SaleId",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_SaleId",
                table: "Vehicles");

            migrationBuilder.AlterColumn<int>(
                name: "SaleId",
                table: "Vehicles",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "CustomerProfiles",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2026, 10, 4, 11, 54, 55, 340, DateTimeKind.Local).AddTicks(3501));

            migrationBuilder.UpdateData(
                table: "CustomerProfiles",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(2026, 10, 4, 11, 54, 55, 340, DateTimeKind.Local).AddTicks(3655));

            migrationBuilder.UpdateData(
                table: "CustomerProfiles",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfBirth",
                value: new DateTime(2026, 10, 4, 11, 54, 55, 340, DateTimeKind.Local).AddTicks(3667));

            migrationBuilder.UpdateData(
                table: "CustomerProfiles",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfBirth",
                value: new DateTime(2026, 10, 4, 11, 54, 55, 340, DateTimeKind.Local).AddTicks(3678));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2026, 10, 4, 11, 54, 55, 340, DateTimeKind.Local).AddTicks(3751));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "HireDate",
                value: new DateTime(2026, 10, 4, 11, 54, 55, 340, DateTimeKind.Local).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "HireDate",
                value: new DateTime(2026, 10, 4, 11, 54, 55, 340, DateTimeKind.Local).AddTicks(3779));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 1,
                column: "SalesDate",
                value: new DateTime(2026, 10, 4, 11, 54, 55, 340, DateTimeKind.Local).AddTicks(3854));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 2,
                column: "SalesDate",
                value: new DateTime(2026, 10, 4, 11, 54, 55, 340, DateTimeKind.Local).AddTicks(3869));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 3,
                column: "SalesDate",
                value: new DateTime(2026, 10, 4, 11, 54, 55, 340, DateTimeKind.Local).AddTicks(3880));

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_SaleId",
                table: "Vehicles",
                column: "SaleId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Sales_SaleId",
                table: "Vehicles",
                column: "SaleId",
                principalTable: "Sales",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

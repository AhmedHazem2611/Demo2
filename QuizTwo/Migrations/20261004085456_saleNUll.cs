using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuizTwo.Migrations
{
    /// <inheritdoc />
    public partial class saleNUll : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CustomerProfiles",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2026, 10, 4, 11, 31, 49, 732, DateTimeKind.Local).AddTicks(8296));

            migrationBuilder.UpdateData(
                table: "CustomerProfiles",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(2026, 10, 4, 11, 31, 49, 732, DateTimeKind.Local).AddTicks(8415));

            migrationBuilder.UpdateData(
                table: "CustomerProfiles",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfBirth",
                value: new DateTime(2026, 10, 4, 11, 31, 49, 732, DateTimeKind.Local).AddTicks(8426));

            migrationBuilder.UpdateData(
                table: "CustomerProfiles",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfBirth",
                value: new DateTime(2026, 10, 4, 11, 31, 49, 732, DateTimeKind.Local).AddTicks(8436));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2026, 10, 4, 11, 31, 49, 732, DateTimeKind.Local).AddTicks(8513));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "HireDate",
                value: new DateTime(2026, 10, 4, 11, 31, 49, 732, DateTimeKind.Local).AddTicks(8528));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "HireDate",
                value: new DateTime(2026, 10, 4, 11, 31, 49, 732, DateTimeKind.Local).AddTicks(8539));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 1,
                column: "SalesDate",
                value: new DateTime(2026, 10, 4, 11, 31, 49, 732, DateTimeKind.Local).AddTicks(8607));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 2,
                column: "SalesDate",
                value: new DateTime(2026, 10, 4, 11, 31, 49, 732, DateTimeKind.Local).AddTicks(8620));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 3,
                column: "SalesDate",
                value: new DateTime(2026, 10, 4, 11, 31, 49, 732, DateTimeKind.Local).AddTicks(8631));
        }
    }
}

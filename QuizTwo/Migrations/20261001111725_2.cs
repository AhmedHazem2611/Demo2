using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuizTwo.Migrations
{
    /// <inheritdoc />
    public partial class _2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CustomerProfiles",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2026, 10, 1, 14, 17, 23, 805, DateTimeKind.Local).AddTicks(2219));

            migrationBuilder.UpdateData(
                table: "CustomerProfiles",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(2026, 10, 1, 14, 17, 23, 805, DateTimeKind.Local).AddTicks(2329));

            migrationBuilder.UpdateData(
                table: "CustomerProfiles",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfBirth",
                value: new DateTime(2026, 10, 1, 14, 17, 23, 805, DateTimeKind.Local).AddTicks(2333));

            migrationBuilder.InsertData(
                table: "CustomerProfiles",
                columns: new[] { "Id", "Address", "City", "DateOfBirth", "Nationality" },
                values: new object[] { 4, "321 Pine St", "Houston", new DateTime(2026, 10, 1, 14, 17, 23, 805, DateTimeKind.Local).AddTicks(2337), "Egyptian" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2026, 10, 1, 14, 17, 23, 805, DateTimeKind.Local).AddTicks(2477));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "HireDate",
                value: new DateTime(2026, 10, 1, 14, 17, 23, 805, DateTimeKind.Local).AddTicks(2488));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "HireDate",
                value: new DateTime(2026, 10, 1, 14, 17, 23, 805, DateTimeKind.Local).AddTicks(2493));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 1,
                column: "SalesDate",
                value: new DateTime(2026, 10, 1, 14, 17, 23, 805, DateTimeKind.Local).AddTicks(2544));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 2,
                column: "SalesDate",
                value: new DateTime(2026, 10, 1, 14, 17, 23, 805, DateTimeKind.Local).AddTicks(2550));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 3,
                column: "SalesDate",
                value: new DateTime(2026, 10, 1, 14, 17, 23, 805, DateTimeKind.Local).AddTicks(2555));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CustomerProfiles",
                keyColumn: "Id",
                keyValue: 4);

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
        }
    }
}

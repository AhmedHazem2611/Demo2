using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuizTwo.Migrations
{
    /// <inheritdoc />
    public partial class vehcileid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VehicleId",
                table: "Sales",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                columns: new[] { "SalesDate", "VehicleId" },
                values: new object[] { new DateTime(2026, 10, 4, 11, 31, 49, 732, DateTimeKind.Local).AddTicks(8607), 0 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "SalesDate", "VehicleId" },
                values: new object[] { new DateTime(2026, 10, 4, 11, 31, 49, 732, DateTimeKind.Local).AddTicks(8620), 0 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "SalesDate", "VehicleId" },
                values: new object[] { new DateTime(2026, 10, 4, 11, 31, 49, 732, DateTimeKind.Local).AddTicks(8631), 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VehicleId",
                table: "Sales");

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

            migrationBuilder.UpdateData(
                table: "CustomerProfiles",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfBirth",
                value: new DateTime(2026, 10, 1, 14, 17, 23, 805, DateTimeKind.Local).AddTicks(2337));

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
    }
}

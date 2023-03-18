using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorSyncfusionCm.Server.Migrations
{
    /// <inheritdoc />
    public partial class LatLong : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Latitude",
                table: "Contacts",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Longitude",
                table: "Contacts",
                type: "float",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "Latitude", "Longitude" },
                values: new object[] { new DateTime(2023, 3, 18, 15, 2, 24, 167, DateTimeKind.Local).AddTicks(8972), null, null });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "Latitude", "Longitude" },
                values: new object[] { new DateTime(2023, 3, 18, 15, 2, 24, 167, DateTimeKind.Local).AddTicks(9022), null, null });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "Latitude", "Longitude" },
                values: new object[] { new DateTime(2023, 3, 18, 15, 2, 24, 167, DateTimeKind.Local).AddTicks(9025), null, null });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 3, 18, 15, 2, 24, 167, DateTimeKind.Local).AddTicks(9138));

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 3, 18, 15, 2, 24, 167, DateTimeKind.Local).AddTicks(9142));

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 3, 18, 15, 2, 24, 167, DateTimeKind.Local).AddTicks(9144));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "Contacts");

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 3, 18, 14, 55, 9, 524, DateTimeKind.Local).AddTicks(164));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 3, 18, 14, 55, 9, 524, DateTimeKind.Local).AddTicks(214));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 3, 18, 14, 55, 9, 524, DateTimeKind.Local).AddTicks(217));

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 3, 18, 14, 55, 9, 524, DateTimeKind.Local).AddTicks(424));

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 3, 18, 14, 55, 9, 524, DateTimeKind.Local).AddTicks(428));

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 3, 18, 14, 55, 9, 524, DateTimeKind.Local).AddTicks(430));
        }
    }
}

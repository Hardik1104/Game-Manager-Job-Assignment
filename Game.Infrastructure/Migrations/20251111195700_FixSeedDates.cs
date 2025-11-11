using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Game.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixSeedDates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 11, 11, 14, 53, 29, 263, DateTimeKind.Local).AddTicks(8021), new DateTime(2025, 11, 11, 14, 53, 29, 265, DateTimeKind.Local).AddTicks(7753) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 11, 11, 14, 53, 29, 280, DateTimeKind.Local).AddTicks(9792), new DateTime(2025, 11, 11, 14, 53, 29, 280, DateTimeKind.Local).AddTicks(9859) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 11, 11, 14, 53, 29, 280, DateTimeKind.Local).AddTicks(9933), new DateTime(2025, 11, 11, 14, 53, 29, 280, DateTimeKind.Local).AddTicks(9935) });
        }
    }
}

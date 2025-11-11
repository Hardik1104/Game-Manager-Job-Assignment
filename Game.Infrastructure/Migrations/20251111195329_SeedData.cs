using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Game.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "AddedOn", "Description", "Genres", "LaunchDate", "ModifiedOn", "Rating", "Tags", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 11, 11, 14, 53, 29, 263, DateTimeKind.Local).AddTicks(8021), "Grand Theft Auto V is a 2013 action-adventure game developed by Rockstar North and published by Rockstar Games. It is the seventh main entry in the Grand Theft Auto series, following 2008's Grand Theft Auto IV", "Open world,Action-adventure,First-Person Shooter", new DateTime(2013, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 11, 11, 14, 53, 29, 265, DateTimeKind.Local).AddTicks(7753), 9, "#OpenWorld#Adventure#Shooting#RockstarGames", "Grand Theft Auto V" },
                    { 2, new DateTime(2025, 11, 11, 14, 53, 29, 280, DateTimeKind.Local).AddTicks(9792), "Red Dead Redemption 2 is a 2018 action-adventure game developed and published by Rockstar Games. The game is the third entry in the Red Dead series and a prequel to the 2010 game Red Dead Redemption.", "Open world,Action-adventure,Western", new DateTime(2018, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 11, 11, 14, 53, 29, 280, DateTimeKind.Local).AddTicks(9859), 9, "#OpenWorld#Adventure#Shooting", "Red Dead Redemption 2" },
                    { 3, new DateTime(2025, 11, 11, 14, 53, 29, 280, DateTimeKind.Local).AddTicks(9933), "God of War is a third-person action-adventure video game. It features an over-the-shoulder free camera (a departure from the previous installments which featured a fixed cinematic camera, with the exception of 2007's two-dimensional side-scroller Betrayal)", "Open world,Action-adventure, Hack and slash,Puzzle,Role-playing", new DateTime(2022, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 11, 11, 14, 53, 29, 280, DateTimeKind.Local).AddTicks(9935), 10, "#OpenWorld#Adventure#RolePlaying#Kartos##Loki#Norse#Mythology", "God of War" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyWatchList.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WatchItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    IsWatched = table.Column<bool>(type: "bit", nullable: false),
                    WatchDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WatchItems", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "WatchItems",
                columns: new[] { "Id", "Description", "IsWatched", "Title", "Type", "WatchDate" },
                values: new object[,]
                {
                    { 1, "Avrupa Yakası", true, "Inception", "Series", new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Harry Potter", true, "Breaking Bad", "Movie", new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Aslanlar Alemi", false, "The Matrix", "Movie", null },
                    { 4, "Gibi", false, "Stranger Things", "Series", null },
                    { 5, "Mahsun J", true, "The Godfather", "Movie", new DateTime(2025, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "Doctor whol", false, "Interstellar", "Movie", null }
                });
        }

    }
}

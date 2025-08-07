using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace REST_API.Migrations
{
    /// <inheritdoc />
    public partial class addedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorName", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Arpan Dev", "A beginner's guide to C#", "C# Programming", 29.99m },
                    { 2, "Arpan Dev", "Learn to build APIs with ASP.NET Core", "ASP.NET Core Web API", 34.99m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}

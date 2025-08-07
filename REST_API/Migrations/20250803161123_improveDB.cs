using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace REST_API.Migrations
{
    /// <inheritdoc />
    public partial class improveDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Books",
                type: "decimal(10,2)",
                precision: 10,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Books",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "AuthorName",
                table: "Books",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorName", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 3, "Julie Lerman", "Master Entity Framework Core", "EF Core In Action", 32.50m },
                    { 4, "Joe Smith", "Learn LINQ from basics to advanced", "LINQ Fundamentals", 27.00m },
                    { 5, "John Taylor", "Create modern websites with Razor Pages", "ASP.NET Razor Pages", 23.49m },
                    { 6, "Robert C. Martin", "Write maintainable and readable code", "Clean Code", 42.95m },
                    { 7, "Arpan Dev", "Classic design patterns with C#", "Design Patterns in C#", 39.99m },
                    { 8, "Jane Doe", "Concurrency and parallelism in C#", "Multithreading in C#", 35.75m },
                    { 9, "Mark Allen", "Practical data structures for developers", "Data Structures", 31.99m },
                    { 10, "Arpan Dev", "Test your .NET code with xUnit", "Unit Testing with xUnit", 28.95m },
                    { 11, "Sam Hill", "Build scalable microservices", "Microservices with .NET", 43.99m },
                    { 12, "Lara Hughes", "Protect your apps from common threats", "Web Security Essentials", 25.00m },
                    { 13, "Arpan Dev", "Build interactive UIs with Blazor", "Blazor in Depth", 37.20m },
                    { 14, "Rahul Patel", "Best practices for designing RESTful APIs", "REST API Design", 30.10m },
                    { 15, "Alice Moore", "Improve and optimize legacy code", "Refactoring C# Code", 41.99m },
                    { 16, "Tom Johnson", "Version control using Git and GitHub", "Git for Developers", 19.99m },
                    { 17, "Emily Zhang", "Comparison of two data access strategies", "Dapper vs EF Core", 26.95m },
                    { 18, "Arpan Dev", "Real-time features with SignalR", "SignalR Real-time Apps", 33.00m },
                    { 19, "Brian Lee", "How to log and monitor .NET apps", "Logging in ASP.NET", 21.99m },
                    { 20, "Arpan Dev", "Hidden gems and performance tricks", "Advanced C# Tips", 36.45m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Books",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)",
                oldPrecision: 10,
                oldScale: 2);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "AuthorName",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);
        }
    }
}

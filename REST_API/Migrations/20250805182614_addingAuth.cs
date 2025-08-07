using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace REST_API.Migrations
{
    /// <inheritdoc />
    public partial class addingAuth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AuthUser",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Role = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthUser", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AuthUser",
                columns: new[] { "Id", "Email", "Password", "Role", "UserName" },
                values: new object[,]
                {
                    { 1, "admin1@example.com", "Admin@123", "Admin", "AdminOne" },
                    { 2, "admin2@example.com", "Admin@234", "Admin", "AdminTwo" },
                    { 3, "admin3@example.com", "Admin@345", "Admin", "AdminThree" },
                    { 4, "admin4@example.com", "Admin@456", "Admin", "AdminFour" },
                    { 5, "admin5@example.com", "Admin@567", "Admin", "AdminFive" },
                    { 6, "user1@example.com", "User@123", "User", "UserOne" },
                    { 7, "user2@example.com", "User@234", "User", "UserTwo" },
                    { 8, "user3@example.com", "User@345", "User", "UserThree" },
                    { 9, "user4@example.com", "User@456", "User", "UserFour" },
                    { 10, "user5@example.com", "User@567", "User", "UserFive" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuthUser");
        }
    }
}

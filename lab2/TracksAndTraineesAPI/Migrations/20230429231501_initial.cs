using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TracksAndTraineesAPI.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tracks",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tracks", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Trainees",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MobileNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Birthdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsGraduated = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainees", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "ID", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "This is the first item.", "First Item" },
                    { 2, "This is the second item.", "Second Item" },
                    { 3, "This is the third item.", "Third Item" }
                });

            migrationBuilder.InsertData(
                table: "Trainees",
                columns: new[] { "ID", "Birthdate", "Email", "Gender", "IsGraduated", "MobileNo", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(1995, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "ahmedhassan@example.com", 0, false, "+201234567890", "Ahmed Hassan" },
                    { 2, new DateTime(1998, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "mariamali@example.com", 1, true, "+201112345678", "Mariam Ali" },
                    { 3, new DateTime(2001, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "omarmahmoud@example.com", 0, false, "+201987654321", "Omar Mahmoud" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tracks");

            migrationBuilder.DropTable(
                name: "Trainees");
        }
    }
}

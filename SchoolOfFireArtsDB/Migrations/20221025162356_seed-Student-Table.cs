using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolOfFineArtsDB.Migrations
{
    public partial class seedStudentTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "DateOfBirth", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(1984, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anne", "Sullivan" },
                    { 2, new DateTime(1984, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maria", "Montessori" },
                    { 3, new DateTime(1984, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "William", "McGuffey" },
                    { 4, new DateTime(1984, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Emma", "Willard" },
                    { 5, new DateTime(1984, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jaime", "Escalante" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}

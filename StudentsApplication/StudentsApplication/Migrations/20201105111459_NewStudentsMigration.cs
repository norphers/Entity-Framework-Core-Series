using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentsApplication.Migrations
{
    public partial class NewStudentsMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("3398544f-756e-476b-8839-88a5a5cdf6e6"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("7a393d79-ec68-4292-ac62-45c7f26c18d1"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("be2b5622-bfc4-40e8-bce1-fa8fbcb814e6"));

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "Age", "Name" },
                values: new object[,]
                {
                    { new Guid("31d0b276-f175-4d6d-bc3f-afa8777caf8f"), 30, "John Doe" },
                    { new Guid("3287a62e-9f49-4655-ae0e-ba0ac04630be"), 25, "Jane Doe" },
                    { new Guid("cee77ebd-82eb-436b-a018-5f6affa11c89"), 28, "Mike Miles" },
                    { new Guid("a7df0328-d0c1-48bf-9a07-f1b80eb2b41f"), 29, "Angela Green" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("31d0b276-f175-4d6d-bc3f-afa8777caf8f"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("3287a62e-9f49-4655-ae0e-ba0ac04630be"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("a7df0328-d0c1-48bf-9a07-f1b80eb2b41f"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("cee77ebd-82eb-436b-a018-5f6affa11c89"));

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "Age", "Name" },
                values: new object[] { new Guid("3398544f-756e-476b-8839-88a5a5cdf6e6"), 30, "John Doe" });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "Age", "Name" },
                values: new object[] { new Guid("be2b5622-bfc4-40e8-bce1-fa8fbcb814e6"), 25, "Jane Doe" });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "Age", "Name" },
                values: new object[] { new Guid("7a393d79-ec68-4292-ac62-45c7f26c18d1"), 28, "Mike Miles" });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentsApplication.Migrations
{
    public partial class DeletedAnotherStudentKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("752b1c8b-0674-437e-8bbc-7fe1cfe7dfb5"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("be0de541-9d5d-4b58-af0f-2192ba3eea4c"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("eb5da8aa-f7b3-489b-9c73-2253de285ffc"));

            migrationBuilder.DropColumn(
                name: "AnotherKeyProperty",
                table: "Student");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<Guid>(
                name: "AnotherKeyProperty",
                table: "Student",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "Age", "AnotherKeyProperty", "Name" },
                values: new object[] { new Guid("752b1c8b-0674-437e-8bbc-7fe1cfe7dfb5"), 30, new Guid("00000000-0000-0000-0000-000000000000"), "John Doe" });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "Age", "AnotherKeyProperty", "Name" },
                values: new object[] { new Guid("eb5da8aa-f7b3-489b-9c73-2253de285ffc"), 25, new Guid("00000000-0000-0000-0000-000000000000"), "Jane Doe" });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "Age", "AnotherKeyProperty", "Name" },
                values: new object[] { new Guid("be0de541-9d5d-4b58-af0f-2192ba3eea4c"), 28, new Guid("00000000-0000-0000-0000-000000000000"), "Mike Miles" });
        }
    }
}

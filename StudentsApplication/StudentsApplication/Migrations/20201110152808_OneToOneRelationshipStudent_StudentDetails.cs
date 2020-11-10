using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentsApplication.Migrations
{
    public partial class OneToOneRelationshipStudent_StudentDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "StudentDetails",
                columns: table => new
                {
                    StudentDetailsId = table.Column<Guid>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    AdditionalInformation = table.Column<string>(nullable: true),
                    StudentId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentDetails", x => x.StudentDetailsId);
                    table.ForeignKey(
                        name: "FK_StudentDetails_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "Age", "Name" },
                values: new object[,]
                {
                    { new Guid("8f70fe4c-8f2b-4f3d-9229-a1e7b1a2f910"), 30, "John Doe" },
                    { new Guid("f18d50dd-4762-441c-89ef-5265b7580d55"), 25, "Jane Doe" },
                    { new Guid("02c042ad-c7b1-45f8-a13a-d76c9ba51ee4"), 28, "Mike Miles" },
                    { new Guid("5e25ecaf-7071-4454-8ba5-e69bda2db8d5"), 29, "Angela Green" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentDetails_StudentId",
                table: "StudentDetails",
                column: "StudentId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentDetails");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("02c042ad-c7b1-45f8-a13a-d76c9ba51ee4"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("5e25ecaf-7071-4454-8ba5-e69bda2db8d5"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("8f70fe4c-8f2b-4f3d-9229-a1e7b1a2f910"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("f18d50dd-4762-441c-89ef-5265b7580d55"));

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
    }
}

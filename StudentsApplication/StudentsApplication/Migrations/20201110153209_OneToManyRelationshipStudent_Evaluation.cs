using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentsApplication.Migrations
{
    public partial class OneToManyRelationshipStudent_Evaluation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "Evaluation",
                columns: table => new
                {
                    EvaluationId = table.Column<Guid>(nullable: false),
                    Grade = table.Column<int>(nullable: false),
                    AdditionalExplanation = table.Column<string>(nullable: true),
                    StudentId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evaluation", x => x.EvaluationId);
                    table.ForeignKey(
                        name: "FK_Evaluation_Student_StudentId",
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
                    { new Guid("c218dd56-19c4-4714-b458-d47a5b90c675"), 30, "John Doe" },
                    { new Guid("a60d6d8c-c611-4bd4-a154-acccc789b583"), 25, "Jane Doe" },
                    { new Guid("ba86e23a-fc9e-4899-83d2-74cfe80d1970"), 28, "Mike Miles" },
                    { new Guid("f186267b-e033-4801-a2e1-8fffe9fdffa0"), 29, "Angela Green" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Evaluation_StudentId",
                table: "Evaluation",
                column: "StudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Evaluation");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("a60d6d8c-c611-4bd4-a154-acccc789b583"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("ba86e23a-fc9e-4899-83d2-74cfe80d1970"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("c218dd56-19c4-4714-b458-d47a5b90c675"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("f186267b-e033-4801-a2e1-8fffe9fdffa0"));

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
        }
    }
}

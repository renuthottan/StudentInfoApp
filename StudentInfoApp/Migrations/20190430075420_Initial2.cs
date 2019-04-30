using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentInfoApp.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseScores_Courses_CourseId",
                table: "CourseScores");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseScores_Students_StudentId",
                table: "CourseScores");

            migrationBuilder.DropIndex(
                name: "IX_CourseScores_StudentId",
                table: "CourseScores");

            migrationBuilder.AddColumn<int>(
                name: "CourseId1",
                table: "CourseScores",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CourseScores_CourseId1",
                table: "CourseScores",
                column: "CourseId1");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseScores_Students_CourseId",
                table: "CourseScores",
                column: "CourseId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseScores_Courses_CourseId1",
                table: "CourseScores",
                column: "CourseId1",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseScores_Students_CourseId",
                table: "CourseScores");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseScores_Courses_CourseId1",
                table: "CourseScores");

            migrationBuilder.DropIndex(
                name: "IX_CourseScores_CourseId1",
                table: "CourseScores");

            migrationBuilder.DropColumn(
                name: "CourseId1",
                table: "CourseScores");

            migrationBuilder.CreateIndex(
                name: "IX_CourseScores_StudentId",
                table: "CourseScores",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseScores_Courses_CourseId",
                table: "CourseScores",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseScores_Students_StudentId",
                table: "CourseScores",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentInfoApp.Migrations
{
    public partial class Initial5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseScores_Students_CourseId",
                table: "CourseScores");

            migrationBuilder.DropIndex(
                name: "IX_CourseScores_CourseId",
                table: "CourseScores");

            migrationBuilder.CreateIndex(
                name: "IX_CourseScores_StudentId",
                table: "CourseScores",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseScores_Students_StudentId",
                table: "CourseScores",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseScores_Students_StudentId",
                table: "CourseScores");

            migrationBuilder.DropIndex(
                name: "IX_CourseScores_StudentId",
                table: "CourseScores");

            migrationBuilder.CreateIndex(
                name: "IX_CourseScores_CourseId",
                table: "CourseScores",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseScores_Students_CourseId",
                table: "CourseScores",
                column: "CourseId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

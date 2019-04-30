using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentInfoApp.Migrations
{
    public partial class Initial4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseScores_Courses_CourseId1",
                table: "CourseScores");

            migrationBuilder.DropIndex(
                name: "IX_CourseScores_CourseId1",
                table: "CourseScores");

            migrationBuilder.DropColumn(
                name: "CourseId1",
                table: "CourseScores");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CourseId1",
                table: "CourseScores",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CourseScores_CourseId1",
                table: "CourseScores",
                column: "CourseId1");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseScores_Courses_CourseId1",
                table: "CourseScores",
                column: "CourseId1",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

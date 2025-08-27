using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ItiProject_GRD.DLL.Migrations
{
    /// <inheritdoc />
    public partial class aw : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Grades_Users_TraineeId",
                table: "Grades");

            migrationBuilder.AddForeignKey(
                name: "FK_Grades_Users_TraineeId",
                table: "Grades",
                column: "TraineeId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Grades_Users_TraineeId",
                table: "Grades");

            migrationBuilder.AddForeignKey(
                name: "FK_Grades_Users_TraineeId",
                table: "Grades",
                column: "TraineeId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

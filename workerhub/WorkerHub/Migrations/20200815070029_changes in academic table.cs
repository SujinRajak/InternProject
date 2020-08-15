using Microsoft.EntityFrameworkCore.Migrations;

namespace WorkerHub.Migrations
{
    public partial class changesinacademictable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SkillId",
                table: "Academics",
                newName: "academicId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "academicId",
                table: "Academics",
                newName: "SkillId");
        }
    }
}

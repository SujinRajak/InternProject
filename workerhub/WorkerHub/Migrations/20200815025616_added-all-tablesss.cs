using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WorkerHub.Migrations
{
    public partial class addedalltablesss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Academics",
                columns: table => new
                {
                    SkillId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Userid = table.Column<string>(nullable: true),
                    Qualification = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    Startdate = table.Column<DateTime>(nullable: true),
                    Enddate = table.Column<DateTime>(nullable: true),
                    Description = table.Column<string>(type: "nvarchar(255)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Academics", x => x.SkillId);
                    table.ForeignKey(
                        name: "FK_Academics_AspNetUsers_Userid",
                        column: x => x.Userid,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Experices",
                columns: table => new
                {
                    ExpId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Userid = table.Column<string>(nullable: true),
                    Sector = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    Position = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    Startdate = table.Column<DateTime>(nullable: true),
                    Enddate = table.Column<DateTime>(nullable: true),
                    Description = table.Column<string>(type: "nvarchar(255)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experices", x => x.ExpId);
                    table.ForeignKey(
                        name: "FK_Experices_AspNetUsers_Userid",
                        column: x => x.Userid,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SkillSets",
                columns: table => new
                {
                    SkillId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Userid = table.Column<string>(nullable: true),
                    Skill = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(255)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillSets", x => x.SkillId);
                    table.ForeignKey(
                        name: "FK_SkillSets_AspNetUsers_Userid",
                        column: x => x.Userid,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Academics_Userid",
                table: "Academics",
                column: "Userid");

            migrationBuilder.CreateIndex(
                name: "IX_Experices_Userid",
                table: "Experices",
                column: "Userid");

            migrationBuilder.CreateIndex(
                name: "IX_SkillSets_Userid",
                table: "SkillSets",
                column: "Userid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Academics");

            migrationBuilder.DropTable(
                name: "Experices");

            migrationBuilder.DropTable(
                name: "SkillSets");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WorkerHub.Migrations
{
    public partial class addedTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmployeeDetailPermissions",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    HiringManagerId = table.Column<string>(nullable: true),
                    EmployeeId = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    ExpiresIn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeDetailPermissions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeDetailPermissions_AspNetUsers_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmployeeDetailPermissions_AspNetUsers_HiringManagerId",
                        column: x => x.HiringManagerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UseSubscriptionStatuses",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ApplicationUserId = table.Column<Guid>(nullable: false),
                    ApplicationUserId1 = table.Column<string>(nullable: true),
                    EndDate = table.Column<DateTime>(nullable: false),
                    IsConsumed = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UseSubscriptionStatuses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UseSubscriptionStatuses_AspNetUsers_ApplicationUserId1",
                        column: x => x.ApplicationUserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeDetailPermissions_EmployeeId",
                table: "EmployeeDetailPermissions",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeDetailPermissions_HiringManagerId",
                table: "EmployeeDetailPermissions",
                column: "HiringManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_UseSubscriptionStatuses_ApplicationUserId1",
                table: "UseSubscriptionStatuses",
                column: "ApplicationUserId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeDetailPermissions");

            migrationBuilder.DropTable(
                name: "UseSubscriptionStatuses");
        }
    }
}

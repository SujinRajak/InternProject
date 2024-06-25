using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WorkerHub.Migrations
{
    public partial class AddedTransactionRelatedTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    PurchaseOrderID = table.Column<string>(nullable: true),
                    PurchaseOrderName = table.Column<string>(nullable: true),
                    ApplicationUserId = table.Column<Guid>(nullable: false),
                    ApplicationUserId1 = table.Column<string>(nullable: true),
                    Amount = table.Column<int>(nullable: false),
                    ReturnUrl = table.Column<string>(nullable: true),
                    WebsiteUrl = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_ApplicationUserId1",
                        column: x => x.ApplicationUserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AmountBreakdowns",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    OrderId = table.Column<int>(nullable: false),
                    Label = table.Column<string>(nullable: true),
                    Amount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AmountBreakdowns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AmountBreakdowns_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    OrderId = table.Column<int>(nullable: false),
                    KhaltiToken = table.Column<string>(nullable: true),
                    Amount = table.Column<int>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transactions_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AmountBreakdowns_OrderId",
                table: "AmountBreakdowns",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ApplicationUserId1",
                table: "Orders",
                column: "ApplicationUserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_OrderId",
                table: "Transactions",
                column: "OrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AmountBreakdowns");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropColumn(
                name: "SkillPercent",
                table: "SkillSets");

            migrationBuilder.DropColumn(
                name: "Addressname",
                table: "Experices");

            migrationBuilder.DropColumn(
                name: "WorkPlace",
                table: "Experices");

            migrationBuilder.DropColumn(
                name: "yearsExp",
                table: "Experices");

            migrationBuilder.DropColumn(
                name: "Availablility",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "bloodgroup",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "citizenship",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "city",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "country",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "dob",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "img",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "states",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "streetname",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Addressname",
                table: "Academics");

            migrationBuilder.DropColumn(
                name: "Graduated",
                table: "Academics");

            migrationBuilder.AlterColumn<int>(
                name: "Startdate",
                table: "Experices",
                type: "int",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DateTime");

            migrationBuilder.AlterColumn<int>(
                name: "Enddate",
                table: "Experices",
                type: "int",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DateTime");

            migrationBuilder.AlterColumn<int>(
                name: "Startdate",
                table: "Academics",
                type: "int",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DateTime");

            migrationBuilder.AlterColumn<int>(
                name: "Enddate",
                table: "Academics",
                type: "int",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DateTime");
        }
    }
}

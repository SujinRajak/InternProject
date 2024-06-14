using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WorkerHub.Migrations
{
    public partial class AddedTransactionRelatedTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SkillPercent",
                table: "SkillSets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Startdate",
                table: "Experices",
                type: "DateTime",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Enddate",
                table: "Experices",
                type: "DateTime",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Addressname",
                table: "Experices",
                type: "nvarchar(100)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WorkPlace",
                table: "Experices",
                type: "nvarchar(100)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "yearsExp",
                table: "Experices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Availablility",
                table: "AspNetUsers",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "bloodgroup",
                table: "AspNetUsers",
                type: "nvarchar(20)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "citizenship",
                table: "AspNetUsers",
                type: "nvarchar(100)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "city",
                table: "AspNetUsers",
                type: "nvarchar(100)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "country",
                table: "AspNetUsers",
                type: "nvarchar(100)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "dob",
                table: "AspNetUsers",
                type: "DateTime",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "img",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "states",
                table: "AspNetUsers",
                type: "nvarchar(100)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "streetname",
                table: "AspNetUsers",
                type: "nvarchar(100)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Startdate",
                table: "Academics",
                type: "DateTime",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Enddate",
                table: "Academics",
                type: "DateTime",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Addressname",
                table: "Academics",
                type: "nvarchar(100)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Graduated",
                table: "Academics",
                type: "nvarchar(100)",
                nullable: true);

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
                    OrderID = table.Column<int>(nullable: false),
                    OrderId = table.Column<Guid>(nullable: true),
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
                    OrderID = table.Column<int>(nullable: false),
                    OrderId = table.Column<Guid>(nullable: true),
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

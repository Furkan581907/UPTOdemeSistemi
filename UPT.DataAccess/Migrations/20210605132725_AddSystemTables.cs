using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UPT.DataAccess.Migrations
{
    public partial class AddSystemTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Subscriptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubscribeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubscribeDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvoiceNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreateUserId = table.Column<int>(type: "int", nullable: true),
                    CreateUserTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUserId = table.Column<int>(type: "int", nullable: false),
                    UpdateUserTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subscriptions_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Debts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubscriptionId = table.Column<int>(type: "int", nullable: false),
                    BillingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DueDateIsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateUserId = table.Column<int>(type: "int", nullable: true),
                    CreateUserTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUserId = table.Column<int>(type: "int", nullable: false),
                    UpdateUserTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Debts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Debts_Subscriptions_SubscriptionId",
                        column: x => x.SubscriptionId,
                        principalTable: "Subscriptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Deposits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    SubscriptionId = table.Column<int>(type: "int", nullable: false),
                    ReturnedTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreateUserId = table.Column<int>(type: "int", nullable: true),
                    CreateUserTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUserId = table.Column<int>(type: "int", nullable: false),
                    UpdateUserTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deposits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Deposits_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Deposits_Subscriptions_SubscriptionId",
                        column: x => x.SubscriptionId,
                        principalTable: "Subscriptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PayingId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PayerId = table.Column<int>(type: "int", nullable: false),
                    PayType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubscriptionId = table.Column<int>(type: "int", nullable: false),
                    SubscriptionsId = table.Column<int>(type: "int", nullable: true),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreateUserId = table.Column<int>(type: "int", nullable: true),
                    CreateUserTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUserId = table.Column<int>(type: "int", nullable: false),
                    UpdateUserTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payments_AspNetUsers_PayingId",
                        column: x => x.PayingId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Payments_Subscriptions_SubscriptionsId",
                        column: x => x.SubscriptionsId,
                        principalTable: "Subscriptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Debts_SubscriptionId",
                table: "Debts",
                column: "SubscriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_Deposits_SubscriptionId",
                table: "Deposits",
                column: "SubscriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_Deposits_UserId",
                table: "Deposits",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_PayingId",
                table: "Payments",
                column: "PayingId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_SubscriptionsId",
                table: "Payments",
                column: "SubscriptionsId");

            migrationBuilder.CreateIndex(
                name: "IX_Subscriptions_UserId",
                table: "Subscriptions",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Debts");

            migrationBuilder.DropTable(
                name: "Deposits");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Subscriptions");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExpenseManagementSystem.Migrations
{
    public partial class AddedExpenseViewModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Expenses",
                columns: table => new
                {
                    ExpenseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id = table.Column<int>(nullable: true),
                    ExpenseDescription = table.Column<string>(nullable: false),
                    ExpenseDate = table.Column<DateTime>(nullable: false),
                    ExpenseAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PayerNameId = table.Column<int>(nullable: true),
                    ExpenseCategoryNameExpenseCategoryId = table.Column<int>(nullable: true),
                    SubmitDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expenses", x => x.ExpenseId);
                    table.ForeignKey(
                        name: "FK_Expenses_ExpenseCategories_ExpenseCategoryNameExpenseCategoryId",
                        column: x => x.ExpenseCategoryNameExpenseCategoryId,
                        principalTable: "ExpenseCategories",
                        principalColumn: "ExpenseCategoryId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Expenses_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Expenses_Payers_PayerNameId",
                        column: x => x.PayerNameId,
                        principalTable: "Payers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_ExpenseCategoryNameExpenseCategoryId",
                table: "Expenses",
                column: "ExpenseCategoryNameExpenseCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_Id",
                table: "Expenses",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_PayerNameId",
                table: "Expenses",
                column: "PayerNameId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Expenses");
        }
    }
}

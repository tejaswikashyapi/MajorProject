using Microsoft.EntityFrameworkCore.Migrations;

namespace ExpenseManagementSystem.Migrations
{
    public partial class AddedExpenseCategoryUpdateTablename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ExpenseCategory",
                table: "ExpenseCategory");

            migrationBuilder.RenameTable(
                name: "ExpenseCategory",
                newName: "ExpenseCategories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExpenseCategories",
                table: "ExpenseCategories",
                column: "ExpenseCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ExpenseCategories",
                table: "ExpenseCategories");

            migrationBuilder.RenameTable(
                name: "ExpenseCategories",
                newName: "ExpenseCategory");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExpenseCategory",
                table: "ExpenseCategory",
                column: "ExpenseCategoryId");
        }
    }
}

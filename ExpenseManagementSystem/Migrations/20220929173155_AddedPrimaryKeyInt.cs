using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExpenseManagementSystem.Migrations
{
    public partial class AddedPrimaryKeyInt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "UserCreatedOn",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<decimal>(
                name: "UserIncome",
                table: "AspNetUsers",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserCreatedOn",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UserIncome",
                table: "AspNetUsers");
        }
    }
}

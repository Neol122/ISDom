using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Data.Migrations
{
    public partial class ThirdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "TicketInShoppingCarts");

            migrationBuilder.AddColumn<int>(
                name: "TicketPrice",
                table: "Tickets",
                nullable: false,
                defaultValue: 0);
        }


        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TicketPrice",
                table: "Tickets");

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "TicketInShoppingCarts",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}

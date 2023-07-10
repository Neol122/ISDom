using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Data.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductInShoppingCarts_Tickets_ShoppingCartId",
                table: "ProductInShoppingCarts");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductInShoppingCarts_ShoppingCarts_TicketId",
                table: "ProductInShoppingCarts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductInShoppingCarts",
                table: "ProductInShoppingCarts");

            migrationBuilder.RenameTable(
                name: "ProductInShoppingCarts",
                newName: "TicketInShoppingCarts");

            migrationBuilder.RenameIndex(
                name: "IX_ProductInShoppingCarts_ShoppingCartId",
                table: "TicketInShoppingCarts",
                newName: "IX_TicketInShoppingCarts_ShoppingCartId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TicketInShoppingCarts",
                table: "TicketInShoppingCarts",
                columns: new[] { "TicketId", "ShoppingCartId" });

            migrationBuilder.AddForeignKey(
                name: "FK_TicketInShoppingCarts_Tickets_ShoppingCartId",
                table: "TicketInShoppingCarts",
                column: "ShoppingCartId",
                principalTable: "Tickets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TicketInShoppingCarts_ShoppingCarts_TicketId",
                table: "TicketInShoppingCarts",
                column: "TicketId",
                principalTable: "ShoppingCarts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TicketInShoppingCarts_Tickets_ShoppingCartId",
                table: "TicketInShoppingCarts");

            migrationBuilder.DropForeignKey(
                name: "FK_TicketInShoppingCarts_ShoppingCarts_TicketId",
                table: "TicketInShoppingCarts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TicketInShoppingCarts",
                table: "TicketInShoppingCarts");

            migrationBuilder.RenameTable(
                name: "TicketInShoppingCarts",
                newName: "ProductInShoppingCarts");

            migrationBuilder.RenameIndex(
                name: "IX_TicketInShoppingCarts_ShoppingCartId",
                table: "ProductInShoppingCarts",
                newName: "IX_ProductInShoppingCarts_ShoppingCartId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductInShoppingCarts",
                table: "ProductInShoppingCarts",
                columns: new[] { "TicketId", "ShoppingCartId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ProductInShoppingCarts_Tickets_ShoppingCartId",
                table: "ProductInShoppingCarts",
                column: "ShoppingCartId",
                principalTable: "Tickets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductInShoppingCarts_ShoppingCarts_TicketId",
                table: "ProductInShoppingCarts",
                column: "TicketId",
                principalTable: "ShoppingCarts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}



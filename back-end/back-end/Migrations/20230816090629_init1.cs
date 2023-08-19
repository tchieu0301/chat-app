using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace back_end.Migrations
{
    /// <inheritdoc />
    public partial class init1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChatBoxes_Accounts_account_id",
                table: "ChatBoxes");

            migrationBuilder.DropIndex(
                name: "IX_ChatBoxes_account_id",
                table: "ChatBoxes");

            migrationBuilder.DropColumn(
                name: "account_id",
                table: "ChatBoxes");

            migrationBuilder.AddColumn<int>(
                name: "ChatBoxchat_box_id",
                table: "Accounts",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_ChatBoxchat_box_id",
                table: "Accounts",
                column: "ChatBoxchat_box_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_ChatBoxes_ChatBoxchat_box_id",
                table: "Accounts",
                column: "ChatBoxchat_box_id",
                principalTable: "ChatBoxes",
                principalColumn: "chat_box_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_ChatBoxes_ChatBoxchat_box_id",
                table: "Accounts");

            migrationBuilder.DropIndex(
                name: "IX_Accounts_ChatBoxchat_box_id",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "ChatBoxchat_box_id",
                table: "Accounts");

            migrationBuilder.AddColumn<int>(
                name: "account_id",
                table: "ChatBoxes",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ChatBoxes_account_id",
                table: "ChatBoxes",
                column: "account_id");

            migrationBuilder.AddForeignKey(
                name: "FK_ChatBoxes_Accounts_account_id",
                table: "ChatBoxes",
                column: "account_id",
                principalTable: "Accounts",
                principalColumn: "account_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

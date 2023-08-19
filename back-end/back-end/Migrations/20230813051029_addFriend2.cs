﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace back_end.Migrations
{
    /// <inheritdoc />
    public partial class addFriend2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Friends_Accounts_account_id1",
                table: "Friends");

            migrationBuilder.DropIndex(
                name: "IX_Friends_account_id1",
                table: "Friends");

            migrationBuilder.DropColumn(
                name: "account_id1",
                table: "Friends");

            migrationBuilder.CreateIndex(
                name: "IX_Friends_account_id",
                table: "Friends",
                column: "account_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Friends_Accounts_account_id",
                table: "Friends",
                column: "account_id",
                principalTable: "Accounts",
                principalColumn: "account_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Friends_Accounts_account_id",
                table: "Friends");

            migrationBuilder.DropIndex(
                name: "IX_Friends_account_id",
                table: "Friends");

            migrationBuilder.AddColumn<int>(
                name: "account_id1",
                table: "Friends",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Friends_account_id1",
                table: "Friends",
                column: "account_id1");

            migrationBuilder.AddForeignKey(
                name: "FK_Friends_Accounts_account_id1",
                table: "Friends",
                column: "account_id1",
                principalTable: "Accounts",
                principalColumn: "account_id");
        }
    }
}
using Microsoft.EntityFrameworkCore.Migrations;

namespace SignalR.API.Migrations
{
    public partial class users_name_fixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_USers_Teams_TeamId",
                table: "USers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_USers",
                table: "USers");

            migrationBuilder.RenameTable(
                name: "USers",
                newName: "Users");

            migrationBuilder.RenameIndex(
                name: "IX_USers_TeamId",
                table: "Users",
                newName: "IX_Users_TeamId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Teams_TeamId",
                table: "Users",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Teams_TeamId",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "USers");

            migrationBuilder.RenameIndex(
                name: "IX_Users_TeamId",
                table: "USers",
                newName: "IX_USers_TeamId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_USers",
                table: "USers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_USers_Teams_TeamId",
                table: "USers",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class ConvecaoNomeTabela_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "user");

            migrationBuilder.RenameIndex(
                name: "IX_User_username",
                table: "user",
                newName: "IX_user_username");

            migrationBuilder.RenameIndex(
                name: "IX_User_email",
                table: "user",
                newName: "IX_user_email");

            migrationBuilder.RenameIndex(
                name: "IX_User_cpf",
                table: "user",
                newName: "IX_user_cpf");

            migrationBuilder.AddPrimaryKey(
                name: "PK_user",
                table: "user",
                column: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_user",
                table: "user");

            migrationBuilder.RenameTable(
                name: "user",
                newName: "User");

            migrationBuilder.RenameIndex(
                name: "IX_user_username",
                table: "User",
                newName: "IX_User_username");

            migrationBuilder.RenameIndex(
                name: "IX_user_email",
                table: "User",
                newName: "IX_User_email");

            migrationBuilder.RenameIndex(
                name: "IX_user_cpf",
                table: "User",
                newName: "IX_User_cpf");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "id");
        }
    }
}

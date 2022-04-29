using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class ConvecaoNomeCampos_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Username",
                table: "User",
                newName: "username");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "User",
                newName: "password");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "User",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Cpf",
                table: "User",
                newName: "cpf");

            migrationBuilder.RenameColumn(
                name: "BirthDate",
                table: "User",
                newName: "birthdate");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "User",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "UpdateAt",
                table: "User",
                newName: "update_at");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "User",
                newName: "phone_number");

            migrationBuilder.RenameColumn(
                name: "CreateAt",
                table: "User",
                newName: "create_at");

            migrationBuilder.RenameIndex(
                name: "IX_User_Username",
                table: "User",
                newName: "IX_User_username");

            migrationBuilder.RenameIndex(
                name: "IX_User_Email",
                table: "User",
                newName: "IX_User_email");

            migrationBuilder.RenameIndex(
                name: "IX_User_Cpf",
                table: "User",
                newName: "IX_User_cpf");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "username",
                table: "User",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "password",
                table: "User",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "User",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "cpf",
                table: "User",
                newName: "Cpf");

            migrationBuilder.RenameColumn(
                name: "birthdate",
                table: "User",
                newName: "BirthDate");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "User",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "update_at",
                table: "User",
                newName: "UpdateAt");

            migrationBuilder.RenameColumn(
                name: "phone_number",
                table: "User",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "create_at",
                table: "User",
                newName: "CreateAt");

            migrationBuilder.RenameIndex(
                name: "IX_User_username",
                table: "User",
                newName: "IX_User_Username");

            migrationBuilder.RenameIndex(
                name: "IX_User_email",
                table: "User",
                newName: "IX_User_Email");

            migrationBuilder.RenameIndex(
                name: "IX_User_cpf",
                table: "User",
                newName: "IX_User_Cpf");
        }
    }
}

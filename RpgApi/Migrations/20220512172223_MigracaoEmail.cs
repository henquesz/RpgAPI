using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RpgApi.Migrations
{
    public partial class MigracaoEmail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Perfil",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "Jogador",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "Jogador");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 43, 176, 223, 190, 119, 176, 206, 101, 120, 97, 171, 76, 174, 36, 80, 43, 208, 151, 143, 68, 157, 184, 206, 96, 109, 71, 110, 62, 0, 138, 97, 159, 140, 244, 111, 168, 154, 61, 196, 134, 141, 82, 193, 180, 148, 6, 8, 187, 200, 91, 69, 147, 70, 68, 197, 253, 213, 71, 116, 151, 23, 207, 84, 19 }, new byte[] { 100, 144, 233, 216, 133, 127, 9, 195, 223, 100, 200, 240, 145, 168, 2, 238, 96, 235, 255, 109, 33, 219, 19, 88, 17, 139, 42, 252, 164, 235, 139, 121, 180, 251, 101, 151, 248, 43, 124, 189, 103, 218, 15, 135, 222, 67, 183, 22, 84, 220, 214, 161, 129, 180, 85, 50, 55, 18, 252, 87, 197, 58, 28, 166, 125, 35, 129, 178, 35, 201, 73, 12, 157, 14, 6, 219, 228, 130, 224, 122, 186, 179, 184, 199, 52, 15, 94, 126, 201, 6, 191, 143, 35, 120, 57, 19, 9, 27, 79, 252, 22, 142, 210, 247, 20, 255, 148, 36, 97, 153, 217, 102, 37, 0, 97, 154, 129, 83, 24, 142, 47, 56, 176, 37, 48, 92, 151, 164 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Usuarios");

            migrationBuilder.AlterColumn<string>(
                name: "Perfil",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Jogador",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "Jogador");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 109, 32, 34, 49, 106, 156, 171, 155, 146, 64, 94, 101, 252, 252, 208, 85, 121, 244, 112, 27, 131, 247, 60, 128, 90, 146, 215, 37, 244, 152, 247, 61, 156, 60, 180, 117, 226, 225, 75, 54, 105, 253, 143, 89, 112, 77, 105, 119, 199, 139, 39, 19, 137, 128, 100, 221, 234, 223, 96, 93, 61, 80, 53, 16 }, new byte[] { 220, 186, 243, 188, 161, 25, 125, 204, 214, 178, 215, 227, 120, 132, 33, 94, 146, 186, 77, 117, 59, 195, 31, 25, 48, 78, 81, 14, 11, 99, 13, 32, 93, 16, 101, 162, 71, 216, 133, 9, 229, 190, 16, 72, 165, 236, 217, 233, 49, 255, 121, 146, 210, 192, 135, 224, 73, 141, 142, 83, 202, 59, 163, 185, 120, 22, 48, 121, 193, 108, 132, 218, 111, 203, 158, 64, 86, 180, 247, 182, 122, 130, 134, 45, 229, 25, 219, 65, 239, 222, 83, 59, 105, 16, 35, 112, 178, 184, 143, 59, 145, 251, 65, 229, 38, 166, 112, 104, 4, 174, 156, 118, 218, 103, 128, 182, 87, 153, 232, 100, 76, 204, 153, 21, 90, 56, 42, 224 } });
        }
    }
}

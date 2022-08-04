using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RpgApi.Migrations
{
    public partial class MigracaoPerfil : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Perfil",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Jogador");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt", "Username" },
                values: new object[] { new byte[] { 138, 91, 195, 240, 78, 70, 31, 210, 180, 205, 181, 91, 98, 226, 160, 33, 238, 229, 4, 208, 34, 113, 81, 206, 23, 47, 91, 11, 133, 225, 246, 174, 125, 160, 161, 190, 54, 75, 253, 56, 98, 20, 210, 100, 46, 193, 182, 138, 29, 208, 129, 171, 14, 54, 34, 176, 124, 164, 184, 219, 242, 51, 61, 38 }, new byte[] { 226, 238, 233, 25, 219, 123, 70, 112, 148, 95, 46, 202, 88, 58, 5, 226, 182, 69, 150, 64, 185, 20, 249, 185, 117, 88, 11, 57, 182, 203, 197, 158, 247, 222, 117, 33, 157, 151, 196, 252, 85, 177, 81, 159, 91, 28, 67, 52, 114, 66, 73, 190, 37, 118, 190, 148, 146, 226, 183, 137, 234, 152, 32, 33, 107, 21, 12, 78, 203, 245, 94, 0, 222, 140, 165, 216, 193, 77, 88, 175, 127, 216, 24, 164, 70, 145, 181, 98, 49, 66, 194, 137, 112, 96, 74, 92, 49, 247, 32, 63, 207, 102, 161, 30, 69, 135, 147, 215, 145, 38, 79, 205, 145, 3, 104, 76, 186, 212, 49, 131, 133, 197, 210, 126, 207, 82, 75, 95 }, "UsuarioAdmin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Perfil",
                table: "Usuarios");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt", "Username" },
                values: new object[] { new byte[] { 3, 161, 58, 148, 57, 243, 35, 18, 158, 191, 6, 217, 95, 119, 114, 90, 97, 250, 223, 38, 144, 114, 254, 141, 156, 137, 87, 214, 0, 213, 1, 167, 104, 121, 195, 248, 204, 221, 251, 216, 205, 39, 95, 24, 144, 146, 185, 94, 15, 217, 230, 158, 196, 93, 120, 141, 209, 104, 55, 143, 125, 40, 250, 245 }, new byte[] { 185, 98, 127, 23, 226, 32, 71, 144, 119, 172, 187, 166, 139, 225, 213, 196, 72, 143, 17, 45, 12, 43, 127, 185, 40, 211, 105, 185, 91, 145, 145, 229, 64, 174, 48, 5, 18, 159, 92, 48, 110, 93, 170, 35, 67, 16, 120, 114, 228, 112, 145, 151, 54, 191, 194, 124, 23, 176, 116, 183, 243, 28, 27, 4, 52, 27, 121, 240, 246, 227, 251, 24, 95, 116, 192, 180, 201, 86, 34, 202, 94, 225, 10, 82, 31, 58, 77, 43, 223, 8, 41, 150, 53, 124, 50, 112, 149, 109, 170, 2, 244, 42, 246, 8, 17, 155, 187, 11, 91, 122, 163, 62, 129, 204, 162, 128, 22, 167, 205, 57, 131, 180, 113, 237, 104, 136, 56, 139 }, null });
        }
    }
}

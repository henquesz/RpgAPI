using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RpgApi.Migrations
{
    public partial class MigracaoUmParaUm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PersonagemId",
                table: "Armas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Armas",
                columns: new[] { "Id", "Dano", "Nome", "PersonagemId" },
                values: new object[,]
                {
                    { 1, 35, "Arco e Flecha", 1 },
                    { 2, 33, "Espada", 2 },
                    { 3, 31, "Machado", 3 }
                });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 82, 26, 76, 179, 192, 56, 131, 53, 180, 67, 211, 185, 185, 113, 233, 100, 4, 161, 208, 216, 106, 15, 219, 249, 228, 202, 121, 116, 1, 173, 166, 173, 177, 58, 54, 18, 136, 8, 130, 103, 173, 73, 68, 241, 28, 107, 92, 176, 206, 66, 146, 198, 1, 72, 143, 56, 81, 15, 13, 45, 194, 232, 239, 8 }, new byte[] { 222, 181, 87, 246, 214, 174, 75, 191, 95, 140, 162, 50, 240, 39, 20, 28, 233, 55, 58, 71, 244, 146, 91, 249, 102, 205, 205, 13, 93, 27, 24, 225, 222, 19, 81, 177, 186, 104, 83, 48, 176, 233, 86, 233, 118, 195, 138, 232, 8, 35, 36, 214, 61, 48, 182, 197, 28, 80, 48, 163, 173, 37, 220, 127, 180, 58, 130, 123, 228, 45, 253, 102, 152, 16, 48, 198, 47, 102, 69, 228, 167, 212, 149, 122, 137, 238, 190, 27, 101, 27, 85, 124, 55, 133, 197, 142, 169, 181, 126, 66, 72, 227, 127, 38, 162, 188, 129, 163, 169, 6, 189, 153, 76, 105, 52, 97, 10, 178, 9, 89, 102, 176, 238, 225, 101, 129, 234, 202 } });

            migrationBuilder.CreateIndex(
                name: "IX_Armas_PersonagemId",
                table: "Armas",
                column: "PersonagemId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Armas_Personagens_PersonagemId",
                table: "Armas",
                column: "PersonagemId",
                principalTable: "Personagens",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Armas_Personagens_PersonagemId",
                table: "Armas");

            migrationBuilder.DropIndex(
                name: "IX_Armas_PersonagemId",
                table: "Armas");

            migrationBuilder.DeleteData(
                table: "Armas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Armas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Armas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "PersonagemId",
                table: "Armas");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 250, 235, 170, 230, 18, 160, 39, 125, 7, 169, 237, 80, 87, 191, 128, 23, 196, 135, 89, 254, 176, 175, 231, 238, 7, 151, 55, 35, 126, 12, 9, 210, 61, 235, 29, 222, 75, 98, 130, 148, 45, 164, 43, 201, 208, 182, 125, 157, 157, 98, 187, 28, 224, 94, 127, 57, 60, 90, 249, 221, 163, 230, 140, 214 }, new byte[] { 8, 243, 55, 166, 72, 254, 255, 66, 194, 73, 138, 36, 136, 83, 185, 255, 28, 75, 113, 34, 8, 3, 192, 73, 44, 137, 44, 125, 80, 219, 241, 165, 141, 151, 105, 114, 56, 53, 45, 237, 199, 66, 107, 50, 64, 152, 242, 188, 82, 248, 254, 174, 224, 120, 162, 159, 136, 204, 170, 209, 18, 159, 227, 174, 131, 179, 30, 52, 1, 47, 153, 160, 32, 124, 106, 83, 253, 125, 70, 54, 114, 218, 74, 95, 111, 89, 71, 68, 214, 167, 193, 131, 68, 124, 152, 117, 172, 217, 199, 235, 48, 112, 63, 247, 189, 38, 94, 226, 143, 185, 102, 20, 24, 161, 189, 149, 242, 39, 205, 3, 95, 218, 212, 224, 210, 80, 68, 20 } });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RpgApi.Migrations
{
    public partial class MigracaoMuitosParaMuitos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Habilidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dano = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Habilidades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonagemHabilidades",
                columns: table => new
                {
                    PersonagemId = table.Column<int>(type: "int", nullable: false),
                    HabilidadeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonagemHabilidades", x => new { x.PersonagemId, x.HabilidadeId });
                    table.ForeignKey(
                        name: "FK_PersonagemHabilidades_Habilidades_HabilidadeId",
                        column: x => x.HabilidadeId,
                        principalTable: "Habilidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonagemHabilidades_Personagens_PersonagemId",
                        column: x => x.PersonagemId,
                        principalTable: "Personagens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Habilidades",
                columns: new[] { "Id", "Dano", "Nome" },
                values: new object[,]
                {
                    { 1, 39, "Adormecer" },
                    { 2, 41, "Congelar" },
                    { 3, 37, "Hipnotizar" }
                });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 3, 161, 58, 148, 57, 243, 35, 18, 158, 191, 6, 217, 95, 119, 114, 90, 97, 250, 223, 38, 144, 114, 254, 141, 156, 137, 87, 214, 0, 213, 1, 167, 104, 121, 195, 248, 204, 221, 251, 216, 205, 39, 95, 24, 144, 146, 185, 94, 15, 217, 230, 158, 196, 93, 120, 141, 209, 104, 55, 143, 125, 40, 250, 245 }, new byte[] { 185, 98, 127, 23, 226, 32, 71, 144, 119, 172, 187, 166, 139, 225, 213, 196, 72, 143, 17, 45, 12, 43, 127, 185, 40, 211, 105, 185, 91, 145, 145, 229, 64, 174, 48, 5, 18, 159, 92, 48, 110, 93, 170, 35, 67, 16, 120, 114, 228, 112, 145, 151, 54, 191, 194, 124, 23, 176, 116, 183, 243, 28, 27, 4, 52, 27, 121, 240, 246, 227, 251, 24, 95, 116, 192, 180, 201, 86, 34, 202, 94, 225, 10, 82, 31, 58, 77, 43, 223, 8, 41, 150, 53, 124, 50, 112, 149, 109, 170, 2, 244, 42, 246, 8, 17, 155, 187, 11, 91, 122, 163, 62, 129, 204, 162, 128, 22, 167, 205, 57, 131, 180, 113, 237, 104, 136, 56, 139 } });

            migrationBuilder.InsertData(
                table: "PersonagemHabilidades",
                columns: new[] { "HabilidadeId", "PersonagemId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 5 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 2, 6 },
                    { 3, 3 },
                    { 3, 4 },
                    { 3, 7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PersonagemHabilidades_HabilidadeId",
                table: "PersonagemHabilidades",
                column: "HabilidadeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonagemHabilidades");

            migrationBuilder.DropTable(
                name: "Habilidades");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 82, 26, 76, 179, 192, 56, 131, 53, 180, 67, 211, 185, 185, 113, 233, 100, 4, 161, 208, 216, 106, 15, 219, 249, 228, 202, 121, 116, 1, 173, 166, 173, 177, 58, 54, 18, 136, 8, 130, 103, 173, 73, 68, 241, 28, 107, 92, 176, 206, 66, 146, 198, 1, 72, 143, 56, 81, 15, 13, 45, 194, 232, 239, 8 }, new byte[] { 222, 181, 87, 246, 214, 174, 75, 191, 95, 140, 162, 50, 240, 39, 20, 28, 233, 55, 58, 71, 244, 146, 91, 249, 102, 205, 205, 13, 93, 27, 24, 225, 222, 19, 81, 177, 186, 104, 83, 48, 176, 233, 86, 233, 118, 195, 138, 232, 8, 35, 36, 214, 61, 48, 182, 197, 28, 80, 48, 163, 173, 37, 220, 127, 180, 58, 130, 123, 228, 45, 253, 102, 152, 16, 48, 198, 47, 102, 69, 228, 167, 212, 149, 122, 137, 238, 190, 27, 101, 27, 85, 124, 55, 133, 197, 142, 169, 181, 126, 66, 72, 227, 127, 38, 162, 188, 129, 163, 169, 6, 189, 153, 76, 105, 52, 97, 10, 178, 9, 89, 102, 176, 238, 225, 101, 129, 234, 202 } });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RpgApi.Migrations
{
    public partial class MigracaoUsuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "FotoPersonagem",
                table: "Personagens",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Personagens",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Armas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dano = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Armas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Foto = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Latitude = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Longitude = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataAcesso = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "DataAcesso", "Foto", "Latitude", "Longitude", "PasswordHash", "PasswordSalt", "Username" },
                values: new object[] { 1, null, null, null, null, new byte[] { 250, 235, 170, 230, 18, 160, 39, 125, 7, 169, 237, 80, 87, 191, 128, 23, 196, 135, 89, 254, 176, 175, 231, 238, 7, 151, 55, 35, 126, 12, 9, 210, 61, 235, 29, 222, 75, 98, 130, 148, 45, 164, 43, 201, 208, 182, 125, 157, 157, 98, 187, 28, 224, 94, 127, 57, 60, 90, 249, 221, 163, 230, 140, 214 }, new byte[] { 8, 243, 55, 166, 72, 254, 255, 66, 194, 73, 138, 36, 136, 83, 185, 255, 28, 75, 113, 34, 8, 3, 192, 73, 44, 137, 44, 125, 80, 219, 241, 165, 141, 151, 105, 114, 56, 53, 45, 237, 199, 66, 107, 50, 64, 152, 242, 188, 82, 248, 254, 174, 224, 120, 162, 159, 136, 204, 170, 209, 18, 159, 227, 174, 131, 179, 30, 52, 1, 47, 153, 160, 32, 124, 106, 83, 253, 125, 70, 54, 114, 218, 74, 95, 111, 89, 71, 68, 214, 167, 193, 131, 68, 124, 152, 117, 172, 217, 199, 235, 48, 112, 63, 247, 189, 38, 94, 226, 143, 185, 102, 20, 24, 161, 189, 149, 242, 39, 205, 3, 95, 218, 212, 224, 210, 80, 68, 20 }, null });

            migrationBuilder.CreateIndex(
                name: "IX_Personagens_UsuarioId",
                table: "Personagens",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Personagens_Usuarios_UsuarioId",
                table: "Personagens",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personagens_Usuarios_UsuarioId",
                table: "Personagens");

            migrationBuilder.DropTable(
                name: "Armas");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Personagens_UsuarioId",
                table: "Personagens");

            migrationBuilder.DropColumn(
                name: "FotoPersonagem",
                table: "Personagens");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Personagens");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RpgApi.Migrations
{
    public partial class MigracaoDisputas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Derrotas",
                table: "Personagens",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Disputas",
                table: "Personagens",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Vitorias",
                table: "Personagens",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Disputas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataDisputa = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AtacanteId = table.Column<int>(type: "int", nullable: false),
                    OponenteId = table.Column<int>(type: "int", nullable: false),
                    Narracao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disputas", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 109, 32, 34, 49, 106, 156, 171, 155, 146, 64, 94, 101, 252, 252, 208, 85, 121, 244, 112, 27, 131, 247, 60, 128, 90, 146, 215, 37, 244, 152, 247, 61, 156, 60, 180, 117, 226, 225, 75, 54, 105, 253, 143, 89, 112, 77, 105, 119, 199, 139, 39, 19, 137, 128, 100, 221, 234, 223, 96, 93, 61, 80, 53, 16 }, new byte[] { 220, 186, 243, 188, 161, 25, 125, 204, 214, 178, 215, 227, 120, 132, 33, 94, 146, 186, 77, 117, 59, 195, 31, 25, 48, 78, 81, 14, 11, 99, 13, 32, 93, 16, 101, 162, 71, 216, 133, 9, 229, 190, 16, 72, 165, 236, 217, 233, 49, 255, 121, 146, 210, 192, 135, 224, 73, 141, 142, 83, 202, 59, 163, 185, 120, 22, 48, 121, 193, 108, 132, 218, 111, 203, 158, 64, 86, 180, 247, 182, 122, 130, 134, 45, 229, 25, 219, 65, 239, 222, 83, 59, 105, 16, 35, 112, 178, 184, 143, 59, 145, 251, 65, 229, 38, 166, 112, 104, 4, 174, 156, 118, 218, 103, 128, 182, 87, 153, 232, 100, 76, 204, 153, 21, 90, 56, 42, 224 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Disputas");

            migrationBuilder.DropColumn(
                name: "Derrotas",
                table: "Personagens");

            migrationBuilder.DropColumn(
                name: "Disputas",
                table: "Personagens");

            migrationBuilder.DropColumn(
                name: "Vitorias",
                table: "Personagens");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 138, 91, 195, 240, 78, 70, 31, 210, 180, 205, 181, 91, 98, 226, 160, 33, 238, 229, 4, 208, 34, 113, 81, 206, 23, 47, 91, 11, 133, 225, 246, 174, 125, 160, 161, 190, 54, 75, 253, 56, 98, 20, 210, 100, 46, 193, 182, 138, 29, 208, 129, 171, 14, 54, 34, 176, 124, 164, 184, 219, 242, 51, 61, 38 }, new byte[] { 226, 238, 233, 25, 219, 123, 70, 112, 148, 95, 46, 202, 88, 58, 5, 226, 182, 69, 150, 64, 185, 20, 249, 185, 117, 88, 11, 57, 182, 203, 197, 158, 247, 222, 117, 33, 157, 151, 196, 252, 85, 177, 81, 159, 91, 28, 67, 52, 114, 66, 73, 190, 37, 118, 190, 148, 146, 226, 183, 137, 234, 152, 32, 33, 107, 21, 12, 78, 203, 245, 94, 0, 222, 140, 165, 216, 193, 77, 88, 175, 127, 216, 24, 164, 70, 145, 181, 98, 49, 66, 194, 137, 112, 96, 74, 92, 49, 247, 32, 63, 207, 102, 161, 30, 69, 135, 147, 215, 145, 38, 79, 205, 145, 3, 104, 76, 186, 212, 49, 131, 133, 197, 210, 126, 207, 82, 75, 95 } });
        }
    }
}

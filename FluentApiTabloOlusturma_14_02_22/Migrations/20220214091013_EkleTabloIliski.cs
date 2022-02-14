using Microsoft.EntityFrameworkCore.Migrations;

namespace FluentApiTabloOlusturma_14_02_22.Migrations
{
    public partial class EkleTabloIliski : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FirID",
                table: "tbl_Personel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Personel_FirID",
                table: "tbl_Personel",
                column: "FirID");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Personel_tbl_Firma_FirID",
                table: "tbl_Personel",
                column: "FirID",
                principalTable: "tbl_Firma",
                principalColumn: "Anahtar",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Personel_tbl_Firma_FirID",
                table: "tbl_Personel");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Personel_FirID",
                table: "tbl_Personel");

            migrationBuilder.DropColumn(
                name: "FirID",
                table: "tbl_Personel");
        }
    }
}

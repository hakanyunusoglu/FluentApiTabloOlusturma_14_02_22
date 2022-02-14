using Microsoft.EntityFrameworkCore.Migrations;

namespace FluentApiTabloOlusturma_14_02_22.Migrations
{
    public partial class DegistirFirmaColumnName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Unvan",
                table: "tbl_Firma",
                newName: "FirmaUnvan");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "tbl_Firma",
                newName: "Anahtar");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FirmaUnvan",
                table: "tbl_Firma",
                newName: "Unvan");

            migrationBuilder.RenameColumn(
                name: "Anahtar",
                table: "tbl_Firma",
                newName: "ID");
        }
    }
}

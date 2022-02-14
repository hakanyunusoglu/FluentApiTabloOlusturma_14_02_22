using Microsoft.EntityFrameworkCore.Migrations;

namespace FluentApiTabloOlusturma_14_02_22.Migrations
{
    public partial class DegistirTabloColumnName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Tel",
                table: "tbl_Personel",
                newName: "TelNo");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "tbl_Personel",
                newName: "Anahtar");

            migrationBuilder.AlterColumn<string>(
                name: "TelNo",
                table: "tbl_Personel",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirmaUnvan",
                table: "tbl_Firma",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TelNo",
                table: "tbl_Personel",
                newName: "Tel");

            migrationBuilder.RenameColumn(
                name: "Anahtar",
                table: "tbl_Personel",
                newName: "ID");

            migrationBuilder.AlterColumn<string>(
                name: "Tel",
                table: "tbl_Personel",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirmaUnvan",
                table: "tbl_Firma",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);
        }
    }
}

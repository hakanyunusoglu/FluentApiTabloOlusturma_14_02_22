using Microsoft.EntityFrameworkCore.Migrations;

namespace FluentApiTabloOlusturma_14_02_22.Migrations
{
    public partial class EkleCoktanCokaRelation2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductKategoriRelationship",
                table: "ProductKategoriRelationship");

            migrationBuilder.AddColumn<int>(
                name: "PkrID",
                table: "ProductKategoriRelationship",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductKategoriRelationship",
                table: "ProductKategoriRelationship",
                column: "PkrID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductKategoriRelationship_ProductID",
                table: "ProductKategoriRelationship",
                column: "ProductID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductKategoriRelationship",
                table: "ProductKategoriRelationship");

            migrationBuilder.DropIndex(
                name: "IX_ProductKategoriRelationship_ProductID",
                table: "ProductKategoriRelationship");

            migrationBuilder.DropColumn(
                name: "PkrID",
                table: "ProductKategoriRelationship");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductKategoriRelationship",
                table: "ProductKategoriRelationship",
                columns: new[] { "ProductID", "KategoriID" });
        }
    }
}

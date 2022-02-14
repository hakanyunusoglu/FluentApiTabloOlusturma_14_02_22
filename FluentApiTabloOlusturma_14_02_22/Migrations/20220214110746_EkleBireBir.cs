using Microsoft.EntityFrameworkCore.Migrations;

namespace FluentApiTabloOlusturma_14_02_22.Migrations
{
    public partial class EkleBireBir : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductKategoriRelationship_Kategoriler_KategoriID",
                table: "ProductKategoriRelationship");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductKategoriRelationship_Products_ProductID",
                table: "ProductKategoriRelationship");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductKategoriRelationship",
                table: "ProductKategoriRelationship");

            migrationBuilder.RenameTable(
                name: "ProductKategoriRelationship",
                newName: "ProductKategoriRelation");

            migrationBuilder.RenameIndex(
                name: "IX_ProductKategoriRelationship_ProductID",
                table: "ProductKategoriRelation",
                newName: "IX_ProductKategoriRelation_ProductID");

            migrationBuilder.RenameIndex(
                name: "IX_ProductKategoriRelationship_KategoriID",
                table: "ProductKategoriRelation",
                newName: "IX_ProductKategoriRelation_KategoriID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductKategoriRelation",
                table: "ProductKategoriRelation",
                column: "PkrID");

            migrationBuilder.CreateTable(
                name: "ProductDetails",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Size = table.Column<int>(type: "int", nullable: false),
                    ProID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDetails", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ProductDetails_Products_ProID",
                        column: x => x.ProID,
                        principalTable: "Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetails_ProID",
                table: "ProductDetails",
                column: "ProID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductKategoriRelation_Kategoriler_KategoriID",
                table: "ProductKategoriRelation",
                column: "KategoriID",
                principalTable: "Kategoriler",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductKategoriRelation_Products_ProductID",
                table: "ProductKategoriRelation",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductKategoriRelation_Kategoriler_KategoriID",
                table: "ProductKategoriRelation");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductKategoriRelation_Products_ProductID",
                table: "ProductKategoriRelation");

            migrationBuilder.DropTable(
                name: "ProductDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductKategoriRelation",
                table: "ProductKategoriRelation");

            migrationBuilder.RenameTable(
                name: "ProductKategoriRelation",
                newName: "ProductKategoriRelationship");

            migrationBuilder.RenameIndex(
                name: "IX_ProductKategoriRelation_ProductID",
                table: "ProductKategoriRelationship",
                newName: "IX_ProductKategoriRelationship_ProductID");

            migrationBuilder.RenameIndex(
                name: "IX_ProductKategoriRelation_KategoriID",
                table: "ProductKategoriRelationship",
                newName: "IX_ProductKategoriRelationship_KategoriID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductKategoriRelationship",
                table: "ProductKategoriRelationship",
                column: "PkrID");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductKategoriRelationship_Kategoriler_KategoriID",
                table: "ProductKategoriRelationship",
                column: "KategoriID",
                principalTable: "Kategoriler",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductKategoriRelationship_Products_ProductID",
                table: "ProductKategoriRelationship",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

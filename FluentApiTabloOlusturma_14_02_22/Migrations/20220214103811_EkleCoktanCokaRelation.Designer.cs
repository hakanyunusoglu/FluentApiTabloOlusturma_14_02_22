// <auto-generated />
using FluentApiTabloOlusturma_14_02_22.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FluentApiTabloOlusturma_14_02_22.Migrations
{
    [DbContext(typeof(FluentApiContext))]
    [Migration("20220214103811_EkleCoktanCokaRelation")]
    partial class EkleCoktanCokaRelation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FluentApiTabloOlusturma_14_02_22.Models.Firma", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Anahtar")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Unvan")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("FirmaUnvan");

                    b.HasKey("ID");

                    b.ToTable("tbl_Firma");
                });

            modelBuilder.Entity("FluentApiTabloOlusturma_14_02_22.Models.Kategori", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Kategoriler");
                });

            modelBuilder.Entity("FluentApiTabloOlusturma_14_02_22.Models.Personel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Anahtar")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FirID")
                        .HasColumnType("int");

                    b.Property<string>("Soyad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tel")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("TelNo");

                    b.HasKey("ID");

                    b.HasIndex("FirID");

                    b.ToTable("tbl_Personel");
                });

            modelBuilder.Entity("FluentApiTabloOlusturma_14_02_22.Models.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Adet")
                        .HasColumnType("int");

                    b.Property<decimal>("Fiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("UrunAd")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("FluentApiTabloOlusturma_14_02_22.Models.ProductKategoriRelationship", b =>
                {
                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<int>("KategoriID")
                        .HasColumnType("int");

                    b.HasKey("ProductID", "KategoriID");

                    b.HasIndex("KategoriID");

                    b.ToTable("ProductKategoriRelationship");
                });

            modelBuilder.Entity("FluentApiTabloOlusturma_14_02_22.Models.Personel", b =>
                {
                    b.HasOne("FluentApiTabloOlusturma_14_02_22.Models.Firma", "Firma")
                        .WithMany("Personeller")
                        .HasForeignKey("FirID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Firma");
                });

            modelBuilder.Entity("FluentApiTabloOlusturma_14_02_22.Models.ProductKategoriRelationship", b =>
                {
                    b.HasOne("FluentApiTabloOlusturma_14_02_22.Models.Kategori", "Kategori")
                        .WithMany("ProductsKategori")
                        .HasForeignKey("KategoriID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FluentApiTabloOlusturma_14_02_22.Models.Product", "Product")
                        .WithMany("ProductKategori")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("FluentApiTabloOlusturma_14_02_22.Models.Firma", b =>
                {
                    b.Navigation("Personeller");
                });

            modelBuilder.Entity("FluentApiTabloOlusturma_14_02_22.Models.Kategori", b =>
                {
                    b.Navigation("ProductsKategori");
                });

            modelBuilder.Entity("FluentApiTabloOlusturma_14_02_22.Models.Product", b =>
                {
                    b.Navigation("ProductKategori");
                });
#pragma warning restore 612, 618
        }
    }
}

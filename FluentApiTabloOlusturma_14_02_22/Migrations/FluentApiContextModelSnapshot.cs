﻿// <auto-generated />
using FluentApiTabloOlusturma_14_02_22.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FluentApiTabloOlusturma_14_02_22.Migrations
{
    [DbContext(typeof(FluentApiContext))]
    partial class FluentApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

            modelBuilder.Entity("FluentApiTabloOlusturma_14_02_22.Models.Personel", b =>
                {
                    b.HasOne("FluentApiTabloOlusturma_14_02_22.Models.Firma", "Firma")
                        .WithMany("Personeller")
                        .HasForeignKey("FirID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Firma");
                });

            modelBuilder.Entity("FluentApiTabloOlusturma_14_02_22.Models.Firma", b =>
                {
                    b.Navigation("Personeller");
                });
#pragma warning restore 612, 618
        }
    }
}

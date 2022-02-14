using Microsoft.EntityFrameworkCore;

namespace FluentApiTabloOlusturma_14_02_22.Models
{
    public class FluentApiContext: DbContext
    {
        public FluentApiContext(DbContextOptions<FluentApiContext> options) : base(options)
        {

        }
        public DbSet<Firma> Firmalar { get; set; }
        public DbSet<Personel> Personeller { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<ProductKategoriRelationship> ProductKategoriRelation { get; set; }
        public DbSet<ProductDetails> ProductDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Firma>().ToTable("tbl_Firma");
            modelBuilder.Entity<Personel>().ToTable("tbl_Personel");
            modelBuilder.Entity<Firma>().Property(x => x.Unvan).HasColumnName("FirmaUnvan").HasMaxLength(50);
            modelBuilder.Entity<Firma>().Property(x => x.ID).HasColumnName("Anahtar");
            modelBuilder.Entity<Personel>().Property(x => x.ID).HasColumnName("Anahtar");
            modelBuilder.Entity<Personel>().Property(x => x.Tel).HasColumnName("TelNo").HasMaxLength(15);
            //NotMapped'ın fluentapi deki karşılığı şu şekildedir
            modelBuilder.Entity<Firma>().Ignore(x => x.FirmaLisansKey);

            //Required'ın fluentapi deki karşılı şu şekildedir
            modelBuilder.Entity<Firma>().Property(x => x.Unvan).IsRequired();

            //Tablolar arası ilişkilerin tanımlanması FluentApi ile şu şekilde yapılıyor.
            //Bire Çok ilişki tanımlama
            //Modeli bağladık             -Bir firmanın        -Birden fazla personeli         -FirID ile birbirine bağlıdır
            //modelBuilder.Entity<Personel>().HasOne(x => x.Firma).WithMany(x => x.Personeller).HasForeignKey(x => x.FirID);
            //Çoktan bire ilişki tanımlama
            modelBuilder.Entity<Firma>().HasMany(x => x.Personeller).WithOne(x => x.Firma).HasForeignKey(x => x.FirID).OnDelete(DeleteBehavior.Cascade);

            //Çoktan çoğa ilişki tanımlama
            modelBuilder.Entity<ProductKategoriRelationship>().HasKey(x => new { x.ProductID, x.KategoriID }); //Composite key oluşturma. Bir tabloda 2 tane birincil anahtar tanımlamak için kullanılır

            modelBuilder.Entity<ProductKategoriRelationship>().HasKey(x => x.PkrID);
            modelBuilder.Entity<ProductKategoriRelationship>().HasOne(x => x.Product).WithMany(x => x.ProductKategori).HasForeignKey(x=>x.ProductID);
            modelBuilder.Entity<ProductKategoriRelationship>().HasOne(x => x.Kategori).WithMany(x => x.KategoriProduct).HasForeignKey(x => x.KategoriID);

            //Bire bir ilişki tanımlama
            modelBuilder.Entity<ProductDetails>().HasOne(x => x.Product).WithOne(x => x.ProductDetail).HasForeignKey<ProductDetails>(x=>x.ProID);
            
            //modelBuilder.Entity<Firma>().HasKey(x=>x.ID);
        }
    }
}

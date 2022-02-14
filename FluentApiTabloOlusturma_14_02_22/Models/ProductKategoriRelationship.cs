namespace FluentApiTabloOlusturma_14_02_22.Models
{
    public class ProductKategoriRelationship
    {
        public int KategoriID { get; set; }
        public Kategori Kategori { get; set; }
        public int ProductID { get; set; }
        public Product Product { get; set; }
    }
}

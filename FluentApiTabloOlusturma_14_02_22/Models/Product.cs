using System.Collections.Generic;

namespace FluentApiTabloOlusturma_14_02_22.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string UrunAd { get; set; }
        public decimal Fiyat { get; set; }
        public int Adet { get; set; }

        public ICollection<ProductKategoriRelationship> ProductKategori { get; set; }
        public ProductDetails ProductDetail { get; set; }
    }
}

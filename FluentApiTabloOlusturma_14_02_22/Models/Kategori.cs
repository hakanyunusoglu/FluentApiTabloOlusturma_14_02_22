using System.Collections;
using System.Collections.Generic;

namespace FluentApiTabloOlusturma_14_02_22.Models
{
    public class Kategori
    {
        public int ID { get; set; }
        public string Ad { get; set; }

        public ICollection<ProductKategoriRelationship> ProductsKategori { get; set; }
    }
}

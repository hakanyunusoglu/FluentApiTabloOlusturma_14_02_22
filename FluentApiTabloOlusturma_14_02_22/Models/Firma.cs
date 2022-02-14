using System.Collections;
using System.Collections.Generic;

namespace FluentApiTabloOlusturma_14_02_22.Models
{
    public class Firma
    {
        public int ID { get; set; }
        public string Unvan { get; set; }
        public string TelNo { get; set; }
        public string Adres { get; set; }
        public string Email { get; set; }
        public string FirmaLisansKey { get; set; }

        public ICollection<Personel> Personeller { get; set; }



    }
}

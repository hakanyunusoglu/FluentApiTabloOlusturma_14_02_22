namespace FluentApiTabloOlusturma_14_02_22.Models
{
    public class Personel
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Email { get; set; }
        public string Tel { get; set; }
        public string Aciklama { get; set; }
        public int FirID { get; set; }
        public Firma Firma { get; set; }
    }
}

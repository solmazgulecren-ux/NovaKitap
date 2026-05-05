namespace NovaKitap.Models
{
    public class UrunViewModel
    {
        public int Id { get; set; }
        public string? UrunAdi { get; set; }
        public decimal Fiyat { get; set; } // Fiyat genelde NOT NULL olur, hata alırsan decimal? yapabilirsin.
        public string? KapakResimUrl { get; set; }
        public string? UrunTipi { get; set; }
    }
}
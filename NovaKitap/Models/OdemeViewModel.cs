using System.Collections.Generic;

namespace NovaKitap.Models
{
    public class OdemeViewModel
    {
        public List<Adresler> KullaniciAdresleri { get; set; } = new List<Adresler>();
        public List<Kartlar> KullaniciKartlari { get; set; } = new List<Kartlar>();
        public decimal ToplamTutar { get; set; }

        // Sepetteki kitapları sayfaya taşımak için bu satırı ekledik
        public List<Kitaplar> SepetKitaplari { get; set; } = new List<Kitaplar>();
    }
}
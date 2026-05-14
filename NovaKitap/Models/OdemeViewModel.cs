using System.Collections.Generic;

namespace NovaKitap.Models
{
    public class OdemeViewModel
    {
        public List<Adresler> KullaniciAdresleri { get; set; } = new List<Adresler>();
        public List<Kartlar> KullaniciKartlari { get; set; } = new List<Kartlar>();
        public decimal ToplamTutar { get; set; }

        // Kitaplar yerine genel UrunViewModel listesi kullanıyoruz
        public List<UrunViewModel> SepetUrunleri { get; set; } = new List<UrunViewModel>();
    }
}
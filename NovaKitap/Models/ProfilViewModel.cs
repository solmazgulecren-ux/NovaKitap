using System.Collections.Generic;

namespace NovaKitap.Models
{
    public class ProfilViewModel
    {
        public Kullanicilar Kullanici { get; set; }
        public List<Adresler> Adresler { get; set; } = new List<Adresler>();
        public List<Kartlar> Kartlar { get; set; } = new List<Kartlar>();

        // Sipariş listeleri
        public List<Siparis> AktifSiparisler { get; set; } = new List<Siparis>();
        public List<Siparis> GecmisSiparisler { get; set; } = new List<Siparis>();

        // Yıldızladıklarım (Kaydedilenler)
        public List<Kaydedilenler> Yildizladiklarim { get; set; } = new List<Kaydedilenler>();
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NovaKitap.Models
{
    public class Siparis
    {
        [Key]
        public int SiparisId { get; set; }
        public int KullaniciId { get; set; }
        public DateTime SiparisTarihi { get; set; } = DateTime.Now;
        public decimal ToplamTutar { get; set; }
        public string? SiparisDurumu { get; set; } = "Onay Bekliyor";
        public string? KargoAdresi { get; set; }

        public List<SiparisDetayi> SiparişDetaylari { get; set; }
    }
}
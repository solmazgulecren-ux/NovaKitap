using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; // EKLENDİ

namespace NovaKitap.Models
{
    public class Siparis
    {
        [Key]
        public int SiparisId { get; set; }
        public int KullaniciId { get; set; }
        public DateTime SiparisTarihi { get; set; } = DateTime.Now;

        [Column(TypeName = "decimal(18,2)")] // EKLENDİ
        public decimal ToplamTutar { get; set; }

        public string? SiparisDurumu { get; set; } = "Onay Bekliyor";
        public string? KargoAdresi { get; set; }

        public List<SiparisDetayi> SiparişDetaylari { get; set; }
    }
}
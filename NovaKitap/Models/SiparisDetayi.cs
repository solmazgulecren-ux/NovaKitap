using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; // EKLENDİ

namespace NovaKitap.Models
{
    public class SiparisDetayi
    {
        [Key]
        public int SiparisDetayId { get; set; }
        public int SiparisId { get; set; }
        public int KitapId { get; set; }
        public int Adet { get; set; } = 1;

        [Column(TypeName = "decimal(18,2)")] // EKLENDİ
        public decimal BirimFiyat { get; set; }

        public Siparis Siparis { get; set; }
        public Kitaplar Kitap { get; set; }
    }
}
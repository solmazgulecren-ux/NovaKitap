using System.ComponentModel.DataAnnotations;

namespace NovaKitap.Models
{
    public class SiparisDetayi
    {
        [Key]
        public int SiparisDetayId { get; set; }
        public int SiparisId { get; set; }
        public int KitapId { get; set; }
        public int Adet { get; set; } = 1;
        public decimal BirimFiyat { get; set; }

        public Siparis Siparis { get; set; }
        public Kitaplar Kitap { get; set; }
    }
}
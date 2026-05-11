using System;
using System.ComponentModel.DataAnnotations;

namespace NovaKitap.Models
{
    public class Yorumlar
    {
        [Key]
        public int YorumId { get; set; }

        // Hangi ürüne ait olduğunu bulmak için
        public int UrunId { get; set; }
        public string UrunTipi { get; set; } // "Kitap", "Kirtasiye", "Oyuncak"

        // Yorum detayları
        public string KullaniciAdi { get; set; }
        public int Yildiz { get; set; }
        public string YorumMetni { get; set; }
        public DateTime Tarih { get; set; } = DateTime.Now;
    }
}
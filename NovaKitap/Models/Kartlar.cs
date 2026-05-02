using System.ComponentModel.DataAnnotations;

namespace NovaKitap.Models
{
    public class Kartlar
    {
        [Key]
        public int KartId { get; set; }
        public int KullaniciId { get; set; }
        public string? KartBasligi { get; set; }
        public string?   AdSoyad { get; set; }
        public string? KartNumarasi { get; set; }
        public string? SonKullanmaAy { get; set; }
        public string? SonKullanmaYil { get; set; }
    }
}
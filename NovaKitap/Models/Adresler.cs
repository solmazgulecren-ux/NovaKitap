using System.ComponentModel.DataAnnotations;

namespace NovaKitap.Models
{
    public class Adresler
    {
        [Key]
        public int AdresId { get; set; }
        public int KullaniciId { get; set; }
        public string? AdresBasligi { get; set; }
        public string? AcikAdres { get; set; }
        public string? Sehir { get; set; }
    }
}
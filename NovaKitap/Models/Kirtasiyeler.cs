using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NovaKitap.Models
{
    [Table("Kirtasiyeler")]
    public class Kirtasiyeler
    {
        [Key]
        public int KirtasiyeId { get; set; }

        [Required]
        [StringLength(200)]
        public string? UrunAdi { get; set; }

        public string? Aciklama { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Fiyat { get; set; }

        [StringLength(500)]
        public string? KapakResimUrl { get; set; }

        public bool? YeniCikanMi { get; set; } = false;

        public bool? CokSatanMi { get; set; } = false;

        public int StokAdedi { get; set; } = 0;
        public int? KategoriId { get; set; }

        [ForeignKey("KategoriId")]
        public virtual Kategoriler? Kategori { get; set; }

        [StringLength(150)]
        public string? Marka { get; set; }

        [StringLength(100)]
        public string? UrunTuru { get; set; } // Örn: Defter, Kalem, Çanta
    }
}
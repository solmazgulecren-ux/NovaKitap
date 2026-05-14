using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NovaKitap.Models
{
    // Veritabanındaki tablo adını zorunlu kılıyoruz ki "Oyuncaklars" hatası almayalım
    [Table("Oyuncaklar")]
    public class Oyuncaklar
    {
        [Key]
        public int OyuncakId { get; set; }

        [Required]
        [StringLength(200)]
        public string? UrunAdi { get; set; }

        public string? Aciklama { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Fiyat { get; set; }

        [StringLength(500)]
        public string? KapakResimUrl { get; set; }

        // DİKKAT: SQL'deki NULL izninden dolayı soru işareti (?) eklendi!
        public bool? YeniCikanMi { get; set; }

        // DİKKAT: SQL'deki NULL izninden dolayı soru işareti (?) eklendi!
        public bool? CokSatanMi { get; set; }

        // DİKKAT: SQL'deki NULL izninden dolayı soru işareti (?) eklendi!
        public int? KategoriId { get; set; }
        public int StokAdedi { get; set; } = 0;

        [ForeignKey("KategoriId")]
        public virtual Kategoriler Kategori { get; set; }

        [StringLength(50)]
        public string? YasGrubu { get; set; }

        [StringLength(150)]
        public string? Marka { get; set; }
    }
}
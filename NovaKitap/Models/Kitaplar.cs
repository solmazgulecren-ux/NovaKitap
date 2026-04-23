using System;
using System.Collections.Generic;

namespace NovaKitap.Models;

public partial class Kitaplar
{
    public int KitapId { get; set; }

    public string KitapAdi { get; set; } = null!;

    public string? Aciklama { get; set; }

    public int? SayfaSayisi { get; set; }

    public decimal Fiyat { get; set; }

    public string? KapakResimUrl { get; set; }

    public bool? YeniCikanMi { get; set; }

    public bool? CokSatanMi { get; set; }

    public int? YazarId { get; set; }

    public int? KategoriId { get; set; }

    public virtual Kategoriler? Kategori { get; set; }

    public virtual ICollection<Kaydedilenler> Kaydedilenlers { get; set; } = new List<Kaydedilenler>();

    public virtual Yazarlar? Yazar { get; set; }

    public string Yayinevi { get; set; }
    public int? BasimYili { get; set; }
}

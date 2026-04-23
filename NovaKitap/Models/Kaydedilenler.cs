using System;
using System.Collections.Generic;

namespace NovaKitap.Models;

public partial class Kaydedilenler
{
    public int KayitId { get; set; }

    public int? KullaniciId { get; set; }

    public int? KitapId { get; set; }

    public DateTime? KayitTarihi { get; set; }

    public virtual Kitaplar? Kitap { get; set; }

    public virtual Kullanicilar? Kullanici { get; set; }
}

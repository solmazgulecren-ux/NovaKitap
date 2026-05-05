using System;
using System.Collections.Generic;

namespace NovaKitap.Models;

public partial class Kullanicilar
{
    public int KullaniciId { get; set; }

    public string AdSoyad { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Rol { get; set; } = "Musteri";
    public string Sifre { get; set; } = null!;

    public virtual ICollection<Kaydedilenler> Kaydedilenlers { get; set; } = new List<Kaydedilenler>();
}

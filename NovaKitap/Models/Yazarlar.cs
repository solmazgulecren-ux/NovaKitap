using System;
using System.Collections.Generic;

namespace NovaKitap.Models;

public partial class Yazarlar
{
    public int YazarId { get; set; }

    public string AdSoyad { get; set; } = null!;

    public string? Biyografi { get; set; }

    public virtual ICollection<Kitaplar> Kitaplars { get; set; } = new List<Kitaplar>();
}

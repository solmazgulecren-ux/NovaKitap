using Microsoft.EntityFrameworkCore;
using NovaKitap.Models;

var builder = WebApplication.CreateBuilder(args);

// --- 1. SERVİS KAYITLARI ---
builder.Services.AddControllersWithViews();

// Oturum (Session) ve Layout'tan oturuma erişim servisleri eklendi
builder.Services.AddHttpContextAccessor();
builder.Services.AddSession();

// Veritabanı bağlantısı
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// --- Veritabanı Yorum Seed ---
// Uygulama başlatılırken Yorumlar tablosu boşsa sahte yorumlar ekle
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    if (!db.Yorumlars.Any())
    {
        var isimler = new[] {
            "Ayşe Y.", "Mehmet K.", "Zeynep D.", "Ali R.", "Fatma S.",
            "Emre T.", "Elif N.", "Burak Ç.", "Selin M.", "Oğuz H.",
            "Derya B.", "Cem A.", "Gül P.", "Hakan L.", "İrem V.",
            "Kaan E.", "Nisa F.", "Serkan G.", "Tuğçe İ.", "Volkan Ö.",
            "Aslı K.", "Barış D.", "Ceren Y.", "Deniz S.", "Eda T.",
            "Furkan M.", "Gamze R.", "Hüseyin B.", "Işıl A.", "Kerem N."
        };

        var kitapYorumlari = new[] {
            "Harika bir kitap! Bir solukta okudum, elimden bırakamadım.",
            "Çok etkileyici bir anlatım. Yazar gerçekten başarılı.",
            "Bu kitabı okumadan geçmeyin, kesinlikle tavsiye ederim!",
            "Konusu çok ilginçti, merak edip bitiremedim.",
            "Beklentilerimi karşıladı, güzel bir okuma deneyimiydi.",
            "Arkadaşıma hediye aldım, çok beğendi. Kaliteli bir baskı.",
            "Sayfa sayısı az gibi görünse de içeriği çok dolu.",
            "Yazarın en iyi eserlerinden biri bence.",
            "Kargo hızlıydı, kitap tertemiz geldi. İçerik de harika.",
            "İkinci kez okuyorum, her seferinde farklı şeyler keşfediyorum.",
            "Çocuğuma aldım, bayıldı! Yaşına çok uygun.",
            "Düşündürücü bir kitap, perspektifimi değiştirdi.",
            "Akıcı bir dili var, sıkılmadan okudum.",
            "Kapak tasarımı da çok güzel, rafta çok şık duruyor.",
            "Fiyatına göre çok kaliteli, memnun kaldım.",
            "Bu yazarın diğer kitaplarını da alacağım kesinlikle.",
            "Üniversitede ders kitabı olarak okutulmuştu, tekrar okumak güzeldi.",
            "Gece yatmadan okudum, sabaha kadar bırakamadım!",
            "Romanın sonundaki plot twist muhteşemdi!",
            "Karakterler çok iyi kurgulanmış, kendimi içinde hissettim."
        };

        var kirtasiyeYorumlari = new[] {
            "Kalitesi çok iyi, uzun süredir kullanıyorum.",
            "Fiyat/performans oranı harika, tavsiye ederim.",
            "Okul için aldım, çok memnunum.",
            "Renkleri çok canlı ve kalıcı.",
            "Çocuğum çok sevdi, her gün kullanıyor.",
            "Ofiste herkes soruyor nereden aldığımı!",
            "Dayanıklı ve şık görünümlü, tam aradığım gibi.",
            "İkinci kez sipariş verdim, ilkini çok beğenmiştim.",
            "Hediye olarak aldım, çok beğenildi.",
            "Yazı yazmak artık zevk, kalitesi gerçekten üst düzey.",
            "Beklediğimden çok daha iyi çıktı.",
            "Sınav döneminde hayat kurtarıcı oldu!",
            "Tasarımı çok modern ve şık.",
            "Her gün çantamda taşıyorum, çok pratik.",
            "Markası güvenilir, her zaman tercih ederim."
        };

        var oyuncakYorumlari = new[] {
            "Çocuğum bayıldı! Saatlerce oynuyor.",
            "Doğum günü hediyesi olarak aldım, çok sevildi.",
            "Kaliteli malzeme, sağlam yapım. Güvenle oynatabiliriz.",
            "Yaş grubuna çok uygun, eğitici de aynı zamanda.",
            "Renkleri canlı, boyutu tam istediğim gibi.",
            "Kargo özenli paketlenmişti, kutusu bile sağlamdı.",
            "Yeğenime hediye ettim, evden gitmek istemedi!",
            "Fiyatı biraz yüksek ama kalitesi hak ediyor.",
            "Hayal gücünü geliştiren harika bir oyuncak.",
            "İkincisini de alacağım, çocuk çok mutlu oldu.",
            "Hem eğlenceli hem öğretici, anne-babalar için ideal.",
            "Marka güvenilir, hiç sorun yaşamadık.",
            "Kutu açılışı bile heyecan vericiydi!",
            "Kreşte de aynısından istendi, çok popüler.",
            "Çocuğumun en sevdiği oyuncağı oldu, her yere götürüyor."
        };

        var yorumListesi = new List<Yorumlar>();

        // Kitap ID'lerini veritabanından al
        var kitapIds = db.Kitaplar.Select(k => k.KitapId).ToList();
        foreach (var kitapId in kitapIds)
        {
            int idx1 = kitapId % isimler.Length;
            int idx2 = (kitapId * 7 + 3) % isimler.Length;
            int yIdx1 = kitapId % kitapYorumlari.Length;
            int yIdx2 = (kitapId * 11 + 5) % kitapYorumlari.Length;

            yorumListesi.Add(new Yorumlar { UrunId = kitapId, UrunTipi = "Kitap", KullaniciAdi = isimler[idx1], Yildiz = (kitapId % 3 == 0) ? 4 : 5, YorumMetni = kitapYorumlari[yIdx1], Tarih = new DateTime(2026, 1, 1).AddDays(kitapId % 120) });
            yorumListesi.Add(new Yorumlar { UrunId = kitapId, UrunTipi = "Kitap", KullaniciAdi = isimler[idx2], Yildiz = (kitapId % 5 == 0) ? 3 : 4, YorumMetni = kitapYorumlari[yIdx2], Tarih = new DateTime(2026, 2, 1).AddDays(kitapId % 90) });
        }

        // Kırtasiye
        var kirtasiyeIds = db.Kirtasiyelers.Select(k => k.KirtasiyeId).ToList();
        foreach (var kId in kirtasiyeIds)
        {
            int idx1 = (kId + 5) % isimler.Length;
            int idx2 = (kId * 3 + 7) % isimler.Length;
            int yIdx1 = kId % kirtasiyeYorumlari.Length;
            int yIdx2 = (kId * 7 + 2) % kirtasiyeYorumlari.Length;

            yorumListesi.Add(new Yorumlar { UrunId = kId, UrunTipi = "Kirtasiye", KullaniciAdi = isimler[idx1], Yildiz = (kId % 4 == 0) ? 4 : 5, YorumMetni = kirtasiyeYorumlari[yIdx1], Tarih = new DateTime(2026, 1, 15).AddDays(kId % 100) });
            yorumListesi.Add(new Yorumlar { UrunId = kId, UrunTipi = "Kirtasiye", KullaniciAdi = isimler[idx2], Yildiz = (kId % 6 == 0) ? 3 : 5, YorumMetni = kirtasiyeYorumlari[yIdx2], Tarih = new DateTime(2026, 3, 1).AddDays(kId % 60) });
        }

        // Oyuncak
        var oyuncakIds = db.Oyuncaklars.Select(o => o.OyuncakId).ToList();
        foreach (var oId in oyuncakIds)
        {
            int idx1 = (oId + 10) % isimler.Length;
            int idx2 = (oId * 5 + 1) % isimler.Length;
            int yIdx1 = oId % oyuncakYorumlari.Length;
            int yIdx2 = (oId * 9 + 4) % oyuncakYorumlari.Length;

            yorumListesi.Add(new Yorumlar { UrunId = oId, UrunTipi = "Oyuncak", KullaniciAdi = isimler[idx1], Yildiz = (oId % 3 == 0) ? 5 : 4, YorumMetni = oyuncakYorumlari[yIdx1], Tarih = new DateTime(2026, 2, 10).AddDays(oId % 80) });
            yorumListesi.Add(new Yorumlar { UrunId = oId, UrunTipi = "Oyuncak", KullaniciAdi = isimler[idx2], Yildiz = (oId % 7 == 0) ? 3 : 5, YorumMetni = oyuncakYorumlari[yIdx2], Tarih = new DateTime(2026, 3, 15).AddDays(oId % 70) });
        }

        db.Yorumlars.AddRange(yorumListesi);
        db.SaveChanges();
    }
}

// --- 2. ARA KATMANLAR (Middleware) ---
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

// Oturum kullanımı (Mutlaka UseRouting ve UseAuthorization arasında olmalı)
app.UseSession();

app.UseAuthorization();

// --- 3. ROTALAMA ---
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NovaKitap.Models;
using Microsoft.AspNetCore.Http;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json; 
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Text;
using System.Linq;
namespace NovaKitap.Controllers
{
    // ChatBot'tan gelen mesajı karşılamak için gereken sınıf
    public class ChatRequest
    {
        public string Mesaj { get; set; } = "";
    }

    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IConfiguration _configuration;

        public HomeController(AppDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        // Yıldızları her sayfada senkronize eden metod
        private void GetKaydedilenIdler()
        {
            int? kullaniciId = HttpContext.Session.GetInt32("KullaniciId");

            if (kullaniciId.HasValue)
            {
                ViewBag.KaydedilenIdler = _context.Kaydedilenlers
                    .Where(x => x.KullaniciId == kullaniciId.Value && x.KitapId != null)
                    .Select(x => x.KitapId.Value)
                    .ToList();
            }
            else
            {
                ViewBag.KaydedilenIdler = new List<int>();
            }
        }

        public IActionResult Index()
        {
            GetKaydedilenIdler();
            HomeViewModel viewModel = new HomeViewModel
            {
                YeniCikanlar = _context.Kitaplar.Where(k => k.YeniCikanMi == true).Take(10).ToList(),
                CokSatanlar = _context.Kitaplar.Where(k => k.CokSatanMi == true).Take(10).ToList(),
                Onerilenler = _context.Kitaplar.Take(10).ToList()
            };

            return View(viewModel);
        }

        public IActionResult Kategori(int id)
        {
            // Sepetteki sayı gibi ortak veriler için (varsa)
            GetKaydedilenIdler();

            // Önce Kategoriyi bulalım ki adını sayfada başlık olarak yazabilelim
            var kategori = _context.Kategorilers.FirstOrDefault(k => k.KategoriId == id);
            if (kategori == null)
            {
                return RedirectToAction("Index"); // Kategori yoksa anasayfaya at
            }

            // O kategoriye ait kitapları, yazar bilgileriyle beraber çekiyoruz
            var kitaplar = _context.Kitaplar
                .Include(k => k.Yazar)
                .Where(k => k.KategoriId == id)
                .ToList();

            ViewBag.KategoriAdi = kategori.KategoriAdi;
            ViewBag.Ikon = kategori.IkonSifi;

            return View(kitaplar);
        }

        // --- EKSİK OLAN YAZAR DETAY METODU EKLENDİ ---
        public IActionResult YazarDetay(int id)
        {
            GetKaydedilenIdler();
            var kitaplar = _context.Kitaplar.Include(k => k.Yazar).Where(k => k.YazarId == id).ToList();
            var yazar = _context.Yazarlars.Find(id);
            ViewBag.KategoriAdi = yazar?.AdSoyad + " Eserleri";
            
            // Kategori sayfasının tasarımını kullanarak yazarın kitaplarını listeliyoruz
            return View("Kategori", kitaplar); 
        }
        // ----------------------------------------------

        public IActionResult Ara(string? q)
        {
            GetKaydedilenIdler();
            if (string.IsNullOrEmpty(q)) return RedirectToAction("Index");

            string arama = q.ToLower();

            var kitaplar = _context.Kitaplar.Include(k => k.Yazar)
                .Where(k => k.KitapAdi.ToLower().Contains(arama) || (k.Yazar != null && k.Yazar.AdSoyad.ToLower().Contains(arama)))
                .Select(k => new UrunViewModel { Id = k.KitapId, UrunAdi = k.KitapAdi, Fiyat = k.Fiyat, KapakResimUrl = k.KapakResimUrl, UrunTipi = "Kitap" }).ToList();

            var kirtasiyeler = _context.Kirtasiyelers
                .Where(k => k.UrunAdi.ToLower().Contains(arama) || (k.Marka != null && k.Marka.ToLower().Contains(arama)))
                .Select(k => new UrunViewModel { Id = k.KirtasiyeId, UrunAdi = k.UrunAdi, Fiyat = k.Fiyat, KapakResimUrl = k.KapakResimUrl, UrunTipi = "Kırtasiye" }).ToList();

            var oyuncaklar = _context.Oyuncaklars
                .Where(o => o.UrunAdi.ToLower().Contains(arama) || (o.Marka != null && o.Marka.ToLower().Contains(arama)))
                .Select(o => new UrunViewModel { Id = o.OyuncakId, UrunAdi = o.UrunAdi, Fiyat = o.Fiyat, KapakResimUrl = o.KapakResimUrl, UrunTipi = "Oyuncak" }).ToList();

            var sonuclar = kitaplar.Concat(kirtasiyeler).Concat(oyuncaklar).ToList();

            ViewBag.AramaKelimesi = q;

            return View(sonuclar);
        }

        public IActionResult Kaydedilenler()
        {
            var kullaniciId = HttpContext.Session.GetInt32("KullaniciId");

            if (kullaniciId == null)
            {
                return RedirectToAction("GirisYap", "Hesap");
            }

            GetKaydedilenIdler();

            var liste = _context.Kaydedilenlers
                .Include(k => k.Kitap)
                .Where(k => k.KullaniciId == kullaniciId)
                .Select(k => k.Kitap)
                .ToList();

            return View(liste);
        }

        [HttpPost]
        public IActionResult KaydetToggle(int kitapId)
        {
            var kullaniciId = HttpContext.Session.GetInt32("KullaniciId");
            if (kullaniciId == null)
            {
                return Unauthorized();
            }

            var mevcutKayit = _context.Kaydedilenlers
                                      .FirstOrDefault(k => k.KullaniciId == kullaniciId && k.KitapId == kitapId);

            if (mevcutKayit != null)
            {
                _context.Kaydedilenlers.Remove(mevcutKayit);
            }
            else
            {
                _context.Kaydedilenlers.Add(new Kaydedilenler
                {
                    KullaniciId = kullaniciId.Value,
                    KitapId = kitapId
                });
            }

            _context.SaveChanges();
            return Ok();
        }

        // --- DETAY VE SEPET İŞLEMLERİ ---

        public IActionResult Detay(int id, string tip = "Kitap")
        {
            GetKaydedilenIdler();

            // Bu ürüne ait yorumları veritabanından çekiyoruz (Yeniden eskiye)
            var yorumlar = _context.Yorumlars
                .Where(y => y.UrunId == id && y.UrunTipi == tip)
                .OrderByDescending(y => y.Tarih)
                .ToList();

            if (tip == "Kirtasiye" || tip == "Kırtasiye")
            {
                var urun = _context.Kirtasiyelers.FirstOrDefault(k => k.KirtasiyeId == id);
                if (urun == null) return RedirectToAction("Index");
                return View("UrunDetay", new UrunViewModel { Id = urun.KirtasiyeId, UrunAdi = urun.UrunAdi, Fiyat = urun.Fiyat, KapakResimUrl = urun.KapakResimUrl, UrunTipi = "Kirtasiye", Aciklama = urun.Aciklama, Marka = urun.Marka, EkBilgi = urun.UrunTuru, YorumlarListesi = yorumlar });
            }
            else if (tip == "Oyuncak")
            {
                var urun = _context.Oyuncaklars.FirstOrDefault(o => o.OyuncakId == id);
                if (urun == null) return RedirectToAction("Index");
                return View("UrunDetay", new UrunViewModel { Id = urun.OyuncakId, UrunAdi = urun.UrunAdi, Fiyat = urun.Fiyat, KapakResimUrl = urun.KapakResimUrl, UrunTipi = "Oyuncak", Aciklama = urun.Aciklama, Marka = urun.Marka, EkBilgi = urun.YasGrubu, YorumlarListesi = yorumlar });
            }

            var kitap = _context.Kitaplar.Include(k => k.Yazar).Include(k => k.Kategori).FirstOrDefault(k => k.KitapId == id);
            if (kitap == null) return RedirectToAction("Index");

            return View("UrunDetay", new UrunViewModel { Id = kitap.KitapId, UrunAdi = kitap.KitapAdi, Fiyat = kitap.Fiyat, KapakResimUrl = kitap.KapakResimUrl, UrunTipi = "Kitap", Aciklama = kitap.Aciklama, Marka = kitap.Yazar?.AdSoyad, EkBilgi = kitap.Yayinevi, YorumlarListesi = yorumlar });
        }

        [HttpPost]
        public IActionResult YorumEkle(int UrunId, string UrunTipi, string KullaniciAdi, int Yildiz, string YorumMetni)
        {
            if (!string.IsNullOrEmpty(YorumMetni))
            {
                _context.Yorumlars.Add(new Yorumlar
                {
                    UrunId = UrunId,
                    UrunTipi = UrunTipi,
                    KullaniciAdi = string.IsNullOrEmpty(KullaniciAdi) ? "Anonim Kullanıcı" : KullaniciAdi,
                    Yildiz = Yildiz,
                    YorumMetni = YorumMetni,
                    Tarih = DateTime.Now
                });
                _context.SaveChanges();
            }
            return RedirectToAction("Detay", new { id = UrunId, tip = UrunTipi });
        }

        public IActionResult SepeteEkle(int id, string tip = "Kitap")
        {
            var kullaniciId = HttpContext.Session.GetInt32("KullaniciId");
            if (kullaniciId == null)
            {
                TempData["GirisUyarisi"] = true;
                return Redirect(Request.Headers["Referer"].ToString() ?? "/");
            }

            string? sepetJson = HttpContext.Session.GetString("Sepetim");
            List<string> sepet = string.IsNullOrEmpty(sepetJson)
                ? new List<string>()
                : JsonSerializer.Deserialize<List<string>>(sepetJson) ?? new List<string>();

            sepet.Add($"{tip}-{id}");
            HttpContext.Session.SetString("Sepetim", JsonSerializer.Serialize(sepet));

            return RedirectToAction("Sepet");
        }

        public IActionResult Sepet()
        {
            GetKaydedilenIdler();

            string? sepetJson = HttpContext.Session.GetString("Sepetim");
            // Sepeti string listesi olarak alıyoruz (Çünkü içinde "Kitap-1", "Oyuncak-5" gibi metinler var)
            List<string> sepetHamListe = string.IsNullOrEmpty(sepetJson)
                ? new List<string>()
                : JsonSerializer.Deserialize<List<string>>(sepetJson) ?? new List<string>();

            var sepetUrunleri = new List<UrunViewModel>();

            foreach (var item in sepetHamListe)
            {
                var parcalar = item.Split('-'); // "Kitap" ve "1" olarak ayırır
                string tip = parcalar[0];
                int id = int.Parse(parcalar[1]);

                if (tip == "Kitap")
                {
                    var kitap = _context.Kitaplar.Include(k => k.Yazar).FirstOrDefault(k => k.KitapId == id);
                    if (kitap != null) sepetUrunleri.Add(new UrunViewModel { Id = kitap.KitapId, UrunAdi = kitap.KitapAdi, Fiyat = kitap.Fiyat, KapakResimUrl = kitap.KapakResimUrl, UrunTipi = "Kitap" });
                }
                else if (tip == "Kirtasiye" || tip == "Kırtasiye")
                {
                    var kirtasiye = _context.Kirtasiyelers.FirstOrDefault(k => k.KirtasiyeId == id);
                    if (kirtasiye != null) sepetUrunleri.Add(new UrunViewModel { Id = kirtasiye.KirtasiyeId, UrunAdi = kirtasiye.UrunAdi, Fiyat = kirtasiye.Fiyat, KapakResimUrl = kirtasiye.KapakResimUrl, UrunTipi = "Kırtasiye" });
                }
                else if (tip == "Oyuncak")
                {
                    var oyuncak = _context.Oyuncaklars.FirstOrDefault(o => o.OyuncakId == id);
                    if (oyuncak != null) sepetUrunleri.Add(new UrunViewModel { Id = oyuncak.OyuncakId, UrunAdi = oyuncak.UrunAdi, Fiyat = oyuncak.Fiyat, KapakResimUrl = oyuncak.KapakResimUrl, UrunTipi = "Oyuncak" });
                }
            }

            return View(sepetUrunleri);
        }

        public IActionResult Odeme()
        {
            var kullaniciId = HttpContext.Session.GetInt32("KullaniciId");
            if (kullaniciId == null) return RedirectToAction("GirisYap", "Hesap");

            string? sepetJson = HttpContext.Session.GetString("Sepetim");
            if (string.IsNullOrEmpty(sepetJson)) return RedirectToAction("Sepet");

            // Sepeti string listesi olarak okuyoruz
            List<string> sepetHamListe = JsonSerializer.Deserialize<List<string>>(sepetJson) ?? new List<string>();
            var sepetUrunleri = new List<UrunViewModel>();

            foreach (var item in sepetHamListe)
            {
                var parcalar = item.Split('-');
                string tip = parcalar[0];
                int id = int.Parse(parcalar[1]);

                if (tip == "Kitap")
                {
                    var k = _context.Kitaplar.Include(x => x.Yazar).FirstOrDefault(x => x.KitapId == id);
                    if (k != null) sepetUrunleri.Add(new UrunViewModel { Id = k.KitapId, UrunAdi = k.KitapAdi, Fiyat = k.Fiyat, KapakResimUrl = k.KapakResimUrl, UrunTipi = "Kitap", Marka = k.Yazar?.AdSoyad });
                }
                else if (tip == "Kirtasiye" || tip == "Kırtasiye")
                {
                    var k = _context.Kirtasiyelers.FirstOrDefault(x => x.KirtasiyeId == id);
                    if (k != null) sepetUrunleri.Add(new UrunViewModel { Id = k.KirtasiyeId, UrunAdi = k.UrunAdi, Fiyat = k.Fiyat, KapakResimUrl = k.KapakResimUrl, UrunTipi = "Kırtasiye", Marka = k.Marka });
                }
                else if (tip == "Oyuncak")
                {
                    var o = _context.Oyuncaklars.FirstOrDefault(x => x.OyuncakId == id);
                    if (o != null) sepetUrunleri.Add(new UrunViewModel { Id = o.OyuncakId, UrunAdi = o.UrunAdi, Fiyat = o.Fiyat, KapakResimUrl = o.KapakResimUrl, UrunTipi = "Oyuncak", Marka = o.Marka });
                }
            }

            var viewModel = new OdemeViewModel
            {
                ToplamTutar = sepetUrunleri.Sum(u => u.Fiyat),
                KullaniciAdresleri = _context.Adresler.Where(a => a.KullaniciId == kullaniciId).ToList(),
                KullaniciKartlari = _context.Kartlar.Where(k => k.KullaniciId == kullaniciId).ToList(),
                SepetUrunleri = sepetUrunleri
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult YeniAdresEkle(string? AdresBasligi, string? AcikAdres, string? Sehir)
        {
            var kullaniciId = HttpContext.Session.GetInt32("KullaniciId");
            if (kullaniciId != null && !string.IsNullOrEmpty(AcikAdres))
            {
                _context.Adresler.Add(new Adresler
                {
                    KullaniciId = kullaniciId.Value,
                    AdresBasligi = AdresBasligi ?? "Ev",
                    AcikAdres = AcikAdres,
                    Sehir = Sehir ?? "Belirtilmedi"
                });
                _context.SaveChanges();
            }
            return RedirectToAction("Odeme");
        }

        [HttpPost]
        public IActionResult YeniKartEkle(string? KartBasligi, string? AdSoyad, string? KartNumarasi, string? SonKullanmaAy, string? SonKullanmaYil)
        {
            var kullaniciId = HttpContext.Session.GetInt32("KullaniciId");
            if (kullaniciId != null && !string.IsNullOrEmpty(KartNumarasi))
            {
                _context.Kartlar.Add(new Kartlar
                {
                    KullaniciId = kullaniciId.Value,
                    KartBasligi = KartBasligi ?? "Kartım",
                    AdSoyad = AdSoyad ?? "İsimsiz",
                    KartNumarasi = KartNumarasi,
                    SonKullanmaAy = SonKullanmaAy ?? "01",
                    SonKullanmaYil = SonKullanmaYil ?? "2030"
                });
                _context.SaveChanges();
            }
            return RedirectToAction("Odeme");
        }

        [HttpPost]
        public IActionResult SiparisiTamamla(int seciliAdresId, int seciliKartId)
        {
            var kullaniciId = HttpContext.Session.GetInt32("KullaniciId");
            if (kullaniciId == null) return RedirectToAction("GirisYap", "Hesap");

            var adres = _context.Adresler.FirstOrDefault(a => a.AdresId == seciliAdresId);
            if (adres == null) return RedirectToAction("Odeme");

            string? sepetJson = HttpContext.Session.GetString("Sepetim");
            if (string.IsNullOrEmpty(sepetJson)) return RedirectToAction("Sepet");

            // DÜZELTME: Sepeti string listesi olarak alıyoruz
            List<string> sepetHamListe = JsonSerializer.Deserialize<List<string>>(sepetJson) ?? new List<string>();

            if (!sepetHamListe.Any()) return RedirectToAction("Sepet");

            // Sipariş nesnesini oluşturuyoruz
            var yeniSiparis = new Siparis
            {
                KullaniciId = kullaniciId.Value,
                KargoAdresi = (adres.Sehir ?? "") + " - " + (adres.AcikAdres ?? ""),
                SiparisTarihi = DateTime.Now,
                SiparisDurumu = "Onay Bekliyor",
                ToplamTutar = 0 // Döngü içinde hesaplayacağız
            };

            _context.Siparisler.Add(yeniSiparis);
            _context.SaveChanges(); // Sipariş ID oluşması için önce kaydediyoruz

            decimal genelToplam = 0;

            foreach (var item in sepetHamListe)
            {
                var parcalar = item.Split('-');
                string tip = parcalar[0];
                int id = int.Parse(parcalar[1]);

                decimal birimFiyat = 0;
                int? kaydedilecekKitapId = null;

                // Ürünün fiyatını ve tipini buluyoruz
                if (tip == "Kitap")
                {
                    var urun = _context.Kitaplar.Find(id);
                    if (urun != null) { birimFiyat = urun.Fiyat; kaydedilecekKitapId = urun.KitapId; }
                }
                else if (tip == "Kirtasiye" || tip == "Kırtasiye")
                {
                    var urun = _context.Kirtasiyelers.Find(id);
                    if (urun != null) birimFiyat = urun.Fiyat;
                }
                else if (tip == "Oyuncak")
                {
                    var urun = _context.Oyuncaklars.Find(id);
                    if (urun != null) birimFiyat = urun.Fiyat;
                }

                // Sipariş Detayı ekleme
                // NOT: SiparisDetayi tablonuz şu an sadece KitapId'ye bağlı olabilir. 
                // Eğer oyuncak/kırtasiye satılacaksa o tabloyu da güncellemek gerekir ama şimdilik çökmemesi için:
                _context.SiparisDetaylari.Add(new SiparisDetayi
                {
                    SiparisId = yeniSiparis.SiparisId,
                    KitapId = kaydedilecekKitapId ?? 1, // Eğer kitap değilse varsayılan 1 veriyoruz (DB kısıtlaması varsa)
                    BirimFiyat = birimFiyat,
                    Adet = 1
                });

                genelToplam += birimFiyat;
            }

            // Toplam tutarı güncelleyip son kez kaydediyoruz
            yeniSiparis.ToplamTutar = genelToplam;
            _context.SaveChanges();

            // Sepeti boşaltıyoruz
            HttpContext.Session.Remove("Sepetim");

            return RedirectToAction("SiparisBasarili");
        }
        public IActionResult SiparisBasarili()
        {
            return View();
        }

        // Diğer boş sayfalar
        public IActionResult Kategoriler() => View();
        public IActionResult YeniCikanlar() => View(GetYeniCikanUrunlerListesi(20));
        
        public IActionResult EnCokSatanlar()
        {
            var cokSatanUrunler = GetCokSatanUrunlerListesi(20);
            return View(cokSatanUrunler);
        }

        private List<UrunViewModel> GetYeniCikanUrunlerListesi(int limit)
        {
            var kitaplar = _context.Kitaplar
                .Where(k => k.YeniCikanMi == true)
                .OrderByDescending(k => k.KitapId)
                .Select(k => new UrunViewModel { Id = k.KitapId, UrunAdi = k.KitapAdi, Fiyat = k.Fiyat, KapakResimUrl = k.KapakResimUrl, UrunTipi = "Kitap" })
                .ToList();

            var kirtasiyeler = _context.Kirtasiyelers
                .Where(k => k.YeniCikanMi == true)
                .OrderByDescending(k => k.KirtasiyeId)
                .Select(k => new UrunViewModel { Id = k.KirtasiyeId, UrunAdi = k.UrunAdi, Fiyat = k.Fiyat, KapakResimUrl = k.KapakResimUrl, UrunTipi = "Kirtasiye" })
                .ToList();

            return kitaplar.Concat(kirtasiyeler).Concat(_context.Oyuncaklars
               .Where(o => o.YeniCikanMi == true)
               .OrderByDescending(o => o.OyuncakId)
               .Select(static o => new UrunViewModel
               {
                   Id = o.OyuncakId,
                   UrunAdi = o.UrunAdi ?? "İsimsiz Ürün", 
                   Fiyat = o.Fiyat,
                   KapakResimUrl = o.KapakResimUrl ?? "/img/default.jpg", 
                   UrunTipi = "Oyuncak"
               })
               .ToList()).Take(limit).ToList();
        }

        private List<UrunViewModel> GetCokSatanUrunlerListesi(int limit)
        {
            var kitaplar = _context.Kitaplar.Where(k => k.CokSatanMi == true)
                .Select(k => new UrunViewModel { Id = k.KitapId, UrunAdi = k.KitapAdi, Fiyat = k.Fiyat, KapakResimUrl = k.KapakResimUrl, UrunTipi = "Kitap" }).ToList();

            var kirtasiyeler = _context.Kirtasiyelers.Where(k => k.CokSatanMi == true)
                .Select(k => new UrunViewModel { Id = k.KirtasiyeId, UrunAdi = k.UrunAdi, Fiyat = k.Fiyat, KapakResimUrl = k.KapakResimUrl, UrunTipi = "Kirtasiye" }).ToList();

            var oyuncaklar = _context.Oyuncaklars.Where(o => o.CokSatanMi == true)
                .Select(o => new UrunViewModel { Id = o.OyuncakId, UrunAdi = o.UrunAdi, Fiyat = o.Fiyat, KapakResimUrl = o.KapakResimUrl, UrunTipi = "Oyuncak" }).ToList();

            return kitaplar.Concat(kirtasiyeler).Concat(oyuncaklar).Take(limit).ToList();
        }

        public IActionResult Yazarlar()
        {
            var yazarListesi = _context.Yazarlars.ToList();
            return View(yazarListesi);
        }

        public IActionResult Privacy() => View();

        public IActionResult Kirtasiye()
        {
            var kirtasiyeUrunleri = _context.Kirtasiyelers
                .OrderByDescending(k => k.KirtasiyeId)
                .Select(k => new UrunViewModel
                {
                    Id = k.KirtasiyeId,
                    UrunAdi = k.UrunAdi,
                    Fiyat = k.Fiyat,
                    KapakResimUrl = k.KapakResimUrl,
                    UrunTipi = "Kirtasiye"
                }).ToList();

            return View(kirtasiyeUrunleri);
        }

        public IActionResult Oyuncak()
        {
            var oyuncaklar = _context.Oyuncaklars
             .Where(o => o.YeniCikanMi == true)
             .OrderByDescending(o => o.OyuncakId)
             .Select(o => new UrunViewModel
             {
                 Id = o.OyuncakId,
                 UrunAdi = o.UrunAdi ?? "Bilinmiyor",
                 Fiyat = o.Fiyat,
                 KapakResimUrl = o.KapakResimUrl ?? "",
                 UrunTipi = "Oyuncak"
             })
             .ToList();

            return View(oyuncaklar);
        }


        [HttpPost]
        public async Task<IActionResult> AsistanCevap([FromBody] ChatRequest request)
        {
            if (request == null || string.IsNullOrWhiteSpace(request.Mesaj))
            {
                return Json(new { cevap = "Lütfen bana bir mesaj yazın." });
            }

            // Müşterinin adını alıyoruz (Giriş yaptıysa)
            var kullaniciId = HttpContext.Session.GetInt32("KullaniciId");
            var kullaniciAdi = "Müşteri";
            if (kullaniciId.HasValue)
            {
                var kullanici = _context.Kullanicilars.Find(kullaniciId.Value);
                if (kullanici != null)
                {
                    kullaniciAdi = kullanici.AdSoyad;
                }
            }

            var msj = request.Mesaj.ToLower();
            string botCevap = "";

            if (msj.Contains("merhaba") || msj.Contains("selam"))
            {
                botCevap = $"Merhaba {kullaniciAdi}! 👋 Ben Nova Asistan. Sana nasıl yardımcı olabilirim? Kitap, kırtasiye veya oyuncak arıyorsan bana söyleyebilirsin.";
            }
            else if (msj.Contains("kitap") || msj.Contains("roman") || msj.Contains("hikaye") || msj.Contains("okumak"))
            {
                var list = await _context.Kitaplar.ToListAsync();
                var oneriler = list.OrderBy(x => Guid.NewGuid()).Take(3).ToList();
                botCevap = $"Harika bir seçim! 📚 Sana şu kitapları önerebilirim:<br><br>";
                foreach (var k in oneriler)
                {
                    botCevap += $"- <a href='/Home/Detay?id={k.KitapId}&tip=Kitap' style='color: var(--star-beige); font-weight: bold; text-decoration: underline;'>{k.KitapAdi}</a> ({k.Fiyat}₺)<br>";
                }
            }
            else if (msj.Contains("kırtasiye") || msj.Contains("kirtasiye") || msj.Contains("kalem") || msj.Contains("defter") || msj.Contains("silgi") || msj.Contains("boya"))
            {
                var list = await _context.Kirtasiyelers.ToListAsync();
                var oneriler = list.OrderBy(x => Guid.NewGuid()).Take(3).ToList();
                botCevap = $"Kırtasiye ihtiyaçların için buradayım! ✏️ İşte senin için seçtiklerim:<br><br>";
                foreach (var k in oneriler)
                {
                    botCevap += $"- <a href='/Home/Detay?id={k.KirtasiyeId}&tip=Kirtasiye' style='color: var(--star-beige); font-weight: bold; text-decoration: underline;'>{k.UrunAdi}</a> ({k.Fiyat}₺)<br>";
                }
            }
            else if (msj.Contains("oyuncak") || msj.Contains("araba") || msj.Contains("oyun") || msj.Contains("bebek") || msj.Contains("lego"))
            {
                var list = await _context.Oyuncaklars.ToListAsync();
                var oneriler = list.OrderBy(x => Guid.NewGuid()).Take(3).ToList();
                botCevap = $"Eğlence başlasın! 🎲 İşte çok sevilen oyuncaklarımız:<br><br>";
                foreach (var o in oneriler)
                {
                    botCevap += $"- <a href='/Home/Detay?id={o.OyuncakId}&tip=Oyuncak' style='color: var(--star-beige); font-weight: bold; text-decoration: underline;'>{o.UrunAdi}</a> ({o.Fiyat}₺)<br>";
                }
            }
            else
            {
                var list = await _context.Kitaplar.ToListAsync();
                var urun = list.OrderBy(x => Guid.NewGuid()).FirstOrDefault();
                botCevap = $"Hmm, bunu tam olarak anlayamadım {kullaniciAdi}. 🤔 Ama eğer ilgini çekerse şu harika ürüne göz atabilirsin:<br><br>";
                if (urun != null)
                {
                    botCevap += $"🌟 <a href='/Home/Detay?id={urun.KitapId}&tip=Kitap' style='color: var(--star-beige); font-weight: bold; text-decoration: underline;'>{urun.KitapAdi}</a> ({urun.Fiyat}₺)<br>";
                }
            }

            return Json(new { cevap = botCevap });
        }

    }
}
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NovaKitap.Models;
using Microsoft.AspNetCore.Http;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json; // Sepet işlemleri için ŞART
using System;

namespace NovaKitap.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
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

            var viewModel = new HomeViewModel
            {
                YeniCikanlar = _context.Kitaplars.Where(k => k.YeniCikanMi == true).Take(10).ToList(),
                CokSatanlar = _context.Kitaplars.Where(k => k.CokSatanMi == true).Take(10).ToList(),
                Onerilenler = _context.Kitaplars.Take(10).ToList()
            };

            return View(viewModel);
        }

        public IActionResult Kategori(int id, string? isim)
        {
            GetKaydedilenIdler();

            var kitaplar = _context.Kitaplars
                                   .Where(k => k.KategoriId == id)
                                   .ToList();

            ViewBag.KategoriAdi = isim ?? "Kategori";
            ViewBag.KategoriId = id;

            return View(kitaplar);
        }

        public IActionResult Ara(string? q)
        {
            GetKaydedilenIdler();

            if (string.IsNullOrEmpty(q))
            {
                return RedirectToAction("Index");
            }

            var sonuclar = _context.Kitaplars
                .Include(k => k.Yazar)
                .Where(k => k.KitapAdi.Contains(q) || (k.Yazar != null && k.Yazar.AdSoyad.Contains(q)))
                .ToList();

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

        public IActionResult Detay(int id)
        {
            GetKaydedilenIdler();

            var kitap = _context.Kitaplars
                .Include(k => k.Yazar)
                .Include(k => k.Kategori)
                .FirstOrDefault(k => k.KitapId == id);

            if (kitap == null) return RedirectToAction("Index");

            return View(kitap);
        }

        public IActionResult SepeteEkle(int id)
        {
            var kullaniciId = HttpContext.Session.GetInt32("KullaniciId");

            // Eğer giriş yapılmamışsa uyarı modalını tetikle ve aynı sayfada kal
            if (kullaniciId == null)
            {
                TempData["GirisUyarisi"] = true;
                return Redirect(Request.Headers["Referer"].ToString() ?? "/");
            }

            string? sepetJson = HttpContext.Session.GetString("Sepetim");

            List<int> sepet = string.IsNullOrEmpty(sepetJson)
                ? new List<int>()
                : JsonSerializer.Deserialize<List<int>>(sepetJson) ?? new List<int>();

            sepet.Add(id);
            HttpContext.Session.SetString("Sepetim", JsonSerializer.Serialize(sepet));

            return RedirectToAction("Sepet");
        }

        public IActionResult Sepet()
        {
            GetKaydedilenIdler();

            string? sepetJson = HttpContext.Session.GetString("Sepetim");
            List<int> sepetIds = string.IsNullOrEmpty(sepetJson)
                ? new List<int>()
                : JsonSerializer.Deserialize<List<int>>(sepetJson) ?? new List<int>();

            var sepetKitaplari = new List<Kitaplar>();
            foreach (var id in sepetIds)
            {
                var kitap = _context.Kitaplars.Include(k => k.Yazar).FirstOrDefault(k => k.KitapId == id);
                if (kitap != null) sepetKitaplari.Add(kitap);
            }

            return View(sepetKitaplari);
        }

        // --- GÜNCELLENEN ÖDEME VE ADRES/KART İŞLEMLERİ ---
        public IActionResult Odeme()
        {
            var kullaniciId = HttpContext.Session.GetInt32("KullaniciId");
            if (kullaniciId == null) return RedirectToAction("GirisYap", "Hesap");

            string? sepetJson = HttpContext.Session.GetString("Sepetim");
            if (string.IsNullOrEmpty(sepetJson)) return RedirectToAction("Sepet");

            List<int> sepetIds = JsonSerializer.Deserialize<List<int>>(sepetJson) ?? new List<int>();

            // FİYAT HATASINI ÇÖZEN KISIM: Contains yerine tek tek ekliyoruz ki aynı kitaptan 2 tane varsa 2'si de listeye girsin.
            var sepetKitaplari = new List<Kitaplar>();
            foreach (var id in sepetIds)
            {
                var kitap = _context.Kitaplars.Include(k => k.Yazar).FirstOrDefault(k => k.KitapId == id);
                if (kitap != null) sepetKitaplari.Add(kitap);
            }

            var viewModel = new OdemeViewModel
            {
                ToplamTutar = sepetKitaplari.Sum(k => k.Fiyat),
                KullaniciAdresleri = _context.Adresler.Where(a => a.KullaniciId == kullaniciId).ToList(),
                KullaniciKartlari = _context.Kartlar.Where(k => k.KullaniciId == kullaniciId).ToList(),
                SepetKitaplari = sepetKitaplari
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
        [HttpPost]
        public IActionResult SiparisiTamamla(int seciliAdresId, int seciliKartId)
        {
            var kullaniciId = HttpContext.Session.GetInt32("KullaniciId");
            if (kullaniciId == null) return RedirectToAction("GirisYap", "Hesap");

            var adres = _context.Adresler.FirstOrDefault(a => a.AdresId == seciliAdresId);
            if (adres == null) return RedirectToAction("Odeme");

            string? sepetJson = HttpContext.Session.GetString("Sepetim");
            List<int> sepetIds = string.IsNullOrEmpty(sepetJson) ? new List<int>() : JsonSerializer.Deserialize<List<int>>(sepetJson) ?? new List<int>();

            if (!sepetIds.Any()) return RedirectToAction("Sepet");

            // AYNI FİYAT ÇÖZÜMÜNÜ SİPARİŞİ KAYDEDERKEN DE UYGULUYORUZ
            var sepetKitaplari = new List<Kitaplar>();
            foreach (var id in sepetIds)
            {
                var kitap = _context.Kitaplars.FirstOrDefault(k => k.KitapId == id);
                if (kitap != null) sepetKitaplari.Add(kitap);
            }

            var yeniSiparis = new Siparis
            {
                KullaniciId = kullaniciId.Value,
                ToplamTutar = sepetKitaplari.Sum(k => k.Fiyat),
                KargoAdresi = (adres.Sehir ?? "") + " - " + (adres.AcikAdres ?? ""),
                SiparisTarihi = DateTime.Now,
                SiparisDurumu = "Onay Bekliyor"
            };

            _context.Siparisler.Add(yeniSiparis);
            _context.SaveChanges();

            // SİPARİŞ DETAYLARINI EKLERKEN DE AYNI LİSTEYİ KULLANIYORUZ
            foreach (var id in sepetIds)
            {
                var kitap = sepetKitaplari.FirstOrDefault(k => k.KitapId == id);
                if (kitap != null)
                {
                    _context.SiparisDetaylari.Add(new SiparisDetayi
                    {
                        SiparisId = yeniSiparis.SiparisId,
                        KitapId = kitap.KitapId,
                        BirimFiyat = kitap.Fiyat,
                        Adet = 1
                    });
                }
            }

            _context.SaveChanges();
            HttpContext.Session.Remove("Sepetim");

            return RedirectToAction("SiparisBasarili");
        }
        public IActionResult SiparisBasarili()
        {
            return View();
        }
        // Diğer boş sayfalar
        public IActionResult Kategoriler() => View();
        public IActionResult YeniCikanlar() => View();
        public IActionResult EnCokSatanlar() => View();
        public IActionResult Yazarlar() => View();
        public IActionResult Privacy() => View();
    }
}
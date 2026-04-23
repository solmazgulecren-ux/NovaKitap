using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NovaKitap.Models;
using Microsoft.AspNetCore.Http;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json; // Sepet işlemleri için ŞART

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

        public IActionResult Kategori(int id, string isim)
        {
            GetKaydedilenIdler();

            var kitaplar = _context.Kitaplars
                                   .Where(k => k.KategoriId == id)
                                   .ToList();

            ViewBag.KategoriAdi = isim;
            ViewBag.KategoriId = id;

            return View(kitaplar);
        }

        public IActionResult Ara(string q)
        {
            GetKaydedilenIdler();

            if (string.IsNullOrEmpty(q))
            {
                return RedirectToAction("Index");
            }

            var sonuclar = _context.Kitaplars
                .Include(k => k.Yazar)
                .Where(k => k.KitapAdi.Contains(q) || k.Yazar.AdSoyad.Contains(q))
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

        // --- YENİ EKLENEN: DETAY VE SEPET İŞLEMLERİ ---

        // 1. Kitap İnceleme (Detay) Sayfası
        public IActionResult Detay(int id)
        {
            GetKaydedilenIdler(); // Sol menü ve üst bar bozulmasın diye çağırıyoruz

            // Kitabı yazarı ve kategorisiyle birlikte çekiyoruz
            var kitap = _context.Kitaplars
                .Include(k => k.Yazar)
                .Include(k => k.Kategori)
                .FirstOrDefault(k => k.KitapId == id);

            if (kitap == null) return RedirectToAction("Index");

            return View(kitap);
        }

        // 2. Sepete Ekle Butonunun Gittiği Aksiyon
        public IActionResult SepeteEkle(int id)
        {
            // Session'daki mevcut sepeti JSON olarak al
            var sepetJson = HttpContext.Session.GetString("Sepetim");

            // Eğer sepet boşsa yeni liste oluştur, doluysa JSON'dan List'e çevir
            List<int> sepet = string.IsNullOrEmpty(sepetJson)
                ? new List<int>()
                : JsonSerializer.Deserialize<List<int>>(sepetJson);

            // Tıklanan kitabın ID'sini listeye ekle
            sepet.Add(id);

            // Güncel listeyi tekrar JSON yapıp Session'a kaydet
            HttpContext.Session.SetString("Sepetim", JsonSerializer.Serialize(sepet));

            // Sepet sayfasına yönlendir
            return RedirectToAction("Sepet");
        }

        // 3. Sepetim Sayfası (Sepetteki kitapları listeler)
        public IActionResult Sepet()
        {
            GetKaydedilenIdler();

            var sepetJson = HttpContext.Session.GetString("Sepetim");
            List<int> sepetIds = string.IsNullOrEmpty(sepetJson)
                ? new List<int>()
                : JsonSerializer.Deserialize<List<int>>(sepetJson);

            // Sepetteki ID'lere sahip olan kitapları veritabanından çek
            var sepetKitaplari = new List<Kitaplar>();
            foreach (var id in sepetIds)
            {
                var kitap = _context.Kitaplars.Include(k => k.Yazar).FirstOrDefault(k => k.KitapId == id);
                if (kitap != null) sepetKitaplari.Add(kitap);
            }

            return View(sepetKitaplari);
        }

        // Diğer boş sayfalar
        public IActionResult Kategoriler() => View();
        public IActionResult YeniCikanlar() => View();
        public IActionResult EnCokSatanlar() => View();
        public IActionResult Yazarlar() => View();
        public IActionResult Privacy() => View();
    }
}
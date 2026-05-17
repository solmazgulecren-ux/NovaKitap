using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using NovaKitap.Models;
using System.Linq;

namespace NovaKitap.Controllers
{
    public class ProfilController : Controller
    {
        private readonly AppDbContext _context;

        public ProfilController(AppDbContext context)
        {
            _context = context;
        }

        // PROFİL SAYFASINI GÖRÜNTÜLEME
        public IActionResult Index()
        {
            int? kullaniciId = HttpContext.Session.GetInt32("KullaniciId");

            if (kullaniciId == null)
            {
                return RedirectToAction("GirisYap", "Hesap");
            }

            // Aktif sipariş durumları
            var aktifDurumlar = new[] { "Onay Bekliyor", "Onaylandı", "Hazırlanıyor", "Kargoya Verildi" };
            // Geçmiş sipariş durumları
            var gecmisDurumlar = new[] { "Teslim Edildi", "İptal Edildi", "Tamamlandı" };

            var viewModel = new ProfilViewModel
            {
                Kullanici = _context.Kullanicilars.Find(kullaniciId),
                Adresler = _context.Adresler.Where(a => a.KullaniciId == kullaniciId).ToList(),
                Kartlar = _context.Kartlar.Where(k => k.KullaniciId == kullaniciId).ToList(),
                AktifSiparisler = _context.Siparisler
                    .Where(s => s.KullaniciId == kullaniciId && aktifDurumlar.Contains(s.SiparisDurumu))
                    .OrderByDescending(s => s.SiparisTarihi)
                    .ToList(),
                GecmisSiparisler = _context.Siparisler
                    .Where(s => s.KullaniciId == kullaniciId && gecmisDurumlar.Contains(s.SiparisDurumu))
                    .OrderByDescending(s => s.SiparisTarihi)
                    .ToList(),
                Yildizladiklarim = _context.Kaydedilenlers
                    .Include(k => k.Kitap)
                    .Where(k => k.KullaniciId == kullaniciId)
                    .OrderByDescending(k => k.KayitTarihi)
                    .ToList()
            };

            return View(viewModel);
        }

        // BİLGİ GÜNCELLEME (Ad Soyad + Telefon)
        [HttpPost]
        public IActionResult BilgiGuncelle(string adSoyad, string telefon)
        {
            int? kullaniciId = HttpContext.Session.GetInt32("KullaniciId");
            if (kullaniciId == null) return RedirectToAction("GirisYap", "Hesap");

            var kullanici = _context.Kullanicilars.Find(kullaniciId);
            if (kullanici != null)
            {
                kullanici.AdSoyad = adSoyad;
                kullanici.Telefon = telefon;
                _context.SaveChanges();

                // Session'daki adı da güncelle ki menüde doğru görünsün
                HttpContext.Session.SetString("KullaniciAdSoyad", adSoyad);

                TempData["Mesaj"] = "Bilgileriniz başarıyla güncellendi!";
            }
            return RedirectToAction("Index");
        }

        // YENİ ADRES EKLEME (SQL'E KAYIT)
        [HttpPost]
        public IActionResult AdresEkle(Adresler yeniAdres)
        {
            int? kullaniciId = HttpContext.Session.GetInt32("KullaniciId");
            if (kullaniciId != null)
            {
                yeniAdres.KullaniciId = kullaniciId.Value; // Adresi giriş yapan kişiye bağlıyoruz
                _context.Adresler.Add(yeniAdres);
                _context.SaveChanges();
                TempData["Mesaj"] = "Yeni adres başarıyla eklendi!";
            }
            return RedirectToAction("Index"); // Kaydedip profil sayfasına geri dön
        }

        // YENİ KART EKLEME (SQL'E KAYIT)
        [HttpPost]
        public IActionResult KartEkle(Kartlar yeniKart)
        {
            int? kullaniciId = HttpContext.Session.GetInt32("KullaniciId");
            if (kullaniciId != null)
            {
                yeniKart.KullaniciId = kullaniciId.Value; // Kartı giriş yapan kişiye bağlıyoruz
                _context.Kartlar.Add(yeniKart);
                _context.SaveChanges();
                TempData["Mesaj"] = "Yeni kart başarıyla eklendi!";
            }
            return RedirectToAction("Index"); // Kaydedip profil sayfasına geri dön
        }

        // ÇIKIŞ YAP
        public IActionResult CikisYap()
        {
            HttpContext.Session.Clear();
            // Cookie'leri temizle
            foreach (var cookie in Request.Cookies.Keys)
            {
                Response.Cookies.Delete(cookie);
            }
            return RedirectToAction("Index", "Home");
        }
    }
}
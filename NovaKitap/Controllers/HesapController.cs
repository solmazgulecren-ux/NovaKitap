using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http; // Session işlemleri için gerekli
using NovaKitap.Models;
using System.Linq;

namespace NovaKitap.Controllers
{
    public class HesapController : Controller
    {
        private readonly AppDbContext _context;

        public HesapController(AppDbContext context)
        {
            _context = context;
        }

        // GET: /Hesap/GirisYap
        [HttpGet]
        public IActionResult GirisYap()
        {
            return View();
        }

        // POST: /Hesap/GirisYap
        [HttpPost]
        public IActionResult GirisYap(string email, string sifre)
        {
            var kullanici = _context.Kullanicilars.FirstOrDefault(x => x.Email == email && x.Sifre == sifre);

            if (kullanici != null)
            {
                HttpContext.Session.SetString("KullaniciAdSoyad", kullanici.AdSoyad);
                HttpContext.Session.SetInt32("KullaniciId", kullanici.KullaniciId);

                // --- GİRİŞ SORUNUNU ÇÖZEN GÜNCELLEME ---
                // Eğer veritabanında kullanıcının rolü boş (null) kalmışsa çökmesini engeller, "Musteri" sayar.
                string atanacakRol = string.IsNullOrEmpty(kullanici.Rol) ? "Musteri" : kullanici.Rol;
                HttpContext.Session.SetString("KullaniciRolu", atanacakRol);
                // ---------------------------------------

                return RedirectToAction("Index", "Home");
            }

            ViewBag.Hata = "E-posta veya şifre hatalı.";
            return View();
        }

        // GET: /Hesap/KayitOl
        [HttpGet]
        public IActionResult KayitOl()
        {
            return View();
        }

        // POST: /Hesap/KayitOl
        [HttpPost]
        public IActionResult KayitOl(Kullanicilar yeniKullanici)
        {
            if (ModelState.IsValid)
            {
                _context.Kullanicilars.Add(yeniKullanici);
                _context.SaveChanges();
                TempData["Mesaj"] = "Kayıt başarılı! Şimdi giriş yapabilirsiniz.";
                return RedirectToAction("GirisYap");
            }
            return View(yeniKullanici);
        }

        // --- YENİ EKLENEN AKSİYONLAR ---

        // GET: /Hesap/Profil
        public IActionResult Profil()
        {
            // Oturumdaki kullanıcının ID'sini al
            var kullaniciId = HttpContext.Session.GetInt32("KullaniciId");

            // Eğer kullanıcı giriş yapmamışsa (ID null ise) giriş sayfasına yönlendir
            if (kullaniciId == null)
            {
                return RedirectToAction("GirisYap");
            }

            // Veritabanından kullanıcıyı bul ve View'a (Profil.cshtml) gönder
            var kullanici = _context.Kullanicilars.Find(kullaniciId);
            return View(kullanici);
        }

        // GET: /Hesap/CikisYap
        public IActionResult CikisYap()
        {
            // Tüm oturum verilerini (AdSoyad, Id vb.) temizle
            HttpContext.Session.Clear();

            // Kullanıcıyı anasayfaya geri gönder
            return RedirectToAction("Index", "Home");
        }
    }
}
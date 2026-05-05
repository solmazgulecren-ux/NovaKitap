using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http; // Session işlemleri için eklendi
using NovaKitap.Models;
using System.Linq;

namespace NovaKitap.Controllers
{
    public class AdminController : Controller
    {
        private readonly AppDbContext _context;

        public AdminController(AppDbContext context)
        {
            _context = context;
        }

        // --- GÜVENLİK DUVARI: Sadece Adminler Girebilir ---
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            string? mevcutRol = HttpContext.Session.GetString("KullaniciRolu");

            if (mevcutRol != "Admin")
            {
                // Yetkisiz girişi engelle ve ana sayfaya yönlendir
                context.Result = new RedirectToActionResult("Index", "Home", null);
            }

            base.OnActionExecuting(context);
        }
        // --------------------------------------------------

        [HttpGet]
        public IActionResult UrunEkle()
        {
            // Veritabanındaki kategori ve yazarları dropdown (seçim) kutuları için çekiyoruz
            ViewBag.Kategoriler = new SelectList(_context.Kategorilers.ToList(), "KategoriId", "KategoriAdi");
            ViewBag.Yazarlar = new SelectList(_context.Yazarlars.ToList(), "YazarId", "AdSoyad");

            return View();
        }

        [HttpPost]
        public IActionResult UrunEkle(
     string urunTipi, string urunAdi, decimal fiyat, int? kategoriId, string kapakResimUrl, string aciklama,
     // Kitap Özel
     int? yazarId, int? sayfaSayisi, string yayinevi, int? basimYili,
     // Kırtasiye Özel
     string kirtasiyeMarka, string urunTuru,
     // Oyuncak Özel
     string oyuncakMarka, string yasGrubu)
        {
            if (urunTipi == "Kitap")
            {
                var yeniKitap = new Kitaplar
                {
                    KitapAdi = urunAdi,
                    Fiyat = fiyat,
                    KategoriId = kategoriId,
                    KapakResimUrl = kapakResimUrl,
                    Aciklama = aciklama,
                    YazarId = yazarId,
                    SayfaSayisi = sayfaSayisi,
                    Yayinevi = yayinevi,
                    BasimYili = basimYili,
                    YeniCikanMi = true,
                    CokSatanMi = false // Otomatik vitrin kuralımız
                };
                _context.Kitaplars.Add(yeniKitap);
            }
            else if (urunTipi == "Kirtasiye")
            {
                var yeniKirtasiye = new Kirtasiyeler
                {
                    UrunAdi = urunAdi,
                    Fiyat = fiyat,
                    KategoriId = kategoriId,
                    KapakResimUrl = kapakResimUrl,
                    Aciklama = aciklama,
                    Marka = kirtasiyeMarka,
                    UrunTuru = urunTuru,
                    YeniCikanMi = true,
                    CokSatanMi = false
                };
                _context.Kirtasiyelers.Add(yeniKirtasiye);
            }
            else if (urunTipi == "Oyuncak")
            {
                var yeniOyuncak = new Oyuncaklar
                {
                    UrunAdi = urunAdi,
                    Fiyat = fiyat,
                    KategoriId = kategoriId,
                    KapakResimUrl = kapakResimUrl,
                    Aciklama = aciklama,
                    Marka = oyuncakMarka,
                    YasGrubu = yasGrubu,
                    YeniCikanMi = true,
                    CokSatanMi = false
                };
                _context.Oyuncaklars.Add(yeniOyuncak);
            }

            _context.SaveChanges();
            TempData["Basari"] = $"{urunTipi} başarıyla eklendi ve 'Yeni Çıkanlar' vitrinine gönderildi! ✦";
            return RedirectToAction("UrunEkle");
        }
    }
}
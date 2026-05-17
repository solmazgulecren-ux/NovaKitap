<<<<<<< HEAD
using Microsoft.AspNetCore.Mvc;
=======
﻿using Microsoft.AspNetCore.Mvc;
>>>>>>> 7639197 (dü)
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http;
using NovaKitap.Models;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

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

        // GET: /Admin/Index (Kontrol Merkezi)
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        // GET: /Admin/UrunEkle (Ürün Ekleme Sayfasını Açar)
        [HttpGet]
        public IActionResult UrunEkle()
        {
            return View();
        }

        // POST: /Admin/UrunEkle (Formdan gelen veriyi SQL'e kaydeder)
        [HttpPost]
        public IActionResult UrunEkle(string UrunTuru, string UrunAdi, decimal Fiyat, int StokAdedi, string? Aciklama, string? KapakResimUrl, string? Marka, int? KategoriId, string? EkBilgi)
        {
            if (UrunTuru == "Kitap")
            {
                _context.Kitaplar.Add(new Kitaplar
                {
                    KitapAdi = UrunAdi,
                    Fiyat = Fiyat,
                    StokAdedi = StokAdedi,
                    Aciklama = Aciklama,
                    KapakResimUrl = KapakResimUrl,
                    Yayinevi = Marka,
                    YeniCikanMi = true,
                    CokSatanMi = false
                });
            }
            else if (UrunTuru == "Kirtasiye")
            {
                _context.Kirtasiyelers.Add(new Kirtasiyeler
                {
                    UrunAdi = UrunAdi,
                    Fiyat = Fiyat,
                    StokAdedi = StokAdedi,
                    Aciklama = Aciklama,
                    KapakResimUrl = KapakResimUrl,
                    Marka = Marka,
                    UrunTuru = EkBilgi, // Formdan gelen Ek Bilgi buraya yazılır
                    YeniCikanMi = true,
                    CokSatanMi = false
                });
            }
            else if (UrunTuru == "Oyuncak")
            {
                _context.Oyuncaklars.Add(new Oyuncaklar
                {
                    UrunAdi = UrunAdi,
                    Fiyat = Fiyat,
                    StokAdedi = StokAdedi,
                    Aciklama = Aciklama,
                    KapakResimUrl = KapakResimUrl,
                    Marka = Marka,
                    YasGrubu = EkBilgi, // Formdan gelen Ek Bilgi buraya yazılır
                    YeniCikanMi = true,
                    CokSatanMi = false
                });
            }

            _context.SaveChanges();
            TempData["Mesaj"] = "Detaylı ürün başarıyla eklendi! ✦";
            return RedirectToAction("StokYonetimi");
        }

        // GET: /Admin/StokYonetimi
        [HttpGet]
        public IActionResult StokYonetimi()
        {
            var viewModel = new StokYonetimiViewModel
            {
                Kitaplar = _context.Kitaplar.ToList(),
                Kirtasiyeler = _context.Kirtasiyelers.ToList(),
                Oyuncaklar = _context.Oyuncaklars.ToList()
            };

            return View(viewModel);
        }

        // POST: /Admin/StokGuncelle
        [HttpPost]
        public IActionResult StokGuncelle(string UrunTuru, int UrunId, int Stok, decimal Fiyat)
        {
            if (UrunTuru == "Kitap")
            {
                var urun = _context.Kitaplar.Find(UrunId);
                if (urun != null) { urun.StokAdedi = Stok; urun.Fiyat = Fiyat; }
            }
            else if (UrunTuru == "Kirtasiye")
            {
                var urun = _context.Kirtasiyelers.Find(UrunId);
                if (urun != null) { urun.StokAdedi = Stok; urun.Fiyat = Fiyat; }
            }
            else if (UrunTuru == "Oyuncak")
            {
                var urun = _context.Oyuncaklars.Find(UrunId);
                if (urun != null) { urun.StokAdedi = Stok; urun.Fiyat = Fiyat; }
            }

            _context.SaveChanges();

            TempData["Mesaj"] = "Stok ve Fiyat başarıyla güncellendi!";
            return RedirectToAction("StokYonetimi");
        }

        // GET: /Admin/KapaklariOtomatikCek
        [HttpGet]
        public async Task<IActionResult> KapaklariOtomatikCek()
        {
            // Veritabanındaki tüm kitapları çekiyoruz
            var kitaplar = _context.Kitaplar.ToList();
            int guncellenenSayi = 0;

            using (var client = new HttpClient())
            {
                foreach (var kitap in kitaplar)
                {
                    try
                    {
                        // Kitap adını internet formatına çevirip Google'a soruyoruz
                        string aramaMetni = Uri.EscapeDataString(kitap.KitapAdi ?? "İsimsiz Kitap");
                        string url = $"https://www.googleapis.com/books/v1/volumes?q=intitle:{aramaMetni}";

                        // Google'dan cevabı alıyoruz
                        var response = await client.GetAsync(url);

                        if (response.IsSuccessStatusCode)
                        {
                            var jsonString = await response.Content.ReadAsStringAsync();
                            using var doc = JsonDocument.Parse(jsonString);
                            var root = doc.RootElement;

                            // Eğer Google bu kitabı bulduysa (items dizisi boş değilse)
                            if (root.TryGetProperty("items", out var items) && items.GetArrayLength() > 0)
                            {
                                var volumeInfo = items[0].GetProperty("volumeInfo");
                                if (volumeInfo.TryGetProperty("imageLinks", out var imageLinks))
                                {
                                    if (imageLinks.TryGetProperty("thumbnail", out var thumbnail))
                                    {
                                        // Resim linkini alıp güvenli (https) formata çeviriyoruz
                                        string resimUrl = thumbnail.GetString().Replace("http://", "https://");

                                        // SQL'deki KapakResimUrl alanını güncelliyoruz
                                        kitap.KapakResimUrl = resimUrl;
                                        guncellenenSayi++;
                                    }
                                }
                            }
                        }
                    }
                    catch
                    {
                        // Bir kitapta hata çıkarsa sistemi durdurma, diğerine geç
                        continue;
                    }
                }
            }

            // Tüm yeni linkleri veritabanına topluca kaydediyoruz
            await _context.SaveChangesAsync();

            TempData["Mesaj"] = $"Harika! Tam {guncellenenSayi} kitabın gerçek kapağı Google'dan otomatik olarak çekildi ve veritabanına işlendi! ✦";
            return RedirectToAction("StokYonetimi");
        }

        // GET: /Admin/SiparisYonetimi
        [HttpGet]
        public IActionResult SiparisYonetimi()
        {
<<<<<<< HEAD
            var siparisler = _context.Siparisler.OrderByDescending(s => s.SiparisTarihi).ToList();

            // Her siparişin kullanıcı adını da çekelim
            var kullaniciIdler = siparisler.Select(s => s.KullaniciId).Distinct().ToList();
            var kullanicilar = _context.Kullanicilars
                .Where(k => kullaniciIdler.Contains(k.KullaniciId))
                .ToDictionary(k => k.KullaniciId, k => k.AdSoyad);

            ViewBag.KullaniciAdlari = kullanicilar;

=======
            // Veritabanındaki Siparisler (Siparislers olarak tanımlı olabilir, DbContext'e göre düzeltilir)
            var siparisler = _context.Siparisler.OrderByDescending(s => s.SiparisTarihi).ToList();
>>>>>>> 7639197 (dü)
            return View(siparisler);
        }

        // GET: /Admin/SiparisDetay 
        [HttpGet]
        public IActionResult SiparisDetay(int id)
        {
            var siparis = _context.Siparisler.FirstOrDefault(s => s.SiparisId == id);
            if (siparis == null) return NotFound();

            var kullanici = _context.Kullanicilars.FirstOrDefault(k => k.KullaniciId == siparis.KullaniciId);
            var detaylar = _context.SiparisDetaylari.Where(d => d.SiparisId == id).ToList();

            ViewBag.Kullanici = kullanici;
            ViewBag.Detaylar = detaylar;

            return View(siparis);
        }

<<<<<<< HEAD
        // AJAX ile sipariş durumu güncelleme (JSON döner)
        [HttpPost]
        public IActionResult SiparisDurumGuncelle([FromForm] int siparisId, [FromForm] string yeniDurum)
        {
            var siparis = _context.Siparisler.FirstOrDefault(s => s.SiparisId == siparisId);
            if (siparis == null)
            {
                return Json(new { basarili = false, mesaj = "Sipariş bulunamadı!" });
            }

            siparis.SiparisDurumu = yeniDurum;
            _context.SaveChanges();

            return Json(new { basarili = true, mesaj = $"#{siparisId} numaralı sipariş '{yeniDurum}' olarak güncellendi!", yeniDurum = yeniDurum });
=======
        [HttpPost]
        public IActionResult SiparisDurumGuncelle(int siparisId, string yeniDurum)
        {
            var siparis = _context.Siparisler.FirstOrDefault(s => s.SiparisId == siparisId);
            if (siparis != null)
            {
                siparis.SiparisDurumu = yeniDurum;
                _context.SaveChanges();
                TempData["Mesaj"] = $"#{siparisId} numaralı sipariş başarıyla '{yeniDurum}' olarak güncellendi!";
            }
            return RedirectToAction("SiparisYonetimi");
>>>>>>> 7639197 (dü)
        }

        // --- ÜRÜN KALDIRMA (SİLME) METODU ---
        [HttpPost]
        public IActionResult UrunKaldir(string UrunTuru, int UrunId)
        {
            try
            {
                if (UrunTuru == "Kitap")
                {
                    var urun = _context.Kitaplar.Find(UrunId);
                    if (urun != null) _context.Kitaplar.Remove(urun);
                }
                else if (UrunTuru == "Kirtasiye")
                {
                    var urun = _context.Kirtasiyelers.Find(UrunId);
                    if (urun != null) _context.Kirtasiyelers.Remove(urun);
                }
                else if (UrunTuru == "Oyuncak")
                {
                    var urun = _context.Oyuncaklars.Find(UrunId);
                    if (urun != null) _context.Oyuncaklars.Remove(urun);
                }

                _context.SaveChanges();
                TempData["Mesaj"] = "Ürün başarıyla sistemden kaldırıldı!";
            }
            catch
            {
                // Eğer ürün daha önce bir siparişte satıldıysa veya kaydedildiyse veritabanı silmeye izin vermez.
                TempData["Hata"] = "Bu ürün geçmiş siparişlerde yer aldığı için tamamen silinemez. Bunun yerine stok adedini 0 yapabilirsiniz.";
            }

            return RedirectToAction("StokYonetimi");
        }


        [HttpGet]
        public IActionResult StokAra(string q, string kategori)
        {
            // Eğer hiçbir şey yazılmadan veya 'Hepsi' seçilip aranırsa, ana stok listesine geri dön
            if (string.IsNullOrWhiteSpace(q) && (string.IsNullOrEmpty(kategori) || kategori == "Hepsi"))
            {
                return RedirectToAction("StokYonetimi");
            }

            var aranan = string.IsNullOrWhiteSpace(q) ? "" : q.ToLower();
            var model = new StokYonetimiViewModel();

            // 1. KİTAPLARDA ARAMA
            if (kategori == "Hepsi" || kategori == "Kitap")
            {
                // Kitap adı veya yazar adında arama yapar
                model.Kitaplar = _context.Kitaplar
                    .Where(x => x.KitapAdi.ToLower().Contains(aranan))
                    .ToList();
            }
            else { model.Kitaplar = new List<Kitaplar>(); }

            // 2. KIRTASİYEDE ARAMA
            if (kategori == "Hepsi" || kategori == "Kirtasiye")
            {
                // Ürün adı veya markada arama yapar
                model.Kirtasiyeler = _context.Kirtasiyelers
                    .Where(x => x.UrunAdi.ToLower().Contains(aranan) || (x.Marka != null && x.Marka.ToLower().Contains(aranan)))
                    .ToList();
            }
            else { model.Kirtasiyeler = new List<Kirtasiyeler>(); }

            // 3. OYUNCAKLARDA ARAMA
            if (kategori == "Hepsi" || kategori == "Oyuncak")
            {
                // Ürün adı veya markada arama yapar
                model.Oyuncaklar = _context.Oyuncaklars
                    .Where(x => x.UrunAdi.ToLower().Contains(aranan) || (x.Marka != null && x.Marka.ToLower().Contains(aranan)))
                    .ToList();
            }
            else { model.Oyuncaklar = new List<Oyuncaklar>(); }

            // Aynı görünümü (StokYonetimi.cshtml) filtrelenmiş verilerle tekrar açıyoruz
            TempData["Mesaj"] = $"'{q}' araması için sonuçlar listeleniyor.";
            return View("StokYonetimi", model);
        }
    }



}
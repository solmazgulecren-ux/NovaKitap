using Microsoft.AspNetCore.Mvc;
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
        public IActionResult UrunEkle(string UrunTuru, string UrunAdi, decimal Fiyat, int StokAdedi)
        {
            if (UrunTuru == "Kitap")
            {
                _context.Kitaplars.Add(new Kitaplar
                {
                    KitapAdi = UrunAdi,
                    Fiyat = Fiyat,
                    StokAdedi = StokAdedi,
                    YeniCikanMi = true, // Otomatik vitrine ekle
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
                    YeniCikanMi = true,
                    CokSatanMi = false
                });
            }

            // SQL'e kesin kayıt yaptığımız yer
            _context.SaveChanges();

            TempData["Mesaj"] = "Ürün başarıyla eklendi ve vitrine gönderildi! ✦";
            // Kayıttan sonra stok sayfasına yolla ki eklendiğini gözümüzle görelim
            return RedirectToAction("StokYonetimi");
        }

        // GET: /Admin/StokYonetimi
        [HttpGet]
        public IActionResult StokYonetimi()
        {
            var viewModel = new StokYonetimiViewModel
            {
                Kitaplar = _context.Kitaplars.ToList(),
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
                var urun = _context.Kitaplars.Find(UrunId);
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
            var kitaplar = _context.Kitaplars.ToList();
            int guncellenenSayi = 0;

            using (var client = new HttpClient())
            {
                foreach (var kitap in kitaplar)
                {
                    try
                    {
                        // Kitap adını internet formatına çevirip Google'a soruyoruz
                        string aramaMetni = Uri.EscapeDataString(kitap.KitapAdi);
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
            // Veritabanındaki Siparisler (Siparislers olarak tanımlı olabilir, DbContext'e göre düzeltilir)
            var siparisler = _context.Siparisler.OrderByDescending(s => s.SiparisTarihi).ToList();
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
    }
}
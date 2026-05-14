using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NovaKitap.Migrations
{
    /// <inheritdoc />
    public partial class YeniKurulum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adresler",
                columns: table => new
                {
                    AdresId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciId = table.Column<int>(type: "int", nullable: false),
                    AdresBasligi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AcikAdres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sehir = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adresler", x => x.AdresId);
                });

            migrationBuilder.CreateTable(
                name: "Kartlar",
                columns: table => new
                {
                    KartId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciId = table.Column<int>(type: "int", nullable: false),
                    KartBasligi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdSoyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KartNumarasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SonKullanmaAy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SonKullanmaYil = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kartlar", x => x.KartId);
                });

            migrationBuilder.CreateTable(
                name: "Kategoriler",
                columns: table => new
                {
                    KategoriId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriAdi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IkonSifi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Kategori__1782CC72FD64979E", x => x.KategoriId);
                });

            migrationBuilder.CreateTable(
                name: "Kullanicilar",
                columns: table => new
                {
                    KullaniciId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdSoyad = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Rol = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Kullanic__E011F77B953AA4E8", x => x.KullaniciId);
                });

            migrationBuilder.CreateTable(
                name: "Siparisler",
                columns: table => new
                {
                    SiparisId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciId = table.Column<int>(type: "int", nullable: false),
                    SiparisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ToplamTutar = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SiparisDurumu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KargoAdresi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OdemeYontemi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Siparisler", x => x.SiparisId);
                });

            migrationBuilder.CreateTable(
                name: "Yazarlar",
                columns: table => new
                {
                    YazarId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdSoyad = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Biyografi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Yazarlar__CF636CE1C5425819", x => x.YazarId);
                });

            migrationBuilder.CreateTable(
                name: "Kirtasiyeler",
                columns: table => new
                {
                    KirtasiyeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UrunAdi = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    KapakResimUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    YeniCikanMi = table.Column<bool>(type: "bit", nullable: true),
                    CokSatanMi = table.Column<bool>(type: "bit", nullable: true),
                    StokAdedi = table.Column<int>(type: "int", nullable: false),
                    KategoriId = table.Column<int>(type: "int", nullable: true),
                    Marka = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    UrunTuru = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kirtasiyeler", x => x.KirtasiyeId);
                    table.ForeignKey(
                        name: "FK_Kirtasiyeler_Kategoriler_KategoriId",
                        column: x => x.KategoriId,
                        principalTable: "Kategoriler",
                        principalColumn: "KategoriId");
                });

            migrationBuilder.CreateTable(
                name: "Oyuncaklar",
                columns: table => new
                {
                    OyuncakId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UrunAdi = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    KapakResimUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    YeniCikanMi = table.Column<bool>(type: "bit", nullable: true),
                    CokSatanMi = table.Column<bool>(type: "bit", nullable: true),
                    KategoriId = table.Column<int>(type: "int", nullable: true),
                    StokAdedi = table.Column<int>(type: "int", nullable: false),
                    YasGrubu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Marka = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oyuncaklar", x => x.OyuncakId);
                    table.ForeignKey(
                        name: "FK_Oyuncaklar_Kategoriler_KategoriId",
                        column: x => x.KategoriId,
                        principalTable: "Kategoriler",
                        principalColumn: "KategoriId");
                });

            migrationBuilder.CreateTable(
                name: "Kitaplar",
                columns: table => new
                {
                    KitapId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KitapAdi = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SayfaSayisi = table.Column<int>(type: "int", nullable: true),
                    Fiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    KapakResimUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    StokAdedi = table.Column<int>(type: "int", nullable: true),
                    YeniCikanMi = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    CokSatanMi = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    YazarId = table.Column<int>(type: "int", nullable: true),
                    KategoriId = table.Column<int>(type: "int", nullable: true),
                    Yayinevi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BasimYili = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Kitaplar__89491B0C9F34EF61", x => x.KitapId);
                    table.ForeignKey(
                        name: "FK__Kitaplar__Katego__5165187F",
                        column: x => x.KategoriId,
                        principalTable: "Kategoriler",
                        principalColumn: "KategoriId");
                    table.ForeignKey(
                        name: "FK__Kitaplar__YazarI__5070F446",
                        column: x => x.YazarId,
                        principalTable: "Yazarlar",
                        principalColumn: "YazarId");
                });

            migrationBuilder.CreateTable(
                name: "Kaydedilenler",
                columns: table => new
                {
                    KayitId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciId = table.Column<int>(type: "int", nullable: true),
                    KitapId = table.Column<int>(type: "int", nullable: true),
                    KayitTarihi = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Kaydedil__BD28AF4BD0CD6182", x => x.KayitId);
                    table.ForeignKey(
                        name: "FK__Kaydedile__Kitap__5812160E",
                        column: x => x.KitapId,
                        principalTable: "Kitaplar",
                        principalColumn: "KitapId");
                    table.ForeignKey(
                        name: "FK__Kaydedile__Kulla__571DF1D5",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanicilar",
                        principalColumn: "KullaniciId");
                });

            migrationBuilder.CreateTable(
                name: "SiparisDetaylari",
                columns: table => new
                {
                    SiparisDetayId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SiparisId = table.Column<int>(type: "int", nullable: false),
                    KitapId = table.Column<int>(type: "int", nullable: false),
                    Adet = table.Column<int>(type: "int", nullable: false),
                    BirimFiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiparisDetaylari", x => x.SiparisDetayId);
                    table.ForeignKey(
                        name: "FK_SiparisDetaylari_Kitaplar_KitapId",
                        column: x => x.KitapId,
                        principalTable: "Kitaplar",
                        principalColumn: "KitapId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SiparisDetaylari_Siparisler_SiparisId",
                        column: x => x.SiparisId,
                        principalTable: "Siparisler",
                        principalColumn: "SiparisId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Kategoriler",
                columns: new[] { "KategoriId", "IkonSifi", "KategoriAdi" },
                values: new object[,]
                {
                    { 1, "✧", "Klasik" },
                    { 2, "✧", "Edebiyat" },
                    { 3, "✧", "Psikoloji" },
                    { 4, "✧", "Tarih" },
                    { 5, "✧", "Felsefe" },
                    { 6, "✧", "Polisiye" },
                    { 7, "✧", "Roman" }
                });

            migrationBuilder.InsertData(
                table: "Kirtasiyeler",
                columns: new[] { "KirtasiyeId", "Aciklama", "CokSatanMi", "Fiyat", "KapakResimUrl", "KategoriId", "Marka", "StokAdedi", "UrunAdi", "UrunTuru", "YeniCikanMi" },
                values: new object[,]
                {
                    { 1, "A4 boyutunda, 80 yaprak, tel spiralli klasik öğrenci defteri.", true, 35.00m, "/img/kirtasiye/urun_1.jpg", null, "Nova Design", 200, "Nova Klasik Çizgili Defter", "Defter", false },
                    { 2, "Gece mavisi kapaklı, 80 sayfa, yüksek kaliteli fildişi kağıt.", true, 85.00m, "/img/kirtasiye/urun_2.jpg", null, "Nova Design", 100, "Nova Yıldızlı Çizgisiz Defter", "Defter", true },
                    { 3, "Matematik ve sayısal dersler için ideal, 120 yaprak kareli defter.", true, 45.00m, "/img/kirtasiye/urun_3.jpg", null, "Mopak", 150, "Kareli Spiralli Defter A5", "Defter", false },
                    { 4, "Sanatçılar için özel dokulu, 140 gramajlı çizgisiz kağıt.", false, 150.00m, "/img/kirtasiye/urun_4.jpg", null, "Moleskine", 50, "Deri Kaplı Eskiz Defteri", "Defter", true },
                    { 5, "Planlama yapmak isteyenler için özel noktalı sayfalar, krem rengi kağıt.", true, 110.00m, "/img/kirtasiye/urun_5.jpg", null, "Matt Notebook", 80, "Noktalı Bullet Journal", "Defter", true },
                    { 6, "Günlük planlayıcı, tarihli, deri görünümlü sert kapak ajanda.", false, 220.00m, "/img/kirtasiye/urun_6.jpg", null, "Ece Ajandası", 60, "Sert Kapaklı Ajanda 2026", "Defter", true },
                    { 7, "Müzik notaları yazmak için özel çizgili, yatay formatlı defter.", false, 25.00m, "/img/kirtasiye/urun_7.jpg", null, "Gıpta", 300, "Müzik (Porte) Defteri", "Defter", false },
                    { 8, "Eğik çizgili, ilkokul ve kaligrafi öğrencileri için özel.", false, 20.00m, "/img/kirtasiye/urun_8.jpg", null, "Mopak", 250, "Güzel Yazı (Kaligrafi) Defteri", "Defter", false },
                    { 9, "Doğa dostu kraft kağıttan üretilmiş çizgili defter.", true, 40.00m, "/img/kirtasiye/urun_9.jpg", null, "Keskin Color", 120, "Geri Dönüşümlü Kraft Defter", "Defter", true },
                    { 10, "Sulu boya ve akrilik çalışmalarına uygun kalın yapraklı resim defteri.", true, 65.00m, "/img/kirtasiye/urun_10.jpg", null, "Alex Schoeller", 90, "Spiralli Resim Defteri", "Defter", false },
                    { 11, "Gizli yazılar için asma kilitli, renkli kapaklı hatıra defteri.", false, 95.00m, "/img/kirtasiye/urun_11.jpg", null, "Noki", 40, "Kilitli Hatıra Defteri", "Defter", false },
                    { 12, "Üstten spiralli, kolay koparılabilir kareli bloknot.", true, 55.00m, "/img/kirtasiye/urun_12.jpg", null, "Gıpta", 180, "A4 Kareli Bloknot", "Defter", false },
                    { 13, "Toplantılar için ideal, cep boy çizgili not defteri.", true, 30.00m, "/img/kirtasiye/urun_13.jpg", null, "Gıpta", 200, "A5 Çizgili Bloknot", "Defter", false },
                    { 14, "Jel kalemler ve metalik boyalar için tamamen siyah yapraklı tasarım defter.", true, 85.00m, "/img/kirtasiye/urun_14.jpg", null, "Nova Design", 70, "Siyah Yapraklı Defter", "Defter", true },
                    { 15, "Üniversite öğrencileri için ayraçlı, 4 ortalı geniş hacimli defter.", true, 130.00m, "/img/kirtasiye/urun_15.jpg", null, "Keskin Color", 110, "Ciltli Akademik Defter", "Defter", false },
                    { 16, "Cepte taşınabilir, lastikli, 9x14 cm boyutlarında not defteri.", false, 45.00m, "/img/kirtasiye/urun_16.jpg", null, "Moleskine", 150, "Küçük Boy Cep Defteri", "Defter", false },
                    { 17, "Profesyonel sanatçılar için soğuk pres pamuklu kağıt.", false, 350.00m, "/img/kirtasiye/urun_17.jpg", null, "Canson", 20, "Sulu Boya Defteri %100 Pamuk", "Defter", true },
                    { 18, "Suni deri kapaklı, prestijli ofis not defteri.", false, 175.00m, "/img/kirtasiye/urun_18.jpg", null, "Nova Office", 50, "Nova Premium Çizgisiz", "Defter", true },
                    { 19, "Modern mermer desen kapaklı, estetik A5 çizgili defter.", true, 60.00m, "/img/kirtasiye/urun_19.jpg", null, "Keskin Color", 140, "Mermer Desenli Defter", "Defter", false },
                    { 20, "Geniş boyutlu, standart okul harita metod defteri.", true, 45.00m, "/img/kirtasiye/urun_20.jpg", null, "Mopak", 300, "Harita Metod Defteri", "Defter", false },
                    { 21, "Ergonomik tutuş, metal gövde. Uzun süreli yazımlar için ideal.", true, 120.00m, "/img/kirtasiye/urun_21.jpg", null, "Rotring", 200, "Mekanik Kurşun Kalem 0.7mm", "Kalem", false },
                    { 22, "12 farklı sertlikte (6B-4H) teknik çizim kalem seti.", false, 245.50m, "/img/kirtasiye/urun_22.jpg", null, "Faber Castell", 50, "Profesyonel Çizim Kalem Seti", "Kalem", true },
                    { 23, "Ofis kullanımı için ekonomik, akıtma yapmayan tükenmez kalem.", true, 150.00m, "/img/kirtasiye/urun_23.jpg", null, "Bic", 80, "Tükenmez Kalem Mavi 50li Kutu", "Kalem", false },
                    { 24, "Paslanmaz çelik uç, pompa ve kartuş ile kullanıma uygun klasik dolma kalem.", false, 450.00m, "/img/kirtasiye/urun_24.jpg", null, "Lamy", 30, "Klasik Dolma Kalem Siyah", "Kalem", true },
                    { 25, "Akıcı yazım sağlayan, ıslak mürekkepli 1.0mm kalınlığında imza kalemi.", true, 65.00m, "/img/kirtasiye/urun_25.jpg", null, "Uniball", 120, "Jel İmza Kalemi Mavi", "Kalem", false },
                    { 26, "Öğrenciler için pastel renkli, yumuşak tutuşlu mekanik kalem.", true, 45.00m, "/img/kirtasiye/urun_26.jpg", null, "Faber Castell", 250, "Uçlu Kalem 0.5mm Pastel", "Kalem", true },
                    { 27, "Öğretmenler ve düzeltmenler için standart kırmızı kurşun kalem.", true, 15.00m, "/img/kirtasiye/urun_27.jpg", null, "Fatih", 400, "Kırmızı Kopya Kalemi", "Kalem", false },
                    { 28, "Sarı, yeşil, pembe, turuncu renklerde solmayan fosforlu kalemler.", true, 75.00m, "/img/kirtasiye/urun_28.jpg", null, "Stabilo", 150, "Fosforlu Kalem Seti 4lü", "Kalem", false },
                    { 29, "Yıkanabilir mürekkepli, çocuklar için güvenli keçeli boya kalemi.", false, 90.00m, "/img/kirtasiye/urun_29.jpg", null, "Carioca", 100, "Keçeli Kalem 12li Set", "Kalem", false },
                    { 30, "Çizim ve ince notlar için siyah renk fineliner.", true, 25.00m, "/img/kirtasiye/urun_30.jpg", null, "Stabilo", 300, "Fineliner 0.4mm İnce Uçlu Kalem", "Kalem", false },
                    { 31, "Siyah kağıtlar ve parlamalar yapmak için örtücü beyaz jel kalem.", true, 35.00m, "/img/kirtasiye/urun_31.jpg", null, "Sakura Gelly Roll", 140, "Beyaz Jel Kalem", "Kalem", true },
                    { 32, "Güzel yazı sanatıyla ilgilenenler için 2.0mm kesik uçlu kalem.", false, 85.00m, "/img/kirtasiye/urun_32.jpg", null, "Artline", 60, "Kaligrafi Kalemi Kesik Uçlu", "Kalem", false },
                    { 33, "CD, cam ve plastik yüzeylere yazabilen silinmez kalem.", false, 30.00m, "/img/kirtasiye/urun_33.jpg", null, "Edding", 120, "Asetat Kalemi S (İnce)", "Kalem", false },
                    { 34, "Siyah renk, çevre dostu mürekkep doldurulabilir tahta kalemi.", true, 45.00m, "/img/kirtasiye/urun_34.jpg", null, "Edding", 180, "Beyaz Tahta Kalemi Doldurulabilir", "Kalem", false },
                    { 35, "Optik formları kolay doldurmak için yumuşak uçlu 2B kurşun kalem.", true, 10.00m, "/img/kirtasiye/urun_35.jpg", null, "Faber Castell", 500, "Sınav Kalemi 2B", "Kalem", false },
                    { 36, "Gümüş, altın ve bronz renklerinde yaldızlı jel kalemler.", false, 110.00m, "/img/kirtasiye/urun_36.jpg", null, "Uniball", 80, "Metalik Renkli Jel Kalem Seti", "Kalem", true },
                    { 37, "Lacivert renk, şişede yüksek kaliteli dolma kalem mürekkebi.", false, 150.00m, "/img/kirtasiye/urun_37.jpg", null, "Pelikan", 40, "Dolma Kalem Mürekkebi 30ml", "Kalem", false },
                    { 38, "Kırılmaya dayanıklı, 120 adet yedek 0.7mm uç.", true, 35.00m, "/img/kirtasiye/urun_38.jpg", null, "Tombow", 400, "0.7mm Kalem Ucu (Min) 3lü", "Kalem", false },
                    { 39, "Kırmızı, mavi, siyah ve yeşil rengi tek gövdede sunan pratik kalem.", true, 40.00m, "/img/kirtasiye/urun_39.jpg", null, "Bic", 150, "Çok Renkli Tükenmez Kalem (4 in 1)", "Kalem", false },
                    { 40, "Arkasındaki özel silgiyle ısıyla silinebilen mavi tükenmez kalem.", true, 65.00m, "/img/kirtasiye/urun_40.jpg", null, "Frixion", 200, "Silinebilir Tükenmez Kalem", "Kalem", true },
                    { 41, "Kalın kurşun kalem hissi veren teknik tasarım kalemi.", false, 130.00m, "/img/kirtasiye/urun_41.jpg", null, "Rotring", 50, "Versatil Kalem 2.0mm", "Kalem", false },
                    { 42, "14 ayar altın uçlu, özel ahşap kutusunda koleksiyonluk kalem.", false, 3500.00m, "/img/kirtasiye/urun_42.jpg", null, "Parker", 5, "Altın Uçlu Prestij Dolma Kalem", "Kalem", false },
                    { 43, "Kalın uç sevenler ve sert yazanlar için 0.9mm versatil kalem.", false, 85.00m, "/img/kirtasiye/urun_43.jpg", null, "Pentel", 90, "Uçlu Kalem 0.9mm", "Kalem", false },
                    { 44, "Bir ucu fırça, diğer ucu kesik 6 renkli marker seti.", false, 280.00m, "/img/kirtasiye/urun_44.jpg", null, "Tombow", 40, "Çift Uçlu Kaligrafi Marker Seti", "Kalem", true },
                    { 45, "Çok akıcı ve pürüzsüz yazım sağlayan sıvı mürekkepli roller.", true, 55.00m, "/img/kirtasiye/urun_45.jpg", null, "Uniball", 160, "Roller Kalem İğne Uçlu", "Kalem", false },
                    { 46, "Koliler ve kargo paketleri için kalın uçlu çıkmaz kalem.", true, 35.00m, "/img/kirtasiye/urun_46.jpg", null, "Sharpie", 200, "Permanent Marker Siyah Kalın", "Kalem", false },
                    { 47, "Göz yormayan soft pastel renklerden oluşan 6lı işaretleme kalemi.", true, 120.00m, "/img/kirtasiye/urun_47.jpg", null, "Stabilo", 130, "Pastel Renk Fosforlu Kalem Seti", "Kalem", true },
                    { 48, "Canlı pigmentli, kırılmaya dayanıklı profesyonel kuru boya seti.", false, 350.00m, "/img/kirtasiye/urun_48.jpg", null, "Faber Castell", 40, "Kuru Boya Seti 24lü Metal Kutu", "Kalem", false },
                    { 49, "Metal gövdeli, şık tasarımlı hediyelik tükenmez kalem.", false, 250.00m, "/img/kirtasiye/urun_49.jpg", null, "Scrikss", 30, "Tükenmez Kalem Özel Seri", "Kalem", true },
                    { 50, "Cam ve porselen yüzeylerde fırınlandıktan sonra sabitlenen boya kalemi.", false, 85.00m, "/img/kirtasiye/urun_50.jpg", null, "Edding", 50, "Cam Boyama Kalemi", "Kalem", false },
                    { 51, "Okul kullanımı için fırçalı klasik sulu boya paleti.", true, 75.00m, "/img/kirtasiye/urun_51.jpg", null, "Faber Castell", 150, "Sulu Boya Seti 12 Renk Tablet", "Boya", false },
                    { 52, "Tuval, ahşap ve seramik boyamaya uygun temel renk akrilik tüpleri.", true, 220.00m, "/img/kirtasiye/urun_52.jpg", null, "Pebeo", 60, "Akrilik Boya Seti 6x75ml", "Boya", true },
                    { 53, "Yüksek örtücülüğe sahip mat guaj boyalar.", false, 190.00m, "/img/kirtasiye/urun_53.jpg", null, "Talens", 70, "Guaj Boya Seti 10 Renk", "Boya", false },
                    { 54, "Profesyonel ressamlar için büyük tüp yağlı boya.", false, 240.00m, "/img/kirtasiye/urun_54.jpg", null, "Van Gogh", 40, "Yağlı Boya 200ml Titanyum Beyazı", "Boya", false },
                    { 55, "Farklı numaralarda, kıl dökmez sentetik resim fırçaları.", true, 130.00m, "/img/kirtasiye/urun_55.jpg", null, "PonART", 100, "Fırça Seti Sentetik Uçlu 5li", "Sanat", false },
                    { 56, "Toz pastel çalışmaları için yumuşak formüllü tebeşir formunda pastel.", false, 280.00m, "/img/kirtasiye/urun_56.jpg", null, "Rembrandt", 30, "Kuru Pastel Seti 24 Renk", "Boya", true },
                    { 57, "Yoğun pigmentli, kağıt üzeri kolay dağılan yağlı pastel boya.", true, 110.00m, "/img/kirtasiye/urun_57.jpg", null, "Crayola", 90, "Yağlı Pastel Seti 12 Renk", "Boya", false },
                    { 58, "Tuval ressamları için klasik oval kesim ahşap boya paleti.", false, 65.00m, "/img/kirtasiye/urun_58.jpg", null, "PonART", 80, "Ahşap Karıştırma Paleti", "Sanat", false },
                    { 59, "Küçük tuvaller için ayarlanabilir açılı gürgen şövale.", false, 350.00m, "/img/kirtasiye/urun_59.jpg", null, "PonART", 20, "Masaüstü Ahşap Şövale", "Sanat", true },
                    { 60, "Akrilik ve yağlı boyaya hazır astarlanmış pamuklu germe tuval.", true, 120.00m, "/img/kirtasiye/urun_60.jpg", null, "Nova Art", 150, "Tuval 35x50 cm Pamuklu", "Sanat", false },
                    { 61, "Sokakta ve atölyede kağıt tutturmak için telli sert altlık.", false, 95.00m, "/img/kirtasiye/urun_61.jpg", null, "Nova Art", 60, "Resim Kağıdı Duraliti", "Sanat", false },
                    { 62, "Doku vermek ve boya yaymak için farklı gözeneklerde deniz süngeri.", false, 55.00m, "/img/kirtasiye/urun_62.jpg", null, "Pebeo", 100, "Sanatsal Sünger Seti", "Sanat", false },
                    { 63, "Söğüt ağacından yapılmış, gölgelendirme için natürel füzen.", true, 75.00m, "/img/kirtasiye/urun_63.jpg", null, "Derwent", 80, "Kömür Kalem (Füzen) Seti", "Sanat", false },
                    { 64, "Füzen ve karakalem hatalarını iz bırakmadan silmek için yoğrulabilir silgi.", true, 35.00m, "/img/kirtasiye/urun_64.jpg", null, "Faber Castell", 200, "Hamur Silgi", "Sanat", false },
                    { 65, "Karakalem ve pastel çalışmaların dağılmasını önleyen vernik spreyi.", false, 250.00m, "/img/kirtasiye/urun_65.jpg", null, "Talens", 40, "Fixative Sprey (Sabitleyici)", "Sanat", true },
                    { 66, "Profesyoneller için yüksek dayanımlı birinci sınıf keten tuval.", false, 320.00m, "/img/kirtasiye/urun_66.jpg", null, "Nova Art", 30, "Keten Tuval 50x70 cm", "Sanat", false },
                    { 67, "Haznesine su doldurularak dış mekanlarda rahatça kullanılabilen fırça.", true, 90.00m, "/img/kirtasiye/urun_67.jpg", null, "Pentel", 70, "Sulu Boya Fırçası Su Hazneli", "Sanat", true },
                    { 68, "En ince detaylar ve imza atmak için ultra ince uçlu fırça.", false, 65.00m, "/img/kirtasiye/urun_68.jpg", null, "Da Vinci", 90, "Liner (Kıl) Fırça Numara 000", "Sanat", false },
                    { 69, "Yağlı boya ve fırça temizliği için kokusuz çözücü sıvı.", false, 180.00m, "/img/kirtasiye/urun_69.jpg", null, "Talens", 40, "Boya İnceltici (Kokusuz Terebentin)", "Sanat", false },
                    { 70, "Tişört ve bez çanta tasarlamak için yıkamaya dayanıklı kumaş boyaları.", true, 195.00m, "/img/kirtasiye/urun_70.jpg", null, "Pebeo", 50, "Kumaş Boyası 6lı Set", "Boya", true },
                    { 71, "Üniversite ve ofis kullanımı için hakiki deri görünümlü yatay çanta.", false, 1200.00m, "/img/kirtasiye/urun_71.jpg", null, "Nova Premium", 15, "Deri Postacı Çantası", "Çanta", true },
                    { 72, "Küçük çocuklar için tekerlekli, hafif ve sevimli desenli çanta.", true, 650.00m, "/img/kirtasiye/urun_72.jpg", null, "Yaygan", 40, "Anaokulu Çantası Çekçekli", "Çanta", false },
                    { 73, "Doğa dostu ham bez kumaş, omuzdan askılı günlük çanta.", true, 120.00m, "/img/kirtasiye/urun_73.jpg", null, "Nova Design", 200, "Bez Çanta (Tote Bag) Nova Logolu", "Çanta", true },
                    { 74, "Eski usul metal, içi süngerli dayanıklı kalemlik.", false, 180.00m, "/img/kirtasiye/urun_74.jpg", null, "Faber Castell", 60, "Metal Kalemlik Kutusu", "Kalemlik", false },
                    { 75, "Sınavlar için uygun, içi görünen fermuarlı file kalem kutusu.", true, 75.00m, "/img/kirtasiye/urun_75.jpg", null, "Noki", 150, "Şeffaf File Kalemlik", "Kalemlik", false },
                    { 76, "Sanatçılar için çok sayıda kalemi rulo yaparak saran kanvas kumaş.", false, 220.00m, "/img/kirtasiye/urun_76.jpg", null, "Nova Art", 40, "Rulo Bez Kalemlik", "Kalemlik", true },
                    { 77, "Masaya renk katacak yumuşak silikondan meyve figürlü kalemlik.", true, 130.00m, "/img/kirtasiye/urun_77.jpg", null, "Kraf", 80, "Silikon Muz Kalemlik", "Kalemlik", false },
                    { 78, "Kalem, silgi ve boyaları ayrı tutmak için geniş iç hacimli kumaş kalemlik.", true, 250.00m, "/img/kirtasiye/urun_78.jpg", null, "Eastpak", 70, "3 Bölmeli Kalem Çantası", "Kalemlik", false },
                    { 79, "Sadece bilgisayar ve birkaç dosya taşımak için suya dayanıklı evrak çantası.", false, 680.00m, "/img/kirtasiye/urun_79.jpg", null, "Targus", 25, "Laptop Evrak Çantası İnce", "Çanta", false },
                    { 80, "Ofis masaları için kalem, kartvizit ve ataş bölmeli doğal ahşap organizer.", true, 190.00m, "/img/kirtasiye/urun_80.jpg", null, "Nova Office", 45, "Masaüstü Ahşap Kalemlik", "Kalemlik", true },
                    { 81, "Tek bir prestijli dolma kalemi korumak için deri çıtçıtlı kılıf.", false, 150.00m, "/img/kirtasiye/urun_81.jpg", null, "Scrikss", 50, "Suni Deri Kalem Kılıfı", "Kalemlik", false },
                    { 82, "Kullanılmadığında cüzdan boyutuna küçülen pratik market çantası.", true, 55.00m, "/img/kirtasiye/urun_82.jpg", null, "Nova Eco", 120, "Katlanabilir Alışveriş Çantası", "Çanta", false },
                    { 83, "Mimarlar ve mühendisler için pafta taşımaya yarayan uzayabilen tüp.", false, 280.00m, "/img/kirtasiye/urun_83.jpg", null, "PonART", 30, "Şeffaf Çizim Tüpü (Proje Çantası)", "Çanta", false },
                    { 84, "50x70 cm boyutlarındaki resimleri kırmadan taşımak için fermuarlı portfolyo.", false, 340.00m, "/img/kirtasiye/urun_84.jpg", null, "Nova Art", 20, "Çift Saplı Resim Çantası (Portfolyo)", "Çanta", true },
                    { 85, "Doğa dostu kraft kağıttan üretilmiş, 500 sayfa kapasiteli geniş klasör.", false, 65.00m, "/img/kirtasiye/urun_85.jpg", null, "Nova Office", 150, "A4 Kraft Dosya Klasörü", "Dosya", false },
                    { 86, "Evrakları delmeden korumak için 11 delikli şeffaf A4 poşet dosya.", true, 80.00m, "/img/kirtasiye/urun_86.jpg", null, "Noki", 300, "Poşet Dosya 100lü Paket", "Dosya", false },
                    { 87, "Ödev ve rapor teslimi için önü şeffaf, arkası renkli plastik dosya.", true, 12.00m, "/img/kirtasiye/urun_87.jpg", null, "Noki", 500, "Telli Sunum Dosyası", "Dosya", false },
                    { 88, "Masaüstü hatırlatmalar için iz bırakmayan yapışkanlı kağıt.", true, 25.00m, "/img/kirtasiye/urun_88.jpg", null, "Post-it", 400, "Yapışkanlı Not Kağıdı (Post-it) Sarı", "Ofis", false },
                    { 89, "Kitap ve evraklarda önemli yerleri işaretlemek için plastik yapışkanlı sekme.", true, 35.00m, "/img/kirtasiye/urun_89.jpg", null, "Kraf", 250, "Sayfa Ayraç Bandı 5 Renk", "Ofis", true },
                    { 90, "Sayfayı yıpratmayan, tozsuz ve iz bırakmayan yumuşak silgi.", true, 15.00m, "/img/kirtasiye/urun_90.jpg", null, "Faber Castell", 600, "Klasik Beyaz Silgi Sınav Tipi", "Ofis", false },
                    { 91, "Hem ince hem kalın kalemler için keskin bıçaklı alüminyum kalemtıraş.", true, 45.00m, "/img/kirtasiye/urun_91.jpg", null, "Maped", 200, "Metal Çift Delikli Kalemtıraş", "Ofis", false },
                    { 92, "Kollu sistemle çalışan, kalem çöpünü haznesinde biriktiren büyük kalemtıraş.", false, 250.00m, "/img/kirtasiye/urun_92.jpg", null, "Carl", 40, "Hazneli Masaüstü Kalemtıraş", "Ofis", true },
                    { 93, "Paslanmaz çelikten üretilmiş, evrakları bir arada tutan gümüş renkli ataş.", false, 20.00m, "/img/kirtasiye/urun_93.jpg", null, "Noki", 300, "Ataş 100lü Kutu", "Ofis", false },
                    { 94, "Pratik kullanım için çanta boyunda mini zımba ve tel takımı.", true, 65.00m, "/img/kirtasiye/urun_94.jpg", null, "Mas", 150, "Küçük Zımba Makinesi", "Ofis", false },
                    { 95, "Lazer ve mürekkep püskürtmeli yazıcılar için 80gr parlak beyaz kağıt.", true, 140.00m, "/img/kirtasiye/urun_95.jpg", null, "Navigator", 100, "A4 Fotokopi Kağıdı 500lü Top", "Ofis", false },
                    { 96, "Paketleme ve onarım için güçlü yapışkanlı, geniş şeffaf bant.", true, 35.00m, "/img/kirtasiye/urun_96.jpg", null, "Ve-Ge", 200, "Şeffaf Koli Bandı", "Ofis", false },
                    { 97, "Duvara poster asmak veya maket yapmak için süngerli çift taraflı bant.", false, 45.00m, "/img/kirtasiye/urun_97.jpg", null, "3M", 120, "Çift Taraflı Bant", "Ofis", false },
                    { 98, "Kesim işlerinde falçata kaymasını engelleyen paslanmaz çelik mühendis cetveli.", false, 60.00m, "/img/kirtasiye/urun_98.jpg", null, "Mas", 90, "Çelik Cetvel 30 cm", "Ofis", true },
                    { 99, "Tükenmez kalem hatalarını anında kapatıp üzerine yazmaya izin veren şerit.", true, 40.00m, "/img/kirtasiye/urun_99.jpg", null, "Tipp-Ex", 250, "Şerit Silici (Daksil)", "Ofis", false },
                    { 100, "Ortopedik sırt desteği.", true, 850.00m, "/img/kirtasiye/urun_100.jpg", null, "Nova Travel", 30, "Uzay Temalı Sırt Çantası", "Çanta", true }
                });

            migrationBuilder.InsertData(
                table: "Oyuncaklar",
                columns: new[] { "OyuncakId", "Aciklama", "CokSatanMi", "Fiyat", "KapakResimUrl", "KategoriId", "Marka", "StokAdedi", "UrunAdi", "YasGrubu", "YeniCikanMi" },
                values: new object[,]
                {
                    { 1, null, true, 1450.00m, "/img/oyuncak/urun_1.jpg", null, "LEGO", 15, "LEGO City Polis İstasyonu", "6+", true },
                    { 2, null, true, 550.00m, "/img/oyuncak/urun_2.jpg", null, "Mattel", 30, "Barbie Sonsuz Hareket Bebeği", "3+", false },
                    { 3, null, true, 2200.00m, "/img/oyuncak/urun_3.jpg", null, "Hot Wheels", 10, "Hot Wheels 50'li Araba Seti", "3+", false },
                    { 4, null, false, 850.00m, "/img/oyuncak/urun_4.jpg", null, "Hasbro", 20, "Monopoly Dijital Bankacılık", "8+", true },
                    { 5, null, true, 1200.00m, "/img/oyuncak/urun_5.jpg", null, "Nerf", 12, "Nerf Ultra One", "8+", true },
                    { 6, null, true, 450.00m, "/img/oyuncak/urun_6.jpg", null, "Fisher-Price", 40, "Fisher-Price Eğitici Tablet", "1-3 Yaş", false },
                    { 7, null, false, 380.00m, "/img/oyuncak/urun_7.jpg", null, "Hasbro", 50, "Play-Doh Mutfak Atölyesi", "3+", false },
                    { 8, null, true, 420.00m, "/img/oyuncak/urun_8.jpg", null, "Mattel", 25, "Scrabble Junior", "5+", false },
                    { 9, null, false, 1100.00m, "/img/oyuncak/urun_9.jpg", null, "Maisto", 18, "Remote Control Rock Crawler", "6+", true },
                    { 10, null, true, 950.00m, "/img/oyuncak/urun_10.jpg", null, "Clementoni", 15, "Clementoni Robotik Laboratuvarı", "8+", true },
                    { 11, null, true, 3500.00m, "/img/oyuncak/urun_11.jpg", null, "LEGO", 5, "Star Wars Millennium Falcon LEGO", "12+", false },
                    { 12, null, true, 750.00m, "/img/oyuncak/urun_12.jpg", null, "MGA", 22, "LOL Surprise! O.M.G. Bebek", "4+", true },
                    { 13, null, false, 650.00m, "/img/oyuncak/urun_13.jpg", null, "Hasbro", 30, "Transformers Optimus Prime", "6+", false },
                    { 14, null, true, 250.00m, "/img/oyuncak/urun_14.jpg", null, "StarGames", 100, "Manyetik Satranç Takımı", "6+", false },
                    { 15, null, true, 900.00m, "/img/oyuncak/urun_15.jpg", null, "NovaToys", 10, "Peluş Ayı Nova 100cm", "0+", true },
                    { 16, null, true, 120.00m, "/img/oyuncak/urun_16.jpg", null, "Mattel", 200, "Uno Kart Oyunu", "7+", false },
                    { 17, null, false, 280.00m, "/img/oyuncak/urun_17.jpg", null, "Anatolian", 45, "Puzzle 1000 Parça: Galaksi", "12+", true },
                    { 18, null, true, 1850.00m, "/img/oyuncak/urun_18.jpg", null, "Woody", 8, "Ahşap Mutfak Seti", "3+", false },
                    { 19, null, true, 450.00m, "/img/oyuncak/urun_19.jpg", null, "Hasbro", 40, "Marvel Spider-Man Figür", "4+", true },
                    { 20, null, true, 850.00m, "/img/oyuncak/urun_20.jpg", null, "Hasbro", 25, "Baby Alive Mama Yiyen Bebek", "3+", false },
                    { 21, null, false, 620.00m, "/img/oyuncak/urun_21.jpg", null, "Spin Master", 35, "Hatchimals Pixies", "5+", true },
                    { 22, null, true, 580.00m, "/img/oyuncak/urun_22.jpg", null, "Fisher-Price", 20, "Thomas & Friends Tren Seti", "3+", false },
                    { 23, null, true, 220.00m, "/img/oyuncak/urun_23.jpg", null, "Mattel", 60, "Enchantimals Bebek ve Hayvanı", "4+", false },
                    { 24, null, true, 350.00m, "/img/oyuncak/urun_24.jpg", null, "Hasbro", 150, "Jenga Klasik", "6+", false },
                    { 25, null, false, 180.00m, "/img/oyuncak/urun_25.jpg", null, "NovaFun", 80, "Slime Dev Yapım Seti", "5+", true },
                    { 26, null, true, 320.00m, "/img/oyuncak/urun_26.jpg", null, "SciencePlay", 30, "Güneş Sistemi Maket Kiti", "8+", false },
                    { 27, null, false, 450.00m, "/img/oyuncak/urun_27.jpg", null, "MusicStar", 15, "Pilli Işıklı Keman", "5+", true },
                    { 28, null, true, 550.00m, "/img/oyuncak/urun_28.jpg", null, "Hasbro", 40, "Tabu XL", "12+", false },
                    { 29, null, true, 720.00m, "/img/oyuncak/urun_29.jpg", null, "Hasbro", 20, "Risk Strateji Oyunu", "10+", false },
                    { 30, null, true, 250.00m, "/img/oyuncak/urun_30.jpg", null, "SandMagic", 70, "Duyusal Kum Seti 2kg", "3+", true },
                    { 31, null, true, 480.00m, "/img/oyuncak/urun_31.jpg", null, "Disney", 15, "Frozen 2 Elsa Kostümü", "4-6 Yaş", false },
                    { 32, null, false, 150.00m, "/img/oyuncak/urun_32.jpg", null, "Woody", 50, "Eğitici Sayılar Abaküsü", "3+", false },
                    { 33, null, false, 650.00m, "/img/oyuncak/urun_33.jpg", null, "SpyKit", 25, "Walkie Talkie Telsiz Seti", "8+", true },
                    { 34, null, true, 1150.00m, "/img/oyuncak/urun_34.jpg", null, "LEGO", 12, "Lego Technic Yarış Arabası", "10+", true },
                    { 35, null, true, 580.00m, "/img/oyuncak/urun_35.jpg", null, "NovaArt", 10, "Büyük Boy Yazı Tahtası", "3+", false },
                    { 36, null, false, 340.00m, "/img/oyuncak/urun_36.jpg", null, "Mattel", 45, "Minecraft Steve Figür Seti", "6+", true },
                    { 37, null, true, 620.00m, "/img/oyuncak/urun_37.jpg", null, "Hasbro", 18, "Trivial Pursuit Aile Boyu", "8+", false },
                    { 38, null, true, 7500.00m, "/img/oyuncak/urun_38.jpg", null, "Pilsan", 5, "Pilsan Akülü Araba 12V", "3-8 Yaş", true },
                    { 39, null, true, 420.00m, "/img/oyuncak/urun_39.jpg", null, "Hasbro", 60, "Twister Eğlence Matı", "6+", false },
                    { 40, null, true, 220.00m, "/img/oyuncak/urun_40.jpg", null, "ToyMed", 90, "Doktor Seti Çantalı", "3+", false },
                    { 41, null, true, 680.00m, "/img/oyuncak/urun_41.jpg", null, "LEGO", 20, "Lego Duplo Hayvan Çiftliği", "2+", true },
                    { 42, null, false, 780.00m, "/img/oyuncak/urun_42.jpg", null, "DC Comics", 15, "Batman Batmobile Araç", "4+", true },
                    { 43, null, true, 650.00m, "/img/oyuncak/urun_43.jpg", null, "Mattel", 25, "Barbie Veteriner Seti", "3+", false },
                    { 44, null, true, 490.00m, "/img/oyuncak/urun_44.jpg", null, "Hasbro", 35, "Süper Doktor Oyunu", "6+", false },
                    { 45, null, true, 890.00m, "/img/oyuncak/urun_45.jpg", null, "K-Nex", 14, "K'Nex Mühendislik Seti", "9+", true },
                    { 46, null, false, 180.00m, "/img/oyuncak/urun_46.jpg", null, "Woody", 100, "Kız Kulesi Maketi", "10+", false },
                    { 47, null, true, 320.00m, "/img/oyuncak/urun_47.jpg", null, "WildLife", 50, "Vahşi Hayvanlar Figür Seti", "3+", false },
                    { 48, null, true, 1450.00m, "/img/oyuncak/urun_48.jpg", null, "SciencePlay", 8, "Teleskop Başlangıç Seti", "8+", true },
                    { 49, null, false, 820.00m, "/img/oyuncak/urun_49.jpg", null, "MGA", 20, "Bratz Retro Bebek", "6+", true },
                    { 50, null, true, 240.00m, "/img/oyuncak/urun_50.jpg", null, "Woody", 80, "Domino 100 Parça Renkli", "4+", false },
                    { 51, null, true, 950.00m, "/img/oyuncak/urun_51.jpg", null, "LEGO", 15, "Lego Ninjago Ejderha Seti", "8+", true },
                    { 52, null, true, 3800.00m, "/img/oyuncak/urun_52.jpg", null, "Disney", 4, "Disney Princess Şato", "3+", true },
                    { 53, null, true, 1650.00m, "/img/oyuncak/urun_53.jpg", null, "Hot Wheels", 10, "Hot Wheels Şehir Macerası", "4+", false },
                    { 54, null, true, 850.00m, "/img/oyuncak/urun_54.jpg", null, "Kosmos", 30, "Catan Masa Oyunu", "10+", false },
                    { 55, null, false, 450.00m, "/img/oyuncak/urun_55.jpg", null, "Spin Master", 55, "Bakugan Başlangıç Paketi", "6+", true },
                    { 56, null, true, 1250.00m, "/img/oyuncak/urun_56.jpg", null, "Spin Master", 18, "Paw Patrol Dev Devriye Aracı", "3+", true },
                    { 57, null, true, 750.00m, "/img/oyuncak/urun_57.jpg", null, "Pilsan", 20, "Pilsan Lego Masa Seti", "2+", false },
                    { 58, null, true, 520.00m, "/img/oyuncak/urun_58.jpg", null, "WizardWorld", 40, "Harry Potter Asa (Işıklı)", "6+", true },
                    { 59, null, true, 450.00m, "/img/oyuncak/urun_59.jpg", null, "Kellytoy", 35, "Squishmallows Yumuşak Yastık", "0+", true },
                    { 60, null, true, 320.00m, "/img/oyuncak/urun_60.jpg", null, "Hasbro", 60, "Guess Who? (Bil Bakalım Kim?)", "6+", false },
                    { 61, null, true, 580.00m, "/img/oyuncak/urun_61.jpg", null, "LEGO", 25, "Lego Friends Kafe Seti", "6+", false },
                    { 62, null, true, 1850.00m, "/img/oyuncak/urun_62.jpg", null, "Moose Toys", 12, "Magic Mixies Sihirli Kazan", "5+", true },
                    { 63, null, true, 180.00m, "/img/oyuncak/urun_63.jpg", null, "Hot Wheels", 120, "Hot Wheels Renk Değiştirenler", "3+", true },
                    { 64, null, false, 750.00m, "/img/oyuncak/urun_64.jpg", null, "SciencePlay", 22, "Mikroskop Seti (1200x)", "10+", true },
                    { 65, null, true, 580.00m, "/img/oyuncak/urun_65.jpg", null, "Mattel", 45, "Barbie Dreamtopia Denizkızı", "3+", false },
                    { 66, null, true, 520.00m, "/img/oyuncak/urun_66.jpg", null, "Hasbro", 30, "Cluedo Dedektiflik Oyunu", "8+", false },
                    { 67, null, false, 1100.00m, "/img/oyuncak/urun_67.jpg", null, "LEGO", 10, "Lego Star Wars Boba Fett", "14+", true },
                    { 68, null, true, 380.00m, "/img/oyuncak/urun_68.jpg", null, "Jazwares", 65, "Pokemon Battle Figure 3-Pack", "4+", true },
                    { 69, null, true, 180.00m, "/img/oyuncak/urun_69.jpg", null, "EğiticiDünya", 100, "Kayıp Kelimeler Hece Oyunu", "5+", false },
                    { 70, null, false, 1250.00m, "/img/oyuncak/urun_70.jpg", null, "Sporty", 8, "Büyük Boy Basketbol Potası", "6+", true },
                    { 71, null, true, 820.00m, "/img/oyuncak/urun_71.jpg", null, "LEGO", 20, "Lego Minecraft Kale Savaşı", "8+", true },
                    { 72, null, true, 950.00m, "/img/oyuncak/urun_72.jpg", null, "Mattel", 15, "Barbie Gardırop Seti", "3+", false },
                    { 73, null, true, 1450.00m, "/img/oyuncak/urun_73.jpg", null, "Playmobil", 7, "Playmobil Korsan Gemisi", "4+", false },
                    { 74, null, true, 780.00m, "/img/oyuncak/urun_74.jpg", null, "Z-Man Games", 20, "Carcassonne Strateji Oyunu", "8+", false },
                    { 75, null, false, 320.00m, "/img/oyuncak/urun_75.jpg", null, "TechToys", 50, "Uçan Helikopter (Sensorlü)", "8+", true },
                    { 76, null, true, 650.00m, "/img/oyuncak/urun_76.jpg", null, "Mattel", 30, "Disney Cars Şimşek McQueen", "3+", false },
                    { 77, null, true, 1100.00m, "/img/oyuncak/urun_77.jpg", null, "Hasbro", 12, "FurReal Sevimli Ayıcık", "4+", true },
                    { 78, null, true, 380.00m, "/img/oyuncak/urun_78.jpg", null, "Hasbro", 40, "Amiral Battı Klasik Oyunu", "7+", false },
                    { 79, null, false, 920.00m, "/img/oyuncak/urun_79.jpg", null, "LEGO", 15, "Lego Technic Kepçe", "9+", true },
                    { 80, null, true, 220.00m, "/img/oyuncak/urun_80.jpg", null, "NovaFun", 60, "Glow in the Dark Slime Kit", "5+", true },
                    { 81, null, false, 850.00m, "/img/oyuncak/urun_81.jpg", null, "Nerf", 25, "Nerf Fortnite Blaster", "8+", true },
                    { 82, null, true, 1350.00m, "/img/oyuncak/urun_82.jpg", null, "Mattel", 10, "Barbie Tatil Villası", "3+", true },
                    { 83, null, true, 720.00m, "/img/oyuncak/urun_83.jpg", null, "Hot Wheels", 20, "Hot Wheels Akrobasi Seti", "4+", true },
                    { 84, null, true, 480.00m, "/img/oyuncak/urun_84.jpg", null, "Jumbo", 35, "Stratego Savaş Oyunu", "8+", false },
                    { 85, null, true, 950.00m, "/img/oyuncak/urun_85.jpg", null, "MagnaTiles", 22, "Manyetik Bloklar 100 Parça", "3+", true },
                    { 86, null, true, 320.00m, "/img/oyuncak/urun_86.jpg", null, "Dragon-I", 55, "Talking Tom İnteraktif Kedi", "3+", false },
                    { 87, null, true, 280.00m, "/img/oyuncak/urun_87.jpg", null, "Woody", 45, "Ahşap Blok Tren", "18 Ay+", false },
                    { 88, null, false, 420.00m, "/img/oyuncak/urun_88.jpg", null, "Sporty", 30, "Okçuluk Seti (Vantuzlu)", "6+", true },
                    { 89, null, false, 520.00m, "/img/oyuncak/urun_89.jpg", null, "Mattel", 25, "Barbie Spa Günü Bebek", "3+", true },
                    { 90, null, true, 450.00m, "/img/oyuncak/urun_90.jpg", null, "LEGO", 50, "Lego Classic Pencereler Paketi", "4+", false },
                    { 91, null, true, 350.00m, "/img/oyuncak/urun_91.jpg", null, "Hasbro", 40, "My Little Pony Işıklı Figür", "3+", true },
                    { 92, null, false, 650.00m, "/img/oyuncak/urun_92.jpg", null, "FunGames", 15, "Air Hockey Masaüstü", "6+", true },
                    { 93, null, true, 220.00m, "/img/oyuncak/urun_93.jpg", null, "TechToys", 100, "Çizim Tableti (LCD Yazı)", "3+", true },
                    { 94, null, true, 480.00m, "/img/oyuncak/urun_94.jpg", null, "Mattel", 30, "Polly Pocket Şato Çantası", "4+", true },
                    { 95, null, true, 450.00m, "/img/oyuncak/urun_95.jpg", null, "Hasbro", 20, "Hulk Aksiyon Figürü 30cm", "4+", false },
                    { 96, null, false, 1250.00m, "/img/oyuncak/urun_96.jpg", null, "Hasbro", 10, "Risk Game of Thrones Edition", "16+", true },
                    { 97, null, true, 850.00m, "/img/oyuncak/urun_97.jpg", null, "MusicStar", 12, "Gitar Başlangıç Seti", "8+", true },
                    { 98, null, true, 320.00m, "/img/oyuncak/urun_98.jpg", null, "LEGO", 40, "Lego Creator 3'ü 1 Arada Kuş", "7+", true },
                    { 99, null, true, 150.00m, "/img/oyuncak/urun_99.jpg", null, "FunGames", 100, "Mikado Çubukları Dev Boy", "6+", false },
                    { 100, null, true, 220.00m, "/img/oyuncak/urun_100.jpg", null, "Rubik", 150, "Rubik Kübü 3x3 Orijinal", "8+", false }
                });

            migrationBuilder.InsertData(
                table: "Yazarlar",
                columns: new[] { "YazarId", "AdSoyad", "Biyografi" },
                values: new object[,]
                {
                    { 1, "Fyodor Dostoyevski", "Rus edebiyatının en büyük yazarlarından." },
                    { 2, "George Orwell", "Distopik eserleriyle tanınan İngiliz yazar." },
                    { 3, "Sabahattin Ali", "Türk edebiyatının usta kalemlerinden." },
                    { 4, "Stefan Zweig", "Avusturyalı romancı ve biyografi yazarı." },
                    { 5, "Franz Kafka", "Modern Alman edebiyatının öncülerinden." },
                    { 6, "Agatha Christie", "Polisiye edebiyatın kraliçesi." },
                    { 7, "Victor Hugo", "Fransız edebiyatının en büyük romantik yazarı." },
                    { 8, "Sigmund Freud", "Psikanalizin kurucusu." },
                    { 9, "Friedrich Nietzsche", "Alman filozof ve kültür eleştirmeni." },
                    { 10, "İlber Ortaylı", "Türk tarihçi ve akademisyen." },
                    { 11, "Ahmet Hamdi Tanpınar", "Türk romanının ve şiirinin önemli ismi." },
                    { 12, "Oğuz Atay", "Postmodern Türk edebiyatının kurucularından." },
                    { 13, "Albert Camus", "Varoluşçuluk akımının öncülerinden." },
                    { 14, "Lev Tolstoy", "Gerçekçi Rus edebiyatının dev ismi." },
                    { 15, "Arthur Conan Doyle", "Sherlock Holmes karakterinin yaratıcısı." },
                    { 16, "Yuval Noah Harari", "İsrailli tarihçi ve yazar." },
                    { 17, "Marcus Aurelius", "Roma imparatoru ve Stoacı filozof." },
                    { 18, "Jules Verne", "Bilimkurgu edebiyatının babası." },
                    { 19, "Jane Austen", "İngiliz edebiyatının romantik dönem yazarı." },
                    { 20, "Carl Gustav Jung", "Analitik psikolojinin kurucusu." }
                });

            migrationBuilder.InsertData(
                table: "Kitaplar",
                columns: new[] { "KitapId", "Aciklama", "BasimYili", "CokSatanMi", "Fiyat", "KapakResimUrl", "KategoriId", "KitapAdi", "SayfaSayisi", "StokAdedi", "Yayinevi", "YazarId", "YeniCikanMi" },
                values: new object[,]
                {
                    { 1, "Fakir bir öğrenci olan Raskolnikov'un işlediği cinayet sonrası yaşadığı derin vicdan azabı ve psikolojik buhranı anlatan, insan ruhunun karanlık dehlizlerine inen eşsiz bir başyapıt.", 1866, true, 145.50m, "/img/kitaplar/kitap_1.jpg", 1, "Suç ve Ceza", 687, 50, "İş Bankası Kültür Yayınları", 1, false },
                    { 2, "Dostoyevski'nin son ve en büyük eseri. Bir baba katli etrafında şekillenen roman, inanç, şüphe, özgür irade ve ahlak kavramlarını üç erkek kardeş üzerinden muazzam bir derinlikle tartışır.", 1880, false, 185.00m, "/img/kitaplar/kitap_2.jpg", 1, "Karamazov Kardeşler", 840, 50, "İş Bankası Kültür Yayınları", 1, false },
                    { 3, "Ekmek çaldığı için kürek mahkumiyetine çarptırılan Jean Valjean'ın kefaret ve merhamet arayışını anlatan, Fransız Devrimi sonrası toplumsal adaletsizliğe tutulmuş devasa bir ayna.", 1862, true, 250.00m, "/img/kitaplar/kitap_3.jpg", 1, "Sefiller", 1200, 50, "İş Bankası Kültür Yayınları", 7, false },
                    { 4, "Napolyon'un Rusya'yı işgali sırasında beş soylu ailenin yaşadıklarını merkeze alan, aşk, savaş, tarih ve insan doğası üzerine yazılmış destansı bir tarihsel roman.", 1869, false, 275.00m, "/img/kitaplar/kitap_4.jpg", 1, "Savaş ve Barış", 1225, 50, "İletişim Yayınları", 14, false },
                    { 5, "Evli bir kadın olan Anna'nın, Kont Vronski ile yaşadığı yasak aşkın toplumsal kurallarla çarpışmasını ve trajik sonunu anlatan unutulmaz bir klasik.", 1877, false, 190.00m, "/img/kitaplar/kitap_5.jpg", 1, "Anna Karenina", 864, 50, "İş Bankası Kültür Yayınları", 14, false },
                    { 6, "Taşralı bir beyefendinin kızı olan Elizabeth Bennet ile varlıklı ve soylu Fitzwilliam Darcy arasındaki çatışmalı aşkı, dönemin İngiliz burjuvazisinin ince bir hicviyle anlatan eser.", 1813, true, 95.00m, "/img/kitaplar/kitap_6.jpg", 1, "Gurur ve Önyargı", 432, 50, "Can Yayınları", 19, false },
                    { 7, "Modern edebiyatın ilk varoluşçu anti-kahramanı olan isimsiz anlatıcının, topluma, bilime ve rasyonaliteye duyduğu öfkeyi kustuğu sarsıcı bir yeraltı itirafı.", 1864, false, 65.00m, "/img/kitaplar/kitap_7.jpg", 1, "Yeraltından Notlar", 150, 50, "İş Bankası Kültür Yayınları", 1, true },
                    { 8, "Yazarın kendi kumar bağımlılığından izler taşıyan roman, kurgusal bir Alman kasabasında rulet masaları etrafında dönen hastalıklı bir tutkuyu ve yıkımı anlatır.", 1866, false, 75.00m, "/img/kitaplar/kitap_8.jpg", 1, "Kumarbaz", 190, 50, "İş Bankası Kültür Yayınları", 1, false },
                    { 9, "Büyük Birader'in her şeyi izlediği, düşünmenin bile suç olduğu totaliter bir devlette geçen, gerçeğin ve tarihin nasıl manipüle edildiğini gösteren sarsıcı distopya.", 1949, true, 110.00m, "/img/kitaplar/kitap_9.jpg", 7, "1984", 352, 50, "Can Yayınları", 2, false },
                    { 10, "İnsanların zorbalığına karşı ayaklanıp çiftliği ele geçiren hayvanların, zamanla kendi içlerinde yeni bir diktatörlük kurmalarını anlatan zekice bir siyasi hiciv.", 1945, true, 85.00m, "/img/kitaplar/kitap_10.jpg", 7, "Hayvan Çiftliği", 152, 50, "Can Yayınları", 2, true },
                    { 11, "İçine kapanık Raif Efendi'nin, Berlin'de bir sanat galerisinde tablosunu gördüğü Maria Puder'e duyduğu tutkulu aşkı ve sonrasında yaşadığı büyük sessizliği konu alır.", 1943, true, 70.00m, "/img/kitaplar/kitap_11.jpg", 7, "Kürk Mantolu Madonna", 160, 50, "Yapı Kredi Yayınları", 3, false },
                    { 12, "Ömer ve Macide'nin aşkı üzerinden, 1930'lar Türkiyesi'ndeki aydın kesimin yozlaşmasını, iradesizliğini ve içlerindeki şeytan ile olan çatışmalarını resmeder.", 1940, false, 90.00m, "/img/kitaplar/kitap_12.jpg", 7, "İçimizdeki Şeytan", 260, 50, "Yapı Kredi Yayınları", 3, false },
                    { 13, "Ailesi katledildikten sonra bir kaymakam tarafından evlat edinilen Yusuf'un, Anadolu kasabasının yozlaşmış eşrafına ve haksızlıklara karşı verdiği trajik mücadele.", 1937, false, 85.00m, "/img/kitaplar/kitap_13.jpg", 7, "Kuyucaklı Yusuf", 220, 50, "Yapı Kredi Yayınları", 3, false },
                    { 14, "Gestapo tarafından bir otel odasına hapsedilen ve zihnini korumak için satranç tahtasını zihninde canlandıran Dr. B'nin, bir yolcu gemisindeki dünya şampiyonuyla karşılaşması.", 1943, true, 45.00m, "/img/kitaplar/kitap_14.jpg", 7, "Satranç", 85, 50, "İş Bankası Kültür Yayınları", 4, true },
                    { 15, "Ünlü bir yazara gönderilen imzasız bir mektuptan okuduğumuz, yazarın hiç fark etmediği bir kadının çocukluğundan ölümüne kadar süren takıntılı ve karşılıksız aşkının melankolik itirafı.", 1922, false, 35.00m, "/img/kitaplar/kitap_15.jpg", 7, "Bilinmeyen Bir Kadının Mektubu", 65, 50, "İş Bankası Kültür Yayınları", 4, false },
                    { 16, "Kumaş pazarlamacısı Gregor Samsa'nın bir sabah yatağında dev bir böceğe dönüşmüş olarak uyanmasıyla başlayan, modern insanın sisteme yabancılaşmasının en somut tasviri.", 1915, true, 55.00m, "/img/kitaplar/kitap_16.jpg", 2, "Dönüşüm", 104, 50, "Can Yayınları", 5, false },
                    { 17, "Josef K.'nın bir sabah ansızın neyle suçlandığını bilmeden tutuklanması ve absürt, görünmez bir hukuk sistemine karşı verdiği çaresiz mücadeleyi anlatan başyapıt.", 1925, false, 95.00m, "/img/kitaplar/kitap_17.jpg", 2, "Dava", 270, 50, "Can Yayınları", 5, false },
                    { 18, "Hayri İrdal ve Halit Ayarcı üzerinden, Türk toplumunun Doğu-Batı arasındaki bocalayışını, eski ile yeni arasındaki çatışmayı absürt bir bürokrasi eleştirisiyle sunan eşsiz bir roman.", 1961, true, 130.00m, "/img/kitaplar/kitap_18.jpg", 7, "Saatleri Ayarlama Enstitüsü", 382, 50, "Dergah Yayınları", 11, true },
                    { 19, "Mümtaz ve Nuran'ın İstanbul fonunda yeşeren aşkı etrafında, Cumhuriyet aydınının gelenekle modernlik, geçmişle gelecek arasında yaşadığı derin huzursuzluğu şiirsel bir dille işler.", 1949, false, 135.00m, "/img/kitaplar/kitap_19.jpg", 2, "Huzur", 390, 50, "Dergah Yayınları", 11, false },
                    { 20, "Turgut Özben'in, intihar eden arkadaşı Selim Işık'ın geçmişinin izini sürerken, küçük burjuva ahlakına ve toplumsal kalıplara isyan eden tutunamayanların dünyasına girmesini anlatır.", 1972, true, 210.00m, "/img/kitaplar/kitap_20.jpg", 7, "Tutunamayanlar", 724, 50, "İletişim Yayınları", 12, false },
                    { 21, "Hikmet Benol'un gecekondu mahallesinde kendi zihninde yarattığı oyunlar ve hayali karakterlerle gerçeği büküşünü, Türk aydınının trajikomik varoluş çırpınışını anlatan eser.", 1973, false, 150.00m, "/img/kitaplar/kitap_21.jpg", 7, "Tehlikeli Oyunlar", 480, 50, "İletişim Yayınları", 12, false },
                    { 22, "Annesinin ölümüne dahi tepkisiz kalan, toplumsal normlara ve ahlak kurallarına tamamen yabancılaşmış Meursault'nun, işlediği anlamsız cinayet sonrası absürt felsefesini yargıya sunuşu.", 1942, true, 60.00m, "/img/kitaplar/kitap_22.jpg", 2, "Yabancı", 112, 50, "Can Yayınları", 13, true },
                    { 23, "Cezayir'in Oran şehrinde veba salgınının patlak vermesiyle karantinaya alınan halkın, felaket karşısında gösterdiği dayanışmayı ve insanın ölüme karşı isyanını anlatan alegorik bir eser.", 1947, false, 115.00m, "/img/kitaplar/kitap_23.jpg", 2, "Veba", 300, 50, "Can Yayınları", 13, false },
                    { 24, "Deniz canavarı sanılan Nautilus denizaltısının esrarengiz Kaptan Nemo'su ve ona esir düşen Profesör Aronnax'ın okyanusların derinliklerinde yaşadığı nefes kesici bilimkurgu serüveni.", 1870, false, 125.00m, "/img/kitaplar/kitap_24.jpg", 7, "Denizler Altında Yirmibin Fersah", 450, 50, "İthaki Yayınları", 18, false },
                    { 25, "İngiliz beyefendisi Phileas Fogg'un, girdiği bir iddia üzerine uşağı Passepartout ile birlikte dünyanın etrafını 80 günde dönmek için vapurlar ve trenlerle girdiği zamana karşı yarış.", 1873, false, 110.00m, "/img/kitaplar/kitap_25.jpg", 7, "Seksen Günde Devri Alem", 320, 50, "İthaki Yayınları", 18, true },
                    { 26, "Tropik bir adada, zengin bir kadının yardım talebini reddeden bir doktorun, ardından hissettiği pişmanlık ve saplantıyla amok krizine girerek felakete sürüklenişinin hikayesi.", 1922, false, 40.00m, "/img/kitaplar/kitap_26.jpg", 2, "Amok Koşucusu", 70, 50, "İş Bankası Kültür Yayınları", 4, false },
                    { 27, "Birbirini tanımayan on kişinin ıssız bir adadaki malikaneye davet edilmeleri ve her birinin geçmişlerindeki sırlara göre sırayla öldürülmesini anlatan klasikleşmiş cinayet romanı.", 1939, true, 105.00m, "/img/kitaplar/kitap_27.jpg", 6, "On Kişiydiler (On Küçük Zenci)", 224, 50, "Altın Kitaplar", 6, false },
                    { 28, "Kar fırtınası yüzünden yolda kalan Doğu Ekspresi'nde işlenen esrarengiz cinayeti çözmek için Dedektif Hercule Poirot'nun yolcuları zekice sorguya çektiği efsanevi gizem.", 1934, true, 115.00m, "/img/kitaplar/kitap_28.jpg", 6, "Doğu Ekspresinde Cinayet", 256, 50, "Altın Kitaplar", 6, true },
                    { 29, "Zengin bir dulun intiharı ve hemen ardından Roger Ackroyd'un öldürülmesiyle başlayan, Hercule Poirot'nun polisiye tarihinin en şaşırtıcı ters köşelerinden birine imza attığı kitap.", 1926, false, 120.00m, "/img/kitaplar/kitap_29.jpg", 6, "Roger Ackroyd Cinayeti", 280, 50, "Altın Kitaplar", 6, false },
                    { 30, "Mısırda bir gemi yolculuğunda trajedi.", 2020, false, 130.00m, "/img/kitaplar/kitap_30.jpg", 6, "Nil'de Ölüm", 310, 50, "Bilinmiyor", 6, false },
                    { 31, "Dr. Watson'ın Sherlock Holmes ile tanıştığı, Baker Sokağı 221B'ye yerleştikleri ve Londra'da işlenen kanlı bir cinayeti tümdengelim yöntemiyle çözdükleri ilk büyük vaka.", 1887, true, 75.00m, "/img/kitaplar/kitap_31.jpg", 6, "Sherlock Holmes - Kızıl Soruşturma", 160, 50, "Ren Kitap", 15, true },
                    { 32, "Hindistan'dan İngiltere'ye uzanan gizemli bir hazinenin, zehirli okların ve eski ihanetlerin peşinden koşan Holmes ve Watson'ın en sürükleyici maceralarından biri.", 1890, false, 80.00m, "/img/kitaplar/kitap_32.jpg", 6, "Sherlock Holmes - Dörtlerin İmzası", 180, 50, "Ren Kitap", 15, false },
                    { 33, "Lanetli bir ailenin sırrı.", 2020, true, 100.00m, "/img/kitaplar/kitap_33.jpg", 6, "Baskerville'lerin Köpeği", 240, 50, "Bilinmiyor", 15, false },
                    { 34, "Freud'un psikanaliz kuramının temel taşı olan bu eser, rüyaların tesadüfi olmadığını, bilinçdışı arzuların ve bastırılmış duyguların sansürlenmiş sembolik ifadeleri olduğunu savunur.", 1899, true, 180.00m, "/img/kitaplar/kitap_34.jpg", 3, "Düşlerin Yorumu", 550, 50, "Say Yayınları", 8, false },
                    { 35, "İnsanın içgüdüsel arzuları (cinsellik ve saldırganlık) ile toplumun bu arzuları baskılayan kuralları arasındaki kaçınılmaz çatışmanın insanı nasıl nevrotik kıldığını anlatan başyapıt.", 1930, false, 65.00m, "/img/kitaplar/kitap_35.jpg", 3, "Uygarlığın Huzursuzluğu", 120, 50, "Metis Yayınları", 8, true },
                    { 36, "Günlük hayatta yaptığımız dil sürçmelerinin, unutkanlıkların ve sakarlıkların aslında bilinçaltımızdaki gizli niyetlerin ve bastırılmış düşüncelerin dışa vurumu olduğunu inceleyen çalışma.", 1901, false, 135.00m, "/img/kitaplar/kitap_36.jpg", 3, "Gündelik Hayatın Psikopatolojisi", 320, 50, "Say Yayınları", 8, false },
                    { 37, "Jung'un analitik psikolojisinin temellerini attığı, ego, gölge, anima/animus kavramlarını ve insan psişesinin yapısını mitoloji ve sembolizmle harmanlayarak anlattığı eseri.", 1928, false, 125.00m, "/img/kitaplar/kitap_37.jpg", 3, "İnsan Ruhuna Yöneliş", 280, 50, "Pinhan Yayıncılık", 20, false },
                    { 38, "Modern kitle toplumlarında bireyin nasıl kaybolduğunu anlatan Jung, insanın kendini tanıması (bireyleşme) ve kendi Gölge'siyle yüzleşmesi gerektiğini savunan uyarıcı bir manifestodur.", 1957, true, 75.00m, "/img/kitaplar/kitap_38.jpg", 3, "Keşfedilmemiş Benlik", 140, 50, "İthaki Yayınları", 20, true },
                    { 39, "Jung'un yıllarca herkesten sakladığı, kendi bilinçdışına yaptığı korkunç ve büyüleyici yolculukları, vizyonları ve arketiplerle karşılaşmalarını anlattığı, el yazması mistik günlüğü.", 2009, false, 250.00m, "/img/kitaplar/kitap_39.jpg", 3, "Kırmızı Kitap", 400, 50, "Kaknüs Yayınları", 20, false },
                    { 40, "Tanrının öldüğünü ilan eden Nietzsche'nin, Üstinsan kavramını ortaya attığı, geleneksel ahlakı yıkıp yerine insanın kendi değerlerini yaratmasını savunan şiirsel felsefe şaheseri.", 1883, true, 140.00m, "/img/kitaplar/kitap_40.jpg", 5, "Böyle Söyledi Zerdüşt", 350, 50, "İş Bankası Kültür Yayınları", 9, false },
                    { 41, "Mutlak doğruları, evrensel iyiyi ve kötüyü reddeden Nietzsche'nin, ahlakın aslında bir güç istenci yansıması olduğunu savunduğu sarsıcı ve provokatif denemeleri.", 1886, false, 110.00m, "/img/kitaplar/kitap_41.jpg", 5, "İyinin ve Kötünün Ötesinde", 240, 50, "İş Bankası Kültür Yayınları", 9, true },
                    { 42, "Sokrates'ten bu yana Batı felsefesinin taptığı putları felsefi bir çekiçle yıktığını iddia eden, yazarın felsefesinin en yoğun özetlerinden biri.", 1889, false, 70.00m, "/img/kitaplar/kitap_42.jpg", 5, "Putların Alacakaranlığı", 130, 50, "İş Bankası Kültür Yayınları", 9, false },
                    { 43, "Roma İmparatoru Marcus Aurelius'un seferler sırasında çadırında kendi kendine yazdığı, Stoacı felsefenin erdem, ölüm, doğaya uyum ve iç huzur üzerine en pratik rehberi.", 180, true, 80.00m, "/img/kitaplar/kitap_43.jpg", 5, "Kendime Düşünceler", 160, 50, "İş Bankası Kültür Yayınları", 17, true },
                    { 44, "İnsanın anlam arayışının, anlamsız bir evrenle çarpışmasından doğan Absürt felsefesini, kayayı sonsuza dek dağa çıkarmaya mahkum edilen Sisifos efsanesi üzerinden inceler.", 1942, true, 75.00m, "/img/kitaplar/kitap_44.jpg", 5, "Sisifos Söyleni", 150, 50, "Can Yayınları", 13, false },
                    { 45, "İnsanın evrendeki anlamsızlığa karşı koyuşunun tek yolunun isyan olduğunu, ancak bu isyanın bir cinayete veya diktatörlüğe dönüşmemesi gerektiğini tartışan metafizik analiz.", 1951, false, 145.00m, "/img/kitaplar/kitap_45.jpg", 5, "Başkaldıran İnsan", 380, 50, "Can Yayınları", 13, false },
                    { 46, "Önemsiz bir maymun türü olan Homo Sapiens'in bilişsel, tarım ve bilim devrimleriyle gezegenin hakimi konumuna nasıl yükseldiğini anlatan, ezber bozan bir insanlık tarihi.", 2011, true, 160.00m, "/img/kitaplar/kitap_46.jpg", 4, "Sapiens: Hayvanlardan Tanrılara", 412, 50, "Kolektif Kitap", 16, false },
                    { 47, "Açlık, savaş ve hastalıkları yenen insanlığın, gelecekte ölümsüzlük, mutluluk ve tanrısallık peşinde koşarken yapay zeka ve biyoteknoloji ile kendi sonunu nasıl hazırlayabileceğini tartışır.", 2015, true, 175.00m, "/img/kitaplar/kitap_47.jpg", 4, "Homo Deus: Yarının Kısa Tarihi", 450, 50, "Kolektif Kitap", 16, true },
                    { 48, "Sahte haberler, teknolojik işsizlik, göçmen krizleri ve ekolojik çöküş gibi günümüzün en yakıcı küresel sorunlarına tarihsel ve felsefi bir mercekten bakan derin bir analiz.", 2018, false, 150.00m, "/img/kitaplar/kitap_48.jpg", 4, "21. Yüzyıl İçin 21 Ders", 368, 50, "Kolektif Kitap", 16, false },
                    { 49, "İlber Ortaylı'nın kendi deneyimlerinden yola çıkarak, seyahat etmek, dil öğrenmek, meslek seçimi ve müzik zevki gibi konularda gençlere ufuk açıcı bir yaşam rehberi sunduğu söyleşi kitabı.", 2019, true, 130.00m, "/img/kitaplar/kitap_49.jpg", 4, "Bir Ömür Nasıl Yaşanır?", 288, 50, "Kronik Kitap", 10, false },
                    { 50, "İlber Ortaylı'nın kaleminden, Mustafa Kemal Atatürk'ün askeri dehasını, vizyonunu, Cumhuriyet'i kurarken verdiği siyasi mücadeleleri tarihi belgeler ışığında anlatan muazzam biyografi.", 2018, true, 195.00m, "/img/kitaplar/kitap_50.jpg", 4, "Gazi Mustafa Kemal Atatürk", 480, 50, "Kronik Kitap", 10, true }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kaydedilenler_KitapId",
                table: "Kaydedilenler",
                column: "KitapId");

            migrationBuilder.CreateIndex(
                name: "IX_Kaydedilenler_KullaniciId",
                table: "Kaydedilenler",
                column: "KullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX_Kirtasiyeler_KategoriId",
                table: "Kirtasiyeler",
                column: "KategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_Kitaplar_KategoriId",
                table: "Kitaplar",
                column: "KategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_Kitaplar_YazarId",
                table: "Kitaplar",
                column: "YazarId");

            migrationBuilder.CreateIndex(
                name: "UQ__Kullanic__A9D1053422C2AF0E",
                table: "Kullanicilar",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Oyuncaklar_KategoriId",
                table: "Oyuncaklar",
                column: "KategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_SiparisDetaylari_KitapId",
                table: "SiparisDetaylari",
                column: "KitapId");

            migrationBuilder.CreateIndex(
                name: "IX_SiparisDetaylari_SiparisId",
                table: "SiparisDetaylari",
                column: "SiparisId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adresler");

            migrationBuilder.DropTable(
                name: "Kartlar");

            migrationBuilder.DropTable(
                name: "Kaydedilenler");

            migrationBuilder.DropTable(
                name: "Kirtasiyeler");

            migrationBuilder.DropTable(
                name: "Oyuncaklar");

            migrationBuilder.DropTable(
                name: "SiparisDetaylari");

            migrationBuilder.DropTable(
                name: "Kullanicilar");

            migrationBuilder.DropTable(
                name: "Kitaplar");

            migrationBuilder.DropTable(
                name: "Siparisler");

            migrationBuilder.DropTable(
                name: "Kategoriler");

            migrationBuilder.DropTable(
                name: "Yazarlar");
        }
    }
}

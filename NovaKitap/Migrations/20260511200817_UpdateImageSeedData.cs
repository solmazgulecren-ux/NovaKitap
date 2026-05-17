using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NovaKitap.Migrations
{
    /// <inheritdoc />
    public partial class UpdateImageSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Kategoriler",
                columns: new[] { "KategoriId", "IkonSifi", "KategoriAdi" },
                values: new object[,]
                {
                    { 1004, "✧", "Dünya Klasikleri" },
                    { 1005, "✧", "Türk Edebiyatı" },
                    { 1006, "✧", "Bilim Kurgu" },
                    { 1007, "✧", "Macera" },
                    { 1008, "✧", "Araştırma" },
                    { 1009, "✧", "Kişisel Gelişim" }
                });

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 1,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/NovaKlasikCizgiliDefter.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 2,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/NovaYildizliCizgisizDefter.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 3,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/KareliSpiralliDefterA5Mopak.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 4,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/DeriKaplEskizDefteriMoleskine.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 5,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/NoktaliBulletJournalMattNotebook.webp");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 6,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/SertKapakliAjanda2026EceAjandas.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 7,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/Mzik(Porte)DefteriGipta.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 8,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/GuzelYazi(Kaligrafi)DefteriMopak.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 9,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/GeriDonusumluKraftDefterKeskinColor.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 10,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/SpiralliResimDefteriAlexSchoeller.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 11,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/KilitliHatiraDefteriNoki.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 12,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/A4KareliBloknotGipta.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 13,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/A5CizgiliBloknotGipta.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 14,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/NovaSiyahYaprakliDefter.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 15,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/CiltliAkademikDefterKeskinColor.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 16,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/KucukBoyCepDefteriMoleskine.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 17,
                column: "KapakResimUrl",
                value: "/img/KirtasiyeVeOyuncakResimleri/SuluBoyaDefteri100PamukCanson.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 18,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/NovaPremiumCizgisizDefter.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 19,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/MermerDesenliDefterKeskinColor.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 20,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/HaritaMetodDefteriMopak.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 21,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/MekanikKursunKalem0.7mmRotring.png");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 22,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/ProfesyonelCizimKalemSetiFaberCastell.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 23,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/TukenmezKalemMavi50liKutuBic.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 24,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/KlasikDolmaKalemSiyahLamy.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 25,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/JelmzaKalemiMaviUniball.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 26,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/UcluKalem0.5mmPastelFaberCastell.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 27,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/KirmiziKopyaKalemiFatih.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 28,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/FosforluKalemSeti4lStabilo.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 29,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/KeceliKalem12liSetCarioca.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 30,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/Fineliner04mmInceUcluKalem.png");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 31,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/BeyazJelKalem.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 32,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/KaligrafiKalemiKesikUclu.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 33,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/AsetatKalemiSInce.png");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 34,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/BeyazTahtaKalemiDoldurulabilir.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 35,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/SinavKalemi2B.png");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 36,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/MetalikRenkliJelKalemSeti.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 37,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/DolmaKalemMurekkebi30ml.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 38,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/07mmKalemUcuMin3lu.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 39,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/CokRenkliTukenmezKalem4in1.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 40,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/SilinebilirTukenmezKalem.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 41,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/VersatilKalem20mm.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 42,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/AltinUcluPrestijDolmaKalem.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 43,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/UcluKalem09mm.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 44,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/CiftUcluKaligrafiMarkerSeti.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 45,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/RollerKalemIgneUclu.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 46,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/PermanentMarkerSiyahKalin.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 47,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/PastelRenkFosforluKalemSeti.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 48,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/KuruBoyaSeti24luMetalKutu.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 49,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/TukenmezKalemOzelSeri.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 50,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/CamBoyamaKalemi.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 51,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/SuluBoyaSeti12RenkTablet.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 52,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/AkrilikBoyaSeti6x75ml.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 53,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/GuajBoyaSeti10Renk.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 54,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/YagliBoya200mlTitanyumBeyazi.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 55,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/FircaSetiSentetikUclu5li.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 56,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/KuruPastelSeti24Renk.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 57,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/YagliPastelSeti12Renk.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 58,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/AhsapKaristirmaPaleti.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 59,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/MasaustuAhsapSovale.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 60,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/Tuval35x50cmPamuklu.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 61,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/ResimKagidiDuraliti.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 62,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/SanatsalSungerSeti.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 63,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/KomurKalemFuzenSeti.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 64,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/HamurSilgi.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 65,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/FixativeSpreySabitleyici.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 66,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/KetenTuval50x70cm.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 67,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/SuluBoyaFircasiSuHazneli.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 68,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/LinerKilFircaNumara000.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 69,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/BoyaIncelticiKokusuzTerebentin.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 70,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/KumasBoyasi6liSet.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 71,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/DeriPostaciCantasi.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 72,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/AnaokuluCantasiCekcekli.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 73,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/BezCanta(Tote Bag)NovaLogolu.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 74,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/MetalKalemlikKutusu.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 75,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/SeffafFileKalemlik.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 76,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/RuloBezKalemlik.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 77,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/SilikonMuzKalemlik.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 78,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/3BolmeliKalemCantasi.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 79,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/LaptopEvrakCantasiInce.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 80,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/MasaustuAhsapKalemlik.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 81,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/SuniDeriKalemKilifi.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 82,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/KatlanabilirAlsverisCantasi.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 83,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/SeffafCizimTupuProjeCantasi.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 84,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/CiftSapliResimCantasi(Portfolyo).jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 85,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/A4KraftDosyaKlasoru.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 86,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/PosetDosya100luPaket.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 87,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/TelliSunumDosyasi.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 88,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/YapiskanliNotKagidiPostItSari.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 89,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/SayfaAyracBandi5Renk.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 90,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/KlasikBeyazSilgiSinavTipi.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 91,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/MetalCiftDelikliKalemtras.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 92,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/HazneliMasaustuKalemtras.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 93,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/Atas100luKutu.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 94,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/KucukZimbaMakinesi.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 95,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/A4FotokopiKagidi500luTop.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 96,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/SeffafKoliBandi.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 97,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/CiftTarafliBant.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 98,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/CelikCetvel30cm.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 99,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/SeritSiliciDaksil.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 100,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/UzayTemaliSirtCantasi.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1,
                column: "KapakResimUrl",
                value: "/img/kitaplar/suc_ve_ceza.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 2,
                column: "KapakResimUrl",
                value: "/img/kitaplar/Karamazov Kardeşler.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 3,
                column: "KapakResimUrl",
                value: "/img/kitaplar/Sefiller.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 4,
                column: "KapakResimUrl",
                value: "/img/kitaplar/SavasSanati.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 5,
                column: "KapakResimUrl",
                value: "/img/kitaplar/Anna Karenina.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 6,
                column: "KapakResimUrl",
                value: "/img/kitaplar/gururveonyargi.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 7,
                column: "KapakResimUrl",
                value: "/img/kitaplar/OlulerEvindenAnilar.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 8,
                column: "KapakResimUrl",
                value: "/img/kitaplar/Kumarbaz.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 9,
                column: "KapakResimUrl",
                value: "/img/kitaplar/George Orwell 1984.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 10,
                column: "KapakResimUrl",
                value: "/img/kitaplar/HaniminCiftligi.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 11,
                column: "KapakResimUrl",
                value: "/img/kitaplar/Kürk Mantolu Madonna.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 12,
                column: "KapakResimUrl",
                value: "/img/kitaplar/KirmiziKitap.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 13,
                column: "KapakResimUrl",
                value: "/img/kitaplar/Buyukuyku.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 14,
                column: "KapakResimUrl",
                value: "/img/kitaplar/satranc.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 16,
                column: "KapakResimUrl",
                value: "/img/kitaplar/Donusum.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 17,
                column: "KapakResimUrl",
                value: "/img/kitaplar/Dava.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 18,
                column: "KapakResimUrl",
                value: "/img/kitaplar/saatleridurdurmaenstitusu.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 19,
                column: "KapakResimUrl",
                value: "/img/kitaplar/RuhUzerine.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 20,
                column: "KapakResimUrl",
                value: "/img/kitaplar/Ölü Canlar.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 21,
                column: "KapakResimUrl",
                value: "/img/kitaplar/TehlikeliOyunlar.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 22,
                column: "KapakResimUrl",
                value: "/img/kitaplar/Yabanci.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 23,
                column: "KapakResimUrl",
                value: "/img/kitaplar/Veba.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 24,
                column: "KapakResimUrl",
                value: "/img/kitaplar/denzleraltndayrmbnfersah.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 25,
                column: "KapakResimUrl",
                value: "/img/kitaplar/seksengundedevrialem.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 26,
                column: "KapakResimUrl",
                value: "/img/kitaplar/AmokKosucusu.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 27,
                column: "KapakResimUrl",
                value: "/img/kitaplar/OnKisiydiler.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 28,
                column: "KapakResimUrl",
                value: "/img/kitaplar/DoguEkspresindeCinayet.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 29,
                column: "KapakResimUrl",
                value: "/img/kitaplar/RogerAckroydCinayeti.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 30,
                column: "KapakResimUrl",
                value: "/img/kitaplar/NildeOlum.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 31,
                column: "KapakResimUrl",
                value: "/img/kitaplar/SherlockHolmesKzlSorusturma.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 32,
                column: "KapakResimUrl",
                value: "/img/kitaplar/SherlockHolmesDortlerinmzasi.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 33,
                column: "KapakResimUrl",
                value: "/img/kitaplar/BaskervillelerinKopegi.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 34,
                column: "KapakResimUrl",
                value: "/img/kitaplar/DuslerinYorumu.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 35,
                column: "KapakResimUrl",
                value: "/img/kitaplar/UygarlığınHuzursuzluğu.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 36,
                column: "KapakResimUrl",
                value: "/img/kitaplar/GundelikHayatinPsikopatolojisi.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 37,
                column: "KapakResimUrl",
                value: "/img/kitaplar/InsanRuhunaYonelis.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 38,
                column: "KapakResimUrl",
                value: "/img/kitaplar/KesfedilmemisBenlik.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 39,
                column: "KapakResimUrl",
                value: "/img/kitaplar/KirmiziKitap.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 40,
                column: "KapakResimUrl",
                value: "/img/kitaplar/BoyleSoylediZerdust.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 41,
                column: "KapakResimUrl",
                value: "/img/kitaplar/IyiliginveKotulugunOtesinde.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 42,
                column: "KapakResimUrl",
                value: "/img/kitaplar/PutlarinAlacakaranlg.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 43,
                column: "KapakResimUrl",
                value: "/img/kitaplar/KendimeDusunceler.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 44,
                column: "KapakResimUrl",
                value: "/img/kitaplar/SisifosSoyleni.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 45,
                column: "KapakResimUrl",
                value: "/img/kitaplar/BaskaldiranInsan.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 46,
                column: "KapakResimUrl",
                value: "/img/kitaplar/SapiensHayvanlardanTanrilara.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 47,
                column: "KapakResimUrl",
                value: "/img/kitaplar/HomoDeusYarininKisaTarihi.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 48,
                column: "KapakResimUrl",
                value: "/img/kitaplar/21YuzyilIcin21Ders.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 49,
                column: "KapakResimUrl",
                value: "/img/kitaplar/BirOmurNasilYasanir.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 50,
                column: "KapakResimUrl",
                value: "/img/kitaplar/GaziMustafaKemalAtaturk.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 1,
                column: "KapakResimUrl",
                value: "/img/oyuncak/LEGOCityPolisstasyonuLEGO.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 2,
                column: "KapakResimUrl",
                value: "/img/oyuncak/BarbieSonsuzHareketBebegiMattel.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 3,
                column: "KapakResimUrl",
                value: "/img/oyuncak/HotWheels50liArabaSetiHotWheels.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 4,
                column: "KapakResimUrl",
                value: "/img/oyuncak/MonopolyDijitalBankacilikHasbro.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 5,
                column: "KapakResimUrl",
                value: "/img/oyuncak/NerfUltraOneNerf.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 6,
                column: "KapakResimUrl",
                value: "/img/oyuncak/FisherPriceEgiticiTabletFisherPrice.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 7,
                column: "KapakResimUrl",
                value: "/img/oyuncak/PlayDohMutfakAtolyesiHasbro.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 8,
                column: "KapakResimUrl",
                value: "/img/oyuncak/ScrabbleJuniorMattel.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 9,
                column: "KapakResimUrl",
                value: "/img/oyuncak/RemoteControlRockCrawlerMaisto.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 10,
                column: "KapakResimUrl",
                value: "/img/oyuncak/ClementoniRobotikLaboratuvariClementoni.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 11,
                column: "KapakResimUrl",
                value: "/img/oyuncak/StarWarsMillenniumFalconLEGOLEGO.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 12,
                column: "KapakResimUrl",
                value: "/img/oyuncak/LOLSurpriseOMGBebekMGA.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 13,
                column: "KapakResimUrl",
                value: "/img/oyuncak/TransformersOptimusPrimeHasbro.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 14,
                column: "KapakResimUrl",
                value: "/img/oyuncak/ManyetikSatrancTakimiStarGames.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 15,
                column: "KapakResimUrl",
                value: "/img/oyuncak/PelusAyiNova100cmNovaToys.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 16,
                column: "KapakResimUrl",
                value: "/img/oyuncak/UnoKartOyunuMattel.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 17,
                column: "KapakResimUrl",
                value: "/img/oyuncak/Puzzle1000ParcaGalaksiAnatolian.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 18,
                column: "KapakResimUrl",
                value: "/img/oyuncak/AhsapMutfakSetiWoody.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 19,
                column: "KapakResimUrl",
                value: "/img/oyuncak/MarvelSpiderManFigurHasbro.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 20,
                column: "KapakResimUrl",
                value: "/img/oyuncak/BabyAliveMamaYiyenBebekHasbro.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 21,
                column: "KapakResimUrl",
                value: "/img/oyuncak/HatchimalsPixiesSpinMaster.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 22,
                column: "KapakResimUrl",
                value: "/img/oyuncak/ThomasFriendsTrenSetiFisherPrice.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 23,
                column: "KapakResimUrl",
                value: "/img/oyuncak/EnchantimalsBebekveHayvaniMattel.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 24,
                column: "KapakResimUrl",
                value: "/img/oyuncak/JengaKlasikHasbro.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 25,
                column: "KapakResimUrl",
                value: "/img/oyuncak/SlimeDevYapimSetiNovaFun.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 26,
                column: "KapakResimUrl",
                value: "/img/oyuncak/GnesSistemiMaketKitiSciencePlay.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 27,
                column: "KapakResimUrl",
                value: "/img/oyuncak/PilliIskliKemanMusicStar.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 28,
                column: "KapakResimUrl",
                value: "/img/oyuncak/TabuXLHasbro.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 29,
                column: "KapakResimUrl",
                value: "/img/oyuncak/RiskStratejiOyunuHasbro.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 30,
                column: "KapakResimUrl",
                value: "/img/oyuncak/DuyusalKumSeti2kgSandMagic.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 31,
                column: "KapakResimUrl",
                value: "/img/oyuncak/Frozen2ElsaKostumuDisney.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 32,
                column: "KapakResimUrl",
                value: "/img/oyuncak/EgiticiSayilarAbakusuWoody.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 33,
                column: "KapakResimUrl",
                value: "/img/oyuncak/WalkieTalkieTelsizSetiSpyKit.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 34,
                column: "KapakResimUrl",
                value: "/img/oyuncak/LegoTechnicYarsArabasiLEGO.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 35,
                column: "KapakResimUrl",
                value: "/img/oyuncak/BuyukBoyYaziTahtasiNovaArt.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 36,
                column: "KapakResimUrl",
                value: "/img/oyuncak/MinecraftSteveFigurSetiMattel.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 37,
                column: "KapakResimUrl",
                value: "/img/oyuncak/TrivialPursuitAileBoyuHasbro.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 38,
                column: "KapakResimUrl",
                value: "/img/oyuncak/PilsanAkuluAraba12VPilsan.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 39,
                column: "KapakResimUrl",
                value: "/img/oyuncak/TwisterEglenceMatiHasbro.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 40,
                column: "KapakResimUrl",
                value: "/img/oyuncak/DoktorSetiCantaliToyMed.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 41,
                column: "KapakResimUrl",
                value: "/img/oyuncak/LegoDuploHayvanCiftligiLEGO.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 42,
                column: "KapakResimUrl",
                value: "/img/oyuncak/BatmanBatmobileAracDCComics.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 43,
                column: "KapakResimUrl",
                value: "/img/oyuncak/BarbieVeterinerSetiMattel.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 44,
                column: "KapakResimUrl",
                value: "/img/oyuncak/SuperDoktorOyunuHasbro.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 45,
                column: "KapakResimUrl",
                value: "/img/oyuncak/KNexMhendislikSetiKNex.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 46,
                column: "KapakResimUrl",
                value: "/img/oyuncak/KizKulesiMaketiWoody.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 47,
                column: "KapakResimUrl",
                value: "/img/oyuncak/VahsiHayvanlarFigurSetiWildLife.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 48,
                column: "KapakResimUrl",
                value: "/img/oyuncak/TeleskopBaslangcSetiSciencePlay.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 49,
                column: "KapakResimUrl",
                value: "/img/oyuncak/BratzRetroBebekMGA.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 50,
                column: "KapakResimUrl",
                value: "/img/oyuncak/Domino100ParcaRenkliWoody.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 51,
                column: "KapakResimUrl",
                value: "/img/oyuncak/LegoNinjagoEjderhaSetiLEGO.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 52,
                column: "KapakResimUrl",
                value: "/img/oyuncak/DisneyPrincessSatoDisney.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 53,
                column: "KapakResimUrl",
                value: "/img/oyuncak/HotWheelsSehirMacerasiHotWheels.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 54,
                column: "KapakResimUrl",
                value: "/img/oyuncak/CatanMasaOyunuKosmos.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 55,
                column: "KapakResimUrl",
                value: "/img/oyuncak/BakuganBaslangicPaketiSpinMaster.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 56,
                column: "KapakResimUrl",
                value: "/img/oyuncak/PawPatrolDevDevriyeAraciSpinMaster.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 57,
                column: "KapakResimUrl",
                value: "/img/oyuncak/PilsanLegoMasaSetiPilsan.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 58,
                column: "KapakResimUrl",
                value: "/img/oyuncak/HarryPotterAsa(Isikli)WizardWorld.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 59,
                column: "KapakResimUrl",
                value: "/img/oyuncak/SquishmallowsYumusakYastikKellytoy.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 60,
                column: "KapakResimUrl",
                value: "/img/oyuncak/GuessWho(BilBakalimKim)Hasbro.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 61,
                column: "KapakResimUrl",
                value: "/img/oyuncak/LegoFriendsKafeSetiLEGO.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 62,
                column: "KapakResimUrl",
                value: "/img/oyuncak/MagicMixiesSihirliKazanMooseToys.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 63,
                column: "KapakResimUrl",
                value: "/img/oyuncak/HotWheelsRenkDegistirenlerHotWheels.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 64,
                column: "KapakResimUrl",
                value: "/img/oyuncak/MikroskopSeti(1200x)SciencePlay.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 65,
                column: "KapakResimUrl",
                value: "/img/oyuncak/BarbieDreamtopiaDenizkiziMattel.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 66,
                column: "KapakResimUrl",
                value: "/img/oyuncak/CluedoDedektiflikOyunuHasbro.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 67,
                column: "KapakResimUrl",
                value: "/img/oyuncak/LegoStarWarsBobaFettLEGO.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 68,
                column: "KapakResimUrl",
                value: "/img/oyuncak/PokemonBattleFigure3PackJazwares.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 69,
                column: "KapakResimUrl",
                value: "/img/oyuncak/KayipKelimelerHeceOyunuEgiticiDnya.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 70,
                column: "KapakResimUrl",
                value: "/img/oyuncak/BuyukBoyBasketbolPotasiSporty.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 71,
                column: "KapakResimUrl",
                value: "/img/oyuncak/LegoMinecraftKaleSavasiLEGO.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 72,
                column: "KapakResimUrl",
                value: "/img/oyuncak/BarbieGardiropSetiMattel.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 73,
                column: "KapakResimUrl",
                value: "/img/oyuncak/PlaymobilKorsanGemisiPlaymobil.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 74,
                column: "KapakResimUrl",
                value: "/img/oyuncak/CarcassonneStratejiOyunuZManGames.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 75,
                column: "KapakResimUrl",
                value: "/img/oyuncak/UcanHelikopter(Sensorlu)TechToys.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 76,
                column: "KapakResimUrl",
                value: "/img/oyuncak/DisneyCarsSimsekMcQueenMattel.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 77,
                column: "KapakResimUrl",
                value: "/img/oyuncak/FurRealSevimliAyicikHasbro.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 78,
                column: "KapakResimUrl",
                value: "/img/oyuncak/AmiralBattiKlasikOyunuHasbro.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 79,
                column: "KapakResimUrl",
                value: "/img/oyuncak/LegoTechnicKepceLEGO.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 80,
                column: "KapakResimUrl",
                value: "/img/oyuncak/GlowintheDarkSlimeKitNovaFun.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 81,
                column: "KapakResimUrl",
                value: "/img/oyuncak/NerfFortniteBlasterNerf.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 82,
                column: "KapakResimUrl",
                value: "/img/oyuncak/BarbieTatilVillasiMattel.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 83,
                column: "KapakResimUrl",
                value: "/img/oyuncak/HotWheelsAkrobasiSetiHotWheels.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 84,
                column: "KapakResimUrl",
                value: "/img/oyuncak/StrategoSavasOyunuJumbo.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 85,
                column: "KapakResimUrl",
                value: "/img/oyuncak/ManyetikBloklar100ParcaMagnaTiles.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 86,
                column: "KapakResimUrl",
                value: "/img/oyuncak/TalkingTomInteraktifKediDragonI.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 87,
                column: "KapakResimUrl",
                value: "/img/oyuncak/AhsapBlokTrenWoody.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 88,
                column: "KapakResimUrl",
                value: "/img/oyuncak/OkculukSeti(Vantuzlu)Sporty.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 89,
                column: "KapakResimUrl",
                value: "/img/oyuncak/BarbieSpaGunuBebekMattel.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 90,
                column: "KapakResimUrl",
                value: "/img/oyuncak/LegoClassicPencerelerPaketiLEGO.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 91,
                column: "KapakResimUrl",
                value: "/img/oyuncak/MyLittlePonyIsikliFigurHasbro.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 92,
                column: "KapakResimUrl",
                value: "/img/oyuncak/AirHockeyMasaustuFunGames.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 93,
                column: "KapakResimUrl",
                value: "/img/oyuncak/CizimTableti(LCDYaz)TechToys.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 94,
                column: "KapakResimUrl",
                value: "/img/oyuncak/PollyPocketSatoCantasiMattel.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 95,
                column: "KapakResimUrl",
                value: "/img/oyuncak/HulkAksiyonFigur30cmHasbro.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 96,
                column: "KapakResimUrl",
                value: "/img/oyuncak/RiskGameofThronesEditionHasbro.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 97,
                column: "KapakResimUrl",
                value: "/img/oyuncak/GitarBaslangicSetiMusicStar.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 98,
                column: "KapakResimUrl",
                value: "/img/oyuncak/LegoCreator31AradaKusLEGO.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 99,
                column: "KapakResimUrl",
                value: "/img/oyuncak/MikadoCubuklariDevBoyFunGames.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 100,
                column: "KapakResimUrl",
                value: "/img/oyuncak/RubikKubu3x3OrijinalRubik.jpg.jpeg");

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 1,
                column: "Biyografi",
                value: "Rus edebiyatının devi.");

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 2,
                column: "Biyografi",
                value: "Distopya ustası.");

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 3,
                column: "Biyografi",
                value: "Türk edebiyatının usta kalemi.");

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 4,
                column: "Biyografi",
                value: "Biyografi ve roman yazarı.");

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 5,
                column: "Biyografi",
                value: "Modern edebiyatın öncüsü.");

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 6,
                column: "Biyografi",
                value: "Polisiye kraliçesi.");

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 7,
                column: "Biyografi",
                value: "Fransız romantik yazar.");

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 8,
                column: "Biyografi",
                value: "Psikanaliz kurucusu.");

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 9,
                column: "Biyografi",
                value: "Alman filozof.");

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 10,
                column: "Biyografi",
                value: "Türk tarihçi.");

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 11,
                column: "Biyografi",
                value: "Türk romancı.");

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 12,
                column: "Biyografi",
                value: "Postmodern yazar.");

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 13,
                column: "Biyografi",
                value: "Varoluşçu yazar.");

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 14,
                column: "Biyografi",
                value: "Gerçekçi Rus yazar.");

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 15,
                column: "Biyografi",
                value: "Sherlock Holmes yaratıcısı.");

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 16,
                column: "Biyografi",
                value: "Tarihçi ve yazar.");

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 17,
                column: "Biyografi",
                value: "Stoacı imparator.");

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 18,
                column: "Biyografi",
                value: "Bilimkurgu babası.");

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 19,
                column: "Biyografi",
                value: "İngiliz romancı.");

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 20,
                column: "Biyografi",
                value: "Analitik psikoloji.");

            migrationBuilder.InsertData(
                table: "Yazarlar",
                columns: new[] { "YazarId", "AdSoyad", "Biyografi" },
                values: new object[,]
                {
                    { 21, "Nikolay Gogol", "Rus yazar." },
                    { 22, "R. L. Stevenson", "İngiliz yazar." },
                    { 23, "Oscar Wilde", "İrlandalı yazar ve şair." },
                    { 24, "Charles Dickens", "İngiliz yazar." },
                    { 25, "Jonathan Swift", "İrlandalı yazar." },
                    { 26, "Antoine de Saint-Exupery", "Fransız pilot ve yazar." },
                    { 27, "Paulo Coelho", "Brezilyalı yazar." },
                    { 28, "Jose Saramago", "Portekizli yazar." },
                    { 29, "John Steinbeck", "Amerikalı yazar." },
                    { 30, "H.G. Wells", "İngiliz bilim kurgu yazarı." },
                    { 31, "Isaac Asimov", "Amerikalı bilim kurgu yazarı." },
                    { 32, "Arthur C. Clarke", "İngiliz bilim kurgu yazarı." },
                    { 33, "Alfred Bester", "Amerikalı bilim kurgu yazarı." },
                    { 34, "Ursula K. Le Guin", "Amerikalı fantastik kurgu yazarı." },
                    { 35, "Anthony Burgess", "İngiliz yazar." },
                    { 36, "Margaret Atwood", "Kanadalı yazar." },
                    { 37, "Pierre Boulle", "Fransız yazar." },
                    { 38, "Mary Shelley", "İngiliz yazar." },
                    { 39, "Bram Stoker", "İrlandalı yazar." },
                    { 40, "Matt Haig", "İngiliz yazar." },
                    { 41, "Halid Ziya Uşaklıgil", "Türk yazar." },
                    { 42, "Mehmet Rauf", "Türk yazar." },
                    { 43, "Peyami Safa", "Türk romancı ve gazeteci." },
                    { 44, "Vedat Türkali", "Türk senarist ve romancı." },
                    { 45, "Kemal Tahir", "Türk yazar." },
                    { 46, "Yusuf Atılgan", "Türk roman ustası." },
                    { 47, "Orhan Kemal", "Toplumcu gerçekçi yazar." },
                    { 48, "Fakir Baykurt", "Türk öğretmen ve yazar." },
                    { 49, "Mustafa Kemal Atatürk", "Türkiye Cumhuriyeti'nin kurucusu." },
                    { 50, "Sun Tzu", "Çinli komutan ve filozof." },
                    { 51, "Mevlana", "Mutasavvıf düşünür." },
                    { 52, "Ömer Hayyam", "İranlı şair ve bilim insanı." },
                    { 53, "Arthur Schopenhauer", "Alman filozof." },
                    { 54, "Platon", "Antik Yunan filozofu." },
                    { 55, "Aristoteles", "Antik Yunan filozofu." },
                    { 56, "Robin Sharma", "Kişisel gelişim yazarı." },
                    { 57, "Don Miguel Ruiz", "Toltek bilgesi ve yazar." },
                    { 58, "Eckhart Tolle", "Ruhsal öğretmen ve yazar." },
                    { 59, "Mark Manson", "Amerikalı yazar." },
                    { 60, "Malcolm Gladwell", "Kanadalı gazeteci ve yazar." },
                    { 61, "Louise Hay", "Motivasyon yazarı." },
                    { 62, "Benjamin Graham", "Amerikalı ekonomist." },
                    { 63, "Ashlee Vance", "Amerikalı köşe yazarı." },
                    { 64, "Walter Isaacson", "Biyografi yazarı." },
                    { 65, "Robert Pirsig", "Amerikalı yazar ve filozof." },
                    { 66, "Roy Baumeister", "Sosyal psikolog." },
                    { 67, "Italo Calvino", "İtalyan yazar." },
                    { 68, "Frank Herbert", "Amerikalı yazar." },
                    { 69, "Jose Mauro de Vasconcelos", "Brezilyalı yazar." },
                    { 70, "Harper Lee", "Amerikalı yazar." },
                    { 71, "J.D. Salinger", "Amerikalı yazar." },
                    { 72, "Vladimir Nabokov", "Rus-Amerikalı yazar." },
                    { 73, "Daphne du Maurier", "İngiliz romancı." },
                    { 74, "Ernest Hemingway", "Amerikalı yazar ve gazeteci." },
                    { 75, "Anne Frank", "Alman-Yahudi günlük yazarı." },
                    { 76, "Louisa May Alcott", "Amerikalı romancı." },
                    { 77, "Charlotte Bronte", "İngiliz romancı." },
                    { 78, "Jack London", "Amerikalı yazar." },
                    { 79, "Stendhal", "Fransız gerçekçi yazar." },
                    { 80, "İvan Gonçarov", "Rus romancı." },
                    { 81, "Charles Bukowski", "Amerikalı yazar ve şair." },
                    { 82, "Sadık Hidayet", "İranlı yazar." },
                    { 83, "Goethe", "Alman edebiyatçı." },
                    { 84, "Alexandre Dumas", "Fransız yazar." },
                    { 85, "Montaigne", "Fransız deneme yazarı." },
                    { 86, "Thomas Hobbes", "İngiliz filozof." },
                    { 87, "Simone de Beauvoir", "Fransız yazar ve filozof." },
                    { 88, "Rousseau", "Cenevreli filozof." },
                    { 89, "Wittgenstein", "Avusturyalı filozof." },
                    { 90, "Jean-Paul Sartre", "Fransız varoluşçu filozof." },
                    { 91, "Jules Payot", "Fransız eğitimci." },
                    { 92, "Cal Newport", "Akademisyen ve yazar." },
                    { 93, "Napoleon Hill", "Kişisel başarı yazarı." },
                    { 94, "Hal Elrod", "Motivasyon konuşmacısı." },
                    { 95, "Mihaly Csikszentmihalyi", "Psikolog." },
                    { 96, "Ben Horowitz", "Girişimci ve yazar." },
                    { 97, "William James", "Amerikalı psikolog." },
                    { 98, "David Burns", "Psikiyatrist ve yazar." },
                    { 99, "Edgar Allan Poe", "Amerikalı şair ve yazar." },
                    { 100, "Dashiell Hammett", "Amerikalı yazar." },
                    { 101, "Raymond Chandler", "Polisiye romancı." },
                    { 102, "Umberto Eco", "İtalyan yazar ve göstergebilimci." },
                    { 103, "Dan Brown", "Amerikalı gerilim yazarı." },
                    { 104, "Michael Connelly", "Polisiye romancı." },
                    { 105, "Jeffery Deaver", "Amerikalı gizem yazarı." },
                    { 106, "Stephen King", "Gerilim ve korku ustası." },
                    { 107, "Herman Melville", "Amerikalı yazar." },
                    { 108, "Emily Bronte", "İngiliz romancı." },
                    { 109, "Hermann Hesse", "Alman-İsviçreli yazar." },
                    { 110, "Richard Bach", "Amerikalı yazar." },
                    { 111, "Daniel Defoe", "İngiliz gazeteci ve romancı." },
                    { 112, "Mark Twain", "Amerikalı mizahçı ve yazar." },
                    { 113, "Ferenc Molnar", "Macar oyun yazarı." },
                    { 114, "William Golding", "İngiliz romancı." },
                    { 115, "Salman Rushdie", "Hint asıllı İngiliz yazar." },
                    { 116, "Khaled Hosseini", "Afgan asıllı Amerikalı yazar." },
                    { 117, "Yann Martel", "Kanadalı yazar." },
                    { 118, "Nikos Kazancakis", "Yunan yazar." },
                    { 119, "Alain de Botton", "İsviçreli yazar ve filozof." },
                    { 120, "Soren Kierkegaard", "Danimarkalı filozof." },
                    { 121, "Cicero", "Romalı filozof." },
                    { 122, "Seneca", "Romalı Stoacı düşünür." },
                    { 123, "Joshua Fields Millburn", "Amerikalı yazar." },
                    { 124, "Charles Duhigg", "Amerikalı yazar." },
                    { 125, "Gary Keller", "Girişimci ve yazar." },
                    { 126, "Tim Ferriss", "Yatırımcı ve yazar." },
                    { 127, "Keith Ferrazzi", "Yazar ve girişimci." },
                    { 128, "Kai-Fu Lee", "Tayvanlı bilgisayar bilimcisi." },
                    { 129, "Bessel van der Kolk", "Psikiyatrist." },
                    { 130, "Roman Krznaric", "Kültür düşünürü." },
                    { 131, "Mickey Spillane", "Amerikalı suç yazarı." },
                    { 132, "Gillian Flynn", "Amerikalı yazar." },
                    { 133, "Paula Hawkins", "İngiliz romancı." },
                    { 134, "Alex Michaelides", "Kıbrıslı-İngiliz yazar." },
                    { 135, "Sue Grafton", "Dedektif romanları yazarı." },
                    { 136, "Jean-Christophe Grange", "Fransız romancı." },
                    { 137, "Charlaine Harris", "Amerikalı romancı." },
                    { 138, "F. Scott Fitzgerald", "Amerikalı romancı." },
                    { 139, "Gabriel García Márquez", "Kolombiyalı romancı." }
                });

            migrationBuilder.InsertData(
                table: "Kitaplar",
                columns: new[] { "KitapId", "Aciklama", "BasimYili", "CokSatanMi", "Fiyat", "KapakResimUrl", "KategoriId", "KitapAdi", "SayfaSayisi", "StokAdedi", "Yayinevi", "YazarId", "YeniCikanMi" },
                values: new object[,]
                {
                    { 1180, "Küçük Zeze'nin duygusal büyüme hikayesi.", null, true, 135.00m, "/img/kitaplar/OtomatikPortakal.jpg", 1004, "Şeker Portakalı", null, 50, "Nova Kitap", 69, false },
                    { 1181, "Adalet ve ırkçılık üzerine unutulmaz roman.", null, false, 180.00m, "/img/kitaplar/MutluOlum.jpg", 1004, "Bülbülü Öldürmek", null, 50, "Nova Kitap", 70, false },
                    { 1182, "Gençlik bunalımı ve yabancılaşma hikayesi.", null, true, 155.00m, "/img/kitaplar/geceyarisicocuklari.jpg", 1004, "Çavdar Tarlasında Çocuklar", null, 50, "Nova Kitap", 71, false },
                    { 1183, "Takıntılı bir aşkın çarpıcı anlatımı.", null, false, 190.00m, "/img/kitaplar/Politika.jpg", 1004, "Lolita", null, 50, "Nova Kitap", 72, false },
                    { 1184, "Gotik atmosferli psikolojik gerilim romanı.", null, false, 165.00m, "/img/kitaplar/Veba.jpg", 1004, "Rebecca", null, 50, "Nova Kitap", 73, false },
                    { 1185, "Kayıp kuşağın Avrupa macerası.", null, false, 170.00m, "/img/kitaplar/kitap_1185.jpg", 1004, "Güneş de Doğar", null, 50, "Nova Kitap", 74, false },
                    { 1186, "Savaşın ortasında yaşanan trajik aşk.", null, false, 160.00m, "/img/kitaplar/ucSilahsorler.jpg", 1004, "Silahlara Veda", null, 50, "Nova Kitap", 74, false },
                    { 1187, "Bir balıkçının doğayla mücadelesi.", null, true, 125.00m, "/img/kitaplar/AslaYalnizYeme.jpg", 1004, "Yaşlı Adam ve Deniz", null, 50, "Nova Kitap", 74, false },
                    { 1188, "Savaş yıllarında bir genç kızın günlüğü.", null, false, 145.00m, "/img/kitaplar/YarınınKısaBirTarihi.jpg", 1004, "Anna Frank'ın Hatıra Defteri", null, 50, "Nova Kitap", 75, false },
                    { 1189, "Dört kız kardeşin büyüme hikayesi.", null, true, 150.00m, "/img/kitaplar/Ölü Canlar.jpg", 1004, "Küçük Kadınlar", null, 50, "Nova Kitap", 76, false },
                    { 1190, "Güçlü bir kadının bağımsızlık mücadelesi.", null, true, 175.00m, "/img/kitaplar/insanneileyasar.jpg", 1004, "Jane Eyre", null, 50, "Nova Kitap", 77, false },
                    { 1191, "Evlilik ve sosyal ilişkiler üzerine klasik roman.", null, false, 165.00m, "/img/kitaplar/Empati.jpg", 1004, "Emma", null, 50, "Nova Kitap", 19, false },
                    { 1192, "Vahşi doğada hayatta kalma öyküsü.", null, true, 140.00m, "/img/kitaplar/mobydick.jpg", 1004, "Beyaz Diş", null, 50, "Nova Kitap", 78, false },
                    { 1193, "Bir köpeğin içgüdülerine dönüş hikayesi.", null, false, 135.00m, "/img/kitaplar/sineklerintanrisi.jpg", 1004, "Vahşetin Çağrısı", null, 50, "Nova Kitap", 78, false },
                    { 1194, "Hırs ve aşk arasında kalan genç adamın hikayesi.", null, false, 185.00m, "/img/kitaplar/MaiveSiyah.jpg", 1004, "Kızıl ve Siyah", null, 50, "Nova Kitap", 79, false },
                    { 1195, "Tembellik ve toplum eleştirisi üzerine klasik eser.", null, true, 170.00m, "/img/kitaplar/kitap_1195.jpg", 1004, "Oblomov", null, 50, "Nova Kitap", 80, false },
                    { 1196, "Saf iyiliğin toplumdaki yeri üzerine roman.", null, true, 220.00m, "/img/kitaplar/Dracula.jpg", 1004, "Budala", null, 50, "Nova Kitap", 1, false },
                    { 1197, "Zorlu bir hayatın sert anlatımı.", null, false, 145.00m, "/img/kitaplar/defineadasi.jpg", 1004, "Ekmek Arası", null, 50, "Nova Kitap", 81, false },
                    { 1198, "Amerikan alt kültürüne mizahi bakış.", null, false, 150.00m, "/img/kitaplar/satranc.jpg", 1004, "Postane", null, 50, "Nova Kitap", 81, false },
                    { 1199, "Yazar olma hayali kuran bir denizcinin hikayesi.", null, true, 180.00m, "/img/kitaplar/marti.jpg", 1004, "Martin Eden", null, 50, "Nova Kitap", 78, false },
                    { 1200, "Modern İran edebiyatının kült romanı.", null, false, 130.00m, "/img/kitaplar/KorBaykus.jpg", 1004, "Kör Baykuş", null, 50, "Nova Kitap", 82, false },
                    { 1201, "İspanya İç Savaşı sırasında geçen dramatik roman.", null, true, 190.00m, "/img/kitaplar/canlarkmncncalyor.jpg", 1004, "Çanlar Kimin İçin Çalıyor", null, 50, "Nova Kitap", 74, false },
                    { 1202, "Karşılıksız aşkın trajik öyküsü.", null, false, 145.00m, "/img/kitaplar/gencwertherinacilari.jpg", 1004, "Genç Werther'in Acıları", null, 50, "Nova Kitap", 83, false },
                    { 1203, "İhanet ve intikam üzerine epik macera.", null, true, 240.00m, "/img/kitaplar/montekristokontu.jpg", 1004, "Monte Kristo Kontu", null, 50, "Nova Kitap", 84, false },
                    { 1204, "Onur ve dostluk dolu şövalyelik hikayesi.", null, false, 210.00m, "/img/kitaplar/ucSilahsorler.jpg", 1004, "Üç Silahşörler", null, 50, "Nova Kitap", 84, false },
                    { 1205, "Paris'te geçen dramatik aşk hikayesi.", null, true, 195.00m, "/img/kitaplar/notredameinkamburu.jpg", 1004, "Notre Dame'ın Kamburu", null, 50, "Nova Kitap", 7, false },
                    { 1206, "İnsan doğası üzerine felsefi düşünceler.", null, true, 160.00m, "/img/kitaplar/Denemeler.jpg", 1008, "Denemeler", null, 50, "Nova Kitap", 85, false },
                    { 1207, "Devlet ve toplum sözleşmesi üzerine eser.", null, false, 175.00m, "/img/kitaplar/Leviathan.jpg", 1008, "Leviathan", null, 50, "Nova Kitap", 86, false },
                    { 1208, "Kadın kimliği üzerine çığır açan çalışma.", null, true, 230.00m, "/img/kitaplar/İkincicinsiyet.jpg", 1008, "İkinci Cins", null, 50, "Nova Kitap", 87, false },
                    { 1209, "Halk egemenliği ve özgürlük üzerine klasik eser.", null, false, 140.00m, "/img/kitaplar/Toplumsozlesmesi.jpg", 1008, "Toplum Sözleşmesi", null, 50, "Nova Kitap", 88, false },
                    { 1210, "Dil ve mantık üzerine önemli felsefi eser.", null, false, 200.00m, "/img/kitaplar/tractatuslogicophilosophicus.jpg", 1008, "Tractatus Logico-Philosophicus", null, 50, "Nova Kitap", 89, false },
                    { 1211, "Varoluşçuluk felsefesinin temel açıklaması.", null, true, 120.00m, "/img/kitaplar/Varolusculukbirhumanizmdir.jpg", 1008, "Varoluşçuluk Bir Hümanizmdir", null, 50, "Nova Kitap", 90, false },
                    { 1212, "Disiplin ve çalışma alışkanlığı geliştirme rehberi.", null, true, 135.00m, "/img/kitaplar/iradeterbiyesi.jpg", 1009, "İrade Terbiyesi", null, 50, "Nova Kitap", 91, false },
                    { 1213, "Derin odaklanma ile verimli çalışma yöntemleri.", null, true, 170.00m, "/img/kitaplar/DeepWork.jpg", 1009, "Deep Work", null, 50, "Nova Kitap", 92, false },
                    { 1214, "Başarı ve finansal özgürlük üzerine klasik eser.", null, true, 180.00m, "/img/kitaplar/dusunvezenginol.jpg", 1009, "Düşün ve Zengin Ol", null, 50, "Nova Kitap", 93, false },
                    { 1215, "Sabah rutinleriyle hayatı değiştirme rehberi.", null, false, 145.00m, "/img/kitaplar/Ölü Canlar.jpg", 1009, "Mucize Sabahlar", null, 50, "Nova Kitap", 94, false },
                    { 1216, "Mutluluk ve üretkenlik psikolojisi üzerine çalışma.", null, true, 190.00m, "/img/kitaplar/Akis.jpg", 1009, "Akış", null, 50, "Nova Kitap", 95, false },
                    { 1217, "Başarının görünmeyen dinamikleri.", null, true, 175.00m, "/img/kitaplar/outliers.jpg", 1009, "Outliers", null, 50, "Nova Kitap", 60, false },
                    { 1218, "Girişimcilik dünyasının zorlukları üzerine.", null, false, 210.00m, "/img/kitaplar/Startup.jpg", 1009, "Startup", null, 50, "Nova Kitap", 96, false },
                    { 1219, "Psikoloji biliminin temel taşlarından biri.", null, false, 220.00m, "/img/kitaplar/psikolojinintemelilkeleri.jpg", 1009, "Psikolojinin Temel İlkeleri", null, 50, "Nova Kitap", 97, false },
                    { 1220, "Bilişsel terapi teknikleriyle mutluluk rehberi.", null, true, 165.00m, "/img/kitaplar/iyihissetmek.jpg", 1009, "İyi Hissetmek", null, 50, "Nova Kitap", 98, false },
                    { 1221, "Modern dedektif hikayelerinin başlangıcı.", null, false, 130.00m, "/img/kitaplar/morguesokaicinayeti.jpg", 1007, "Morgue Sokağı Cinayetleri", null, 50, "Nova Kitap", 99, false },
                    { 1222, "Kara roman türünün öncü eserlerinden biri.", null, true, 145.00m, "/img/kitaplar/maltasahinikitap.jpg", 1007, "Malta Şahini", null, 50, "Nova Kitap", 100, false },
                    { 1223, "Özel dedektif Philip Marlowe'un ilk macerası.", null, false, 150.00m, "/img/kitaplar/Buyukuyku.jpg", 1007, "Büyük Uyku", null, 50, "Nova Kitap", 101, false },
                    { 1224, "Orta Çağ manastırında geçen gizemli cinayetler.", null, true, 240.00m, "/img/kitaplar/gulunadi.jpg", 1007, "Gülün Adı", null, 50, "Nova Kitap", 102, false },
                    { 1225, "Masonluk ve sembollerle dolu gerilim romanı.", null, true, 220.00m, "/img/kitaplar/Kaybolansembol.jpg", 1007, "Kaybolan Sembol", null, 50, "Nova Kitap", 103, false },
                    { 1226, "Polisiye ve suç dünyasında sürükleyici hikaye.", null, false, 185.00m, "/img/kitaplar/olumsessizgeldi.jpg", 1007, "Ölüm Sessiz Geldi", null, 50, "Nova Kitap", 104, false },
                    { 1227, "Zeki bir seri katilin izini süren dedektifler.", null, true, 195.00m, "/img/kitaplar/kemikkoleksiyoncusu.jpg", 1007, "Kemik Koleksiyoncusu", null, 50, "Nova Kitap", 105, false },
                    { 1228, "Fantastik ve korku öğelerini birleştiren seri.", null, true, 260.00m, "/img/kitaplar/karakule.jpg", 1007, "Kara Kule", null, 50, "Nova Kitap", 106, false },
                    { 1229, "Doğaüstü güçlerle çevrili gerilim hikayesi.", null, false, 170.00m, "/img/kitaplar/medyum.jpg", 1007, "Medyum", null, 50, "Nova Kitap", 106, false },
                    { 1230, "Kaptan Ahab'ın beyaz balina takıntısı.", null, true, 195.00m, "/img/kitaplar/mobydick.jpg", 1004, "Moby Dick", null, 50, "Nova Kitap", 107, false },
                    { 1231, "Aşk, gurur ve toplumsal sınıf çatışmaları.", null, true, 175.00m, "/img/kitaplar/gururveonyargi.jpg", 1004, "Gurur ve Önyargı", null, 50, "Nova Kitap", 19, false },
                    { 1232, "Tutkulu ve trajik bir aşk hikayesi.", null, true, 165.00m, "/img/kitaplar/ugultulutepeler.jpg", 1004, "Uğultulu Tepeler", null, 50, "Nova Kitap", 108, false },
                    { 1233, "Kendini keşfetme yolculuğu.", null, false, 170.00m, "/img/kitaplar/Simurg.jpg", 1008, "Simurg", null, 50, "Nova Kitap", 109, false },
                    { 1234, "Modern insanın içsel çatışmaları.", null, true, 175.00m, "/img/kitaplar/bozkrkurdu.jpg", 1008, "Bozkırkurdu", null, 50, "Nova Kitap", 109, false },
                    { 1235, "Özgürlük ve kendini geliştirme üzerine alegori.", null, true, 95.00m, "/img/kitaplar/marti.jpg", 1009, "Martı", null, 50, "Nova Kitap", 110, false },
                    { 1236, "Issız adada hayatta kalma mücadelesi.", null, false, 140.00m, "/img/kitaplar/robinsoncrusoe.jpg", 1004, "Robinson Crusoe", null, 50, "Nova Kitap", 111, false },
                    { 1237, "Korsanlar ve hazine avı macerası.", null, false, 130.00m, "/img/kitaplar/defineadasi.jpg", 1007, "Define Adası", null, 50, "Nova Kitap", 22, false },
                    { 1238, "Yaramaz bir çocuğun eğlenceli maceraları.", null, true, 120.00m, "/img/kitaplar/tomsawyerinmaceralari.jpg", 1007, "Tom Sawyer'ın Maceraları", null, 50, "Nova Kitap", 112, false },
                    { 1239, "Amerika nehirlerinde geçen özgürlük yolculuğu.", null, false, 125.00m, "/img/kitaplar/huckleberryfinn.jpg", 1007, "Huckleberry Finn", null, 50, "Nova Kitap", 112, false },
                    { 1240, "Kaptan Nemo ile denizaltı macerası.", null, true, 175.00m, "/img/kitaplar/denzleraltndayrmbnfersah.jpg", 1006, "Denizler Altında 20 Bin Fersah", null, 50, "Nova Kitap", 18, false },
                    { 1241, "Dünya turuna çıkan bir adamın yarışı.", null, true, 160.00m, "/img/kitaplar/seksengundedevrialem.jpg", 1006, "Seksen Günde Devri Alem", null, 50, "Nova Kitap", 18, false },
                    { 1242, "Çocukluk dostluğu ve mahalle mücadelesi.", null, true, 115.00m, "/img/kitaplar/palsokagcocuklari.jpg", 1007, "Pal Sokağı Çocukları", null, 50, "Nova Kitap", 113, false },
                    { 1243, "Medeniyetten uzak kalan çocukların vahşileşmesi.", null, true, 155.00m, "/img/kitaplar/sineklerintanrisi.jpg", 1004, "Sineklerin Tanrısı", null, 50, "Nova Kitap", 114, false },
                    { 1244, "Hindistan'ın bağımsızlığıyla doğan çocukların hikayesi.", null, false, 210.00m, "/img/kitaplar/geceyarisicocuklari.jpg", 1004, "Gece Yarısı Çocukları", null, 50, "Nova Kitap", 115, false },
                    { 1245, "Afganistan'da iki kadının dramatik yaşamı.", null, true, 190.00m, "/img/kitaplar/bnmuhtesemgunes.jpg", 1004, "Bin Muhteşem Güneş", null, 50, "Nova Kitap", 116, false },
                    { 1246, "Dostluk, ihanet ve kefaret üzerine roman.", null, true, 185.00m, "/img/kitaplar/ucurtmaavcisi.jpg", 1004, "Uçurtma Avcısı", null, 50, "Nova Kitap", 116, false },
                    { 1247, "Bir çocuk ve kaplanın okyanustaki hayatta kalma mücadelesi.", null, true, 170.00m, "/img/kitaplar/pininyasami.jpg", 1004, "Pi'nin Yaşamı", null, 50, "Nova Kitap", 117, false },
                    { 1248, "Özgür ruhlu bir adamın hayat felsefesi.", null, true, 160.00m, "/img/kitaplar/zorba.jpg", 1004, "Zorba", null, 50, "Nova Kitap", 118, false },
                    { 1249, "Ölüm cezasına karşı etkileyici bir anlatım.", null, false, 130.00m, "/img/kitaplar/brdammahkumununsongunu.jpg", 1004, "Bir İdam Mahkumunun Son Günü", null, 50, "Nova Kitap", 7, false },
                    { 1250, "Zaman ve insan ilişkileri üzerine düşündüren roman.", null, false, 180.00m, "/img/kitaplar/saatleridurdurmaenstitusu.jpg", 1004, "Saatleri Durdurma Enstitüsü", null, 50, "Nova Kitap", 28, false },
                    { 1251, "Psikolojik gerilim dolu kısa roman.", null, true, 120.00m, "/img/kitaplar/satranc.jpg", 1004, "Satranç", null, 50, "Nova Kitap", 4, false },
                    { 1252, "İnsan özgürlüğü ve başkaldırı üzerine deneme.", null, false, 145.00m, "/img/kitaplar/ayaklanma.jpg", 1008, "Ayaklanma", null, 50, "Nova Kitap", 13, false },
                    { 1253, "Felsefeyi günlük yaşama uyarlayan eser.", null, true, 165.00m, "/img/kitaplar/felsefenintesellisi.jpg", 1008, "Felsefenin Tesellisi", null, 50, "Nova Kitap", 119, false },
                    { 1254, "İnanç ve etik üzerine derin düşünceler.", null, false, 175.00m, "/img/kitaplar/korkuvetitreme.jpg", 1008, "Korku ve Titreme", null, 50, "Nova Kitap", 120, false },
                    { 1255, "Siyaset ve erdem üzerine klasik eser.", null, false, 140.00m, "/img/kitaplar/devletadam.jpg", 1008, "Devlet Adamı", null, 50, "Nova Kitap", 121, false },
                    { 1256, "Stoacı yaşam felsefesinin temel taşlarından biri.", null, true, 135.00m, "/img/kitaplar/mutluyasamuzerine.jpg", 1008, "Mutlu Yaşam Üzerine", null, 50, "Nova Kitap", 122, false },
                    { 1257, "İnsan sevgisi ve merhamet üzerine öyküler.", null, true, 110.00m, "/img/kitaplar/insanneileyasar.jpg", 1008, "İnsan Neyle Yaşar", null, 50, "Nova Kitap", 14, false },
                    { 1258, "Sade yaşamın gücü üzerine modern rehber.", null, true, 155.00m, "/img/kitaplar/minimalizm.jpg", 1009, "Minimalizm", null, 50, "Nova Kitap", 123, false },
                    { 1259, "Alışkanlıkların hayatımızı nasıl şekillendirdiği.", null, true, 175.00m, "/img/kitaplar/aliskanliklaringucu.jpg", 1009, "Alışkanlıkların Gücü", null, 50, "Nova Kitap", 124, false },
                    { 1260, "Odaklanarak başarıya ulaşmanın yolları.", null, true, 160.00m, "/img/kitaplar/teksey.jpg", 1009, "Tek Şey", null, 50, "Nova Kitap", 125, false },
                    { 1261, "Verimli çalışma ve özgür yaşam rehberi.", null, true, 185.00m, "/img/kitaplar/4SaatlikcalsmaHaftasi.jpg", 1009, "4 Saatlik Çalışma Haftası", null, 50, "Nova Kitap", 126, false },
                    { 1262, "İnsan ilişkileri ve network kurma sanatı.", null, false, 145.00m, "/img/kitaplar/AslaYalnizYeme.jpg", 1009, "Asla Yalnız Yeme", null, 50, "Nova Kitap", 127, false },
                    { 1263, "Gelecekte yapay zekanın dünyayı nasıl değiştireceği.", null, false, 220.00m, "/img/kitaplar/YapayZeka2041.jpg", 1009, "Yapay Zeka 2041", null, 50, "Nova Kitap", 128, false },
                    { 1264, "Travma ve insan psikolojisi üzerine çalışma.", null, true, 230.00m, "/img/kitaplar/BedenKaytTutar.jpg", 1009, "Beden Kayıt Tutar", null, 50, "Nova Kitap", 129, false },
                    { 1265, "İnsan ilişkilerinde empati kurmanın önemi.", null, false, 150.00m, "/img/kitaplar/Empati.jpg", 1009, "Empati", null, 50, "Nova Kitap", 130, false },
                    { 1266, "Gizem ve sembollerle dolu sürükleyici macera.", null, true, 215.00m, "/img/kitaplar/KayipSembol.jpg", 1007, "Kayıp Sembol", null, 50, "Nova Kitap", 103, false },
                    { 1267, "Sert polisiye türünün dikkat çeken eserlerinden biri.", null, false, 135.00m, "/img/kitaplar/KanunBenim.jpg", 1007, "Kanun Benim", null, 50, "Nova Kitap", 131, false },
                    { 1268, "İpucu avıyla ilerleyen gerilim dolu polisiye.", null, true, 190.00m, "/img/kitaplar/seytanAyrintidaGizlidir.jpg", 1007, "Şeytan Ayrıntıda Gizlidir", null, 50, "Nova Kitap", 105, false },
                    { 1269, "Geçmişin sırlarıyla yüzleşen bir kadının hikayesi.", null, true, 175.00m, "/img/kitaplar/KaranlikYerler.jpg", 1007, "Karanlık Yerler", null, 50, "Nova Kitap", 132, false },
                    { 1270, "Gizemli bir kayboluşun psikolojik çözümlemesi.", null, true, 180.00m, "/img/kitaplar/TrendekiKiz.jpg", 1007, "Trendeki Kız", null, 50, "Nova Kitap", 133, false },
                    { 1271, "Konuşmayı bırakan bir kadının gizemi.", null, true, 195.00m, "/img/kitaplar/SessizHasta.jpg", 1007, "Sessiz Hasta", null, 50, "Nova Kitap", 134, false },
                    { 1272, "Alfabetik seri cinayetlerin izini süren dedektif.", null, false, 150.00m, "/img/kitaplar/CinayetAlfabesi.jpg", 1007, "Cinayet Alfabesi", null, 50, "Nova Kitap", 135, false },
                    { 1273, "Fransız Alplerinde geçen karanlık cinayet hikayesi.", null, true, 210.00m, "/img/kitaplar/KizilNehirler.jpg", 1007, "Kızıl Nehirler", null, 50, "Nova Kitap", 136, false },
                    { 1274, "Doğaüstü olaylarla örülü polisiye roman.", null, false, 165.00m, "/img/kitaplar/oluRuhlarKulubu.jpg", 1007, "Ölü Ruhlar Kulübü", null, 50, "Nova Kitap", 137, false },
                    { 1275, "Sherlock Holmes'un en ünlü vakalarından biri.", null, true, 145.00m, "/img/kitaplar/BaskervilleTazisi.jpg", 1007, "Baskerville Tazısı", null, 50, "Nova Kitap", 15, false },
                    { 1276, "Batı toplumunun parıltılı ama boş yaşam eleştirisi.", null, true, 165.00m, "/img/kitaplar/TheGreatGatsby.jpg", 1004, "The Great Gatsby", null, 50, "Nova Kitap", 138, false },
                    { 1277, "Buendia ailesinin nesiller boyu süren büyülü hikayesi.", null, true, 210.00m, "/img/kitaplar/YuzyillikYalnizlik.jpg", 1004, "Yüzyıllık Yalnızlık", null, 50, "Nova Kitap", 139, false },
                    { 1278, "Anlam verilemeyen bir suçlama karşısında bireyin çaresizliği.", null, true, 150.00m, "/img/kitaplar/Dava.jpg", 1004, "Dava", null, 50, "Nova Kitap", 5, false },
                    { 1279, "Paul Atreides’in imparatorluk sonrası yaşadığı çatışmalar.", null, true, 195.00m, "/img/kitaplar/DuneMesihi.jpg", 1006, "Dune Mesihi", null, 50, "Nova Kitap", 68, false },
                    { 1280, "Absürdizmin ve yabancılaşmanın başyapıtı.", null, true, 115.00m, "/img/kitaplar/Yabanci.jpg", 1004, "Yabancı", null, 50, "Nova Kitap", 13, false },
                    { 1281, "Gregor Samsa'nın bir sabah böceğe dönüşme hikayesi.", null, true, 95.00m, "/img/kitaplar/Donusum.jpg", 1004, "Dönüşüm", null, 50, "Nova Kitap", 5, false },
                    { 1282, "St. Petersburg'da geçen hüzünlü bir hayalperest öyküsü.", null, false, 105.00m, "/img/kitaplar/Denemeler.jpg", 1004, "Beyaz Geceler", null, 50, "Nova Kitap", 1, false },
                    { 1283, "Tutku ve irade çatışması üzerine sarsıcı bir roman.", null, true, 130.00m, "/img/kitaplar/Kumarbaz.jpg", 1004, "Kumarbaz", null, 50, "Nova Kitap", 1, false },
                    { 1284, "Dostoyevski'nin ilk romanı ve toplumsal dram.", null, false, 110.00m, "/img/kitaplar/Insanciklar.jpg", 1004, "İnsancıklar", null, 50, "Nova Kitap", 1, false },
                    { 1285, "Sibirya'daki hapishane hayatının gerçekçi anlatımı.", null, false, 155.00m, "/img/kitaplar/OlulerEvindenAnilar.jpg", 1004, "Ölüler Evinden Anılar", null, 50, "Nova Kitap", 1, false },
                    { 1286, "Bürokrasi ve yolsuzluk üzerine sert bir yergi.", null, false, 100.00m, "/img/kitaplar/Mufettis.jpg", 1004, "Müfettiş", null, 50, "Nova Kitap", 21, false },
                    { 1287, "Ulaşılamayan otorite ve bürokratik labirentler.", null, true, 170.00m, "/img/kitaplar/satranc.jpg", 1004, "Şato", null, 50, "Nova Kitap", 5, false },
                    { 1288, "Edebiyat tarihinin en derinlikli aşk mektupları.", null, true, 140.00m, "/img/kitaplar/MilenayaMektuplar.jpg", 1004, "Milena'ya Mektuplar", null, 50, "Nova Kitap", 5, false },
                    { 1289, "İnsan doğasındaki iyi ve kötünün savaşı.", null, true, 115.00m, "/img/kitaplar/DrJekyllveMrHyde.jpg", 1004, "Dr. Jekyll ve Mr. Hyde", null, 50, "Nova Kitap", 22, false },
                    { 1290, "Güzellik, gençlik ve ahlaki çöküşün romanı.", null, true, 150.00m, "/img/kitaplar/DorianGrayinPortresi.jpg", 1004, "Dorian Gray'in Portresi", null, 50, "Nova Kitap", 23, false },
                    { 1291, "Fedakarlık ve iyilik üzerine etkileyici masallar.", null, false, 90.00m, "/img/kitaplar/MutluPrens.jpg", 1004, "Mutlu Prens", null, 50, "Nova Kitap", 23, false },
                    { 1292, "Yetimhaneden sokaklara uzanan bir hayatta kalma öyküsü.", null, true, 160.00m, "/img/kitaplar/OliverTwist.jpg", 1004, "Oliver Twist", null, 50, "Nova Kitap", 24, false },
                    { 1293, "Fransız Devrimi gölgesinde kaos ve aşk.", null, true, 175.00m, "/img/kitaplar/kiSehrinHikayesi.jpg", 1004, "İki Şehrin Hikayesi", null, 50, "Nova Kitap", 24, false },
                    { 1294, "Pip'in çocukluğundan yetişkinliğine uzanan sancılı büyüme hikayesi.", null, true, 180.00m, "/img/kitaplar/BuyukUmutlar.jpg", 1004, "Büyük Umutlar", null, 50, "Nova Kitap", 24, false },
                    { 1295, "İnsan doğasına ve topluma yönelik keskin bir eleştiri.", null, false, 130.00m, "/img/kitaplar/GulliverinGezileri.jpg", 1004, "Gulliver'in Gezileri", null, 50, "Nova Kitap", 25, false },
                    { 1296, "Çocukların gözünden büyüklerin dünyası.", null, true, 85.00m, "/img/kitaplar/KucukPrens.jpg", 1004, "Küçük Prens", null, 50, "Nova Kitap", 26, false },
                    { 1297, "Aşk ve cinsellik üzerine provokatif bir anlatı.", null, false, 155.00m, "/img/kitaplar/OnBirDakika.jpg", 1004, "On Bir Dakika", null, 50, "Nova Kitap", 27, false },
                    { 1298, "Yaşamın anlamını sorgulayan bir delilik hikayesi.", null, true, 145.00m, "/img/kitaplar/VeronikaOlmekIstiyor.jpg", 1004, "Veronika Ölmek İstiyor", null, 50, "Nova Kitap", 27, false },
                    { 1299, "Bilinmeyen bir körlük salgınının yarattığı toplumsal kaos.", null, true, 190.00m, "/img/kitaplar/Korluk.jpg", 1004, "Körlük", null, 50, "Nova Kitap", 28, false },
                    { 1300, "Demokrasi ve siyaset üzerine alegorik bir roman.", null, false, 185.00m, "/img/kitaplar/Gormek.jpg", 1004, "Görmek", null, 50, "Nova Kitap", 28, false },
                    { 1301, "Salgın hastalık karşısında insanlık ve dayanışma.", null, true, 165.00m, "/img/kitaplar/Veba.jpg", 1004, "Veba", null, 50, "Nova Kitap", 13, false },
                    { 1302, "Mutluluğu arayan bir adamın felsefi yolculuğu.", null, false, 125.00m, "/img/kitaplar/MutluOlum.jpg", 1004, "Mutlu Ölüm", null, 50, "Nova Kitap", 13, false },
                    { 1303, "Büyük Buhran döneminde iki arkadaşın dokunaklı hikayesi.", null, true, 110.00m, "/img/kitaplar/FarelerveInsanlar.jpg", 1004, "Fareler ve İnsanlar", null, 50, "Nova Kitap", 29, false },
                    { 1304, "Topraklarından koparılan mevsimlik işçilerin dramı.", null, true, 220.00m, "/img/kitaplar/GazapUzumleri.jpg", 1004, "Gazap Üzümleri", null, 50, "Nova Kitap", 29, false },
                    { 1305, "Büyük bir inci bulan balıkçının trajedisi.", null, false, 100.00m, "/img/kitaplar/Inci.jpg", 1004, "İnci", null, 50, "Nova Kitap", 29, false },
                    { 1306, "Bilimsel deneyler ve canavarlığa dönüşüm.", null, false, 135.00m, "/img/kitaplar/DrMoreaununAdasi.jpg", 1006, "Dr. Moreau'nun Adası", null, 50, "Nova Kitap", 30, false },
                    { 1307, "Marslıların dünyayı istilası üzerine klasik bilim kurgu.", null, true, 150.00m, "/img/kitaplar/DunyalarSavasi.jpg", 1006, "Dünyalar Savaşı", null, 50, "Nova Kitap", 30, false },
                    { 1308, "Görünmezliği bulan bir bilim insanının yalnızlığı.", null, false, 120.00m, "/img/kitaplar/GorunmezAdam.jpg", 1006, "Görünmez Adam", null, 50, "Nova Kitap", 30, false },
                    { 1309, "Robotik yasaları ve yapay zeka öyküleri.", null, true, 170.00m, "/img/kitaplar/BenRobot.jpg", 1006, "Ben, Robot", null, 50, "Nova Kitap", 31, false },
                    { 1310, "Galaktik İmparatorluğun kaderini belirleyen savaşlar.", null, true, 185.00m, "/img/kitaplar/VakifveImparatorluk.jpg", 1006, "Vakıf ve İmparatorluk", null, 50, "Nova Kitap", 31, false },
                    { 1311, "Psiko-tarih biliminin gizli koruyucuları.", null, false, 185.00m, "/img/kitaplar/kinciVakif.jpg", 1006, "İkinci Vakıf", null, 50, "Nova Kitap", 31, false },
                    { 1312, "Dünya dışı üstün bir ırkın insanlığa müdahalesi.", null, true, 160.00m, "/img/kitaplar/CocuklugunSonu.jpg", 1006, "Çocukluğun Sonu", null, 50, "Nova Kitap", 32, false },
                    { 1313, "İnsanın evrimine ve geleceğine dair epik yolculuk.", null, true, 175.00m, "/img/kitaplar/2001BirUzayDestani.jpg", 1006, "2001: Bir Uzay Destanı", null, 50, "Nova Kitap", 32, false },
                    { 1314, "Işınlanma ve intikam temalı siberpunk öncüsü.", null, false, 155.00m, "/img/kitaplar/KaplanKaplan.jpg", 1006, "Kaplan! Kaplan!", null, 50, "Nova Kitap", 33, false },
                    { 1315, "Anarşist bir ütopya ile kapitalist dünyanın kıyaslanması.", null, true, 180.00m, "/img/kitaplar/mutluyasamuzerine.jpg", 1006, "Mülksüzler", null, 50, "Nova Kitap", 34, false },
                    { 1316, "Büyü, isimler ve gölgeler üzerine fantastik bir klasik.", null, true, 165.00m, "/img/kitaplar/YerdenizBuyucusu.jpg", 1006, "Yerdeniz Büyücüsü", null, 50, "Nova Kitap", 34, false },
                    { 1317, "Şiddet, özgür irade ve devlet kontrolü.", null, true, 145.00m, "/img/kitaplar/OtomatikPortakal.jpg", 1006, "Otomatik Portakal", null, 50, "Nova Kitap", 35, false },
                    { 1318, "Kadınların sadece damızlık olarak görüldüğü karanlık gelecek.", null, true, 190.00m, "/img/kitaplar/DamizlikKizinOykusu.jpg", 1006, "Damızlık Kızın Öyküsü", null, 50, "Nova Kitap", 36, false },
                    { 1319, "İnsan ve maymun rollerinin değiştiği şaşırtıcı gezegen.", null, false, 140.00m, "/img/kitaplar/MaymunlarGezegeni.jpg", 1006, "Maymunlar Gezegeni", null, 50, "Nova Kitap", 37, false },
                    { 1320, "Yaratıcısına isyan eden bir canavarın trajik öyküsü.", null, true, 150.00m, "/img/kitaplar/Frankenstein.jpg", 1004, "Frankenstein", null, 50, "Nova Kitap", 38, false },
                    { 1321, "Transilvanya'dan Londra'ya uzanan gotik korku.", null, true, 170.00m, "/img/kitaplar/Dracula.jpg", 1004, "Dracula", null, 50, "Nova Kitap", 39, false },
                    { 1322, "Sherlock Holmes ve Watson'ın çözdüğü ilk dava.", null, true, 125.00m, "/img/kitaplar/KzilSorusturmaArthurConanDoyle.jpg", 1007, "Kızıl Soruşturma", null, 50, "Nova Kitap", 15, false },
                    { 1323, "Kayıp hazine ve gizemli bir intikam hikayesi.", null, false, 130.00m, "/img/kitaplar/SherlockHolmesDortlerinmzasi.jpg", 1007, "Dörtlerin İmzası", null, 50, "Nova Kitap", 15, false },
                    { 1324, "Lüks bir gemide işlenen ustaca kurgulanmış cinayet.", null, true, 160.00m, "/img/kitaplar/NildeOlum.jpg", 1007, "Nil'de Ölüm", null, 50, "Nova Kitap", 6, false },
                    { 1325, "Polisiye tarihinin en şaşırtıcı sonlarından biri.", null, true, 155.00m, "/img/kitaplar/RogerAckroydCinayeti.jpg", 1007, "Roger Ackroyd Cinayeti", null, 50, "Nova Kitap", 6, false },
                    { 1326, "Jane Marple'ın keskin zekasıyla çözülen sırlar.", null, false, 145.00m, "/img/kitaplar/CesetlerMerdiveni.jpg", 1007, "Cesetler Merdiveni", null, 50, "Nova Kitap", 6, false },
                    { 1327, "Geçmişten gelen bir cinayetin ürpertici izleri.", null, false, 140.00m, "/img/kitaplar/UyuyanOlum.jpg", 1007, "Uyuyan Ölüm", null, 50, "Nova Kitap", 6, false },
                    { 1328, "Yaşanmamış hayatlar arasında bir seçim yolculuğu.", null, true, 165.00m, "/img/kitaplar/GeceYarisiKutuphanesi.jpg", 1004, "Gece Yarısı Kütüphanesi", null, 50, "Nova Kitap", 40, false },
                    { 1329, "Türk edebiyatında modern romanın başlangıcı.", null, false, 150.00m, "/img/kitaplar/MaiveSiyah.jpg", 1005, "Mai ve Siyah", null, 50, "Nova Kitap", 41, false },
                    { 1330, "Edebiyatımızın ilk psikolojik romanı.", null, false, 140.00m, "/img/kitaplar/Eylul.jpg", 1005, "Eylül", null, 50, "Nova Kitap", 42, false },
                    { 1331, "Doğu-Batı çatışması ve kültürel ikilem.", null, true, 125.00m, "/img/kitaplar/FatihHarbiye.jpg", 1005, "Fatih-Harbiye", null, 50, "Nova Kitap", 43, false },
                    { 1332, "Mistisizm ve realizm arasında bir arayış hikayesi.", null, false, 145.00m, "/img/kitaplar/MatmazelNoraliyaninKoltugu.jpg", 1005, "Matmazel Noraliya'nın Koltuğu", null, 50, "Nova Kitap", 43, false },
                    { 1333, "27 Mayıs öncesi Türkiye'nin siyasi ve sosyal portresi.", null, true, 210.00m, "/img/kitaplar/BirGunTekBasina.jpg", 1005, "Bir Gün Tek Başına", null, 50, "Nova Kitap", 44, false },
                    { 1334, "Osmanlı Devleti'nin kuruluş dönemine epik bir bakış.", null, true, 220.00m, "/img/kitaplar/DevletAna.jpg", 1005, "Devlet Ana", null, 50, "Nova Kitap", 45, false },
                    { 1335, "Milli Mücadele döneminin zorlu şartları ve insanları.", null, false, 200.00m, "/img/kitaplar/YorgunSavasci.jpg", 1005, "Yorgun Savaşçı", null, 50, "Nova Kitap", 45, false },
                    { 1336, "Modern şehir hayatında bireyin yalnızlığı ve yabancılaşması.", null, true, 135.00m, "/img/kitaplar/AylakAdam.jpg", 1005, "Aylak Adam", null, 50, "Nova Kitap", 46, false },
                    { 1337, "Zebercet'in iç dünyasındaki karanlık ve yalnızlık.", null, false, 130.00m, "/img/kitaplar/AnayurtOteli.jpg", 1005, "Anayurt Oteli", null, 50, "Nova Kitap", 46, false },
                    { 1338, "Bireyin iç dünyasını yansıtan sarsıcı öyküler.", null, true, 160.00m, "/img/kitaplar/KorkuyuBeklerken.jpg", 1005, "Korkuyu Beklerken", null, 50, "Nova Kitap", 12, false },
                    { 1339, "Gerçekle hayalin birbirine karıştığı modern bir roman.", null, true, 240.00m, "/img/kitaplar/TehlikeliOyunlar.jpg", 1005, "Tehlikeli Oyunlar", null, 50, "Nova Kitap", 12, false },
                    { 1340, "Toplumsal eleştiri içeren çarpıcı öyküler ve masallar.", null, true, 115.00m, "/img/kitaplar/SircaKosk.jpg", 1005, "Sırça Köşk", null, 50, "Nova Kitap", 3, false },
                    { 1341, "Sabahattin Ali'nin ilk öykü kitabı ve aşk hikayeleri.", null, false, 110.00m, "/img/kitaplar/Degirmen.jpg", 1005, "Değirmen", null, 50, "Nova Kitap", 3, false },
                    { 1342, "Anadolu insanının yaşamına ışık tutan gerçekçi öyküler.", null, false, 110.00m, "/img/kitaplar/YeniDunya.jpg", 1005, "Yeni Dünya", null, 50, "Nova Kitap", 3, false },
                    { 1343, "Çukurova'da ağalık düzeni ve sınıf çatışmaları.", null, true, 175.00m, "/img/kitaplar/HaniminCiftligi.jpg", 1005, "Hanımın Çiftliği", null, 50, "Nova Kitap", 47, false },
                    { 1344, "Görevine sadık bir bekçinin trajikomik hikayesi.", null, false, 160.00m, "/img/kitaplar/Murtaza.jpg", 1005, "Murtaza", null, 50, "Nova Kitap", 47, false },
                    { 1345, "Tarım işçilerinin zorlu yaşam savaşı.", null, true, 170.00m, "/img/kitaplar/BereketliTopraklarUzerinde.jpg", 1005, "Bereketli Topraklar Üzerinde", null, 50, "Nova Kitap", 47, false },
                    { 1346, "Köy hayatı ve imece ruhu üzerine bir başyapıt.", null, false, 150.00m, "/img/kitaplar/Kaplumbagalar.jpg", 1005, "Kaplumbağalar", null, 50, "Nova Kitap", 48, false },
                    { 1347, "Toprak kavgası ve köylünün hak arama mücadelesi.", null, true, 145.00m, "/img/kitaplar/YilanlarinOcu.jpg", 1005, "Yılanların Öcü", null, 50, "Nova Kitap", 48, false },
                    { 1348, "Stoacı imparatorun yaşam ve ölüm üzerine notları.", null, true, 140.00m, "/img/kitaplar/KendimeDusunceler.jpg", 1008, "Kendime Düşünceler", null, 50, "Nova Kitap", 17, false },
                    { 1349, "Türkiye Cumhuriyeti'nin kuruluş belgesi ve tarihi söylev.", null, true, 250.00m, "/img/kitaplar/Nutuk.jpg", 1005, "Nutuk", null, 50, "Nova Kitap", 49, false },
                    { 1350, "Strateji ve liderlik üzerine binlerce yıllık rehber.", null, true, 95.00m, "/img/kitaplar/SavasSanati.jpg", 1008, "Savaş Sanatı", null, 50, "Nova Kitap", 50, false },
                    { 1351, "Tasavvuf felsefesinin en önemli hikmet dolu eseri.", null, true, 180.00m, "/img/kitaplar/MesnevidenSecmeler.jpg", 1008, "Mesnevi'den Seçmeler", null, 50, "Nova Kitap", 51, false },
                    { 1352, "Hayat, şarap ve varoluş üzerine felsefi dörtlükler.", null, false, 120.00m, "/img/kitaplar/Rubailer.jpg", 1008, "Rubailer", null, 50, "Nova Kitap", 52, false },
                    { 1353, "Karamsar felsefenin yaşam bilgeliği üzerine yorumları.", null, false, 130.00m, "/img/kitaplar/HicliginMutlulugu.jpg", 1008, "Hiçliğin Mutluluğu", null, 50, "Nova Kitap", 53, false },
                    { 1354, "Geleneksel ahlakın ve değerlerin yıkımı.", null, true, 165.00m, "/img/kitaplar/IyiliginveKotulugunOtesinde.jpg", 1008, "İyinin ve Kötünün Ötesinde", null, 50, "Nova Kitap", 9, false },
                    { 1355, "Nietzsche'nin kendi felsefesini ve hayatını anlattığı eser.", null, false, 150.00m, "/img/kitaplar/EcceHomo.jpg", 1008, "Ecce Homo", null, 50, "Nova Kitap", 9, false },
                    { 1356, "Batı felsefesine ve değerlerine sert bir meydan okuyuş.", null, false, 140.00m, "/img/kitaplar/PutlarinAlacakaranlg.jpg", 1008, "Putların Alacakaranlığı", null, 50, "Nova Kitap", 9, false },
                    { 1357, "Aşk ve sevgi üzerine yapılmış felsefi tartışmalar.", null, true, 125.00m, "/img/kitaplar/Solen.jpg", 1008, "Şölen", null, 50, "Nova Kitap", 54, false },
                    { 1358, "Ruhun ölümsüzlüğü üzerine Sokrates'in son konuşması.", null, false, 120.00m, "/img/kitaplar/Phaidon.jpg", 1008, "Phaidon", null, 50, "Nova Kitap", 54, false },
                    { 1359, "Retorik, güç ve adalet üzerine bir diyalog.", null, false, 135.00m, "/img/kitaplar/Gorgias.jpg", 1008, "Gorgias", null, 50, "Nova Kitap", 54, false },
                    { 1360, "Mutluluk ve erdemli bir yaşamın temelleri.", null, true, 190.00m, "/img/kitaplar/NikomakhosaEtik.jpg", 1008, "Nikomakhos'a Etik", null, 50, "Nova Kitap", 55, false },
                    { 1361, "Devlet yönetimi ve toplumsal düzen üzerine inceleme.", null, true, 180.00m, "/img/kitaplar/Politika.jpg", 1008, "Politika", null, 50, "Nova Kitap", 55, false },
                    { 1362, "Canlılık, algı ve akıl üzerine felsefi analiz.", null, false, 160.00m, "/img/kitaplar/RuhUzerine.jpg", 1008, "Ruh Üzerine", null, 50, "Nova Kitap", 55, false },
                    { 1363, "Sabah erken kalkmanın verimlilik üzerindeki gücü.", null, true, 175.00m, "/img/kitaplar/Sabah5Kulubu.jpg", 1009, "5 AM Kulübü", null, 50, "Nova Kitap", 56, false },
                    { 1364, "Maddi dünyadan ruhsal huzura giden bir yol haritası.", null, true, 155.00m, "/img/kitaplar/FerrarisiniSatanBilge.jpg", 1009, "Ferrari'sini Satan Bilge", null, 50, "Nova Kitap", 56, false },
                    { 1365, "Toltek bilgeliği ile kişisel özgürlük rehberi.", null, true, 130.00m, "/img/kitaplar/DortAnlasma.jpg", 1009, "Dört Anlaşma", null, 50, "Nova Kitap", 57, false },
                    { 1366, "Zihnin karmaşasından kurtulup anı yaşama sanatı.", null, true, 180.00m, "/img/kitaplar/SimdininGucu.jpg", 1009, "Şimdinin Gücü", null, 50, "Nova Kitap", 58, false },
                    { 1367, "Hayatı daha anlamlı kılmak için neleri dert etmeli.", null, true, 160.00m, "/img/kitaplar/KafayaTakmamaSanat.jpg", 1009, "Kafaya Takmama Sanatı", null, 50, "Nova Kitap", 59, false },
                    { 1368, "Tanımadığımız insanları neden yanlış anlarız?", null, false, 185.00m, "/img/kitaplar/YabancilarlaKonusmak.jpg", 1009, "Yabancılarla Konuşmak", null, 50, "Nova Kitap", 60, false },
                    { 1369, "Olumlu düşüncelerin sağlık üzerindeki etkileri.", null, true, 145.00m, "/img/kitaplar/DusunceGucuyleTedavi.jpg", 1009, "Düşünce Gücüyle Tedavi", null, 50, "Nova Kitap", 61, false },
                    { 1370, "Değer yatırımı üzerine finans dünyasının kutsal kitabı.", null, true, 250.00m, "/img/kitaplar/AkilliYatirimci.jpg", 1009, "Akıllı Yatırımcı", null, 50, "Nova Kitap", 62, false },
                    { 1371, "Geleceği şekillendiren bir girişimcinin biyografisi.", null, true, 220.00m, "/img/kitaplar/ElonMusk.jpg", 1009, "Elon Musk", null, 50, "Nova Kitap", 63, false },
                    { 1372, "Apple'ın kurucusunun hayatı ve teknoloji vizyonu.", null, true, 230.00m, "/img/kitaplar/SteveJobsWalterIsaacson.jpg", 1009, "Steve Jobs", null, 50, "Nova Kitap", 64, false },
                    { 1373, "Tarihin en meraklı dehasının hayat hikayesi.", null, false, 240.00m, "/img/kitaplar/LeonardodaVinci.jpg", 1009, "Leonardo da Vinci", null, 50, "Nova Kitap", 64, false },
                    { 1374, "Yarının kısa bir tarihi ve insanlığın geleceği.", null, true, 210.00m, "/img/kitaplar/HomoDeus.jpg", 1009, "Homo Deus", null, 50, "Nova Kitap", 16, false },
                    { 1375, "Günümüz dünyasının en acil sorularına cevaplar.", null, false, 200.00m, "/img/kitaplar/21YuzyilIcin21Ders.jpg", 1009, "21. Yüzyıl İçin 21 Ders", null, 50, "Nova Kitap", 16, false },
                    { 1376, "Nitelik kavramı üzerine felsefi bir yolculuk.", null, true, 195.00m, "/img/kitaplar/ZenveMotosikletBakimSanati.jpg", 1008, "Zen ve Motosiklet Bakım Sanatı", null, 50, "Nova Kitap", 65, false },
                    { 1377, "Özdenetim ve iradenin bilimsel temelleri.", null, false, 170.00m, "/img/kitaplar/IradeGucu.jpg", 1009, "İrade Gücü", null, 50, "Nova Kitap", 66, false },
                    { 1378, "Hayali şehirler üzerinden bir rüya anlatısı.", null, true, 150.00m, "/img/kitaplar/GorunmezKentler.jpg", 1004, "Görünmez Kentler", null, 50, "Nova Kitap", 67, false },
                    { 1379, "Dune serisinin devamı; imparatorluk ve kader.", null, true, 215.00m, "/img/kitaplar/DuneCocuklari.jpg", 1006, "Dune Çocukları", null, 50, "Nova Kitap", 68, false }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1180);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1181);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1182);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1183);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1184);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1185);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1186);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1187);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1188);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1189);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1190);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1191);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1192);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1193);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1194);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1195);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1196);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1197);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1198);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1199);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1200);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1201);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1202);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1203);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1204);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1205);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1206);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1207);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1208);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1209);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1210);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1211);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1212);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1213);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1214);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1215);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1216);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1217);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1218);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1219);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1220);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1221);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1222);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1223);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1224);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1225);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1226);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1227);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1228);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1229);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1230);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1231);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1232);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1233);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1234);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1235);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1236);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1237);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1238);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1239);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1240);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1241);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1242);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1243);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1244);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1245);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1246);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1247);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1248);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1249);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1250);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1251);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1252);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1253);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1254);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1255);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1256);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1257);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1258);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1259);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1260);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1261);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1262);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1263);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1264);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1265);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1266);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1267);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1268);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1269);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1270);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1271);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1272);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1273);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1274);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1275);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1276);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1277);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1278);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1279);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1280);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1281);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1282);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1283);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1284);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1285);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1286);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1287);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1288);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1289);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1290);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1291);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1292);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1293);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1294);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1295);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1296);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1297);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1298);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1299);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1300);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1301);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1302);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1303);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1304);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1305);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1306);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1307);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1308);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1309);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1310);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1311);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1312);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1313);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1314);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1315);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1316);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1317);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1318);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1319);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1320);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1321);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1322);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1323);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1324);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1325);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1326);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1327);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1328);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1329);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1330);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1331);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1332);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1333);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1334);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1335);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1336);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1337);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1338);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1339);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1340);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1341);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1342);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1343);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1344);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1345);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1346);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1347);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1348);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1349);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1350);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1351);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1352);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1353);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1354);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1355);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1356);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1357);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1358);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1359);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1360);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1361);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1362);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1363);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1364);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1365);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1366);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1367);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1368);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1369);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1370);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1371);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1372);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1373);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1374);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1375);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1376);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1377);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1378);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1379);

            migrationBuilder.DeleteData(
                table: "Kategoriler",
                keyColumn: "KategoriId",
                keyValue: 1004);

            migrationBuilder.DeleteData(
                table: "Kategoriler",
                keyColumn: "KategoriId",
                keyValue: 1005);

            migrationBuilder.DeleteData(
                table: "Kategoriler",
                keyColumn: "KategoriId",
                keyValue: 1006);

            migrationBuilder.DeleteData(
                table: "Kategoriler",
                keyColumn: "KategoriId",
                keyValue: 1007);

            migrationBuilder.DeleteData(
                table: "Kategoriler",
                keyColumn: "KategoriId",
                keyValue: 1008);

            migrationBuilder.DeleteData(
                table: "Kategoriler",
                keyColumn: "KategoriId",
                keyValue: 1009);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 139);

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 1,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_1.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 2,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_2.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 3,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_3.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 4,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_4.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 5,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_5.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 6,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_6.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 7,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_7.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 8,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_8.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 9,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_9.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 10,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_10.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 11,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_11.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 12,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_12.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 13,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_13.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 14,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_14.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 15,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_15.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 16,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_16.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 17,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_17.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 18,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_18.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 19,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_19.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 20,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_20.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 21,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_21.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 22,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_22.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 23,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_23.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 24,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_24.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 25,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_25.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 26,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_26.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 27,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_27.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 28,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_28.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 29,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_29.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 30,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_30.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 31,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_31.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 32,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_32.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 33,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_33.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 34,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_34.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 35,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_35.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 36,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_36.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 37,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_37.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 38,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_38.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 39,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_39.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 40,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_40.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 41,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_41.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 42,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_42.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 43,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_43.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 44,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_44.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 45,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_45.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 46,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_46.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 47,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_47.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 48,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_48.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 49,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_49.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 50,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_50.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 51,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_51.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 52,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_52.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 53,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_53.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 54,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_54.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 55,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_55.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 56,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_56.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 57,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_57.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 58,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_58.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 59,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_59.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 60,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_60.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 61,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_61.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 62,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_62.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 63,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_63.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 64,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_64.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 65,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_65.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 66,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_66.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 67,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_67.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 68,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_68.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 69,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_69.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 70,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_70.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 71,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_71.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 72,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_72.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 73,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_73.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 74,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_74.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 75,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_75.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 76,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_76.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 77,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_77.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 78,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_78.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 79,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_79.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 80,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_80.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 81,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_81.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 82,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_82.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 83,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_83.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 84,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_84.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 85,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_85.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 86,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_86.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 87,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_87.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 88,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_88.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 89,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_89.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 90,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_90.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 91,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_91.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 92,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_92.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 93,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_93.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 94,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_94.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 95,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_95.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 96,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_96.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 97,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_97.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 98,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_98.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 99,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_99.jpg");

            migrationBuilder.UpdateData(
                table: "Kirtasiyeler",
                keyColumn: "KirtasiyeId",
                keyValue: 100,
                column: "KapakResimUrl",
                value: "/img/kirtasiye/urun_100.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1,
                column: "KapakResimUrl",
                value: "/img/kitaplar/kitap_1.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 2,
                column: "KapakResimUrl",
                value: "/img/kitaplar/kitap_2.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 3,
                column: "KapakResimUrl",
                value: "/img/kitaplar/kitap_3.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 4,
                column: "KapakResimUrl",
                value: "/img/kitaplar/kitap_4.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 5,
                column: "KapakResimUrl",
                value: "/img/kitaplar/kitap_5.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 6,
                column: "KapakResimUrl",
                value: "/img/kitaplar/kitap_6.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 7,
                column: "KapakResimUrl",
                value: "/img/kitaplar/kitap_7.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 8,
                column: "KapakResimUrl",
                value: "/img/kitaplar/kitap_8.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 9,
                column: "KapakResimUrl",
                value: "/img/kitaplar/kitap_9.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 10,
                column: "KapakResimUrl",
                value: "/img/kitaplar/kitap_10.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 11,
                column: "KapakResimUrl",
                value: "/img/kitaplar/kitap_11.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 12,
                column: "KapakResimUrl",
                value: "/img/kitaplar/kitap_12.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 13,
                column: "KapakResimUrl",
                value: "/img/kitaplar/kitap_13.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 14,
                column: "KapakResimUrl",
                value: "/img/kitaplar/kitap_14.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 16,
                column: "KapakResimUrl",
                value: "/img/kitaplar/kitap_16.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 17,
                column: "KapakResimUrl",
                value: "/img/kitaplar/kitap_17.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 18,
                column: "KapakResimUrl",
                value: "/img/kitaplar/kitap_18.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 19,
                column: "KapakResimUrl",
                value: "/img/kitaplar/kitap_19.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 20,
                column: "KapakResimUrl",
                value: "/img/kitaplar/kitap_20.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 21,
                column: "KapakResimUrl",
                value: "/img/kitaplar/kitap_21.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 22,
                column: "KapakResimUrl",
                value: "/img/kitaplar/kitap_22.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 23,
                column: "KapakResimUrl",
                value: "/img/kitaplar/kitap_23.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 24,
                column: "KapakResimUrl",
                value: "/img/kitaplar/kitap_24.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 25,
                column: "KapakResimUrl",
                value: "/img/kitaplar/kitap_25.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 26,
                column: "KapakResimUrl",
                value: "/img/kitaplar/kitap_26.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 27,
                column: "KapakResimUrl",
                value: "/img/kitaplar/kitap_27.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 28,
                column: "KapakResimUrl",
                value: "/img/kitaplar/kitap_28.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 29,
                column: "KapakResimUrl",
                value: "/img/kitaplar/kitap_29.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 30,
                column: "KapakResimUrl",
                value: "/img/kitaplar/kitap_30.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 31,
                column: "KapakResimUrl",
                value: "/img/kitaplar/kitap_31.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 32,
                column: "KapakResimUrl",
                value: "/img/kitaplar/kitap_32.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 33,
                column: "KapakResimUrl",
                value: "/img/kitaplar/kitap_33.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 34,
                column: "KapakResimUrl",
                value: "/img/kitaplar/kitap_34.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 35,
                column: "KapakResimUrl",
                value: "/img/kitaplar/kitap_35.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 36,
                column: "KapakResimUrl",
                value: "/img/kitaplar/kitap_36.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 37,
                column: "KapakResimUrl",
                value: "/img/kitaplar/kitap_37.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 38,
                column: "KapakResimUrl",
                value: "/img/kitaplar/kitap_38.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 39,
                column: "KapakResimUrl",
                value: "/img/kitaplar/kitap_39.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 40,
                column: "KapakResimUrl",
                value: "/img/kitaplar/kitap_40.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 41,
                column: "KapakResimUrl",
                value: "/img/kitaplar/kitap_41.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 42,
                column: "KapakResimUrl",
                value: "/img/kitaplar/kitap_42.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 43,
                column: "KapakResimUrl",
                value: "/img/kitaplar/kitap_43.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 44,
                column: "KapakResimUrl",
                value: "/img/kitaplar/kitap_44.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 45,
                column: "KapakResimUrl",
                value: "/img/kitaplar/kitap_45.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 46,
                column: "KapakResimUrl",
                value: "/img/kitaplar/kitap_46.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 47,
                column: "KapakResimUrl",
                value: "/img/kitaplar/kitap_47.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 48,
                column: "KapakResimUrl",
                value: "/img/kitaplar/kitap_48.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 49,
                column: "KapakResimUrl",
                value: "/img/kitaplar/kitap_49.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 50,
                column: "KapakResimUrl",
                value: "/img/kitaplar/kitap_50.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 1,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_1.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 2,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_2.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 3,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_3.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 4,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_4.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 5,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_5.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 6,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_6.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 7,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_7.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 8,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_8.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 9,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_9.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 10,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_10.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 11,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_11.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 12,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_12.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 13,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_13.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 14,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_14.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 15,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_15.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 16,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_16.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 17,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_17.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 18,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_18.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 19,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_19.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 20,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_20.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 21,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_21.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 22,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_22.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 23,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_23.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 24,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_24.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 25,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_25.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 26,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_26.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 27,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_27.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 28,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_28.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 29,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_29.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 30,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_30.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 31,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_31.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 32,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_32.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 33,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_33.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 34,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_34.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 35,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_35.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 36,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_36.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 37,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_37.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 38,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_38.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 39,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_39.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 40,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_40.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 41,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_41.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 42,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_42.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 43,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_43.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 44,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_44.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 45,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_45.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 46,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_46.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 47,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_47.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 48,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_48.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 49,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_49.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 50,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_50.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 51,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_51.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 52,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_52.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 53,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_53.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 54,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_54.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 55,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_55.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 56,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_56.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 57,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_57.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 58,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_58.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 59,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_59.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 60,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_60.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 61,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_61.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 62,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_62.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 63,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_63.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 64,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_64.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 65,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_65.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 66,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_66.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 67,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_67.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 68,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_68.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 69,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_69.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 70,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_70.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 71,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_71.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 72,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_72.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 73,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_73.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 74,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_74.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 75,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_75.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 76,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_76.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 77,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_77.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 78,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_78.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 79,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_79.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 80,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_80.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 81,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_81.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 82,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_82.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 83,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_83.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 84,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_84.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 85,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_85.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 86,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_86.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 87,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_87.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 88,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_88.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 89,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_89.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 90,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_90.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 91,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_91.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 92,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_92.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 93,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_93.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 94,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_94.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 95,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_95.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 96,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_96.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 97,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_97.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 98,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_98.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 99,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_99.jpg");

            migrationBuilder.UpdateData(
                table: "Oyuncaklar",
                keyColumn: "OyuncakId",
                keyValue: 100,
                column: "KapakResimUrl",
                value: "/img/oyuncak/urun_100.jpg");

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 1,
                column: "Biyografi",
                value: "Rus edebiyatının en büyük yazarlarından.");

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 2,
                column: "Biyografi",
                value: "Distopik eserleriyle tanınan İngiliz yazar.");

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 3,
                column: "Biyografi",
                value: "Türk edebiyatının usta kalemlerinden.");

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 4,
                column: "Biyografi",
                value: "Avusturyalı romancı ve biyografi yazarı.");

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 5,
                column: "Biyografi",
                value: "Modern Alman edebiyatının öncülerinden.");

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 6,
                column: "Biyografi",
                value: "Polisiye edebiyatın kraliçesi.");

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 7,
                column: "Biyografi",
                value: "Fransız edebiyatının en büyük romantik yazarı.");

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 8,
                column: "Biyografi",
                value: "Psikanalizin kurucusu.");

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 9,
                column: "Biyografi",
                value: "Alman filozof ve kültür eleştirmeni.");

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 10,
                column: "Biyografi",
                value: "Türk tarihçi ve akademisyen.");

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 11,
                column: "Biyografi",
                value: "Türk romanının ve şiirinin önemli ismi.");

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 12,
                column: "Biyografi",
                value: "Postmodern Türk edebiyatının kurucularından.");

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 13,
                column: "Biyografi",
                value: "Varoluşçuluk akımının öncülerinden.");

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 14,
                column: "Biyografi",
                value: "Gerçekçi Rus edebiyatının dev ismi.");

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 15,
                column: "Biyografi",
                value: "Sherlock Holmes karakterinin yaratıcısı.");

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 16,
                column: "Biyografi",
                value: "İsrailli tarihçi ve yazar.");

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 17,
                column: "Biyografi",
                value: "Roma imparatoru ve Stoacı filozof.");

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 18,
                column: "Biyografi",
                value: "Bilimkurgu edebiyatının babası.");

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 19,
                column: "Biyografi",
                value: "İngiliz edebiyatının romantik dönem yazarı.");

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarId",
                keyValue: 20,
                column: "Biyografi",
                value: "Analitik psikolojinin kurucusu.");
        }
    }
}

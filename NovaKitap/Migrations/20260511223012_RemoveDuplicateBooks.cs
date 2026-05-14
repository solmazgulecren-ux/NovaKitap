using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NovaKitap.Migrations
{
    /// <inheritdoc />
    public partial class RemoveDuplicateBooks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1231);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1241);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1251);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1278);

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
                keyValue: 1283);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1301);

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
                keyValue: 1339);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1348);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1354);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1356);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 1375);

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 4,
                column: "KapakResimUrl",
                value: "/img/kitaplar/YorgunSavasci.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 7,
                column: "KapakResimUrl",
                value: "/img/kitaplar/bozkrkurdu.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 10,
                column: "KapakResimUrl",
                value: "/img/kitaplar/HaniminCiftligi.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 12,
                column: "KapakResimUrl",
                value: "/img/kitaplar/seytanAyrintidaGizlidir.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 13,
                column: "KapakResimUrl",
                value: "/img/kitaplar/KorkuyuBeklerken.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 15,
                column: "KapakResimUrl",
                value: "/img/kitaplar/MilenayaMektuplar.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 19,
                column: "KapakResimUrl",
                value: "/img/kitaplar/AylakAdam.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 4,
                column: "KapakResimUrl",
                value: "/img/kitaplar/insanneileyasar.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 7,
                column: "KapakResimUrl",
                value: "/img/kitaplar/Kumarbaz.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 10,
                column: "KapakResimUrl",
                value: "/img/kitaplar/George Orwell 1984.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 12,
                column: "KapakResimUrl",
                value: "/img/kitaplar/Kürk Mantolu Madonna.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 13,
                column: "KapakResimUrl",
                value: "/img/kitaplar/Kürk Mantolu Madonna.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 15,
                column: "KapakResimUrl",
                value: "/img/kitaplar/satranc.jpg");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "KitapId",
                keyValue: 19,
                column: "KapakResimUrl",
                value: "/img/kitaplar/saatleridurdurmaenstitusu.jpg");

            migrationBuilder.InsertData(
                table: "Kitaplar",
                columns: new[] { "KitapId", "Aciklama", "BasimYili", "CokSatanMi", "Fiyat", "KapakResimUrl", "KategoriId", "KitapAdi", "SayfaSayisi", "StokAdedi", "Yayinevi", "YazarId", "YeniCikanMi" },
                values: new object[,]
                {
                    { 1231, "Aşk, gurur ve toplumsal sınıf çatışmaları.", null, true, 175.00m, "/img/kitaplar/gururveonyargi.jpg", 1004, "Gurur ve Önyargı", null, 50, "Nova Kitap", 19, false },
                    { 1241, "Dünya turuna çıkan bir adamın yarışı.", null, true, 160.00m, "/img/kitaplar/seksengundedevrialem.jpg", 1006, "Seksen Günde Devri Alem", null, 50, "Nova Kitap", 18, false },
                    { 1251, "Psikolojik gerilim dolu kısa roman.", null, true, 120.00m, "/img/kitaplar/satranc.jpg", 1004, "Satranç", null, 50, "Nova Kitap", 4, false },
                    { 1278, "Anlam verilemeyen bir suçlama karşısında bireyin çaresizliği.", null, true, 150.00m, "/img/kitaplar/Dava.jpg", 1004, "Dava", null, 50, "Nova Kitap", 5, false },
                    { 1280, "Absürdizmin ve yabancılaşmanın başyapıtı.", null, true, 115.00m, "/img/kitaplar/Yabanci.jpg", 1004, "Yabancı", null, 50, "Nova Kitap", 13, false },
                    { 1281, "Gregor Samsa'nın bir sabah böceğe dönüşme hikayesi.", null, true, 95.00m, "/img/kitaplar/Donusum.jpg", 1004, "Dönüşüm", null, 50, "Nova Kitap", 5, false },
                    { 1283, "Tutku ve irade çatışması üzerine sarsıcı bir roman.", null, true, 130.00m, "/img/kitaplar/Kumarbaz.jpg", 1004, "Kumarbaz", null, 50, "Nova Kitap", 1, false },
                    { 1301, "Salgın hastalık karşısında insanlık ve dayanışma.", null, true, 165.00m, "/img/kitaplar/Veba.jpg", 1004, "Veba", null, 50, "Nova Kitap", 13, false },
                    { 1324, "Lüks bir gemide işlenen ustaca kurgulanmış cinayet.", null, true, 160.00m, "/img/kitaplar/NildeOlum.jpg", 1007, "Nil'de Ölüm", null, 50, "Nova Kitap", 6, false },
                    { 1325, "Polisiye tarihinin en şaşırtıcı sonlarından biri.", null, true, 155.00m, "/img/kitaplar/RogerAckroydCinayeti.jpg", 1007, "Roger Ackroyd Cinayeti", null, 50, "Nova Kitap", 6, false },
                    { 1339, "Gerçekle hayalin birbirine karıştığı modern bir roman.", null, true, 240.00m, "/img/kitaplar/TehlikeliOyunlar.jpg", 1005, "Tehlikeli Oyunlar", null, 50, "Nova Kitap", 12, false },
                    { 1348, "Stoacı imparatorun yaşam ve ölüm üzerine notları.", null, true, 140.00m, "/img/kitaplar/KendimeDusunceler.jpg", 1008, "Kendime Düşünceler", null, 50, "Nova Kitap", 17, false },
                    { 1354, "Geleneksel ahlakın ve değerlerin yıkımı.", null, true, 165.00m, "/img/kitaplar/IyiliginveKotulugunOtesinde.jpg", 1008, "İyinin ve Kötünün Ötesinde", null, 50, "Nova Kitap", 9, false },
                    { 1356, "Batı felsefesine ve değerlerine sert bir meydan okuyuş.", null, false, 140.00m, "/img/kitaplar/PutlarinAlacakaranlg.jpg", 1008, "Putların Alacakaranlığı", null, 50, "Nova Kitap", 9, false },
                    { 1375, "Günümüz dünyasının en acil sorularına cevaplar.", null, false, 200.00m, "/img/kitaplar/21YuzyilIcin21Ders.jpg", 1009, "21. Yüzyıl İçin 21 Ders", null, 50, "Nova Kitap", 16, false }
                });
        }
    }
}

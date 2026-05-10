using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NovaKitap.Migrations
{
    /// <inheritdoc />
    public partial class AdminVeSepetDuzenleme : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Kullanicilar",
                columns: new[] { "KullaniciId", "AdSoyad", "Email", "Rol", "Sifre" },
                values: new object[] { 1, "Eco Solangül", "e@gmail.com", "Admin", "1234" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciId",
                keyValue: 1);
        }
    }
}

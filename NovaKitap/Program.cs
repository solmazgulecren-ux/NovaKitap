using Microsoft.EntityFrameworkCore;
using NovaKitap.Models;

var builder = WebApplication.CreateBuilder(args);

// --- 1. SERVİS KAYITLARI ---
builder.Services.AddControllersWithViews();

// Oturum (Session) ve Layout'tan oturuma erişim servisleri eklendi
builder.Services.AddHttpContextAccessor();
builder.Services.AddSession();

// Veritabanı bağlantısı
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// --- 2. ARA KATMANLAR (Middleware) ---
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

// Oturum kullanımı (Mutlaka UseRouting ve UseAuthorization arasında olmalı)
app.UseSession();

app.UseAuthorization();

// --- 3. ROTALAMA ---
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
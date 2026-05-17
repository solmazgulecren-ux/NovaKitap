using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using NovaKitap.Models;
namespace NovaKitap.Models;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Kategoriler> Kategorilers { get; set; }

    public virtual DbSet<Kaydedilenler> Kaydedilenlers { get; set; }

    public virtual DbSet<Kitaplar> Kitaplar { get; set; }

    public virtual DbSet<Kullanicilar> Kullanicilars { get; set; }

    public virtual DbSet<Yazarlar> Yazarlars { get; set; }

    public DbSet<Yorumlar> Yorumlars { get; set; }

    public DbSet<Siparis> Siparisler { get; set; }
    public DbSet<SiparisDetayi> SiparisDetaylari { get; set; }
    public DbSet<Adresler> Adresler { get; set; }
    public DbSet<Kartlar> Kartlar { get; set; }
    public virtual DbSet<Kirtasiyeler> Kirtasiyelers { get; set; }
    public virtual DbSet<Oyuncaklar> Oyuncaklars { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=NovaKitapDB;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Kategoriler>(entity =>
        {
            entity.HasKey(e => e.KategoriId).HasName("PK__Kategori__1782CC72FD64979E");

            entity.ToTable("Kategoriler");

            entity.Property(e => e.IkonSifi).HasMaxLength(50);
            entity.Property(e => e.KategoriAdi).HasMaxLength(100);
        });

        modelBuilder.Entity<Kaydedilenler>(entity =>
        {
            entity.HasKey(e => e.KayitId).HasName("PK__Kaydedil__BD28AF4BD0CD6182");

            entity.ToTable("Kaydedilenler");

            entity.Property(e => e.KayitTarihi)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Kitap).WithMany(p => p.Kaydedilenlers)
                .HasForeignKey(d => d.KitapId)
                .HasConstraintName("FK__Kaydedile__Kitap__5812160E");

            entity.HasOne(d => d.Kullanici).WithMany(p => p.Kaydedilenlers)
                .HasForeignKey(d => d.KullaniciId)
                .HasConstraintName("FK__Kaydedile__Kulla__571DF1D5");
        });

        modelBuilder.Entity<Kitaplar>(entity =>
        {
            entity.HasKey(e => e.KitapId).HasName("PK__Kitaplar__89491B0C9F34EF61");

            entity.ToTable("Kitaplar");

            entity.Property(e => e.CokSatanMi).HasDefaultValue(false);
            entity.Property(e => e.Fiyat).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.KapakResimUrl).HasMaxLength(500);
            entity.Property(e => e.KitapAdi).HasMaxLength(200);
            entity.Property(e => e.YeniCikanMi).HasDefaultValue(false);

            entity.HasOne(d => d.Kategori).WithMany(p => p.Kitaplars)
                .HasForeignKey(d => d.KategoriId)
                .HasConstraintName("FK__Kitaplar__Katego__5165187F");

            entity.HasOne(d => d.Yazar).WithMany(p => p.Kitaplars)
                .HasForeignKey(d => d.YazarId)
                .HasConstraintName("FK__Kitaplar__YazarI__5070F446");
        });

        modelBuilder.Entity<Kullanicilar>(entity =>
        {
            entity.HasKey(e => e.KullaniciId).HasName("PK__Kullanic__E011F77B953AA4E8");

            entity.ToTable("Kullanicilar");

            entity.HasIndex(e => e.Email, "UQ__Kullanic__A9D1053422C2AF0E").IsUnique();

            entity.Property(e => e.AdSoyad).HasMaxLength(150);
            entity.Property(e => e.Email).HasMaxLength(150);
            entity.Property(e => e.Sifre).HasMaxLength(100);
            entity.Property(e => e.Telefon).HasMaxLength(20);
        });

        modelBuilder.Entity<Yazarlar>(entity =>
        {
            entity.HasKey(e => e.YazarId).HasName("PK__Yazarlar__CF636CE1C5425819");

            entity.ToTable("Yazarlar");

            entity.Property(e => e.AdSoyad).HasMaxLength(150);
        });

        modelBuilder.Seed();
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

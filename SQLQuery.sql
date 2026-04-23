CREATE DATABASE NovaKitapDB;
GO

USE NovaKitapDB;
GO

-- 1. Kategoriler Tablosu
CREATE TABLE Kategoriler (
    KategoriId INT IDENTITY(1,1) PRIMARY KEY,
    KategoriAdi NVARCHAR(100) NOT NULL,
    IkonSifi NVARCHAR(50) -- UI tarafında yıldız veya özel ikon class'ları tutmak için
);

-- 2. Yazarlar Tablosu
CREATE TABLE Yazarlar (
    YazarId INT IDENTITY(1,1) PRIMARY KEY,
    AdSoyad NVARCHAR(150) NOT NULL,
    Biyografi NVARCHAR(MAX)
);

-- 3. Kitaplar Tablosu
CREATE TABLE Kitaplar (
    KitapId INT IDENTITY(1,1) PRIMARY KEY,
    KitapAdi NVARCHAR(200) NOT NULL,
    Aciklama NVARCHAR(MAX),
    SayfaSayisi INT,
    Fiyat DECIMAL(18,2) NOT NULL,
    KapakResimUrl NVARCHAR(500),
    YeniCikanMi BIT DEFAULT 0,  -- Anasayfa barları için
    CokSatanMi BIT DEFAULT 0,   -- Anasayfa barları için
    YazarId INT FOREIGN KEY REFERENCES Yazarlar(YazarId),
    KategoriId INT FOREIGN KEY REFERENCES Kategoriler(KategoriId)
);

-- 4. Kullanıcılar Tablosu (Giriş Yap / Kayıt Ol için)
CREATE TABLE Kullanicilar (
    KullaniciId INT IDENTITY(1,1) PRIMARY KEY,
    AdSoyad NVARCHAR(150) NOT NULL,
    Email NVARCHAR(150) NOT NULL UNIQUE,
    Sifre NVARCHAR(100) NOT NULL
);

-- 5. Kaydedilen Kitaplar (Kutup Yıldızı İşlevi İçin)
CREATE TABLE Kaydedilenler (
    KayitId INT IDENTITY(1,1) PRIMARY KEY,
    KullaniciId INT FOREIGN KEY REFERENCES Kullanicilar(KullaniciId),
    KitapId INT FOREIGN KEY REFERENCES Kitaplar(KitapId),
    KayitTarihi DATETIME DEFAULT GETDATE()
);
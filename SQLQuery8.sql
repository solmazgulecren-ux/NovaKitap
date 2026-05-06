-- 1. Rol sütununu ekle ve varsayılan olarak 'Musteri' yap
ALTER TABLE [dbo].[Kullanicilar] ADD [Rol] NVARCHAR(20) DEFAULT ('Musteri') NOT NULL;

-- 2. Kendi hesabını Admin yap (Buraya kayıtlı olduğun e-posta adresini yazmalısın!)
UPDATE [dbo].[Kullanicilar] SET [Rol] = 'Admin' WHERE [Email] = 'senin_email_adresin@example.com';

-- 3. Stok sütunlarını ekle
ALTER TABLE [dbo].[Kitaplar] ADD [StokAdedi] INT DEFAULT (0) NOT NULL;
ALTER TABLE [dbo].[Kirtasiyeler] ADD [StokAdedi] INT DEFAULT (0) NOT NULL;
ALTER TABLE [dbo].[Oyuncaklar] ADD [StokAdedi] INT DEFAULT (0) NOT NULL;

-- 4. Sayfa boş kalmasın diye hepsine varsayılan stok ekle
UPDATE [dbo].[Kitaplar] SET [StokAdedi] = 50;
UPDATE [dbo].[Kirtasiyeler] SET [StokAdedi] = 100;
UPDATE [dbo].[Oyuncaklar] SET [StokAdedi] = 30;
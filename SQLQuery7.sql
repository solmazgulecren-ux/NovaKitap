ALTER TABLE [dbo].[Kitaplar] ADD [StokAdedi] INT DEFAULT (0) NOT NULL;
ALTER TABLE [dbo].[Kirtasiyeler] ADD [StokAdedi] INT DEFAULT (0) NOT NULL;
ALTER TABLE [dbo].[Oyuncaklar] ADD [StokAdedi] INT DEFAULT (0) NOT NULL;

-- Başlangıç için hepsine biraz stok ekleyelim ki sayfa boş kalmasın
UPDATE [dbo].[Kitaplar] SET [StokAdedi] = 50;
UPDATE [dbo].[Kirtasiyeler] SET [StokAdedi] = 100;
UPDATE [dbo].[Oyuncaklar] SET [StokAdedi] = 30;
ALTER TABLE [dbo].[Kitaplar] ADD [StokAdedi] INT DEFAULT (0) NOT NULL;
GO

ALTER TABLE [dbo].[Kirtasiyeler] ADD [StokAdedi] INT DEFAULT (0) NOT NULL;
GO

ALTER TABLE [dbo].[Oyuncaklar] ADD [StokAdedi] INT DEFAULT (0) NOT NULL;
GO

UPDATE [dbo].[Kitaplar] SET [StokAdedi] = 50;
UPDATE [dbo].[Kirtasiyeler] SET [StokAdedi] = 100;
UPDATE [dbo].[Oyuncaklar] SET [StokAdedi] = 30;
GO
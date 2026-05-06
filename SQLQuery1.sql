-- KIRTASİYE TABLOSU
CREATE TABLE [dbo].[Kirtasiyeler] (
    [KirtasiyeId]   INT             IDENTITY (1, 1) NOT NULL,
    [UrunAdi]       NVARCHAR (200)  NOT NULL,
    [Aciklama]      NVARCHAR (MAX)  NULL,
    [Fiyat]         DECIMAL (18, 2) NOT NULL,
    [KapakResimUrl] NVARCHAR (500)  NULL,
    [YeniCikanMi]   BIT             DEFAULT ((0)) NULL,
    [CokSatanMi]    BIT             DEFAULT ((0)) NULL,
    [KategoriId]    INT             NULL,
    [Marka]         NVARCHAR (150)  NULL,
    [UrunTuru]      NVARCHAR (100)  NULL, -- Örn: Defter, Kalem, Çanta
    PRIMARY KEY CLUSTERED ([KirtasiyeId] ASC),
    FOREIGN KEY ([KategoriId]) REFERENCES [dbo].[Kategoriler] ([KategoriId])
);

-- OYUNCAK TABLOSU
CREATE TABLE [dbo].[Oyuncaklar] (
    [OyuncakId]     INT             IDENTITY (1, 1) NOT NULL,
    [UrunAdi]       NVARCHAR (200)  NOT NULL,
    [Aciklama]      NVARCHAR (MAX)  NULL,
    [Fiyat]         DECIMAL (18, 2) NOT NULL,
    [KapakResimUrl] NVARCHAR (500)  NULL,
    [YeniCikanMi]   BIT             DEFAULT ((0)) NULL,
    [CokSatanMi]    BIT             DEFAULT ((0)) NULL,
    [KategoriId]    INT             NULL,
    [YasGrubu]      NVARCHAR (50)   NULL, -- Örn: 3+, 8-12 Yaş
    [Marka]         NVARCHAR (150)  NULL,
    PRIMARY KEY CLUSTERED ([OyuncakId] ASC),
    FOREIGN KEY ([KategoriId]) REFERENCES [dbo].[Kategoriler] ([KategoriId])
);
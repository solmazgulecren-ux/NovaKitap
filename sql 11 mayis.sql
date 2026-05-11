DECLARE @i INT;

-- 1. KİTAPLAR İÇİN YORUMLAR (50 Kitap x 2 Yorum)
SET @i = 1;
WHILE @i <= 50
BEGIN
    INSERT INTO [Yorumlar] ([UrunId], [UrunTipi], [KullaniciAdi], [Yildiz], [YorumMetni], [Tarih])
    VALUES 
    (@i, 'Kitap', 'KitapKurdu_' + CAST(@i AS NVARCHAR), (ABS(CHECKSUM(NEWID())) % 2) + 4, 'Okuduğum en etkileyici eserlerden biriydi. Çevirisi çok başarılı, herkese tavsiye ederim.', DATEADD(day, -(ABS(CHECKSUM(NEWID())) % 30), GETDATE())),
    (@i, 'Kitap', 'Okur_' + CAST(@i AS NVARCHAR), (ABS(CHECKSUM(NEWID())) % 3) + 3, 'Kütüphanemde mutlaka bulunması gereken bir eser. Kargolama biraz gecikse de elime sağlam ulaştı.', DATEADD(day, -(ABS(CHECKSUM(NEWID())) % 20), GETDATE()));
    SET @i = @i + 1;
END

-- 2. KIRTASİYE İÇİN YORUMLAR (100 Ürün x 2 Yorum)
SET @i = 1;
WHILE @i <= 100
BEGIN
    INSERT INTO [Yorumlar] ([UrunId], [UrunTipi], [KullaniciAdi], [Yildiz], [YorumMetni], [Tarih])
    VALUES 
    (@i, 'Kirtasiye', 'Ogrenci_' + CAST(@i AS NVARCHAR), (ABS(CHECKSUM(NEWID())) % 2) + 4, 'Malzeme kalitesi muazzam. Kesinlikle parasını sonuna kadar hak ediyor, çok memnun kaldım.', DATEADD(day, -(ABS(CHECKSUM(NEWID())) % 15), GETDATE())),
    (@i, 'Kirtasiye', 'Tasarimci_' + CAST(@i AS NVARCHAR), (ABS(CHECKSUM(NEWID())) % 3) + 3, 'Günlük kullanım için ideal. Beklentilerimi büyük ölçüde karşıladı.', DATEADD(day, -(ABS(CHECKSUM(NEWID())) % 10), GETDATE()));
    SET @i = @i + 1;
END

-- 3. OYUNCAKLAR İÇİN YORUMLAR (100 Ürün x 2 Yorum)
SET @i = 1;
WHILE @i <= 100
BEGIN
    INSERT INTO [Yorumlar] ([UrunId], [UrunTipi], [KullaniciAdi], [Yildiz], [YorumMetni], [Tarih])
    VALUES 
    (@i, 'Oyuncak', 'Ebeveyn_' + CAST(@i AS NVARCHAR), 5, 'Çocuğum bayıldı! Parçaları çok kaliteli ve güvenli. Hediye paketi de çok özenliydi, teşekkürler Nova Kitap.', DATEADD(day, -(ABS(CHECKSUM(NEWID())) % 25), GETDATE())),
    (@i, 'Oyuncak', 'Koleksiyoner_' + CAST(@i AS NVARCHAR), 4, 'Koleksiyonum için harika bir parça oldu. Detayları gerçekten çok iyi işlenmiş.', DATEADD(day, -(ABS(CHECKSUM(NEWID())) % 5), GETDATE()));
    SET @i = @i + 1;
END
GO
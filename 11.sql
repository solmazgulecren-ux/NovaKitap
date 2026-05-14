UPDATE Kitaplar 
SET KapakResimUrl = '/img/kitaplar/' + 
    LOWER(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(KitapAdi, ' ', '_'), 'ı', 'i'), 'ğ', 'g'), 'ü', 'u'), 'ş', 's'), 'ö', 'o'), 'ç', 'c')) + '.jpg'
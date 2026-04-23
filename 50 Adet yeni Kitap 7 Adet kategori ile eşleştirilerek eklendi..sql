USE NovaKitapDB;
GO

-- 1. KATEGORİLERİ EKLİYORUZ
-- Kimlik (Identity) eklemeyi geçici olarak açıyoruz ki ID'ler 1'den 7'ye tam otursun.
SET IDENTITY_INSERT Kategoriler ON;

INSERT INTO Kategoriler (KategoriId, KategoriAdi, IkonSifi) VALUES 
(1, 'Klasik', '✧'),
(2, 'Edebiyat', '✧'),
(3, 'Psikoloji', '✧'),
(4, 'Tarih', '✧'),
(5, 'Felsefe', '✧'),
(6, 'Polisiye', '✧'),
(7, 'Roman', '✧');

SET IDENTITY_INSERT Kategoriler OFF;
GO

-- 2. YAZARLARI EKLİYORUZ
INSERT INTO Yazarlar (AdSoyad, Biyografi) VALUES 
('Fyodor Dostoyevski', 'Rus edebiyatının en büyük yazarlarından.'), -- 1
('George Orwell', 'Distopik eserleriyle tanınan İngiliz yazar.'), -- 2
('Sabahattin Ali', 'Türk edebiyatının usta kalemlerinden.'), -- 3
('Stefan Zweig', 'Avusturyalı romancı ve biyografi yazarı.'), -- 4
('Franz Kafka', 'Modern Alman edebiyatının öncülerinden.'), -- 5
('Agatha Christie', 'Polisiye edebiyatın kraliçesi.'), -- 6
('Victor Hugo', 'Fransız edebiyatının en büyük romantik yazarı.'), -- 7
('Sigmund Freud', 'Psikanalizin kurucusu.'), -- 8
('Friedrich Nietzsche', 'Alman filozof ve kültür eleştirmeni.'), -- 9
('İlber Ortaylı', 'Türk tarihçi ve akademisyen.'), -- 10
('Ahmet Hamdi Tanpınar', 'Türk romanının ve şiirinin önemli ismi.'), -- 11
('Oğuz Atay', 'Postmodern Türk edebiyatının kurucularından.'), -- 12
('Albert Camus', 'Varoluşçuluk akımının öncülerinden.'), -- 13
('Lev Tolstoy', 'Gerçekçi Rus edebiyatının dev ismi.'), -- 14
('Arthur Conan Doyle', 'Sherlock Holmes karakterinin yaratıcısı.'), -- 15
('Yuval Noah Harari', 'İsrailli tarihçi ve yazar.'), -- 16
('Marcus Aurelius', 'Roma imparatoru ve Stoacı filozof.'), -- 17
('Jules Verne', 'Bilimkurgu edebiyatının babası.'), -- 18
('Jane Austen', 'İngiliz edebiyatının romantik dönem yazarı.'), -- 19
('Carl Gustav Jung', 'Analitik psikolojinin kurucusu.'); -- 20
GO

-- 3. 50 ADET GERÇEK KİTABI EKLİYORUZ
INSERT INTO Kitaplar (KitapAdi, Aciklama, SayfaSayisi, Fiyat, KapakResimUrl, YeniCikanMi, CokSatanMi, YazarId, KategoriId) VALUES 
-- KLASİKLER (Kategori 1)
('Suç ve Ceza', 'Bir cinayetin psikolojik tahlili.', 687, 145.50, 'https://via.placeholder.com/220x300/1B2A4A/C0C0C0?text=Suc+ve+Ceza', 0, 1, 1, 1),
('Karamazov Kardeşler', 'İnsan ruhunun derinliklerine bir yolculuk.', 840, 185.00, 'https://via.placeholder.com/220x300/1B2A4A/C0C0C0?text=Karamazov', 0, 0, 1, 1),
('Sefiller', 'Jean Valjeanin epik hikayesi.', 1200, 250.00, 'https://via.placeholder.com/220x300/1B2A4A/C0C0C0?text=Sefiller', 0, 1, 7, 1),
('Savaş ve Barış', 'Napolyon döneminde Rusya.', 1225, 275.00, 'https://via.placeholder.com/220x300/1B2A4A/C0C0C0?text=Savas+ve+Baris', 0, 0, 14, 1),
('Anna Karenina', 'Trajik bir aşk hikayesi.', 864, 190.00, 'https://via.placeholder.com/220x300/1B2A4A/C0C0C0?text=Anna+Karenina', 0, 0, 14, 1),
('Gurur ve Önyargı', 'Toplumsal sınıflar ve aşk.', 432, 95.00, 'https://via.placeholder.com/220x300/1B2A4A/C0C0C0?text=Gurur+ve+Onyargi', 0, 1, 19, 1),
('Yeraltından Notlar', 'Modern insanın yabancılaşması.', 150, 65.00, 'https://via.placeholder.com/220x300/1B2A4A/C0C0C0?text=Yeraltindan', 1, 0, 1, 1),
('Kumarbaz', 'Tutku ve yıkımın romanı.', 190, 75.00, 'https://via.placeholder.com/220x300/1B2A4A/C0C0C0?text=Kumarbaz', 0, 0, 1, 1),

-- EDEBİYAT & ROMAN (Kategori 2 ve 7)
('1984', 'Büyük Birader seni izliyor.', 352, 110.00, 'https://via.placeholder.com/220x300/1B2A4A/C0C0C0?text=1984', 0, 1, 2, 7),
('Hayvan Çiftliği', 'Bütün hayvanlar eşittir.', 152, 85.00, 'https://via.placeholder.com/220x300/1B2A4A/C0C0C0?text=Hayvan+Ciftligi', 1, 1, 2, 7),
('Kürk Mantolu Madonna', 'Unutulmaz bir aşkın hüzünlü portresi.', 160, 70.00, 'https://via.placeholder.com/220x300/1B2A4A/C0C0C0?text=Kurk+Mantolu', 0, 1, 3, 7),
('İçimizdeki Şeytan', 'Aydın kesimin eleştirisi.', 260, 90.00, 'https://via.placeholder.com/220x300/1B2A4A/C0C0C0?text=Icimizdeki+Seytan', 0, 0, 3, 7),
('Kuyucaklı Yusuf', 'Bir Anadolu kasabasının dramı.', 220, 85.00, 'https://via.placeholder.com/220x300/1B2A4A/C0C0C0?text=Kuyucakli+Yusuf', 0, 0, 3, 7),
('Satranç', 'Bir gemide geçen psikolojik gerilim.', 85, 45.00, 'https://via.placeholder.com/220x300/1B2A4A/C0C0C0?text=Satranc', 1, 1, 4, 7),
('Bilinmeyen Bir Kadının Mektubu', 'Karşılıksız bir aşkın itirafı.', 65, 35.00, 'https://via.placeholder.com/220x300/1B2A4A/C0C0C0?text=Bilinmeyen+Kadin', 0, 0, 4, 7),
('Dönüşüm', 'Gregor Samsa bir sabah uyandığında...', 104, 55.00, 'https://via.placeholder.com/220x300/1B2A4A/C0C0C0?text=Donusum', 0, 1, 5, 2),
('Dava', 'Suçunu bilmeyen bir adamın yargılanışı.', 270, 95.00, 'https://via.placeholder.com/220x300/1B2A4A/C0C0C0?text=Dava', 0, 0, 5, 2),
('Saatleri Ayarlama Enstitüsü', 'Doğu-Batı çatışmasının absürt yüzü.', 382, 130.00, 'https://via.placeholder.com/220x300/1B2A4A/C0C0C0?text=Saatleri+Ayarlama', 1, 1, 11, 7),
('Huzur', 'İstanbul fonunda bir iç hesaplaşma.', 390, 135.00, 'https://via.placeholder.com/220x300/1B2A4A/C0C0C0?text=Huzur', 0, 0, 11, 2),
('Tutunamayanlar', 'Türk aydınının trajedisi.', 724, 210.00, 'https://via.placeholder.com/220x300/1B2A4A/C0C0C0?text=Tutunamayanlar', 0, 1, 12, 7),
('Tehlikeli Oyunlar', 'Oyunlarla yaşayan bir aydın.', 480, 150.00, 'https://via.placeholder.com/220x300/1B2A4A/C0C0C0?text=Tehlikeli+Oyunlar', 0, 0, 12, 7),
('Yabancı', 'Topluma yabancılaşmış bir adam.', 112, 60.00, 'https://via.placeholder.com/220x300/1B2A4A/C0C0C0?text=Yabanci', 1, 1, 13, 2),
('Veba', 'Kuşatılmış bir şehirde dayanışma.', 300, 115.00, 'https://via.placeholder.com/220x300/1B2A4A/C0C0C0?text=Veba', 0, 0, 13, 2),
('Denizler Altında Yirmibin Fersah', 'Kaptan Nemo ile sualtı macerası.', 450, 125.00, 'https://via.placeholder.com/220x300/1B2A4A/C0C0C0?text=Denizler+Altinda', 0, 0, 18, 7),
('Seksen Günde Devri Alem', 'Phileas Foggun zamana karşı yarışı.', 320, 110.00, 'https://via.placeholder.com/220x300/1B2A4A/C0C0C0?text=Seksen+Gunde', 1, 0, 18, 7),
('Amok Koşucusu', 'Sırrını saklayan bir doktorun çöküşü.', 70, 40.00, 'https://via.placeholder.com/220x300/1B2A4A/C0C0C0?text=Amok+Kosucusu', 0, 0, 4, 2),

-- POLİSİYE (Kategori 6)
('On Kişiydiler (On Küçük Zenci)', 'Bir adada mahsur kalan 10 yabancı.', 224, 105.00, 'https://via.placeholder.com/220x300/1B2A4A/C0C0C0?text=On+Kisiydiler', 0, 1, 6, 6),
('Doğu Ekspresinde Cinayet', 'Karda mahsur kalan trende bir cinayet.', 256, 115.00, 'https://via.placeholder.com/220x300/1B2A4A/C0C0C0?text=Dogu+Ekspresinde', 1, 1, 6, 6),
('Roger Ackroyd Cinayeti', 'Hercule Poirotun en zorlu vakası.', 280, 120.00, 'https://via.placeholder.com/220x300/1B2A4A/C0C0C0?text=Roger+Ackroyd', 0, 0, 6, 6),
('Nil''de Ölüm', 'Mısırda bir gemi yolculuğunda trajedi.', 310, 130.00, 'https://via.placeholder.com/220x300/1B2A4A/C0C0C0?text=Nilde+Olum', 0, 0, 6, 6),
('Sherlock Holmes - Kızıl Soruşturma', 'Holmesun ilk macerası.', 160, 75.00, 'https://via.placeholder.com/220x300/1B2A4A/C0C0C0?text=Kizil+Sorusturma', 1, 1, 15, 6),
('Sherlock Holmes - Dörtlerin İmzası', 'Gizemli bir hazine peşinde.', 180, 80.00, 'https://via.placeholder.com/220x300/1B2A4A/C0C0C0?text=Dortlerin+Imzasi', 0, 0, 15, 6),
('Baskerville''lerin Köpeği', 'Lanetli bir ailenin sırrı.', 240, 100.00, 'https://via.placeholder.com/220x300/1B2A4A/C0C0C0?text=Baskervillelerin', 0, 1, 15, 6),

-- PSİKOLOJİ (Kategori 3)
('Düşlerin Yorumu', 'Rüyaların gizli anlamları.', 550, 180.00, 'https://via.placeholder.com/220x300/1B2A4A/C0C0C0?text=Duslerin+Yorumu', 0, 1, 8, 3),
('Uygarlığın Huzursuzluğu', 'İnsan doğası ve toplum çatışması.', 120, 65.00, 'https://via.placeholder.com/220x300/1B2A4A/C0C0C0?text=Uygarligin', 1, 0, 8, 3),
('Gündelik Hayatın Psikopatolojisi', 'Dil sürçmeleri ve unutkanlıklar.', 320, 135.00, 'https://via.placeholder.com/220x300/1B2A4A/C0C0C0?text=Psikopatoloji', 0, 0, 8, 3),
('İnsan Ruhuna Yöneliş', 'Analitik psikoloji üzerine yazılar.', 280, 125.00, 'https://via.placeholder.com/220x300/1B2A4A/C0C0C0?text=Insan+Ruhuna', 0, 0, 20, 3),
('Keşfedilmemiş Benlik', 'Bireyin modern toplumdaki yeri.', 140, 75.00, 'https://via.placeholder.com/220x300/1B2A4A/C0C0C0?text=Kesfedilmemis+Benlik', 1, 1, 20, 3),
('Kırmızı Kitap', 'Jungun iç dünyasına yolculuk.', 400, 250.00, 'https://via.placeholder.com/220x300/1B2A4A/C0C0C0?text=Kirmizi+Kitap', 0, 0, 20, 3),

-- FELSEFE (Kategori 5)
('Böyle Söyledi Zerdüşt', 'Üstinsan kavramının doğuşu.', 350, 140.00, 'https://via.placeholder.com/220x300/1B2A4A/C0C0C0?text=Zerdust', 0, 1, 9, 5),
('İyinin ve Kötünün Ötesinde', 'Ahlak felsefesine eleştirel bakış.', 240, 110.00, 'https://via.placeholder.com/220x300/1B2A4A/C0C0C0?text=Iyinin+ve+Kotunun', 1, 0, 9, 5),
('Putların Alacakaranlığı', 'Eski değerlerin yıkılışı.', 130, 70.00, 'https://via.placeholder.com/220x300/1B2A4A/C0C0C0?text=Putlarin', 0, 0, 9, 5),
('Kendime Düşünceler', 'Bir imparatorun felsefi günlüğü.', 160, 80.00, 'https://via.placeholder.com/220x300/1B2A4A/C0C0C0?text=Kendime+Dusunceler', 1, 1, 17, 5),
('Sisifos Söyleni', 'Absürt felsefesinin temeli.', 150, 75.00, 'https://via.placeholder.com/220x300/1B2A4A/C0C0C0?text=Sisifos+Soyleni', 0, 1, 13, 5),
('Başkaldıran İnsan', 'İsyanın metafizik tarihi.', 380, 145.00, 'https://via.placeholder.com/220x300/1B2A4A/C0C0C0?text=Baskaldiran', 0, 0, 13, 5),

-- TARİH (Kategori 4)
('Sapiens: Hayvanlardan Tanrılara', 'İnsanlığın kısa tarihi.', 412, 160.00, 'https://via.placeholder.com/220x300/1B2A4A/C0C0C0?text=Sapiens', 0, 1, 16, 4),
('Homo Deus: Yarının Kısa Tarihi', 'İnsanlığın gelecekteki rotası.', 450, 175.00, 'https://via.placeholder.com/220x300/1B2A4A/C0C0C0?text=Homo+Deus', 1, 1, 16, 4),
('21. Yüzyıl İçin 21 Ders', 'Günümüz sorunlarına tarihsel bakış.', 368, 150.00, 'https://via.placeholder.com/220x300/1B2A4A/C0C0C0?text=21+Ders', 0, 0, 16, 4),
('Bir Ömür Nasıl Yaşanır?', 'Hayatta doğru seçimler yapmak üzerine.', 288, 130.00, 'https://via.placeholder.com/220x300/1B2A4A/C0C0C0?text=Bir+Omur', 0, 1, 10, 4),
('Gazi Mustafa Kemal Atatürk', 'Atatürkün detaylı biyografisi.', 480, 195.00, 'https://via.placeholder.com/220x300/1B2A4A/C0C0C0?text=Gazi+Mustafa+Kemal', 1, 1, 10, 4);
GO
use master
go

create database MarlaRestaurant
use MarlaRestaurant
go

create table Calisan(
CalisanID int not null primary key identity(1,1),
CalisanAdi nvarchar(50) not null,
CalisanSoyadi nvarchar(50) not null,
Unvan nvarchar(50) not null,
RestaurantID int not null
)
create table CalisanDetay(
CalisanDetayID int not null primary key,
Maas decimal(18,2) not null,
Tckn nvarchar(50) not null,
TelNo nvarchar(50) not null,
Mail  nvarchar(50)
)
create table Restaurant(
RestaurantID int not null primary key identity(1,1),
RestaurantAdi nvarchar(50) not null,
Sehir nvarchar(50),
Adres nvarchar(250),
Tel nvarchar(12)
)
create table Urun(
UrunID int not null primary key identity(1,1),
KategoriID int not null,
UrunAdi nvarchar(50) not null,
UrunAciklamasi nvarchar(250),
Fiyat decimal(18,2) not null,
Durum bit 
)
create table Menu(
MenuID int not null primary key,
MenuAdi nvarchar(50)
)
Create table MenuKategori(
MenuKategoriID int not null primary key identity (1,1),
MenuKategoriAdi nvarchar(50)
)
create table Siparis(
SiparisID int not null primary key identity(1,1),
SiparisTarihi datetime not null,
TeslimTarihi datetime not null,
SiparisTuru bit,
MasaNumarası int
)
create table UrunSiparisDetay(
UrunSiparisDetayID int not null primary key identity(1,1),
UrunID int not null,
SiparisID int not null,
SiparisMiktari int,
Fiyat decimal(18,2) not null
)
create table Depo(
DepoID int not null primary key identity(1,1),
DepoAdi nvarchar(50),
Adres nvarchar(250)
)
create table Malzeme(
MalzemeID int not null primary key identity(1,1),
MalzemeAdi nvarchar(50),
Durum bit
)
create table MalzemeKategori(
MalzemeKategoriID int not null primary key identity(1,1),
MalzemeKategoriAdi nvarchar(50)
)
create table UrunMalzemeDetay(
UrunMalzemeID int primary key identity(1,1) not null,
UrunID int not null,
MalzemeID int not null,
MalzemeStok int not null
)
create table Tedarikci(
TedarikciID int not null primary key identity(1,1),
TedarikciAdi nvarchar(50) not null,
)
create table DepoMalzemeDetay(
DepoMalzemeID int primary key identity(1,1) not null,
DepoID int not null,
MalzemeID int not null,
DepoStok int not null
)
create table Musteri(
MusteriID int not null primary key identity(1,1),
Adi nvarchar(50),
Soyadi nvarchar(50),
Adres nvarchar(50),
Telefon nvarchar(50)
)
create table Adisyon(
AdisyonID int not null primary key identity(1,1),
Tarih datetime not null
)
create table OdemeYontemi(
OdemeYontemiID int not null primary key identity(1,1),
OdemeYontemiAdi nvarchar(50)
)
create table AdisyonOdemeDetay( AdisyonOdemeDetayID int primary key identity(1,1) not null,
AdisyonID int not null,
OdemeYontemiID int not null,
OdemeYontemiAdi nvarchar(50)
)
create table AdisyonSiparisDetay(
AdisyonSiparisDetayID int primary key identity(1,1) not null,
SiparisID int not null,
AdisyonID int not null
)
create table RestaurantMalzemeDetay(
RestaurantMalzemeDetayID int primary key identity(1,1) not null,
MalzemeID int not null,
RestaurantID int not null,
RestaurantStok int
)
create table TahsilatTipi(
TahsilatTipiID int primary key identity(1,1) not null,
TahsilatAdi nvarchar(30),
)
create table CariHesaplar(
CariHesapID int primary key identity(1,1) not null,
CariKodu nvarchar(15) not null,
Unvan nvarchar(50) not null,
VergiNumarasi nvarchar(50) not null,
VergiDairesi nvarchar(50) not null,
Telefon char(11),
Adres nvarchar(150),
)
alter table RestaurantMalzemeDetay add constraint Fk_RestaurantMalzemeDetay01 foreign key (RestaurantID) references Restaurant(RestaurantID)
alter table RestaurantMalzemeDetay add constraint Fk_RestaurantMalzemeDetay02 foreign key (MalzemeID) references Malzeme(MalzemeID)
alter table Calisan add constraint Fk_Calisan01 foreign key (RestaurantID) references Restaurant(RestaurantID)
alter table CalisanDetay add constraint Fk_CalisanDetay01 foreign key (CalisanDetayID) references Calisan(CalisanID)
alter table Restaurant Add MenuID int foreign key references Menu(MenuID)
alter table Urun add constraint Fk_UrunKategori foreign key (KategoriID) references MenuKategori(MenuKategoriID)
alter table Siparis add MusteriID int foreign key references Musteri(MusteriID)
alter table UrunSiparisDetay add constraint Fk_UrunSiparisDetay01 foreign key (SiparisID) references Siparis(SiparisID)
alter table UrunSiparisDetay add constraint Fk_UrunSiparisDetay02 foreign key (UrunID) references Urun(UrunID)
alter table Malzeme add MalzemeKategoriID int foreign key references MalzemeKategori(MalzemeKategoriID)
alter table Malzeme add TedarikciID int foreign key references Tedarikci(TedarikciID)
alter table UrunMalzemeDetay add constraint Fk_UrunMalzemeDetay01 foreign key (UrunID) references Urun(UrunID)
alter table UrunMalzemeDetay add constraint Fk_UrunMalzemeDetay02 foreign key (MalzemeID) references Malzeme(MalzemeID)
alter table DepoMalzemeDetay add constraint Fk_DepoMalzemeDetay01 foreign key (DepoID) references Depo(DepoID)
alter table DepoMalzemeDetay add constraint Fk_DepoMalzemeDetay02 foreign key (MalzemeID) references Malzeme(MalzemeID)
alter table AdisyonSiparisDetay add constraint Fk_AdisyonOdemeDetay05 foreign key (AdisyonID) references Adisyon(AdisyonID)
alter table AdisyonSiparisDetay add constraint Fk_AdisyonOdemeDetay06 foreign key (SiparisID) references Siparis(SiparisID)
alter table AdisyonOdemeDetay add constraint Fk_AdisyonOdemeDetay01 foreign key (AdisyonID) references Adisyon(AdisyonID)
alter table AdisyonOdemeDetay add constraint Fk_AdisyonOdemeDetay02 foreign key (OdemeYontemiID) references OdemeYontemi(OdemeYontemiID)
alter table MenuKategori add MenuID int foreign key references Menu(MenuID)
alter table Siparis add CalisanId int foreign key references Calisan(CalisanId)
alter table CariHesaplar add TedarikciID int foreign key references Tedarikci(TedarikciID) 
alter table TahsilatTipi add CariHesapID int foreign key references CariHesaplar(CariHesapID) 

select * from Menu
INSERT Menu VALUES (1,'Marla Menu')

select * from Restaurant
INSERT Restaurant VALUES ('Marla','İstanbul','İstanbul/Kadıköy','02166215455',1),
						 ('Marla','İstanbul','İstanbul/Beşiktaş','02126215455',1),
						 ('Marla','Ankara','Ankara/Çankaya','03126625456',1)

select * from Calisan
INSERT Calisan VALUES ('Ravza','YILMAZ','Müdür',1),
					  ('Mert','DİKAN','Şef',1),
					  ('Esra','KAHRAMAN','Aşçı',1),
					  ('Bahar','KARABAĞLI','Garson',1),
					  ('Ozan','YİĞİT','Kurye',1),
					  ('Hamza','DURMAZ','Kurye',1),
					  ('Volkan','USLUOL','Müdür',2),
					  ('Erkan','KİRAZ','Şef',2),
					  ('Alican','KELEŞ','Aşçı',2),
					  ('Furkan','AYTEKİN','Garson',2),
					  ('Can','KILIÇ','Kurye',2),
					  ('Fırat','GÜLER','Kurye',2),
					  ('Emekcan','DURMUŞ','Müdür',3),
					  ('Mesut','ATMACA','Şef',3),
					  ('Yahya','ÇİFTÇİ','Aşçı',3),
					  ('Burak','YILMAZ','Garson',3),
					  ('Metin','TEKİN','Kurye',3),
					  ('Mehmet','KESKİN','Kurye',3)
					 
select * from CalisanDetay
INSERT CalisanDetay VALUES (1,22000.53,'16007523652','5325555555','ravzayilmaz@gmail.com'),
						   (2,18000.63,'16007523653','5325555554','mertdikan2@gmail.com'),
						   (3,15000.53,'16007523651','5325555553','esrakahraman@gmail.com'),
						   (4,10000.45,'16007523650','5325555552','baharkarabagli@gmail.com'),
						   (5,10000.53,'16007523654','5325555551','ozanyigit@gmail.com'),
						   (6,9000.43,'16007523655','5325555556','hamzadurmaz@gmail.com'),
						   (7,9000.23,'16007523656','5325555557','fıratguler32@gmail.com'),
						   (8,22000.13,'16007523658','5325555558','volkanusluol@gmail.com'),
						   (9,10008.53,'16007523659','5325555559','erkankiraz@gmail.com'),
						   (10,15000.53,'16007523650','5325555550','alicankeless@gmail.com'),
						   (11,10000.43,'16007523652','5325555552','furkanaytekinn@gmail.com'),
						   (12,10000.93,'16007523651','5325555551','cankilic@gmail.com'),
						   (13,20000.30,'65807523652','5325555552','emekdurmus@gmail.com'),
						   (14,18000.73,'65807523652','5325555553','mesutatmacaa@gmail.com'),
						   (15,15000.23,'65807523653','5415555554','yahyaciftcii@gmail.com'),
						   (16,10000.23,'65807523656','5415555554','brkylmz@gmail.com'),
						   (17,10000.23,'65807523655','5415555555','metintekin@gmail.com'),
						   (18,9000.23,'65807523654','5415555558','mehmetkeskin@gmail.com')

select * from MenuKategori
INSERT MenuKategori VALUES ('Kahvaltı',1),
						   ('Başlangıç',1),
						   ('Salata',1),
						   ('Makarna',1),
						   ('Krep & Dürüm',1),
						   ('Burger',1),
						   ('Pizza',1),
						   ('Balık',1),
						   ('Beyaz Et',1),
						   ('Kırmızı Et',1),
						   ('Tatlı',1),
						   ('İçecek',1)

select * from Urun
insert Urun values (1,'Mini Kahvaltı Tabağı','Domates, salatalık, beyaz peynir, kaşar peyniri, bal, tereyağı, reçel, zeytin',140.00,1),
				   (1,'Serpme Kahvaltı (Çift Kişilik)','Sınırsız çay, domates, salatalık, biber,kaşar peyniri, hellim, cheddar,sosis, sucuk, dana jambon,bal, kaymak, tereyağı',250.00,1),
				   (2,'Çorba','Günün Çorbası',30.00,1),
				   (2,'Patates Tava','Kajun Baharatı ile servis edilir.',50.00,1),
				   (3,'Tavuklu Sezar Salata','Marul, cherry domates, kruton, parmesan peyniri, sezar sos, jülyen tavuk parçaları',85.00,1),
				   (3,'Ton Balıklı Salata','Akdeniz yeşillikleri, mısır, cherry domates, salatalık, özel sos ile',80.00,1),
				   (4,'Köri Solsu Penne','Kurutulmuş domates, jülyen tavuk parçaları, köri sosu ile',95.00,1),
				   (4,'Spaghetti Bolognese','Klasik bolonez sos, kaşar peyniri ile',95.00,1),
				   (5,'Cheddar Peynirli Tavuk Dürüm','Tortilla ekmeği, sote tavuk dilimleri, mantar, cheddar peyniri ile',90.00,1),
				   (5,'Tavuk Ve Mantarlı Krep','Sote tavuk parçaları, mantar, kaşar peyniri, krema, patates kızartması ve akdeniz yeşillikleri ile',90.00,1),
				   (6,'Cheeseburger','100 gr. el yapımı burger köftesi, kaşar peyniri, turşu, domates, karamelize soğan, yeşillik, barbekü sos, patates kızartması, soğan halkası ile',100.00,1),
				   (6,'Marla Burger','200 gr. el yapımı burger köftesi, cheddar peyniri, dana jambon,barbekü sos, soğan halkası ile',100.00,1),
				   (7,'Marla Pizza','Panna, mozzarella peyniri, jambon, mantar, mısır',90.00,1),
				   (7,'İtalyan Pizza','Pizza sosu, mozzarella peyniri yeşil biber, sucuk, mantar, siyah zeytin, kırmızı köz biber, kekik',100.00,1),
				   (8,'Somon Izgara','Marine edilmiş somon balığı, sote ıspanak, akdeniz yeşillikleri, özel sos ile',200.00,0),
				   (8,'Fish & Chips','Panelenmiş mezgit balığı, parmak patates, günün garnisi ile',150.00,1),
				   (9,'Marla Piliç','Tortilla ekmeği sepetinde jülyen doğranmış tavuk parçaları, renkli biber, mantar, özel sos, kaşar peyniri, ',167.00,1),
				   (9,'Lady Louisiana Chicken','Izgara tavuk butu, louisiana sos, pilav, parmak patates ve günün garnisi ile',220.00,1),
				   (10,'İstiridye Soslu Antrikot','Dana antrikot üzeri istiridye sos ve bademli, pilav, patates, sote sebze ile',300.00,1),
				   (10,'Beef Stroganoff','180 gr. jülyen bonfile, karamelize soğan, turşu, mantar, krema, dömiglas sos,elma dilim patates',320.00,1),
				   (11,'Browni','1 top dondurma ile',60.00,1),
				   (11,'San Sebastian Cake','Özel İsveç çikolatası ile',70.00,1),
				   (12,'Su','Cam şişe ile',20.00,1),
				   (12,'Americano','Özel kavrulmuş kahve taneleri ile',60.00,1),
				   (12,'Ice Vanilla','Özel vanilya özütüyle ve enfes kreması ile',70.00,1),
				   (12,'Altın Viski','Özel Seri',400.00,1)

select * from MalzemeKategori
insert MalzemeKategori values ('Sebze'),
							  ('Meyve'),
                              ('Ekmek&Tahıllar'),
							  ('Süt&Süt Ürünleri'),
                              ('Et'),
							  ('Balık'),
							  ('İçecek'),
							  ('Alkollü İçecek')

select * from Tedarikci
insert  Tedarikci values ('Emine Yılmaz'),
						 ('Yakup Dikan'),
                         ('Belinay Karabağlı'),
						 ('Yusuf Çiftçi'),
						 ('Fatih Usluol'),
						 ('Kenan Durmaz'),
						 ('Mehmet Kiraz'),
						 ('Ceren Kalkan'),
						 ('Erdal Durmuş'),
						 ('Rıza Güler')
insert  Tedarikci values ('Kenan Demir'),
						 ('Canan Uslu'),
						 ('Berk Güven'),
						 ('Mustafa Kuşcu'),
						 ('Zafer Özden'),
						 ('Büşra Karasu'),
						 ('Meral Oğuz'),
						 ('Ömer Sucu'),
						 ('Ferit Döngel'),
						 ('Mualla Çapalı')

select * from Malzeme
insert Malzeme values ('Domates',1,1,1),   
					  ('Patates',1,1,1),
					  ('Makarna',1,3,2),
					  ('Çikolata',1,4,3),
					  ('Salatalık',1,1,1),
					  ('Mantar',1,1,1),
                      ('Marul',1,1,1),
					  ('Soğan',1,1,1),
					  ('Mango',1,2,1),
					  ('Avakado',1,2,1),
					  ('Çilek',1,2,1),
					  ('Muz',1,2,1),
					  ('Tam Buğday Ekmeği',1,3,2),
					  ('Un',1,3,2),
					  ('Kıtır Ekmek',1,3,2),
					  ('Tortilla Ekmeği',1,3,2),
					  ('İnek Sütü',1,4,3),
					  ('Soya Sütü',0,4,3),
					  ('Manda Yoğurdu',1,4,3),
					  ('Kaymaklı Yoğurt',1,4,3),
					  ('Sucuk',1,5,4),
					  ('Pastırma',1,5,4),
					  ('Bonfile Et',1,5,4),
					  ('Tavuk',1,5,4),
					  ('Somon',1,6,4),
					  ('Hamsi',1,6,4),
					  ('Istakoz',1,6,4),
					  ('Su',1,7,5),
					  ('Cola',1,7,5),
					  ('Kahve',1,7,5),
					  ('Maden Suyu',1,7,5),
					  ('Redbull',1,8,6),
					  ('Viski',1,8,6),
					  ('Bira',1,8,6),
					  ('Votka',1,8,6)
						
select * from UrunMalzemeDetay
insert UrunMalzemeDetay values (1,1,800),
                               (1,2,700),							   
							   (1,4,700),
							   (1,5,100),
							   (2,6,50),
							   (2,7,50),
							   (2,8,100),
							   (3,3,500),
							   (4,33,1000),
							   (5,21,150),
							   (6,22,50),
							   (7,21,0),
							   (8,34,50),
							   (9,14,100),
							   (10,13,80),
							   (11,20,90),
							   (12,21,0),
							   (13,18,87),
							   (14,19,75),
							   (15,22,90),
							   (16,23,100),
							   (17,21,0),
							   (18,21,0),
							   (19,20,0),
							   (20,20,0),
							   (21,11,60),
							   (22,35,20),
							   (23,25,1000),
							   (24,27,950),
							   (25,14,0),
							   (26,30,55) 

select * from Depo
insert Depo values ('Marla İstanbul Depo','Çiçek Mh. Kahraman Sk. No:32 Pendik/İstanbul'),
				   ('Marla Ankara Depo','Kızılay Mh. Çamlık Sk. No:17 Polatlı/Ankara')

select * from DepoMalzemeDetay
insert DepoMalzemeDetay values (1,1,1000),
                               (1,2,1040),
							   (1,3,1540),
							   (1,4,1280),
							   (1,5,2280),
							   (1,6,2257),
							   (1,7,2457),
							   (1,8,2231),
							   (1,9,1280),
							   (1,10,1280),
							   (1,11,1280),
							   (1,12,3000),
							   (1,13,1280),
							   (1,14,1280),
							   (1,15,3287),
							   (1,16,1280),
							   (1,17,3500),
							   (1,18,1280),
							   (1,19,1280),
							   (1,20,2865),
							   (1,21,1280),
							   (1,22,1280),
							   (1,23,3125),
							   (1,24,1280),
							   (1,25,1280),
							   (1,26,1465),
							   (1,27,1281),
							   (1,28,1586),
							   (1,29,1370),
							   (1,30,1280),
							   (1,31,1452),
							   (1,32,1324),
							   (1,33,1324),
							   (1,34,1494),
							   (1,35,1478)  
insert DepoMalzemeDetay values (2,1,1000),
                               (2,2,1040),
							   (2,3,1540),
							   (2,4,1280),
							   (2,5,2280),
							   (2,6,2257),
							   (2,7,2457),
							   (2,8,2231),
							   (2,9,1280),
							   (2,10,1280),
							   (2,11,1280),
							   (2,12,3000),
							   (2,13,1280),
							   (2,14,1280),
							   (2,15,3287),
							   (2,16,1280),
							   (2,17,3500),
							   (2,18,1280),
							   (2,19,1280),
							   (2,20,2865),
							   (2,21,1280),
							   (2,22,1280),
							   (2,23,3125),
							   (2,24,1280),
							   (2,25,1280),
							   (2,26,1465),
							   (2,27,1281),
							   (2,28,1586),
							   (2,29,1370),
							   (2,30,1280),
							   (2,31,1452),
							   (2,32,1324),
							   (2,33,1324),
							   (2,34,1725),
							   (2,35,1254)  

select * from Musteri
insert Musteri values ('Ahmet','Yılmaz','Sakız Mh. Yeni Sk. Kartal/İstanbul','5526589897'),
					  ('Arzu','Öztürk','',''),
					  ('Melek','Atlar','Murat Mh. Çiçek Sk. Bağcılar/İstanbul','5523589597'),
                      ('Yunus','Balık','Lale Mh. Dolap Sk. Kadıköy/İstanbul','5523589597'),
					  ('Pembe','Erdağ','',''),
					  ('Bihter','Ziyagil','',''),
					  ('Behlül','Haznedar','','')

select * from Adisyon
insert Adisyon values ('2022-10-04 13:00:05.000'),
					  ('2022-10-04 15:03:07.000'),
					  ('2022-10-05 22:10:13.000'),
					  ('2022-10-06 19:28:07.000'),
					  ('2022-10-07 09:47:07.000'),
					  ('2022-10-07 21:00:12.000'),
					  ('2022-10-08 14:00:05.000')

select * from Siparis
-- 1 olan online
-- 0 restaurant
insert Siparis values ('2023-20-03 15:03:07.000' ,'2022-10-04 15:18:07.000',0,1,2,4),				
					  ('2023-20-03 09:47:07.000' ,'2022-10-07 10:05:07.000',0,1,3,4),
					  ('2023-23-03 21:00:12.000' ,'2022-10-07 21:15:12.000',0,2,5,4),
					  ('2023-23-03 09:47:07.000' ,'2022-10-07 10:05:07.000',0,7,6,4)

select * from AdisyonSiparisDetay
insert AdisyonSiparisDetay values (1,1),
								  (2,1),
								  (3,3),
								  (4,4)
								  
select * from OdemeYontemi
insert OdemeYontemi values ('Nakit'),
						   ('Kredi Kartı'),
						   ('Ticket'),
						   ('Multinet'),
						   ('Sodexo')

select * from AdisyonOdemeDetay
insert AdisyonOdemeDetay values (1,1,'Nakit'),
								(2,1,'Nakit'),
								(3,2,'Kredi Kartı'),
								(4,3,'Ticket'),
								(5,4,'Multinet'),
								(6,5,'Sodexo'),
								(7,4,'Multinet')
select * from Evraklar
select * from Siparis
select * from Urun
select * from UrunSiparisDetay

INSERT UrunSiparisDetay VALUES (1,1,1,140.00), --Kahvaltı 09.47
							   (3,2,1,30.00), --Çorba 13.00
							   (19,3,1,300.00),-- İstiridye 21.00
							   (7,4,1,95.00) -- Köri Soslu 15.00
							   --(5,3,1,90.00),-- Tavuklu Sezar Salata 22.10
							   --(13,4,1,90.00), --Marla Pizza 19.28
							   --(10,7,1,90.00) -- Tavuk Krep 09.47
select * from RestaurantMalzemeDetay

select * from Tedarikci
select*from CariHesaplar

insert CariHesaplar values ('100.320.100001','Yılmaz Manav','2379578986','Dörtyol Vergi Dairesi','02126784545','Dörtyol/Hatay',1),
						    ('120.01.100001','Dikan Fırıncılık','2379578945','Kağıthane Vergi Dairesi','02327649089','Kağıthane/İstanbul',2),
						    ('120.01.100002','Karabağlı Süt&Süt Ürünleri','2379578234','Beylükdüzü Vergi Dairesi','02127640967','Beylikdüzü/istanbul',3),
						    ('120.01.100003','Çiftçi Sebzecilik','237952366','Beşiktaş Vergi Dairesi','02127635656','Beşiktaş/İstanbul',4),
						    ('320.01.100001','Usluol Bakliyat','2379578899','Kartal Vergi Dairesi','03327658989','Kartal/İatanbul',5),
						    ('120.01.100004','Durmazlar Sucuk A.Ş','2379572200','Kocasinan Vergi Dairesi','02128763499','Kocasinan/Kayseri',6),
						    ('100.320.100002','Kiraz Unlu Mamülleri A.Ş','2379573344','Talas Vergi Dairesi','02126784545','Talas/Kayseri',7),
						    ('120.01.100005','Kalkan Balıkçılık','2379578977','Şişli Vergi Dairesi','01218752222','Şişli/İstanbul',8),
						    ('120.01.100006','Duşmuş İçeceş LTi','2379578222','Beykoz Vergi Dairesi','02127890088','Beykoz/istanbul',9),
							('120.01.100007','Güler Market','2379578222','Beykoz Vergi Dairesi','02127890777','Beykoz/istanbul',10)
insert CariHesaplar values ('100.320.100003','Demir Meşrubat','2379578000','Bünyan Vergi Dairesi','02126784511','Bünyan/Kayseri',12),
						    ('120.01.100008','Uslu Unlu Mamülleri','2379572333','Kağıthane Vergi Dairesi','02327649288','Kağıthane/İstanbul',13),
						    ('120.01.100009','Güven Kasapçılık','2379578999','Beylükdüzü Vergi Dairesi','02127640922','Beylikdüzü/istanbul',14),
						    ('120.01.100010','Kuşcu Bakliyat Çeşitleri','237951122','Beşiktaş Vergi Dairesi','02127635655','Beşiktaş/İstanbul',15),
						    ('100.320.100004','Özden Balıkçılık','2379578899','Beykoz Vergi Dairesi','03327658900','Beykoz/İatanbul',16),
						    ('120.01.100011','Karasu Meşrubat','2379572200','Eyüp Vergi Dairesi','02128763444','Eyüp/İstanbul',17),
						    ('120.01.100012','Oğuz Temizlik Ürünleri','2379578870','Kocasinan Vergi Dairesi','02126784545','Kocasinan/Kayseri',18)
insert CariHesaplar values ('320.01.100002','Şahinler Sucuk','2379578222','Çankaya Vergi Dairesi','02126781111','Çankaya/Ankara',22),
						   ('320.01.100003','Kamil Peynirleri','2379572900','Kağıthane Vergi Dairesi','02327640988','Kağıthane/İstanbul',23),
						   ('320.01.100004','Solmaz Market','2379573300','Beylükdüzü Vergi Dairesi','02127644545','Beylikdüzü/istanbul',24),
						   ('320.01.100005','Bakliyat Ürünleri A.Ş','237950978','Beşiktaş Vergi Dairesi','02127634567','Beşiktaş/İstanbul',25)
update CariHesaplar set CariKodu='320.01.100006' where CariHesapID=6

select * from CariHesaplar
select * from CARI_HESAP_HAREKETLERI

insert into CARI_HESAP_HAREKETLERI values (1000,1,11,'12-12-2022',1),
										  (5000,2,12,'05-11-2023',1),
										  (2000,3,13,'12-12-2023',1),
										  (3000,4,14,'10.10.2022',1),
										  (10000,5,15,'11.11.2022',1),
										  (7000,6,16,'6.6.2022',1)
insert into CARI_HESAP_HAREKETLERI values (20000,7,11,'05-05-2022',1),
										  (255000,8,12,'08-08-2023',1),
										  (2000,9,13,'06-06-2023',1),
										  (15000,10,14,'10.10.2022',1),
										  (1000,11,11,'11.11.2022',0),
										  (7000,12,13,'05.07.2023',1),
										  (8000,13,13,'10-10-2023',1),
										  (13000,14,14,'02.02.2023',1),
										  (100000,15,11,'03.03.2023',1),
										  (70000,16,12,'08.08.2023',0),
										  (50000,17,12,'06.06.2024',1)
insert into CARI_HESAP_HAREKETLERI values (10000,22,15,'05-05-2022',1),
										  (25000,23,15,'01-02-2023',1),
										  (1500,24,15,'02-03-2023',1),
										  (4000,25,15,'10.10.2022',1)
										  


select * from CARI_HESAP_HAREKETLERI						    
select * from CariHesaplar
select * from Tedarikci
select * from Evraklar
go
create proc Sp_RestaurantMalzemeDetay
(
@MalzemeId int,
@RestaurantId int,
@Stok int
)
WITH ENCRYPTION
AS 
set @MalzemeId=1
while (@MalzemeId<=35)

BEGIN
INSERT RestaurantMalzemeDetay(MalzemeID,RestaurantId,RestaurantStok) values (@MalzemeId,@RestaurantId,@Stok)
set @MalzemeId=@MalzemeId+1
END
exec Sp_RestaurantMalzemeDetay 1,1,25

select * from DepoMalzemeDetay
select * from UrunMalzemeDetay
select *from UrunSiparisDetay

go
create view vw_ToplamHesap
as
select a.AdisyonID,sum(usd.Fiyat*usd.SiparisMiktari) as [toplam fiyat] from 
Adisyon a 
join AdisyonSiparisDetay asd on a.AdisyonID=asd.AdisyonID
join Siparis s on s.SiparisID=asd.SiparisID
join UrunSiparisDetay usd on usd.SiparisID=s.SiparisID
group by a.AdisyonID
go

select * from vw_ToplamHesap

--Müşterilerin hangi ödeme yöntemini kullandığını getiren view
go
create view vw_OdemeYontemi
as
select
m.Adi +''+m.Soyadi as [Ad Soyad], oy.OdemeYontemiAdi
from Musteri m 
join Siparis s on m.MusteriID=s.MusteriID
join AdisyonSiparisDetay asd on asd.AdisyonID=s.SiparisID
join Adisyon a on a.AdisyonID=asd.AdisyonID
join AdisyonOdemeDetay aod on aod.AdisyonID=a.AdisyonID
join OdemeYontemi oy on oy.OdemeYontemiID=aod.OdemeYontemiID
go

select * from vw_OdemeYontemi

--Ürün ekleyen store procedur
go
create proc Sp_UrunGiris(
@KategoriID int,
@urunadi nvarchar(50),
@urunaciklama nvarchar(250),
@fiyat decimal(18,2),
@durum bit
)
as
begin
insert Urun(KategoriID,UrunAdi,UrunAciklamasi,Fiyat,Durum) values(@KategoriID,@urunadi,@urunaciklama,@fiyat,@durum)
end


 --BORÇ ALACAK DURUMLARI
 declare @cari nvarchar(50)=''
if @cari=''
 begin
 select sum( tutar) as Alacak,ch.CariKodu ,ch.Unvan  from CARI_HESAP_HAREKETLERI cha inner join CariHesaplar ch on cha.CariHesapID=ch.CariHesapID
 where EvrakTipi in( 11,12,13,14)  and cha.durum=1  group by ch.CariKodu , ch.Unvan
 end

 else
 begin 
 select sum( tutar) as Alacak ,ch.CariKodu,ch.Unvan from CARI_HESAP_HAREKETLERI  cha inner join CariHesaplar ch on cha.CariHesapID=ch.CariHesapID
 where EvrakTipi in( 11,12,13,14)  and cha.durum=1 and ch.CariKodu like  '%' + @cari + '%' group by ch.CariKodu,ch.Unvan
 end
 
  if @cari=''
 begin
 select sum( tutar) as Borc,ch.CariKodu,ch.Unvan from CARI_HESAP_HAREKETLERI  cha inner join CariHesaplar ch on cha.CariHesapID=ch.CariHesapID
 where EvrakTipi in( 15,16)  and cha.durum=1 group by ch.CariKodu,ch.Unvan
 end

 else
 begin 
select sum( tutar) as Borc ,ch.CariKodu,ch.Unvan from CARI_HESAP_HAREKETLERI  cha inner join CariHesaplar ch on cha.CariHesapID=ch.CariHesapID
 where EvrakTipi in( 15,16) and ch.CariKodu like  '%' + @cari + '%' and cha.durum=1 group by ch.CariKodu,ch.Unvan
 end

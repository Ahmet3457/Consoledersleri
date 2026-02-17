use northwinddb--DB(Database) çaðýrmak için use kullanýlýr

select *from Products--NorthWind DB altýnda Products tablosundaki data(veri)larý listeler
--select=> seçmek
--* => bütün kolonlarý getirir,hepsi demek
--from=> den dan, tablo(tablo adý)dan
--Products => tablo
--bir tabloda istenilen kadar data çekmek 
select ProductID ,ProductName ,UnitPrice ,UnitsInStock from Products
--Aliases=> isimlendirme
/*
Product=> Ürünler
Customer=> Müþteri
Employee=> Personel,Çalýþan
Order=> Sipariþ
Detail=> detay
Caregory=> Kategori
Supplier=> Tedarikçiler
ship=>Yüklenicler
Region=> Bölge
*/
--ctrl+R=> sonuç penceresini göster gizle
--execute/f5 => seçimi çalýþtýrýr.Eðer seçim yapmadan execute/f5 yaparsanýz bütün sayfadaki kodlar çalýþtýrýlýr
select *from Customers
--SQL küçük büyük harf duyarlýlýðý yoktur
select 
CustomerID as Kod,
CompanyName as 'Firma Adý',
ContactName as 'Ýletiþimdeki Kiþi',
Address as [Adres],
City as 'Þehir', Country as Ülke
from Customers
--personel (Employee) tablos Adý,soyad, doðum tarihi, þehir, ülke kolonlarýný getirip kolonlarý TR ile gösteriniz?
 --Sipariþler(Order) tablosunda Sipariþ tarihi(OrderDate), Kargo maliyeti(Freight),Nakliye þehri,ülkei(shipCity,ShipCountry)þeklinde listeleyiniz

select FirstName as Adý,LastName as Soyadý,BirthDate as 'Doðum Tarihi',
City as 'Þehir',Country as 'Ülke' from Employees

select OrderDate as 'Sipariþ Tarihi', Freight as 'Kargo Maliyeti', ShipCity as 'Nakliye Þehri', ShipCountry as 'Nakliye Ülkesi' from Orders
-----------------------------------------------------------------------
--MS-SQL=>Microsoft -Stracture(Mimari) Query(Sorgu) Language(Dil)
--SQL bir programlama dili deðildir
--T-SQL=> Transact SQL

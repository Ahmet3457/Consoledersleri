use Northwind--DB(Database) çaðýrmak için use kullanýlýr

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
--MS-SQL=>Microsoft -Structured(Mimari) Query(Sorgu) Language(Dil)
--SQL bir programlama dili deðildir
--T-SQL=> Transact SQL
--Where, order by, top,operatörler,hazýr fonksiyonlar, group by, having, koþul, döngü, deðiþken tanýmý(declare), fonksiyon, view, stored procedure, trigger, create, update, delete, insert,
--where
select *from Products where UnitPrice=10
select ProductName, UnitPrice,UnitsInStock,QuantityPerUnit from Products where UnitPrice=10
/*
Operatörler
<,>,=>,<=,!=,=,+,-,*,/,%=> c# ta olduðu gibi kullanýlýr
and,or=> and(&&) ve or(||) c# taki yapýlar ile ayný þekilde kullanýlýr
in, between =>??
*/
select *from Orders where ShipCountry<>'Brazil'--<>eþit deðildir
select *from Orders where ShipCountry!='Brazil'--!= eþit deðildir
select *from Products where UnitPrice<>10 and UnitsInStock>100--fiyatý 10 olmayan ve stoðu 100den büyük olan datalarý listeledik
--sayý sorgularý direkt yazýlýr ama metin için ''(tek týrnak) alýnmasý gereklidir
--sýralama için order by kullanýlýr
--order=>Sipariþ, sýralama
select *from Customers order by City-- a dan z ye yada küçükten büyüðe doðru sýralar. Kolon adýndan sonra bir þey yazýlmazsa oto olarak asc(ascanding) kabul eder
select *from Customers order by City asc
select *from Customers order by City desc--descanding=> z'den a'ya yada büyükten küçüðe doðru sýralama yapar 
--Order by her zaman bütün scriptin(SQL kod parçacýðý) sonunda yazýlýr
--Order by ile beraber genelde top kullanýlýr
select top 15 *from Customers order by City asc--þehirlere göre a dan z ye sýralayarak ilk 15 datayý listeledik
--aynýsýný aþaðýda kolon ismi vererek yapalým
select
top 15 CustomerID as Kod,
CompanyName as [Firma Adý],
ContactName as 'Yetkili Kiþi',
City as Þehir,
Country as Ülke 
from Customers order by City asc

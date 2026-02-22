--Ahmet Selim DURKUT
--20 Şubat Cuma 2026
--like sorular
use Northwind
select *from Customers
--başta %, sonda %,_ işareti ile karakter sayımı
--Ülkesi içinde swe olan ve şehri için br geçen müşterileri listeleyiniz
select *from Customers where Country like '%swe%' and City like '%br%'
select *from Products
--Ürün adı içinde 3.harfi i ve 4.harfi c olan ve stok değerleri 0-10(0,10 dahil) arasında olan üstünde olanları Name, Stock, Price kolonlarını TR yaparak ürünleri listeleyiniz
select
ProductName 'Ürün Adı',
UnitsInStock Stok,
UnitPrice 'Fiyat'
from Products where ProductName like '--ic%' and UnitsInStock>=0 and UnitsInStock<=10
--*************************************
--Aralık için between kullanalım
select 
ProductName 'Ürün Adı',
UnitsInStock Stok,
UnitPrice 'Fiyat' 
from Products where ProductName like '__ic%' and UnitsInStock between 0 and 10 
---------------------------------------------
--Genel Tekrar soruları
--Aliases, kolon adı, select, from, Tablo adı, where(koşul kelimesi), Operatörler(<,>,<=,>=,!=,<>(Eşit Değildir),=,between,and,or,in,not in,is null,is not null,order by (sıralama),like (%yeri, _ konumu))
--Ürün fiyatları 15-25 arasında olan ürünleri fiyatına göre küçükten büyüğe doğru Ad,Stok,Fiyat,Birim Tanımı(QuantityPerUnit) şeklinde listeleyiniz?
select
ProductName Ad,
UnitsInStock Stok,
UnitPrice 'Fiyat',
QuantityPerUnit 'Birim Tanımı' 
from Products where UnitPrice between 15 and 25 order by UnitPrice asc	
--ürün stokları 100 üzerinde olan ürünleri , ürün isimlerine göre a dan z ye sıralayınız?
select
ProductName Ad,
UnitsInStock Stok,
UnitPrice 'Fiyat',
QuantityPerUnit 'Birim Tanımı',
Discontinued 'Üretimdemi'
from Products where UnitsInStock >100 order by ProductName
--------------------------------------------------------
--top kullanımı
select *from Products order by UnitPrice --ürünleri fiyata göre küçükten büyüğe doğru sıralar
select *from Products order by UnitsInStock --ürünleri stoğa göre küçükten büyüğe doğru sıralar
select *from Orders order by Freight --Siparişleri kargo bedeline göre küçükten büyüğe doğru sıralar
select *from Customers order by CompanyName --a,z
select *from Products --ürünleri listeler
order by UnitPrice --fiyati küçükten büyüğe doğru 
--en düşük fiyata sahip olan ilk 5 ürün
select top 5 *from Products--ürünleri listeler
order by UnitPrice--fiyatı küçükten büyüğe doğru
--en yüksek fiyata sahip 5 ürün
select top 5 *from Products--ürünleri listeler
order by UnitPrice desc--fiyatı büyükten küçüğe doğru
--En genç 3 personelin Adı,Soyadı,Doğum Tarihi,address,şehir ve ülkesini gösteriniz
select 
top 3
FirstName Adı,
LastName Soyadı,
BirthDate 'Doğum Tarihi',
Address as Adres,
from Employees order by BirthDate desc


/*
Operatörler
<,>,<=,>=,!=,=,+,-,*,/,%=> c# ta olduğu gibi kullanılır
Devam
and,or=> and (&&)ve or(||) c# taki yapılar ile aynı şekilde kullanılır
is nul,is not nul=>???
in, between =>??
like	
*/
use Northwind
/*
||=> or
true or True=True
true or False=True
False or True=True
False or False=False
&&=> and
True and True= True
True and False= False
False and True= False
False and False= False
*/

select *from Customers where Country='Germany' and City='Berlin'
select *from Customers where Country='Germany' or Country='Mexico' or City='Sao Paulo'
--birden fazla or yerine in kullanılır
select *from Customers where Country in ('Germany','Mexico','Sao Paulo')--in i.erenleri getirir
select *from Customers where Country not in ('Germany','Mexico','Brazil')--not in olmayanları getirir
--is null,is not null
--null=> boş
--empty=> boş
--'' => boş
--' '=>boş ama klavyeden space tuşu ile boşluk verilmiş
--null
select *from Customers where Region=''
select *from Customers where Region is null --null olanları getirir.Doğal olarak SQL ilk data eklenirken müdahale edilmeyen data null olarak gelir 
select *from Customers where Region is not null
--between=> aralık filtrelemek için kullanılır
select *from Products
select *from Products where UnitsInStock>10 and UnitsInStock<15--3
select *from Products where UnitsInStock>=10 and UnitsInStock<=15--9
select *from Products where UnitsInStock between 10 and 15--10 ve 15 dahil ederek aralık vermektedir
--TR gün-Ay-Yıl=> SQL içinde bu şekilde tarih için sorgulanma yapılmaz
select *from Orders where OrderDate>='01.01.1996' and OrderDate<='12.31.1996'--İngiliz tarih formatına göre ay-gün-yıl olarak verilmesi gereklidir
select *from Orders where OrderDate between '01.01.1996' and '12.31.1996'
--**************************************************************************************
--like => arama yapmak için kullanılır
select *from Customers where ContactName like 'Maria'--like ile beraber mutlaka % işareti kullanılmalıdır aksi halde eşittir(=) gibi çalışır
select *from Customers where ContactName = 'Maria'--like ile % işareti olmadan aynı anlama gelir
select *from Customers where ContactName like '%Maria%'--% işareti hem baş hem sonda olarak verildiğinde Maria geçen cümlenin ortası sonu başı yani neresinde Maria geçiyorsa getirir

select *from Customers where ContactName like 'Mar%'--ilk 3 harfi mar olan ContactName dataları getirir
select *from Orders
--1996 yılında olan siparişleri like ile getirin
select *from Orders where OrderDate like '%1996%'
--% işareti başta ise 
select *from Customers where ContactName like '%Mar'--son 3 harfi MAR/Mar/mAR olanları getirir
--arama içinde _ kullanılması
select *from Products where ProductName like 'c_a%'--her bir alt tire bir bilinmeyen karaktere denk gelir 
-- _ tire aynı zamanda karakter için zorunluluk getirir yani _ varsa orada kesin karakter gelecektir
select *from Products where ProductName like '_o_to%'--1.harfi bilinmeyen, 2.harfi o olan,3.harfi bilinmeyen, 4.ve 5. harfi to olan ve sonu ne ile bittiği önemsiz olan dataları listeler
--like için soru çözümü yapılacak
--devam konular
--Hazır fonksiyonlar
--group by,having
--distinct
using System.Security.Cryptography;

namespace _260206_1_method_tanim
{
    internal class Program
    {
        static void Main(string[] args)
        {//Main method BAŞLAMA parantezi

            //string[] => string bir dizi. int[],double, ArrayList,... olabilir
            //args=> değişken-> parametre.dizi,sayilar,isimler,sehirler olabilir
            //Main(string[] args)=> string bir dizisi olan Main adında method(function)->Topla,Fark,MaasZam,GetirKisiBilgileri
            //void=> method türü->int,double,...(var dışında bütün veri tipleri kullanılabilir)
            //static=> Erişim belirleyicisi.Bir yapıya (değişkeni method, class) erişim yani kullanmak için izin olup olmadığını Erişim Belirleyicileri(internal, static, public, private, protected, protected internal) ile sağlarız
            //Method Nedir??=> Sürekli kodlanan bir kod varsa bu kodu sürekli kodlamak yerine onu bir format ile sürekli kullanabileceğimiz halde tutmak için method içinde kodlarız ve her lazım olduğunda Method çağırmak yeterli olacaktır, artık aynı kodu tekrar tekrar yazmaya gerek yoktur
            //aşağıdaki yapıyı method ile yapalım

            Console.WriteLine("1.sayıyı giriniz:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2.sayıyı giriniz:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Toplam(sayi1, sayi2);

            //bu 2 sayının büyükden küçük sayıyı çıkartın Fark adında adında method kodlayınız?
            Fark(sayi2, sayi1);

            //büyük sayıya küçük sayının bölünmesinde kalanı veren ModAl adında method kodlayınız?
            Bolum(sayi1, sayi2);//method kullanımı
                                //ctrl+m+o=> bütün methodları gizler
                                //ctrl+m+l=> bütün satırları açar
                                //ctrl+k+d=> hata yoksa düzenler
            
             /*
                Erişim Belirleyicileri
                1-public => herkese açık
                2-private=> özel, sadece tanımlandığı yerde kullanılabilir
                3-internal=> aynı proje altında kullanılabilir
                4-protected=> kalıtım verdiği class larda kullanılabilir
                5-internal protected=> aynı proje altında ve kalıtım verdiği class larda kullanılabilir
                6-static=> tanımlama yapmadan direk kullanma imkanı sağlar
                


                Method çeşitleri
             1-Değer döndürmeyen void method
             2-Değer döndüren return method
             3-Aşırı yüklenmiş Overload method
             */


        }//Main method BİTİŞ parantezi


        /// <summary>
        /// bu 2 sayının toplamını hesaplar
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        static void Toplam(int s1, int s2)
        {
            int toplam = s1 + s2;
            Console.WriteLine("2 sayının toplamı:" + toplam);
        }
        /// <summary>
        /// bu 2 sayının farkını hesaplar
        /// </summary>
        /// <param name="deger1"></param>
        /// <param name="deger2"></param>
        static void Fark(int deger1, int deger2)
        {
            if (deger1 > deger2)
            {
                int fark1 = deger1 - deger2;
                Console.WriteLine("Fark1:" + fark1);
            }
            else
            {
                int fark2 = deger2 - deger1;
                Console.WriteLine("Fark2:" + fark2);
            }
        }
        /// <summary>
        /// bu 2 sayının modunu hesaplar
        /// </summary>
        /// <param name="deger1"></param>
        /// <param name="deger2"></param>
        static void Bolum(int deger1, int deger2)
        {
            int kalan;
            if (deger1 > deger2)
            {
                kalan = deger1 % deger2;
                Console.WriteLine("bolum1:" + kalan);
            }
            else
            {
                kalan = deger1 % deger2;
                Console.WriteLine("bolum2:" + kalan);
            }
        }


    }
}

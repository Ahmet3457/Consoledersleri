namespace _260116_2_Odevler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan alınan 5 sayi için aşağıdaki işlemleri yapı ve sonuçları ekranda gösteriniz
            /*
            1) 5 sayıdam 2nin katı olanlar için true, olmayan için false verecek şeklinde bir işleme düşünüp kodlayınız
            2)1. sayıdan 5. sayıya kadar olan sayıların toplamını bulunuz
            3)1. sayıya 5 ekleyin,2.sayıdan -10 çıkartın,3.sayıyı da 5 ile çarparak işlemlerin sonucunu ekranda gösteriniz? NOT:Yeni bir değişken tanımlamadan bu soru yapılacak
            4)5 sayının toplam sonucu 9,11,13 e ayrı ayrı bölündüğünü true, false şeklinde hesaplayınız
            5)1.,2.,3.sayıların toplamı,4.sayıdan 5.sayı çıkartılınca kalan sonucu bölerek sonucu ekranda gösteriniz


            */
            int s1 = 10;
            int s2 = 7;
            int s3 = 4;
            int s4 = 8;
            int s5 = 6;

            //1
            Console.WriteLine("2'nin katı kontrolü:");
            Console.WriteLine(s1 % 2 == 0);
            Console.WriteLine(s2 % 2 == 0);
            Console.WriteLine(s3 % 2 == 0);
            Console.WriteLine(s4 % 2 == 0);
            Console.WriteLine(s5 % 2 == 0);

            //2
            int toplam = s1 + s2 + s3 + s4 + s5;
            Console.WriteLine("Toplam: " + toplam);

            //3
            Console.WriteLine("İşlemler:");
            Console.WriteLine("1. sayı + 5 = " + (s1 + 5));
            Console.WriteLine("2. sayı - 10 = " + (s2 - 10));
            Console.WriteLine("3. sayı * 5 = " + (s3 * 5));

            //4
            Console.WriteLine("Bölünebilme kontrolü:");
            Console.WriteLine("9'a bölünür mü?" + (toplam % 9 == 0));
            Console.WriteLine("11'e bölünür mü?" + (toplam % 11 == 0));
            Console.WriteLine("13'e bölünür mü?" + (toplam % 13 == 0));

            //5
            double sonuc = (double)(s1 + s2 + s3) / (s4 - s5);
            Console.WriteLine("Sonuç: " + sonuc);
        }
    }
}

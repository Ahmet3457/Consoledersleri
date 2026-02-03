namespace _260130_6_dizi_random
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Random=> rastgele sayı üretmek için kullanılan bir class yapısıdır
            Random rastgele = new Random();
            Console.WriteLine(rastgele.Next(200));

            for (int i = 0; i < 150; i++)
            {
                int sayi=rastgele.Next(200);
                Console.Write(sayi + ",");
            }
                    /*
        1)rastgele üretilen 200 sayı arasında tek olanları ve çift olanları ayrı ayrı diziler içinde dizi eleman sayısı az/çok olmayacak şekilde oluşturan yapıyı kodlayınız(2 döngü ile işlem yapılıyor)
        2)Kullanıcıdan alınan 5 sayıyı dizi-döngü kullanarak küçükten büyüğe doğru sıralayınız?
        3)Kullanıcıdan bir fabrikadan çalışan sayısı alındıktan sonra çalışanların isimlerini bir bir isteyip(1. personel Ahmet) girilen isimleri aldıktan sonra her bir personelin aldığı maaşı(Ahmet ne kadar maaş alıyor-49000) şeklinde istedikten sonra son olarak her bir isim karşısında isim için girilen maaşı listeleyen(Ahmet-49000) şeklinde veren yapıyı kodlayınız         
         */

            //----1
            int[] sayilar = new int[200];
int[] tekler = new int[200];
int[] ciftler = new int[200];

int tek = 0;
int cift = 0;

Random r = new Random();

for (int i = 0; i < 200; i++)
{
    sayilar[i] = r.Next(1, 101);
}

for (int i = 0; i < 200; i++)
{
    if (sayilar[i] % 2 == 0)
    {
        ciftler[cift] = sayilar[i];
        cift++;
    }
    else
    {
        tekler[tek] = sayilar[i];
        tek++;
    }
}

Console.WriteLine("Çiftler:");
for (int i = 0; i < cift; i++)
{
    Console.Write(ciftler[i] + " ");
}

Console.WriteLine("\nTekler:");
for (int i = 0; i < tek; i++)
{
    Console.Write(tekler[i] + " ");
}

        //----2
          int[] sayilar = new int[5];

for (int i = 0; i < 5; i++)
{
    Console.Write("Sayı gir: ");
    sayilar[i] = Convert.ToInt32(Console.ReadLine());
}

for (int i = 0; i < 5; i++)
{
    for (int j = i + 1; j < 5; j++)
    {
        if (sayilar[i] > sayilar[j])
        {
            int gecici = sayilar[i];
            sayilar[i] = sayilar[j];
            sayilar[j] = gecici;
        }
    }
}

Console.WriteLine("Sıralı hali:");
for (int i = 0; i < 5; i++)
{
    Console.Write(sayilar[i] + " ");
}

        //----3
        Console.Write("Çalışan sayısı: ");
int sayi = Convert.ToInt32(Console.ReadLine());

string[] isim = new string[sayi];
int[] maas = new int[sayi];

for (int i = 0; i < sayi; i++)
{
    Console.Write((i + 1) + ". personel adı: ");
    isim[i] = Console.ReadLine();
}

for (int i = 0; i < sayi; i++)
{
    Console.Write(isim[i] + " maaşı: ");
    maas[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Liste:");
for (int i = 0; i < sayi; i++)
{
    Console.WriteLine(isim[i] + " - " + maas[i]);
}



            
            
        }
    }
}

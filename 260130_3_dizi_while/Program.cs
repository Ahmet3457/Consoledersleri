namespace _260130_3_dizi_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullanıcıdan alınan 7 sayıyı aldıktan sonra ekranda gösterip toplamlarını hesaplayınız
            int[] sayilar = new int[7];
            int elemanSayisi = sayilar.Count();
            int toplam = 0;
            int i = 0;

            do
            {
                
                Console.WriteLine(i + 1 + ". sayıyı giriniz.");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
                toplam += sayilar[i];
                i++;
            } while (i<elemanSayisi);
            Console.WriteLine("sayıların toplamı:"+toplam);
            Console.ReadLine();
        }
    }
}

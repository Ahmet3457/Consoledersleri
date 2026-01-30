namespace _260130_5_dizi_ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullanıcıdan 11 sayı alınız,girilen 11 sayıyı listelerken çift olan sayıların sağında çift, tek olan sayıların sağında tek yazısı yazdırınız
            /*
            45-TEK
            60-ÇİFT
            15-TEK
            10-ÇİFT
            */

            int[] dizi = new int[11];

            for (int i = 0; i < dizi.Length; i++)
            {
                Console.WriteLine(i + 1 + ".sayıyı giriniz:");
                dizi[i] = Convert.ToInt32(Console.ReadLine());    
            }

            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] % 2 == 0)
                {
                    Console.WriteLine(dizi[i]+"-ÇİFT");
                    i++;
                }
                else
                {
                    Console.WriteLine(dizi[i]+"-TEK");
                    i++;
                }
            }

        }
    }
}

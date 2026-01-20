using System.Diagnostics;

namespace _260120_4_if_else_maas_cinsiyet
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //kullanıcıdan alınan cinsiyet ve maaş bilgisine göre
        //Eğer cinsiyet kadın ise maaşına %20.5 zam,eğer cinsiyet erkek ise maaşına %21.25 zam yapılacak şekilde kodlayıp,yeni zamlı maaşı ve yapılan zam oranınında kullanıcıya gösterecek şekilde kodlayınız
        DEST:

            Console.WriteLine("Cinsiyet giriniz(K/E ya da kadın/erkek):");
            string Cinsiyet = Console.ReadLine().ToLower();

            Console.WriteLine("Maaşınızı giriniz:");
            double Maas =Convert.ToDouble(Console.ReadLine());

            if(Cinsiyet=="kadın" || cinisyet=="k")
            {
                Maas = Maas + Maas * 20.5 / 100;
                Console.WriteLine("zam oranı:% 20.5 ile yeni maaşınızı:" + Maas);
            }
            else
            {
                Maas = Maas + Maas * 21.25 / 100;
                Console.WriteLine("zam oranı:%21.25 ile yeni maaşınız:" + Maas);
            }
            Console.WriteLine("------------------------");
            goto DEST;           
        }
    }
}

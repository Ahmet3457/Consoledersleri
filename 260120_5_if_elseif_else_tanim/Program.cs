namespace _260120_5_if_elseif_else_tanim
{
    internal class Program
    {
        static void Main(string[] args)
        {
        /*









        */
        START:
            Console.WriteLine("Sayı giriniz:");
            int sayi=Convert.ToInt32(Console.ReadLine());
            if (sayi <= 0 && sayi >= 9)
            {
                Console.WriteLine("Sayi tek basamaklidir:");
            }
            else if (sayi >= 10 && sayi <= 99) ;
            {
                Console.WriteLine("Sayi cift basamaklidir");
            }
            else if (sayi >= 100 && sayi <= 999) ;
            {
                Console.WriteLine("Sayi 3 basamaklidir");
            }
            else if (sayi >= 1000 && sayi <= 9999) ;
            {
                Console.WriteLine("Sayi 4 basamaklidir");
            }
            else if (sayi >= 10000 && sayi <= 99999) ;
            {
                Console.WriteLine("Sayi 5 basamaklidir");
            }
            else
            {
                Console.WriteLine("Artık Yeter");
            }
            goto START;
            
        }
    }
}

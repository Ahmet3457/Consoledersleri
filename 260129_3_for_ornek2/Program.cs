namespace _260129_3_for_ornek2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1-15000 arasındaki sayıların 5in katı olup, 2nin katı olmayan sayıların sayısı ve toplamlarını hesaplayınız

            int toplam = 0, adet = 0;

            for(int i =1; i <= 15000; i++)
            {
                if(i%5==0 && i%2!=0)
                {
                    adet++;
                    toplam += i;
                }

            }
            Console.WriteLine("1-15000 arasındaki 5in katı olup 2nin katı olmayan sayı adeti:{0} vetoplamları:{1}", adet, toplam);

        }
    }
}

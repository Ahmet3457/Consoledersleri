namespace _260129_6_for_dik_ucgen_ters_say
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //dik üçğenin karakter sayısı max alınacak şekilde max değerden 0a doğru aynı satırda yazdırınız

            string metin = "*";

            for (int i = 1; i < 10; i++)
            {
                Console.Write(metin+"-->");
                int adet = metin.Length;

                for(int k= i; k> 0;k--)
                {
                    Console.Write(k+",");
                }
                Console.WriteLine();
                metin += "*";
            }





        }
    }
}

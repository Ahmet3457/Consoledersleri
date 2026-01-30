namespace _260130_4_dizi_ornek3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] dizi = new double[6];
            //6 eleman ekleyip, eklenen elemanları ekranda gösteriniz?

            //dizi[0] = 57;
            //dizi[1] = 43;
            //dizi[2] = 18;
            //dizi[3] = 82;
            //dizi[4] = 10;
            //dizi[5] = 90;

            for (int i = 0; i < dizi.Length; i++)
            {
                Console.WriteLine(i + 1". eleman:");
                dizi[i] = Convert.ToDouble(Console.ReadLine());
            }

            for (int i = 0; i < dizi.Length; i++)
            {
                Console.WriteLine(dizi[i]);
            }

        }
    }
}

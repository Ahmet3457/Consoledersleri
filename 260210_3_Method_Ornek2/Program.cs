namespace _260210_3_Method_Ornek2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan alınan 3 sayıyı küçükten büyüğe doğru sıralamasını yapan işlemi kodlayınız

            int s1 = SayiAl();
            int s2 = SayiAl();
            int s3 = SayiAl();

            int[] sirali = Sirala(s1, s2, s3);

            Console.WriteLine("Küçükten büyüğe sıralı hali:");
            for (int i = 0; i < sirali.Length; i++)
            {
                Console.WriteLine(sirali[i]);
            }
        }
        static int SayiAl()
        {
            Console.WriteLine("Sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            return sayi;
        }

        #region My code but not short
        //static int[] Sirala(int s1, int s2, int s3)
        //{
        //    int kucuk, orta, buyuk;

        //    if (s1 <= s2 && s1 <= s3)
        //    {
        //        kucuk = s1;
        //        if (s2 <= s3)
        //        {
        //            orta = s2;
        //            buyuk = s3;
        //        }
        //        else
        //        {
        //            orta = s3;
        //            buyuk = s2;
        //        }
        //    }
        //    else if (s2 <= s1 && s2 <= s3)
        //    {
        //        kucuk = s2;
        //        if (s1 <= s3)
        //        {
        //            orta = s1;
        //            buyuk = s3;
        //        }
        //        else
        //        {
        //            orta = s3;
        //            buyuk = s1;
        //        }
        //    }
        //    else
        //    {
        //        kucuk = s3;
        //        if (s1 <= s2)
        //        {
        //            orta = s1;
        //            buyuk = s2;
        //        }
        //        else
        //        {
        //            orta = s2;
        //            buyuk = s1;
        //        }
        //    }

        //    int[] dizi = { kucuk, orta, buyuk };
        //    return dizi;
        //}
        #endregion
    }
}

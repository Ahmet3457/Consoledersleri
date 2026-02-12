namespace _260212_1_method_elektrik_fatura_cozum_hoca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EkranaYaz("Harcanan elektrik değerini kw cinsinden giriniz:");
            //double kw = OkuDouble();
            //EkranaYaz("Faturanız:" + HesaplaFatura(kw));
            //yukarıdaki 2 satır kodu tek bir satır ile kodlayabiliriz
            EkranaYaz("Faturanız:" + HesaplaFatura(OkuDouble()));
        }
        static void EkranaYaz(string metin)
        {
            Console.WriteLine(metin);
        }
        static double OkuDouble()
        {
            return Convert.ToDouble(Console.ReadLine());
        }
        static double HesaplaFatura(double kw)
        {
            //double fatura =0;
            if(kw>0&&kw<=150)
            {
                return kw * 1.06;
            }
            else if (kw > 150 && kw<=300)
            {
                //double ilk150 = 140;//150kw
                //175kw=> 150kw+25kw
                //175kw=> 150kw(140tl)+25kw(*1.16)
                //fatura=> 140tl+25kw1.16;
                return 140 + (kw - 150) * 1.16;
            }
            else if (kw > 300 && kw<=450)
            {
                return 320 + (kw - 300) * 1.25;
            }
            else if (kw > 450 && kw<= 650)
            {
                return 530 + (kw - 450) * 1.29;
            }
            else
            {
                return 800+(kw)
            }
        }
    }
}

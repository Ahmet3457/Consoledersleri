namespace _260212_1_method_elektrik_fatura_ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
        Bir elektrik faturası için bazı şartlar ile fatura hesabı yapılmaktadır. Bu şartlar
        eğer kullanılan elektrik kw olarak 0-150 arasında ise her kw için 1.06 Tl ile çarpılarak hesaplanmaktadır
        --60*1.06=>       
        eğer kullanılan elektrik kw olarak 150-300 arasında ise ilk 150 kw için 140 TL, 150 kw ve üstü içinde her kw için 1.16 Tl ile çarpılarak hesaplanmaktadır
        eğer kullanılan elektrik kw olarak 300-450 arasında ise ilk 300 kw için 320 TL, 300 kw ve üstü içinde her kw için 1.25 Tl ile çarpılarak hesaplanmaktadır
        eğer kullanılan elektrik kw olarak 450-650 arasında ise ilk 450 kw için 530 TL, 450 kw ve üstü içinde her kw için 1.29 Tl ile çarpılarak hesaplanmaktadır
        eğer 650 ve üstü ise ilk 650 için 800 Tl, 650 ve üstü içnde 1.32 Tl   ile çarpılarak hesaplanmaktadır
        bu şartlar kullanıcının gireceği harcadoğı elektriği kw cinsinden  aldoktan sonra ödeyeceği faturayı hesaplayınız?


    */

            Console.WriteLine("Harcanan kw'ı giriniz:");
            double kw = Convert.ToDouble(Console.ReadLine());

            Fatura(kw);

        }


        static double Fatura(double kw)
        {
            double fatura=0;
            if (kw > 0 && kw <= 150)
            {
                fatura = kw * 1.06;
                Console.WriteLine("Kullanılan kw :{0} ve ödenen tutar:{1}" ,kw , fatura);
            }
            else if(kw>150 && kw<=300)
            {
                double ilk150 = 140;
                //190=>150+40
                //---->140+40*1.16
                //====140+(190-150)*1.16
                //====140+(kw-150)*1.16
                double ustu150 = (kw - 150) * 1.16;
                fatura = ilk150 + ustu150;

                Console.WriteLine("Kullanılan kw :{0} ve ödenen tutar:{1}", kw, fatura);
            }
            else if(kw>300 && kw<=450)
            {
                fatura = 320 + (kw - 300) * 1.25;
                Console.WriteLine("Kullanılan kw :{0} ve ödenen tutar:{1}", kw, fatura);
            }
            else if(kw>450 && kw<=650)
            {
                fatura = 530 + (kw - 450) * 1.29;
                Console.WriteLine("Kullanılan kw :{0} ve ödenen tutar:{1}", kw, fatura);
            }
            else if(kw>650)
            {
                fatura = 800 + (kw - 650) * 1.32;
                Console.WriteLine("Kullanılan kw :{0} ve ödenen tutar:{1}", kw, fatura);
            }
            return fatura;
        }
    }
}

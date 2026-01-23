namespace _260123_2_switch_case_ornek1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullanıcıdan alınan kaçıncı ayda olduğu bilgisine göre ayın adı ve hangi mevsimde olduğunu hesaplayan yapıyı kodlayınız

            Console.WriteLine("Kaçıncı aydasınız?");
            byte ay = Convert.ToByte(Console.ReadLine());

            switch(ay)
            {
                case 1:
                case 12:
                case 2:
                    Console.WriteLine("KIŞ mevsimindesiniz.");
                    if (ay == 12)
                    {
                        Console.WriteLine("Aralık ayındasınız");
                    }
                    else if (ay == 1)
                    {
                        Console.WriteLine("Ocak ayındasınız");
                    }
                    else
                    {
                        Console.WriteLine("Şubat ayındasınız");
                    }
                    break;
                default:
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("İLKBAHAR mevsimindesiniz");
                    if (ay == 3)
                    {
                        Console.WriteLine("Mart ayındasınız");
                    }
                    else if (ay == 4)
                    {
                        Console.WriteLine("Nisan ayındasınız");
                    }
                    else
                    {
                        Console.WriteLine("Mayıs ayındasınız");
                    }
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("YAZ mevsimindesiniz.");
                    if (ay == 6)
                    {
                        Console.WriteLine("Haziran ayındasınız");
                    }
                    else if (ay == 7)
                    {
                        Console.WriteLine("Temmuz ayındasınız");
                    }
                    else
                    {
                        Console.WriteLine("Ağustos ayındasınız");
                    }
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("SONBAHAR mevsimindesiniz.");
                    if (ay == 9)
                    {
                        Console.WriteLine("Eylül ayındasınız");
                    }
                    else if (ay == 10)
                    {
                        Console.WriteLine("Ekim ayındasınız");
                    }
                    else
                    {
                        Console.WriteLine("Kasım ayındasınız");
                    }
                    break;
                    


            }
        }
    }
}

using System;

namespace _260213_3_Bankamatik_Proje
{
    class Program
    {
        static double bakiye = 250;
        static string sifre = "ab18";

        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("---------------------------------");
            Console.WriteLine("1 - Kartlı İşlem");
            Console.WriteLine("2 - Kartsız İşlem");
            Console.WriteLine("---------------------------------");
            Console.Write("Seçiminiz: ");
            string islem = Console.ReadLine();

            if (islem == "1")
            {
                int hak = 3;
                while (hak > 0)
                {
                    Console.Write("Şifre: ");
                    string girilen = Console.ReadLine();
                    if (girilen == sifre)
                    {
                        AnaMenu();
                        return;
                    }
                    else
                    {
                        hak--;
                        Console.WriteLine("Hatalı şifre. Kalan: " + hak);
                    }
                }
            }
            else
            {
                Console.WriteLine("Kartsız işlem şu an aktif değildir.");
            }
        }

        static void AnaMenu()
        {
            Console.Clear();
            Console.WriteLine("---------------------------------");
            Console.WriteLine("ANA MENÜ");
            Console.WriteLine("1 - Para Çekme");
            Console.WriteLine("2 - Para Yatırma");
            Console.WriteLine("3 - Para Transferleri");
            Console.WriteLine("4 - Eğitim Ödemeleri");
            Console.WriteLine("5 - Ödemeler");
            Console.WriteLine("6 - Bilgi Güncelleme");
            Console.WriteLine("0 - Çıkış");
            Console.WriteLine("---------------------------------");
            Console.Write("Seçiminiz: ");
            string secim = Console.ReadLine();

            if (secim == "1") ParaCekme();
            else if (secim == "2") ParaYatirma();
            else if (secim == "3") ParaTransferleri();
            else if (secim == "4") EgitimOdemeleri();
            else if (secim == "5") Odemeler();
            else if (secim == "6") BilgiGuncelleme();
            else if (secim == "0") Console.WriteLine("Çıkış yapıldı.");
        }

        static void ParaCekme()
        {
            Console.Clear();
            Console.Write("Çekilecek tutar: ");
            double tutar = Convert.ToDouble(Console.ReadLine());
            if (tutar <= bakiye) { bakiye -= tutar; Console.WriteLine("Para çekildi. Bakiye: " + bakiye); }
            else Console.WriteLine("Yetersiz bakiye!");
            AltMenuSec();
        }

        static void ParaYatirma()
        {
            Console.Clear();
            Console.WriteLine("1 - Kredi Kartına\n2 - Kendi Hesabına");
            string s = Console.ReadLine();
            if (s == "1")
            {
                Console.Write("Kart No (12 hane): ");
                string k = Console.ReadLine();
                if (k.Length >= 12)
                {
                    Console.Write("Yatırılacak tutar: ");
                    double t = Convert.ToDouble(Console.ReadLine());
                    if (t <= bakiye) { bakiye -= t; Console.WriteLine("İşlem tamam."); }
                }
            }
            else
            {
                Console.Write("Tutar: ");
                bakiye += Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Bakiye artırıldı.");
            }
            AltMenuSec();
        }

        static void ParaTransferleri()
        {
            Console.Clear();
            Console.WriteLine("1 - EFT\n2 - Havale");
            string s = Console.ReadLine();
            if (s == "1")
            {
                Console.Write("IBAN (TR...): ");
                string i = Console.ReadLine();
                if (i.StartsWith("TR") && i.Length == 14)
                {
                    Console.Write("Tutar: ");
                    double t = Convert.ToDouble(Console.ReadLine());
                    if (t <= bakiye) { bakiye -= t; Console.WriteLine("Transfer edildi."); }
                }
            }
            else
            {
                Console.Write("Hesap No (11 hane): ");
                string h = Console.ReadLine();
                if (h.Length == 11)
                {
                    Console.Write("Tutar: ");
                    double t = Convert.ToDouble(Console.ReadLine());
                    if (t <= bakiye) { bakiye -= t; Console.WriteLine("Transfer edildi."); }
                }
            }
            AltMenuSec();
        }

        static void EgitimOdemeleri()
        {
            Console.Clear();
            Console.WriteLine("Bu sayfa arızalıdır.");
            AltMenuSec();
        }

        static void Odemeler()
        {
            Console.Clear();
            Console.WriteLine("1 - Elektrik Faturası\n2 - Telefon Faturası\n3 - İnternet Faturası\n4 - Su Faturası\n5 - OGS Ödemeleri");
            Console.Write("Seçiminiz: ");
            Console.ReadLine();
            Console.Write("Tutar: ");
            double t = Convert.ToDouble(Console.ReadLine());
            if (t <= bakiye) { bakiye -= t; Console.WriteLine("Ödeme başarılı."); }
            else Console.WriteLine("Yetersiz bakiye!");
            AltMenuSec(); // Buraya zorla ekledim
        }

        static void BilgiGuncelleme()
        {
            Console.Clear();
            Console.WriteLine("1 - Şifre Değiştir");
            string sec = Console.ReadLine();
            if (sec == "1")
            {
                Console.Write("Mevcut Şifre: ");
                if (Console.ReadLine() == sifre)
                {
                    Console.Write("Yeni Şifre: ");
                    sifre = Console.ReadLine();
                    Console.WriteLine("Güncellendi.");
                }
            }
            AltMenuSec(); // Buraya zorla ekledim
        }

        static void AltMenuSec()
        {
            Console.WriteLine("\n---------------------------------");
            Console.WriteLine("9 - Ana Menü");
            Console.WriteLine("0 - Çıkış");
            Console.WriteLine("---------------------------------");
            Console.Write("Seçiminiz: ");
            string s = Console.ReadLine();
            if (s == "9") AnaMenu();
            else Environment.Exit(0);
        }
    }
}
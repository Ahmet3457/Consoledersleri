namespace _260123_6_while_ornek2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            1) 1-100 arasındaki sayıları ekrana yazın ve toplamlarını hesaplayınız
            2) 55-255 arasındaki 5 in katlarını ekrana yazın ve toplamlarını hesaplayınız
            3) 500 den 0 a doğru 13 katlarını ekranda yazınız(tersten sayım olacak)
            4) 1-100 arasında asal sayıların toplamını hesaplayınız? (zor soru)
            */




















            int sayi2 = 2;
            //Bir sayı 1 ve kendisinden başka bölüneni yoksa



            //1,2,3,...,10000
            //1 asal değil???
            //2 asaldır
            //3=>2,3 yok=>değil
            //4=>2,3 var=>4 değil
            //5=>2,3,4 yok=> asaldır
            //6=>2,3,4,5 var=> asal değil
            //sayi2=11=>2,3,4,5,6,7,8,9,10
            int bolenSayi = 2;
            bool asalMi = true;

            while(sayi2 > bolenSayi)
            {
                if(sayi2 % bolenSayi == 0)//eğer sayi2 bolenSayi ya tam bölünüyorsa bu sayi2nin asal olduğunu ispatlar
                {
                    asalMi = false;
                    break;//içinde bulunduğu döngüyü sonlandırır.sayi2>bolenSayi koşullu döngüyü sonlandırır,diğer döngüye devam eder
                }

                bolenSayi++;

            }
            if (asalMi)
            {
                toplamAsalSayilar = toplamAsalSayilar + sayi2;
                Console.Write(sayi2 + ",");
            }
            sayi2++;

        }
        Console.WriteLine();
        Console.WriteLine("Toplam Asal Sayılar:"+ toplamAsalSayilar);
    }
}

namespace _260127_3_do_while_ornek1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullanıcıdan alınan 5 sayıdan en büyük sayıyı hesaplayan yapıyı kodlayınız

            //kullanıcıdan negatif sayı alınakadar girilen pozitif sayıların toplamını ve adetini hesaplayan do while yapısını kodlayınız

            //kullanıcıdan 1-100 arasında sayı girmesini isteyiniz, girilen sayı 1-100 arasında değil ise tekrar sayı girmesini isteyiniz, girilen sayı 1-100 arasında ise sayıyı ekranda gösteriniz ve 1-100 arasında 11 sayı girildikten sonra işlemi sonlandırıp girilen sayıların toplamını ekranda gösteriniz

            //kullanıcı adı admin, şifresi 12?ab olan bir sistem için 3 defa giriş hakkı tanıyan do while sistemini kodlayınız
            //***********************************************************
            //1.SORU
            int sayiAdeti = 0;
            int enbuyukSayi=0;
            do
            {

                Console.WriteLine(sayiAdeti+1+".soruyu giriniz?");
                int sayi1 = Convert.ToInt32(Console.ReadLine());

                if (sayi1>enbuyukSayi)
                {
                    enbuyukSayi = sayi1;
                }
                sayiAdeti++;

            } while (sayiAdeti<5);

            Console.WriteLine("Girilen sayılar içinde en büyük sayı:"+enbuyukSayi);

            //2.SORU
            int sayi;
int toplam = 0;
int adet = 0;

do
{
    Console.Write("Bir sayı girin (negatif çıkış): ");
    sayi = Convert.ToInt32(Console.ReadLine());

    if (sayi > 0)
    {
        toplam += sayi;
        adet++;
    }

} while (sayi >= 0);

Console.WriteLine("Girilen pozitif sayı adedi: " + adet);
Console.WriteLine("Pozitif sayıların toplamı: " + toplam);



            //3.SORU
            int sayi;
            int toplam = 0;
            int adet = 0;

while (adet < 11)
{
    do
    {
        Console.Write("1-100 arası sayı giriniz: ");
        sayi = Convert.ToInt32(Console.ReadLine());
    }
    while (sayi < 1 || sayi > 100);

    toplam = toplam + sayi;
    adet = adet + 1;
}

Console.WriteLine("Girilen sayıların toplamı: " + toplam);

            //4.SORU
            string kullaniciAdi;
string sifre;
int hak = 3;

do
{
    Console.Write("Kullanıcı adı: ");
    kullaniciAdi = Console.ReadLine();

    Console.Write("Şifre: ");
    sifre = Console.ReadLine();

    if (kullaniciAdi == "admin" && sifre == "12?ab")
    {
        Console.WriteLine("Giriş başarılı 👍");
        break;
    }
    else
    {
        hak--;
        Console.WriteLine("Hatalı giriş! Kalan hak: " + hak);
    }

} while (hak > 0);

if (hak == 0)
{
    Console.WriteLine("Giriş hakkınız bitti ❌");
}


            
        }
    }
}

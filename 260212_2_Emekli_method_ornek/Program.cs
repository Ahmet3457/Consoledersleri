namespace _260212_2_Emekli_method_ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
 Bir ülkede emeklilik hesabı cinsiyet,yaş,prim gün sayısı(Çalıştığı gün sayısı) şartlarına göre hesaplanıp emekli edilmektedir 
Eğer Cinsiyet kadın ise
yaş 60 ve üstü ise, prim 7300 ise kişi maaşının 15 katı kadar ikramiye alarak emekli ediliyor

Eğer Cinsiyet erkek ise
yaş 65 ve üstü ise, prim 8500 ise kişi maaşının 17.5 katı kadar ikramiye alarak emekli ediliyor 

bu şartlara kişi emekli ise alacağı ikramiye, emekli değilse emekli olmama nedenini veren yapıyı kodlayınız
NOT:Cinsiyet seçimi switch case ile yapılacaktır
NOT:Eğer prim,yaş ve cinsiyet hatalı girilirse kullanıcıdan bir daha girmesi istenecektir, tekrar giriş yapmayacaksa bu koşul kullanıcıya bırakılır ve kullanıcı klavyede beklenen bir harf, yazı, karakter ile çıkış sağlanmalıdır

 */


        }
        static void Cinsiyet()
        {
            string cinsiyet = "cinsiyet";
            switch(cinsiyet)
            {
                case "kadın":
                    break;
                case "erkek":
                    break;
            }
            Console.WriteLine(cinsiyet);
        }
        static void Yas()
        {
            Console.WriteLine("Yaşınızı giriniz:");
            byte girilenYas = Convert.ToByte(Console.ReadLine());
            if(girilenYas>=60)
            {
                Console.WriteLine("Emeklilik yaşınız uygundur:");

            }
            else
            {
                Console.WriteLine("Emeklilik yaşınız uygun değildir:");

            }
        }


    }
}

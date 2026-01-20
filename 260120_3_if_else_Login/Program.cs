namespace _260120_3_if_else_Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //kullanıcıdan bir websitesi için login sayfasında giriş ekranı için kullanıcı ve şifre isteyen sistemi kodlayarak tasarlayınız
        //kullanıcı adı: admin
        //kullanıcı şifre: ab?0

        BASLA:
            Console.WriteLine("kullanıcı adınızı giriniz?");
            string kullaniciAdi=Console.ReadLine();

            Console.WriteLine("Şifrenizi giriniz?");
            string sifre = Console.ReadLine();

            if (kullaniciAdi == "admin" && sifre == "ab?0")
            {
                Console.WriteLine("Giriş başarılı");
                Console.WriteLine("!!!!!!!!!HOŞGELDİNİZ!!!!!!!!");
            }
            else
            {
                Console.WriteLine("kullanıcı adı veya şifre hatalı, tekrar deneyiniz!");
                goto BASLA;
            }
        }
    }
}

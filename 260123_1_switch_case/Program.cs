namespace _260123_1_switch_case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             switch case karar yapısı sadece eşitlik durumunda çalışan bir karar yapısıdır

            */
            int sayi = 0;

            switch (sayi)//değişken sadece tanımlanır, burda tanımlanan değişken herhangi karşılaştırma operatörü ile kullanılmaz sadece caseler için hangi değişken kullanılacak belirtilir
            {
                case 1://sayi değişken 1e eşit olduğunda burdaki kodlar okunacaktır

                //kod alanı
                break;//1 için son
            case 2:

                break;//her bir case bir break ille sonlanır

            default://bir değer almaz eğer caselerde verilen değer sayi değişkeninde yoksa default kısmındaki kodlar okunacaktır. -if -else yapısındaki else gibi çalışır

                //kodlar
                break;//default için son

            case 56:
                //56 için kodlar
                break;
            }

            string metin = "merhaba";

            switch (metin)
            {
                default:
                    break;

                case "hello":
                case "mer":
                case "":
                    //1 den fazla case 1 break ile sonlandırılabilir
                    break;

                case "slaw":

                    break;

                case "hallo":

                    break;
            }
        }
    }
}

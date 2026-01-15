namespace _260115_3_Mantiksal_Operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             3)Mantıksal operatörler:
            and işareti && => Ve
            or işareti || => Veya
            ----------------------------
            && => and (ve) için 2 işlem sorgusunda 4 değişik sorgu biçiminde çıkacak sonuçlar 
            true && true =True=> and durumunda 2 koşul true olursa işlem sonucu true olacak
            true && false =False
            false && true =False
            false&&false =False

             ||=> or (veya) için 2 işlem sorgusunda 4 değişik soegu biçiminde çıkacak sonuçlar
            true||true=true
            true||false=true
            false||true=true
            false||false=false=> 2 sorgu false olursa işlem sonucu false olur, diğer durumlarda hep true verir
            */

            bool sonuc = 10 > 5 && 20 > 15;
            //-------------true&& true
            //-------------true
            Console.WriteLine("10>5 && 20 > 15 işlem sonucu:" + sonuc);
            sonuc = 10 > 5 && 0 >= 2;
            //------------true&&false=false
            Console.WriteLine("10 > 5 && 0 >= 2 sonuç :" + sonuc);
            sonuc = 10 > 5 || 0 >= 2;
            Console.WriteLine("10 > 5 || 0>= 2 sonuç:"+sonuc);
        }
    }
}

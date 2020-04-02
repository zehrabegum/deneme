using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İKİ TANE SAYİ GİRİNİZ:");
            int sayi1 = int.Parse(Console.ReadLine());
            int sayi2 = int.Parse(Console.ReadLine());
            int buyuk;
            int kucuk;
            if (sayi1 < sayi2)
            {
                buyuk = sayi2;
                kucuk = sayi1;
            }
            else
            {
                buyuk = sayi1;
                kucuk = sayi2;
            }
            int kat = kucuk;
            while (kat % kucuk != 0 || kat % buyuk != 0)
            {
                kat=kat+kucuk;
            }
            Console.WriteLine("sonuc:{0}", kat);
        }
    }
    
}

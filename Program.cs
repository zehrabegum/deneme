using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayi Giriniz:");
            int sayi = int.Parse(Console.ReadLine());
            int toplam = 0;
            for (int i = 1; i < sayi ; i++)
            {
                if(sayi%i==0)
                {
                    toplam += i;
                }
               
            }
            Console.WriteLine("Bölenleri Toplamı:{0}",toplam);
        }
    }
}

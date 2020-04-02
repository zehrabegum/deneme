using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayi Giriniz:");
            int sayi = int.Parse(Console.ReadLine());
            for(int i=2;i<sayi;i++)
            {
                if (sayi % i == 0)
                { 
                    Console.WriteLine("sayi asal degildir");   
                }
                else
                {
                    Console.WriteLine("sayi asaldir");
                    break;//koysan da olur koymasan da.
                }
            }
            if(sayi==1)
            {
                Console.WriteLine("sayi asal degildir");
            }
            if (sayi == 2)
            {
                Console.WriteLine("sayi asaldir");
            }
        }
    }
}

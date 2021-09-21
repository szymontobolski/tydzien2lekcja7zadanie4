using System;

namespace tydzien2lekcja7zadanie5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int rok = 2016;
               

            if (rok % 4 == 0 && rok % 100 != 0 || rok % 400 == 0)

                Console.WriteLine($"{rok} jest rokiem przestępnym");

            else
                Console.WriteLine($"{rok} nie jest rokiem przestępnym");

            Console.ReadKey();
        }
    }
}

using System;
namespace Uppgift2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv lönen för person 1");
            double lön1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Skriv lönen för person 2");
            double lön2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Skriv lönen för person 3");
            double lön3 = double.Parse(Console.ReadLine());
            double medel = (lön1 + lön2 + lön3) / 3;
            Console.WriteLine("Medellönen för dem tre anställda är " + medel + "kr.");
            Console.ReadKey();
        }
    }
}
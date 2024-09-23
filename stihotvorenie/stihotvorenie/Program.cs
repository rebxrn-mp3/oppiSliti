using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stihotvorenie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Грабитель 78");

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Воровал, ворую и буду воровать");
            Console.WriteLine("Буду воровать, буду, буду воровать");
            Console.WriteLine("Торговал, торгую и буду торговать");
            Console.WriteLine("Буду торговать, буду, буду торговать");

            Console.ReadKey();

            Console.ResetColor();
            Console.Clear();

            Console.WriteLine("Грабитель 78");
            Console.WriteLine();
            Console.WriteLine("Воровал, ворую и буду воровать");
            Console.WriteLine("Буду воровать, буду, буду воровать");
            Console.WriteLine("Торговал, торгую и буду торговать");
            Console.WriteLine("Буду торговать, буду, буду торговать");



            Console.ReadKey();
        }
    }
}

using System;

namespace ConsoleAppInteraktywnie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witay ! ");
            Console.WriteLine("Podaj swoje imie: ");
            string imie = Console.ReadLine();
            Console.WriteLine("Podaj nazwisko: ");
            string nazwisko = Console.ReadLine();
            Console.WriteLine($"Witaj {imie} {nazwisko}");
        }
    }
}

using System;

namespace Zadanie_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj jaka silnie chcesz obliczyć :");
            int silnia = int.Parse(Console.ReadLine());

            Console.WriteLine(funkcjaSilnia(silnia));

        }

        private static int funkcjaSilnia(int silnia)
        {
            int wynik = 1;
            for (int licznik = 1; licznik <= silnia; licznik++)
            {
                wynik *= licznik;
            }
            return wynik;
          
        }
    }
}

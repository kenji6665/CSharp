using System;

namespace Pracadomowa1
{
    class Program
    {
        static void Main(string[] args) // funkcja main przyjmuje wartosc args ktory przyjmuje wartosci przez uzytownika z wiersza polecen
        {
            ValueTypes();
            for (; ;)
            {
                Greeting();
                Age();
                Settings();

            }

        }

        private static void ValueTypes()
        {
            int maxInt = int.MaxValue;
            int minInt = int.MinValue;
            long maxLong = long.MaxValue;
            long minLong = long.MinValue;
            Console.WriteLine("maxint =" + maxInt );
            Console.WriteLine("minint =" + minInt);
            Console.WriteLine("maxlong =" + maxLong);
            Console.WriteLine("maxlong =" + maxLong);
        }

        /// <summary>
        /// Ustawienia programu
        /// </summary>
        private static void Settings()
        {
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
        }
        /// <summary>
        /// Sprawdzamy wiek uzytkownika
        /// </summary>
        private static void Age()
        {
            Console.WriteLine("Napisz ile masz lat!!");
            //  int age = int.Parse( Console.ReadLine() ); // Parse konwertuje w tym przypadku stringa na inta podanego z klawiatury jeszcze jest Try Parse
            int age;
            bool result = int.TryParse(Console.ReadLine(), out age);

            //foreach (var item in args) / petla ktora sama wykrywa dlugosc

            if (age > 18)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Jestes Dorosły");
            }
            else if (result == false)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Wprowadzileś zły wiek!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Brawo ,Jestes małym gejem");
            }
        }
        /// <summary>
        /// Wypisujemy Powitanie uzytkownika
        /// </summary>
        private static void Greeting()
        {
            Console.WriteLine("Wpisz swoje imie");
            string name = Console.ReadLine();
            // string name = args[0]; Tak mozna zobaczyc wartosci tablicy args ktore zostaly wpisane z wiersza polecen "CMD"
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Witaj ," + name);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}

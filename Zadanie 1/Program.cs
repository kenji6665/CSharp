using System;

namespace Zadanie_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 256;
            Display(number);
        }


        public static void Display(int howMany)
        {
            int counter = 1;
            howMany++;
            char space = ' ';
            while (counter < howMany)
            {
                string message = counter + " hello";
                Console.WriteLine(message.PadLeft(9,space));
                ++counter;
            }
        }
    }

}



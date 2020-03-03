using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            //Console.WriteLine("Podaj pierwsza cyfre");
            int firstNumber = GetValidIntigerFromConsole();

            //Console.WriteLine("Podaj drugą cyfre");
            int secondNumber = GetValidIntigerFromConsole();
    
            int result = firstNumber + secondNumber;

            Console.WriteLine($"Wynik = {result}"); // Interpolacja $ i zmienne w {}

            Console.ReadKey();
        }

        private static int GetValidIntigerFromConsole()
        {
            string messageToUser = "Podaj cyfre";
            Console.WriteLine(messageToUser);
            string numberString = Console.ReadLine();
            int number;
            bool conversionResult = int.TryParse(numberString, out number);

            while (conversionResult == false)
            {
                Console.WriteLine("Nie podałeś liczby! Spróbuj jeszcze raz!");
                Console.ReadKey();

                Console.Clear();
                Console.WriteLine(messageToUser);
                numberString = Console.ReadLine() + numberString;
                conversionResult = int.TryParse(numberString, out number);
            }

            return number;
        }
    }
}
using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Podaj pierwsza cyfre");
            string firstNumberString = Console.ReadLine();
            int firstNumber;
            bool conversionResult = int.TryParse(firstNumberString, out firstNumber);

            while (conversionResult == false)
            {
                Console.WriteLine("Nie podałeś liczby! Spróbuj jeszcze raz!");
                Console.ReadKey();

                Console.Clear();
                Console.WriteLine("Podaj pierwsza cyfre");
                firstNumberString = Console.ReadLine();
                conversionResult = int.TryParse(firstNumberString, out firstNumber);
            }

            Console.WriteLine("Podaj drugą cyfre");
            string secondNumberString = Console.ReadLine();
            int secondNumber;
            conversionResult = int.TryParse(secondNumberString, out secondNumber);

            while (conversionResult == false)
            {
                Console.WriteLine("Nie podałeś liczby! Spróbuj jeszcze raz!");
                Console.ReadKey();

                Console.Clear();
                Console.WriteLine("Podaj drugą cyfre");
                secondNumberString = Console.ReadLine();
                conversionResult = int.TryParse(secondNumberString, out secondNumber);
            }

            int result = firstNumber + secondNumber;

            Console.WriteLine($"Wynik = {result}"); // Interpolacja $ i zmienne w {}

            Console.ReadKey();
        }
    }
}
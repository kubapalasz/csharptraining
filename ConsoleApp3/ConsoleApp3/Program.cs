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
            int firstNumber = int.Parse(firstNumberString);

            Console.WriteLine("Podaj drugą cyfre");
            string secondNumberString = Console.ReadLine();
            int secondNumber = int.Parse(secondNumberString);


            int result = firstNumber + secondNumber;

            Console.WriteLine($"Wynik = {result}"); // Interpolacja $ i zmienne w {}

            Console.ReadKey();
        }
    }
}
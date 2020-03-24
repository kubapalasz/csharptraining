using System;
using ConsoleTools;
using Math.Services;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args == null || args.Length == 0)
            {
                Console.WriteLine("Podaj parametry wywołania:");
                Console.WriteLine("1/ Kod zadania");
                Console.WriteLine("2/ Parametry zadania");
                return;
            }

            switch (args[0])
            {
                case HelloWorld.Code:
                    HelloWorld.Run(args);
                    break;

                case "04-R":
                    // Dodaj tutaj swój kod ;-)
                    Console.WriteLine("Jestem prostą aplikacją wskazującą największą liczbę :-)");
                    if (args.Length == 1)   // jeśli użytkownik nie przekaże parametrów w trakcie wywołania aplikacji to zostanie o nie poproszony
                    {
                        Console.WriteLine("Podaj liczbę lub wciśnij 'W':");
                        ConsoleKeyInfo currentKey = Console.ReadKey();                          
                        List<string> userArguments = new List<string>();         
                        while (currentKey.Key != ConsoleKey.W)
                        {
                            userArguments.Add(Convert.ToString(currentKey.KeyChar) + Console.ReadLine());
                            Console.WriteLine("Podaj kolejną liczbę lub wciśnij 'W':");
                            currentKey = Console.ReadKey();                            
                        }
                        var wynik = LargestNumber.MaxFromArray(userArguments.ToArray());
                        Console.WriteLine();
                        Console.WriteLine($"Maksymalna liczba = {wynik}");
                        Console.ReadKey();
                        break;
                    } else
                    {
                        var wynik = LargestNumber.MaxFromArray(args);                        
                        Console.WriteLine($"Maksymalna liczba = {wynik}"); // Interpolacja $ i zmienne w {}
                        Console.ReadKey();
                        break;
                    }


                case "08-R":
                    // Dodaj tutaj swój kod ;-)
                    Console.WriteLine("Jestem prostą aplikacją eliminującą liczby nieparzyste :-)");
                    if (args.Length == 1)   // jeśli użytkownik nie przekaże parametrów w trakcie wywołania aplikacji to zostanie o nie poproszony
                    {
                        Console.WriteLine("Podaj liczbę lub wciśnij 'W':");
                        ConsoleKeyInfo currentKey = Console.ReadKey();
                        List<string> userArguments = new List<string>();
                        while (currentKey.Key != ConsoleKey.W)
                        {
                            userArguments.Add(Convert.ToString(currentKey.KeyChar) + Console.ReadLine());
                            Console.WriteLine("Podaj kolejną liczbę lub wciśnij 'W':");
                            currentKey = Console.ReadKey();
                        }
                        var wynik = ElimanteOddNumbers.RemoveOddNumbers(userArguments.ToArray());
                        Console.WriteLine();
                        Console.WriteLine($"Podane liczby bez nieprzystych = {wynik}");
                        Console.ReadKey();
                        break;
                    }
                    else
                    {
                        var wynik = ElimanteOddNumbers.RemoveOddNumbers(args);
                        Console.WriteLine($"Podane liczby bez nieprzystych = {wynik}"); // Interpolacja $ i zmienne w {}
                        Console.ReadKey();
                        break;
                    }
            }

            Console.ReadKey();

        }       
    }
}

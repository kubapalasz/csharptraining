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

            var wynik = string.Empty;
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
                        wynik = LargestNumber.MaxFromArray(userArguments.ToArray());
                        Console.WriteLine();
                        Console.WriteLine($"Maksymalna liczba = {wynik}");
                        Console.ReadKey();
                        break;
                    } else
                    {
                        wynik = LargestNumber.MaxFromArray(args);                        
                        Console.WriteLine($"Maksymalna liczba = {wynik}"); // Interpolacja $ i zmienne w {}
                        Console.ReadKey();

                        break;
                    }


                case "08-R":
                    // Dodaj tutaj swój kod ;-)
                    Console.WriteLine("Jestem prostą aplikacją eliminującą liczby nieparzyste :-)");

                    var numberCandidates = args.ToList(); // od tego momentu lista.

                    if (numberCandidates.Count == 1)   // jeśli użytkownik nie przekaże parametrów w trakcie wywołania aplikacji to zostanie o nie poproszony
                    {                        
                        string currentValue = string.Empty;
                        while(true)
                        {
                            Console.WriteLine("Podaj liczbę lub wybierz W - wynik:");
                            currentValue = Console.ReadLine().ToUpper();
                            if (currentValue == "W")
                            {
                                break;
                            }
                            numberCandidates.Add(currentValue);                           
                        }
                        while (currentValue != "W");

                    }

                    wynik = ElimanteOddNumbers.RemoveOddNumbers(numberCandidates);
                    Console.WriteLine($"Podane liczby bez nieprzystych = {wynik}");
                    break;
            }

            Console.ReadKey();
        }       
    }
}

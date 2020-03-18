using System;
using ConsoleTools;
using Math.Services;
using System.Linq;

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
                    if (args[1] == null || args.Length == 0)   // jeśli użytkownik nie przekaże parametrów w trakcie wywołania aplikacji to zostanie o nie poproszony
                    {
                        Console.WriteLine("Podaj liczbę lub wciśnij 'W':");
                        ConsoleKeyInfo currentKey = Console.ReadKey();  //tutaj chciałem zrobić aby użytkownik mógł zawołać funcję liczacą albo wprowadzać kolejne liczby
                        ClearCurrentConsoleLine();                      //niestety nie wiem jak zrobić aby jednocześnie program kontrolował czy wprowadzony znak to 'W'
                        string[] arguments = new string[] { };          //a jak nie to od razu brał go na poczet wprowadzanej liczby (jako obejście problemu usuwam pierwszy wprowadzany znak)
                        while (currentKey.Key != ConsoleKey.W)
                        {
                            //arguments = arguments.Append(currentKey.KeyChar.ToString()).ToArray();  //to było pewne rozwiązanie ale mogłem wprowadzać tylko pojedyncze cyfry wiec poszedłem w ReadLine
                            //Console.WriteLine();
                            arguments = arguments.Append(Console.ReadLine()+" ").ToArray();
                            Console.WriteLine("Podaj kolejną liczbę lub wciśnij 'W':");
                            currentKey = Console.ReadKey();
                            ClearCurrentConsoleLine();
                        }
                        var wynik = LargestNumber.MaxFromArray(arguments);
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
                    
            }

            Console.ReadKey();

        }
        public static void ClearCurrentConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }
    }
}

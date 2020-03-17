using Math.Services;
using System;
using ConsoleTools;

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
            }

            Console.ReadKey();
        }
    }
}

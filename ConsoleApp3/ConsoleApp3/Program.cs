using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            DateTime asa = new DateTime();

            Human kuba = new Human("18");
            Human aga = new Human("12");



            var justa = new Human
            {
                Age = 33,
                Height = "178",
                SkinColor = "White"
            };

            var justa2 = new Human();
            justa.Age = 33;

            Console.WriteLine("Hello " + kuba.Height + "!");
            Console.WriteLine($"Hello {kuba.Height}!");
            Console.WriteLine($"Hello {aga.Height}!");
            Console.Clear();

            Console.WriteLine($"Hello {justa.AgeInDays()}!");

            var enteredLine = Console.ReadLine();

            Console.WriteLine($"You have entered '{enteredLine}'!");


            var typedKey = Console.ReadKey();

            Console.WriteLine($"You have typed '{typedKey.KeyChar}'!");

            ConsoleKeyInfo currentKey = Console.ReadKey();

            while (currentKey.Key != ConsoleKey.Escape)
            {
                Console.WriteLine($"> '{currentKey.KeyChar}'!");
                currentKey = Console.ReadKey();
            }

            // if | for | foreach | switch 
            /*
             *
             *
             */

        }
    }

    public class Human
    {
        public Human()
        {
        }

        public Human(string height)
        {
            Height = height;
            SkinColor = "Red";
        }

        public string Height { get; set; }
        public string SkinColor { get; set; }
        public int Age { get; set; }

        public int AgeInDays()
        {
            return Age * 365;
        }

    }
}
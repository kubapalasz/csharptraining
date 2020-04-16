using System;

namespace Math.Services
{
    public interface IUsb
    {
    }

    public class Pendrive : IUsb
    {
    }

    public class Mouse : IUsb
    {
    }

    public class PoweBank : IUsb
    {
    }

    public class Mobile : IUsb
    {
    }


    public interface IGeometricFigure
    {
        int X { get; }
        int Y { get; }
        int Width { get; set; }
        int Heigth { get; set; }
        string Character { get; set; }
        void Draw();
        void Grow();
        void Shrink();
        void Move(ConsoleKey consoleKey);
    }

    public abstract class BaseFigure
    {
        public int X { get; set; } = 1;
        public int Y { get; set; } = 1;
        public int Width { get; set; }
        public int Heigth { get; set; }
        public string Character { get; set; }
    }

    public class Circle : BaseFigure, IGeometricFigure
    {
        public Circle()
        {
            X = 100;
        }

        public void Draw()
        {
            throw new NotImplementedException();
        }

        public void Grow()
        {
            throw new NotImplementedException();
        }

        public void Shrink()
        {
            throw new NotImplementedException();
        }

        public void Move(ConsoleKey consoleKey)
        {
            throw new NotImplementedException();
        }
    }

    public class Cross : BaseFigure, IGeometricFigure
    {
    }

    public class Rectangle : BaseFigure, IGeometricFigure
    {
        public Rectangle()
            : this("*") //Constructor chaining
        {
        }

        public Rectangle(string character)
        {
            Character = character;
        }

        public void Draw()
        {
            // CLear
            // Draw
        }

        public void Grow()
        {
        }

        public void Shrink()
        {
        }

        public void Move(ConsoleKey consoleKey)
        {
            if (!IsMoveValid(consoleKey))
            {
                return;
            }

            if (ApplyXYChanges(consoleKey))
            {
                Draw();
            }
        }

        private bool ApplyXYChanges(ConsoleKey consoleKey)
        {
            var shouldIDraw = false;
            switch (consoleKey)
            {
                case ConsoleKey.UpArrow:
                    Y--;
                    shouldIDraw = true;
                    break;
                case ConsoleKey.LeftArrow:
                    X--;
                    shouldIDraw = true;
                    break;
                case ConsoleKey.RightArrow:
                    X++;
                    shouldIDraw = true;
                    break;
                case ConsoleKey.DownArrow:
                    X--;
                    shouldIDraw = true;
                    break;
            }

            return shouldIDraw;
        }

        // Sprawdzenie czy nie wychodzisz za erkan
        private bool IsMoveValid(ConsoleKey consoleKey)
        {
            

            return false;
        }
    }






    public class Drawing
    {
        //private string character;

        public static void DrawRectangle(int xPosition, int yPosition, int height, int width, string character)
        {
            //this.character = character;
            DrawHorizontalLine(xPosition, width, yPosition, character);
            DrawHorizontalLine(xPosition, width, yPosition + height, character);
            DrawVerticallLine(yPosition, height, xPosition, character);            
            DrawVerticallLine(yPosition, height, xPosition + width, character);
        }     
        
        private static void DrawInPoint(int xPosition, int yPosition, string character)
        {
            Console.SetCursorPosition(xPosition, yPosition);
            Console.Write(character);
        }

        private static void DrawHorizontalLine (int startX, int lengthX, int yPosition, string character)
        {
            for (var i = 0; i <= (lengthX); i++)
            {
                DrawInPoint(startX + i, yPosition, character);
            }
        }

        private static void DrawVerticallLine(int startY, int lengthY, int xPosition, string character)
        {
            for (var i = 0; i < (lengthY); i++)
            {
                DrawInPoint(xPosition, startY + i, character);
            }
        }

        //public static void DrawRectangle(int height, int width, string character)                  //old version
        //{
        //    for (var i = 1; i <= height; i++) // pętla po y
        //    {
        //        for (var j = 1; j <= width; j++) // pętla po x
        //        {
        //            if (i == 1 || i == height) // czy pierwszy lub ostatni wiersz
        //            {
        //                Console.Write(character);
        //            }
        //            else
        //            {
        //                if (j == 1 || j == width) // czy pierwsza lub ostatnia kolumna
        //                {
        //                    Console.Write(character);
        //                }
        //                else
        //                {
        //                    Console.Write(" ");
        //                }
        //            }
        //        }
        //        Console.WriteLine();
        //    }
        //}
    }
}

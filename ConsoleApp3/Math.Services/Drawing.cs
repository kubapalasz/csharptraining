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
        int Height { get; set; }
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
        public int Height { get; set; }
        public string Character { get; set; }
    }

    public class Circle : BaseFigure, IGeometricFigure
    {
        public Circle()
        {
            X = 100;
            Y = 20;

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

    public class Rectangle : BaseFigure, IGeometricFigure
    {
        public Rectangle()
            : this("*") //Constructor chaining
        {
            //Character = "*";
        }

        public Rectangle(string character)
        {
            Character = character;
        }
                

        public void Draw()
        {
            Console.Clear(); // CLear
            DrawHorizontalLine(this.X, this.Width, this.Y, this.Character);
            DrawHorizontalLine(this.X, this.Width, this.Y + this.Height, this.Character);
            DrawVerticallLine(this.Y, this.Height, this.X, this.Character);
            DrawVerticallLine(this.Y, this.Height, this.X + this.Width, this.Character);   // Draw
        }

        public void Grow()
        {
            this.Height += 1;
            this.Width += 1;
        }

        public void Shrink()
        {
            this.Height -= 1;
            this.Width -= 1;
        }

        private static void DrawInPoint(int x, int y, string character)
        {
            
            Console.SetCursorPosition(x, y);
            Console.Write(character);
        }

        private static void DrawHorizontalLine(int x, int width, int y, string character)
        {
            for (var i = 0; i <= (width); i++)
            {
                DrawInPoint(x + i, y, character);
            }
        }

        private static void DrawVerticallLine(int y, int height, int x, string character)
        {
            for (var i = 0; i < (height); i++)
            {
                DrawInPoint(x, y + i, character);
            }
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
                    Y++;
                    shouldIDraw = true;
                    break;
                case ConsoleKey.OemPlus:
                    Grow();
                    shouldIDraw = true;
                    break;
                case ConsoleKey.OemMinus:
                    Shrink();
                    shouldIDraw = true;
                    break;
            }

            return shouldIDraw;
        }

        // Sprawdzenie czy nie wychodzisz za erkan
        private bool IsMoveValid(ConsoleKey consoleKey)
        {
            if (consoleKey == ConsoleKey.UpArrow)
            {
                if (Y > 0) return true;
            }
            if ( consoleKey == ConsoleKey.LeftArrow)
            {
                if (X > 0) return true;
            }
            if (consoleKey == ConsoleKey.RightArrow)
            {
                if (X + Width + 1 < Console.WindowWidth) return true;
            }    
            if (consoleKey == ConsoleKey.DownArrow)
            {
                if (Y + Height + 1 < Console.WindowHeight) return true;
            }
            if (consoleKey == ConsoleKey.OemPlus || consoleKey == ConsoleKey.OemMinus) return true;
            
            return false;
        }
    }






    //public class Drawing
    //{
    //    //private string character;

    //    public static void DrawRectangle(int xPosition, int yPosition, int height, int width, string character)
    //    {
    //        //this.character = character;
    //        DrawHorizontalLine(xPosition, width, yPosition, character);
    //        DrawHorizontalLine(xPosition, width, yPosition + height, character);
    //        DrawVerticallLine(yPosition, height, xPosition, character);            
    //        DrawVerticallLine(yPosition, height, xPosition + width, character);
    //    }     
        
    //    private static void DrawInPoint(int xPosition, int yPosition, string character)
    //    {
    //        Console.SetCursorPosition(xPosition, yPosition);
    //        Console.Write(character);
    //    }

    //    private static void DrawHorizontalLine (int startX, int lengthX, int yPosition, string character)
    //    {
    //        for (var i = 0; i <= (lengthX); i++)
    //        {
    //            DrawInPoint(startX + i, yPosition, character);
    //        }
    //    }

    //    private static void DrawVerticallLine(int startY, int lengthY, int xPosition, string character)
    //    {
    //        for (var i = 0; i < (lengthY); i++)
    //        {
    //            DrawInPoint(xPosition, startY + i, character);
    //        }
    //    }

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


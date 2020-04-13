using System;

namespace Math.Services
{
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

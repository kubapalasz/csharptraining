using System;

namespace Math.Services
{
    public class Drawing
    {
        public static void DrawRectangle(int height, int width, string character)
        {   
            for (var i = 1; i <= height; i++) // pętla po y
            {
                for (var j = 1; j <= width; j++) // pętla po x
                {
                    if (i == 1 || i == height) // czy pierwszy lub ostatni wiersz
                    {
                        Console.Write(character);
                    }
                    else
                    {
                        if (j == 1 || j == width) // czy pierwsza lub ostatnia kolumna
                        {
                            Console.Write(character);
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
                Console.WriteLine();
            }
        }             
    }
}

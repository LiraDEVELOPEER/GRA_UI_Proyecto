using System;
using System.Threading;

internal class Barras
{
    public static void Proceso()
    {
        bool sube = true;
        bool horizontal = true;
        int contadorX = 0;
        int contadorY = 0;
        int X = 96;
        int Y = 20;
        Console.Clear();

        Console.ForegroundColor = ConsoleColor.Green;
        Console.SetCursorPosition(40, 0);
        Console.WriteLine("Dibujar gráfica");

        Console.SetCursorPosition(X,Y);

        for (int i = 0; i <= 257; i++)
        {
            if (horizontal==true && contadorX < 6)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("*");
                X -= 1;
                Console.SetCursorPosition(X, Y);
                contadorX++;
            }
            if (contadorX == 6)
            {
                contadorX = 0;
                horizontal = false;
            }

            if (horizontal==false && contadorY < 13)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("*");
                //Y += sube ? -1 : 1;
                if (sube)
                {
                    Y = Y - 1;
                }
                else
                {
                    Y = Y + 1;
                }
                
                Console.SetCursorPosition(X, Y);
                contadorY++;
            }

            if (contadorY == 13)
            {
                contadorY = 0;
                sube = !sube;
                horizontal = true;
                Console.WriteLine("*");
                Console.SetCursorPosition(X-1,Y);
            }

            Thread.Sleep(1);
        }

        Console.SetCursorPosition(X,Y+1); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("*");

        Console.SetCursorPosition(30, 24); 
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Listo!!! Presiona una tecla para continuar");
        Console.ReadKey();
    }
}


using System.ComponentModel.Design;

internal class Espiral
{
    public static void Proceso()
    {
        int topeX=3;
        int tope_Y=1;
        int X = 40;
        int Y = 14;
        bool derecha = false;
        bool sube = true;
        int color = 1;
        bool inicio = true;
        Console.Clear();

        //Condiciones iniciales
        Console.SetCursorPosition(X, Y);
        Console.ForegroundColor = ConsoleColor.Green;

        for (int level = 1; level <= 11; level++)
        {
            
            for (int asterisco = 0; asterisco <= topeX; asterisco++)
            {
                Thread.Sleep(5);

                Console.Write("*");
                if (inicio == true)
                {
                    color = 2;
                    inicio = false;
                }
                //Pa donde va en X
                if (derecha == true)
                {
                    Console.SetCursorPosition(X + 1, Y);
                    X = X + 1;
                }
                else
                {
                    Console.SetCursorPosition(X - 1, Y);
                    X = X - 1;
                }

                if (color == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    color = 2;
                }
                else
                {
                    if (color == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        color = 3;
                    }
                    else
                    {
                        if (color == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            color = 4;
                        }
                        else
                        {
                            if (color == 4)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                color = 5;
                            }
                            else
                            {
                                if (color == 5)
                                {
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    color = 1;
                                }
                            }
                        }
                    }
                }
                
                
                //Color
            }

            for (int asterisco=0; asterisco<= tope_Y; asterisco++)
            {
                Thread.Sleep(5);
                Console.Write("*");
                //Pa donde va en Y
                if (sube == true)
                {
                    Console.SetCursorPosition(X, Y - 1);
                    Y= Y - 1; ;
                }
                else
                {
                    Console.SetCursorPosition(X, Y + 1);
                    Y = Y + 1;
                }
                if (color == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    color = 2;
                }
                else
                {
                    if (color == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        color = 3;
                    }
                    else
                    {
                        if (color == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            color = 4;
                        }
                        else
                        {
                            if (color == 4)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                color = 5;
                            }
                            else
                            {
                                if (color == 5)
                                {
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    color = 1;
                                }
                            }
                        }
                    }
                }
            }

            

            if (sube == true)
            {
                sube = false;
            }
            else
            {
                sube = true;
            }
            if(derecha== true)
            {
                derecha = false;
            }
            else
            {
                derecha = true;
            }

            topeX = topeX + 5;
            tope_Y = tope_Y + 2;
        }
        Console.SetCursorPosition(30, 26);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Listo!!! Presiona una tecla para continuar");
        Console.ReadKey();

        
    }
}
using System;
using System.Diagnostics;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("=== MENÚ PRINCIPAL ===");
            Console.WriteLine("1. Ejecutar Espiral de asteriscos");
            Console.WriteLine("2. Ejecutar Grafica de barras de asteriscos");
            Console.WriteLine("3. Salir");
            Console.Write("Selecciona una opción: ");

            string opcion = Console.ReadLine();
            

            switch (opcion)
            {
                case "1":
                    Espiral.Proceso();
                    break;
                case "2":
                    Barras.Proceso();
                    break;
                case "3":
                    Console.WriteLine("Saliendo... ");
                    return;
                default:
                    Console.WriteLine("Opción no válida. Presiona Enter para intentar de nuevo.");
                    Console.ReadLine();
                    break;
            }
        }
    }
}

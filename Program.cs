using System;
using System.Globalization;

namespace A133590.Ejercicio24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 24");
            Console.WriteLine("Programa que determina si una fecha ingresada es válida y está en formato dd/MM/yyyy.");

            Console.Write("Por favor, ingrese una fecha: ");
            DateTime fecha;
            
            if (DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out fecha))
            {
                Console.WriteLine("La fecha ingresada es válida.");
            }
            else
            {
                Console.WriteLine("La fecha ingresada no es válida.");
            }

            Console.WriteLine("Presione cualquier tecla para continuar..");
            Console.ReadKey();
        }
    }
}

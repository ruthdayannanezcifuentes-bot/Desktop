using System;

namespace ActividadGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Calculadora Básica ---");

            // Paso 1: Definir dos números
            double num1 = 10;
            double num2 = 5;

            // Operación base (Suma)
            double suma = num1 + num2;
            Console.WriteLine($"La suma de {num1} + {num2} es: {suma}");

            // FASE DE LA ACTIVIDAD: Multiplicación
            double multiplicacion = num1 * num2;
            Console.WriteLine($"La multiplicación de {num1} * {num2} es: {multiplicacion}");

            // Pausa para ver el resultado
            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
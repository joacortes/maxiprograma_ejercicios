using System;

namespace _2_segundoEjercicio
{
    class Program
    {
        // 2. Hacer un programa para ingresar un número y luego se emita un cartel por pantalla “Positivo” si el número es mayor a cero, “Negativo” si el número es menor a cero o “Cero” si el número es igual a cero.
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Ingrese un número: ");
            numero = int.Parse(Console.ReadLine());

            if(numero > 0)
                Console.WriteLine("Positivo");
            else if(numero < 0)
                Console.WriteLine("Negativo");
            else
                Console.WriteLine("Cero");
        }
    }
}

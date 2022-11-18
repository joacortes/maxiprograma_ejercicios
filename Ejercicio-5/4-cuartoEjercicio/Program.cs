using System;

namespace _4_cuartoEjercicio
{
    class Program
    {
        // 4. Hacer un programa que solicite UN número y luego calcule y emita un cartel aclaratorio si el mismo es primo o no es primo.  Nota: un numero es primo cuando es divisible únicamente por 1 y por sí mismo.

        // Si n / 1 da resto 0 y n / n da resto 0 y n / i except 
        static void Main(string[] args)
        {
            int n, cont = 0;

            Console.WriteLine("Ingrese un número: ");
            n = int.Parse(Console.ReadLine());

            for(int i = 1; i < n; i++){
                if(n % i == 0)
                    cont++;
            }

            if(cont >= 2)
                Console.WriteLine("El número {0} no es primo", n);
            else
                Console.WriteLine("El número {0} es primo", n);

            
        }
    }
}

using System;

namespace _4_cuartoEjercicio
{
    // 4. Hacer un programa para ingresar cuatro números distintos y luego mostrar por pantalla el menor de ellos.
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4, menor = 0;

            Console.WriteLine("Ingrese el número 1: ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número 2: ");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número 3: ");
            n3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número 4: ");
            n4 = int.Parse(Console.ReadLine());

            if(n1 < n2 && n1 < n3 && n1 < n4){
                menor = n1;
            }else if (n2 < n1 && n2 < n3 && n2 < n4){
                menor = n2;
            }else if (n3 < n1 && n3 < n2 && n3 < n4){
                menor = n3;
            }else{
                menor = n4;
            }

            Console.WriteLine("El menor es: {0}", menor);
        }
    }
}

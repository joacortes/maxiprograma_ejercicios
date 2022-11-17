using System;

namespace _1_primerEjercicio
{
    class Program
    {
// 1. Hacer un programa que solicite el ingreso de dos números y luego calcular:
// La resta si el primero es mayor que el segundo.
// La suma si son iguales.
// El producto si el primero es menor.
// Se deberá emitir un cartel por pantalla con el resultado correspondiente.
        static void Main(string[] args)
        {
            int num, num2, output;

            Console.WriteLine("Ingrese un número: ");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un número: ");
            num2 = int.Parse(Console.ReadLine());

            if(num > num2)
                output = num - num2;
            else if(num < num2)
                output = num * num2;
            else
                output = num + num2;

            Console.WriteLine(output);
        }
    }
}

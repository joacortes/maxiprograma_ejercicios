using System;

namespace _2_segundoEjercicio
{
    class Program
    {
        // 2. Hacer un programa que solicite el ingreso de 10 números y que muestre el mayor de ellos por pantalla. Solo se debe emitir UN valor por pantalla.
        static void Main(string[] args)
        {
            int numero;
            int mayor = 0;
            for(int i = 0; i < 10; i++)
            {
                
                Console.WriteLine("Ingrese un número: ");
                numero = int.Parse(Console.ReadLine());

                if(numero > mayor){
                    mayor = numero;
                }
            }

            Console.WriteLine("El mayor numero es: {0}", mayor);
        }
    }
}

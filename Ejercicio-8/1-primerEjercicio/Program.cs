using System;

namespace _1_primerEjercicio
{
    class Program
    {
        // 1. Hacer una función llamada “producto” que reciba dos números enteros y que devuelva el producto de ambos. Luego hacer un programa que pida el precio de un artículo y la cantidad vendida y muestre por pantalla el monto total a pagar. Usar la función.
        static void Main(string[] args)
        {
            int precio = 0, cantidad = 0, mTotal;

            ingresarDatos(ref precio, ref cantidad);
            mTotal = producto(precio, cantidad);
            
            Console.WriteLine("El monto total a pagar es: " + mTotal);
        }

        static int producto(int a, int b){
            int r;

            r = a * b;

            return r;
        }

        static void ingresarDatos(ref int precio, ref int cantidad){
            Console.WriteLine("Ingrese precio: ");
            precio = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese cantidad: ");
            cantidad = int.Parse(Console.ReadLine());
        }
    }
}

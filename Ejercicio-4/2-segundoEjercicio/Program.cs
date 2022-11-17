using System;

namespace _2_segundoEjercicio
{
    class Program
    {

// 2. Un importante negocio de desinfectante líquido realiza descuentos dependiendo de la cantidad de litros vendidos según la siguiente escala:
// Si vende menos de 100 litros, no hay descuento.
// Si vende entre 101 y 300 litros, el descuento es del 10%.
// Si vende entre 301 y 500 litros, el descuento es del 15%.
// Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.
// Hacer un programa que solicite el ingreso del importe total de la venta y la cantidad de litros vendidos y calcule y emita el importe con el descuento  aplicado..
        static void Main(string[] args)
        {
            double importeTotal, litros, importeConDescuento = 0;

            Console.WriteLine("Ingrese el importe total: ");
            importeTotal = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese los litros vendidos: ");
            litros = double.Parse(Console.ReadLine());

            if(litros > 100 && litros < 301){
                importeConDescuento = importeTotal - (importeTotal * 0.10);
            }else if(litros > 300 && litros < 501){
                importeConDescuento = importeTotal - (importeTotal * 0.15);
            }else if(litros > 500){
                importeConDescuento = importeTotal - (importeTotal * 0.25);
            }

            Console.WriteLine("El importe con descuento es: {0}", importeConDescuento);
        }
    }
}

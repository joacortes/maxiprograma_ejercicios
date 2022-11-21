using System;

namespace _4_cuartoEjercicio
{
    class Program
    {
// 4. Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un registro con los siguientes datos:
// - Número de Artículo (1 a 15)
// - Cantidad Vendida 

// Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0.
// Se pide determinar e informar:
// a) El número de artículo que más se vendió en total.
// b) Los números de artículos que no registraron ventas.
// c) Cuantas unidades se vendieron del número de artículo 10.
        static void Main(string[] args)
        {
            
            int nArticulo, cVendida, mayor, nroArtMax;
            int[] almacenarCantidadArticulos = new int [15];
            

            Console.Write("Ingrese un número de articulo (1-15): ");
            nArticulo = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la cantidad vendida: ");
            cVendida = int.Parse(Console.ReadLine());

            while(nArticulo != 0){

                almacenarCantidadArticulos[nArticulo - 1] += cVendida;

                Console.Write("Ingrese un número de articulo: ");
                nArticulo = int.Parse(Console.ReadLine());

                Console.Write("Ingrese la cantidad vendida: ");
                cVendida = int.Parse(Console.ReadLine());
            }

            mayor = almacenarCantidadArticulos[0];
            nroArtMax = 0;
            for(int i = 0; i < almacenarCantidadArticulos.Length; i++){
                if(almacenarCantidadArticulos[i] > mayor){
                    mayor = almacenarCantidadArticulos[i];
                    nroArtMax = i + 1;
                }

                
            }

            Console.WriteLine("El número de articulos que mas se vendio es: " + nroArtMax + " con una cantidad de " + mayor);

            for(int i = 0; i < almacenarCantidadArticulos.Length; i++){
                if(almacenarCantidadArticulos[i] == 0){
                    Console.WriteLine("El articulo {0} no posee ventas", i + 1);
                }
            }
            
            Console.WriteLine("El número de articulo 10 vendio las siguientes unidades: " + almacenarCantidadArticulos[9]);
        }
    }
}

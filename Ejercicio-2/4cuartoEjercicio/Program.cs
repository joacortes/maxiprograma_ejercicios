using System;

namespace _4cuartoEjercicio
{
    class Program
    {
        // 4. Una casa de computación paga a sus empleados un sueldo fijo de ARS15000 más una comisión del 5% sobre el total facturado por cada empleado. Hacer un programa para ingresar el total facturado por un empleado y que luego calcule y emita por pantalla el sueldo total a cobrar por el mismo.
        static void Main(string[] args)
        {
            double totalFacturado, sueldoTotalFacturado;
            const double SUELDO = 15000.00;
            const double COMISION = 0.05;

            Console.WriteLine("Ingrese el total facturado");
            totalFacturado = double.Parse(Console.ReadLine());

            sueldoTotalFacturado = SUELDO + (totalFacturado * COMISION);

            Console.WriteLine("El sueldo total facturado es de: $ {0}", sueldoTotalFacturado);
        }
    }
}

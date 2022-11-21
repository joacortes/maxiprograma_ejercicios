using System;

namespace _3_tercerEjercicio
{
    class Program
    {
//  Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos (tres ingresos). El programa deberá generar una cadena donde todas las ocurrencias del primer carácter dado hayan sido reemplazadas por el segundo. Mostrar el resultado en pantalla. Ejemplo:
// CADENA FUENTE: “La mar estaba serena"
// CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
// CADENA RESULTADO: “Li mir estibi sereni"
        static void Main(string[] args)
        {
            char[] almacenarCadena;
            string cadena;
            char caracter1, caracter2;

            Console.Write("Ingresar cadena: ");
            cadena = Console.ReadLine();

            
            almacenarCadena = cadena.ToCharArray();

            Console.Write("CARACTER 1: ");
            caracter1 = char.Parse(Console.ReadLine());

            Console.Write("CARACTER 2: ");
            caracter2 = char.Parse(Console.ReadLine());

            for(int i = 0; i < almacenarCadena.Length; i++){
                if(almacenarCadena[i] == caracter1){
                    almacenarCadena[i] = caracter2;
                }
            }

            cadena = new string(almacenarCadena);

            Console.WriteLine(cadena);
        }
    }
}

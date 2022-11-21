using System;

namespace _4_cuartoEjercicio
{
    class Program
    {
// 4. Hacer una función de tipo void (porque no va a devolver nada) llamada “positivoNegativoCero” que reciba un número por valor y una variable por referencia. Que analice el número y escriba variable recibida por referencia con:
// a. 1 si el número es positivo.
// b. -1 si el número es negativo.
// c. 0 si el número es cero.
        static void Main(string[] args)
        {
            int n, b = 0;

            n = int.Parse(Console.ReadLine());

            positivoNegativoCero(n, ref b);

            Console.WriteLine("El numero {0} tiene un estado de {1}", n, b);
        }

        static void positivoNegativoCero(int a, ref int b){
            if(a > 0)
                b = 1;
            else if(a == 0)
                b = 0;
            else
                b = -1;
        }
    }
}

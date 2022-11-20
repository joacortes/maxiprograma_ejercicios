using System;

namespace _2_segundoEjercicio
{
    class Program
    {
//Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. Se pide determinar e informar:
//El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo.
//Informar cuántos grupos están formados por todos números ordenados de mayor a menor.
        static void Main(string[] args)
        {
            int numeros, contImpares, cantNumeros, posicionGrupo = 0, menor, contGrupos = 0;
            double porcentajeMaximo = -1, porcentaje;

            bool ordenados;

            for(int i = 0; i < 5; i++){

                cantNumeros = 0;
                contImpares = 0;
                ordenados = true;

                numeros = int.Parse(Console.ReadLine());
                menor = numeros;
                while(numeros != 0){
                    cantNumeros++;
                    
                    if(numeros % 2 != 0)
                        contImpares++;
                    

                    if(numeros <= menor)
                        menor = numeros;
                    else
                        ordenados = false;
                    
                    numeros = int.Parse(Console.ReadLine());
                }

                
                porcentaje = (contImpares * 100) / cantNumeros;

                if(porcentaje > porcentajeMaximo){
                    porcentajeMaximo = porcentaje;
                    posicionGrupo = i;
                }

                if(ordenados == true)
                    contGrupos++;
            }
            

            Console.WriteLine("El grupo con mayor porcentaje de impares es {0}, con un porcentaje de {1}", posicionGrupo, porcentajeMaximo);
            Console.WriteLine("Hay {0} grupos ordenados de mayor a menor", contGrupos);
        }
    }
}

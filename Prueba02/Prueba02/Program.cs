using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora V.2 ");

            int numero1 = 20;
            int numero2 = 30;

            Console.WriteLine("El primer numero es:" + numero1);
            Console.WriteLine("El segundo numero es:" + numero2);

            //int valorsuma = numero1 + numero2;
            int valorsuma = suma(numero1, numero2);

            Console.WriteLine("La suma es: " + valorsuma);

            int valorresta = resta(numero1, numero2);

            Console.WriteLine("La resta es: " + valorresta);


            Console.Read();


        }
        /// <summary>
        /// Esta operacion calcula la suma de dos numeros. 
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        static int suma(int num1, int num2)
        {
            int result = 0;

            result = num1 + num2;

            return result;

        }
        /// <summary>
        /// Esta operacion calcula la resta de dos numeros 
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        static int resta(int num1, int num2)
        {

            int result = 0;

            result = num1 - num2;

            return result;


        }







    }

}

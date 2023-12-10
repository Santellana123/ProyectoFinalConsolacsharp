using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalC_Consola
{
    internal class RadixSort
    {
        private static int ObtenerDigito(int num, int posicion)
        {
            for (int i = 0; i < posicion; i++)
            {
                num /= 10;
            }
            return num % 10;
        }

        // Función para encontrar el número de dígitos en el número más grande
        private static int NumeroDeDigitos(int num)
        {
            int count = 0;
            while (num > 0)
            {
                num /= 10;
                count++;
            }
            return count;
        }

        // Función principal para ordenar utilizando Radix Sort
        public static void OrdenarRadix(int[] array)
        {
            if (array == null || array.Length <= 1)
                return;

            int max = array.Max();
            int numDigitos = NumeroDeDigitos(max);

            // Aplicar Radix Sort para cada posición de dígito
            for (int posicion = 0; posicion < numDigitos; posicion++)
            {
                // Crear buckets para cada dígito (0-9)
                List<int>[] buckets = new List<int>[10];
                for (int i = 0; i < 10; i++)
                {
                    buckets[i] = new List<int>();
                }

                // Colocar elementos en los buckets según el dígito en la posición actual
                foreach (int num in array)
                {
                    int digito = ObtenerDigito(num, posicion);
                    buckets[digito].Add(num);
                }

                // Reconstruir el array ordenado a partir de los buckets
                int index = 0;
                for (int i = 0; i < 10; i++)
                {
                    foreach (int num in buckets[i])
                    {
                        array[index++] = num;
                    }
                }
            }
        }

        public static void MostrarArreglo(int[] array)
        {
            foreach (int num in array)
            {
                Console.Write($"{num} ");
            }

            Console.WriteLine();
        }
    }
}

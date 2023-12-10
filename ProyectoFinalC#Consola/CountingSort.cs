using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalC_Consola
{
    internal class CountingSort
    {
        public static void OrdenarCounting(int[] array)
        {
            if (array == null || array.Length == 0)
                return;

            int max = array.Max();
            int min = array.Min();
            int range = max - min + 1;

            // Inicializar el arreglo de conteo
            int[] conteo = new int[range];
            int[] resultado = new int[array.Length];

            // Contar la frecuencia de cada elemento
            for (int i = 0; i < array.Length; i++)
            {
                conteo[array[i] - min]++;
            }

            // Calcular las posiciones finales de los elementos en el resultado
            for (int i = 1; i < range; i++)
            {
                conteo[i] += conteo[i - 1];
            }

            // Construir el arreglo ordenado
            for (int i = array.Length - 1; i >= 0; i--)
            {
                resultado[conteo[array[i] - min] - 1] = array[i];
                conteo[array[i] - min]--;
            }

            // Copiar el resultado al arreglo original
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = resultado[i];
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

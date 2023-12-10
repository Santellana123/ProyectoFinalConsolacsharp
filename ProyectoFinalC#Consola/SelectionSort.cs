using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalC_Consola
{
    internal class SelectionSort
    {
        public static void OrdenarSeleccion(int[] array)
        {
            if (array == null || array.Length <= 1)
                return;

            int n = array.Length;

            for (int i = 0; i < n - 1; i++)
            {
                // Encontrar el índice del elemento mínimo en el subarray no ordenado
                int indiceMinimo = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] < array[indiceMinimo])
                    {
                        indiceMinimo = j;
                    }
                }

                // Intercambiar el elemento mínimo con el primer elemento no ordenado
                int temp = array[indiceMinimo];
                array[indiceMinimo] = array[i];
                array[i] = temp;
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

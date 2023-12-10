using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalC_Consola
{
    internal class InsertionSort
    {
        public static void OrdenarInsercion(int[] array)
        {
            int n = array.Length;

            for (int i = 1; i < n; ++i)
            {
                int key = array[i];
                int j = i - 1;

                // Mover los elementos del array[0..i-1] que son mayores que key
                // a una posición por delante de su posición actual
                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }

                array[j + 1] = key;
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalC_Consola
{
    internal class ShellSort
    {
        public static void OrdenarShell(int[] array)
        {
            if (array == null || array.Length <= 1)
                return;

            int n = array.Length;
            int brecha = n / 2;

            while (brecha > 0)
            {
                for (int i = brecha; i < n; i++)
                {
                    int temp = array[i];
                    int j = i;

                    // Realizar inserción directa en el subarray
                    while (j >= brecha && array[j - brecha] > temp)
                    {
                        array[j] = array[j - brecha];
                        j -= brecha;
                    }

                    array[j] = temp;
                }

                // Reducir la brecha
                brecha /= 2;
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

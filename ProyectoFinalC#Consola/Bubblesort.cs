using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalC_Consola
{
    internal class Bubblesort
    {
        public static void OrdenarBurbuja(int[] array)
        {
            int n = array.Length;
            bool swapped;

            do
            {
                swapped = false;

                for (int i = 1; i < n; i++)
                {
                    if (array[i - 1] > array[i])
                    {
                        // Swap elements
                        int temp = array[i - 1];
                        array[i - 1] = array[i];
                        array[i] = temp;

                        swapped = true;
                    }
                }

                // After each pass, the largest unsorted element is at the end
                n--;
            } while (swapped);

            // Mostrar el arreglo ordenado
            Console.WriteLine("Arreglo ordenado con Bubblesort:");
            MostrarArreglo(array);
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

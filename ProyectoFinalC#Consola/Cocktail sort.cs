using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalC_Consola
{
    internal class Cocktail_sort
    {
        public static void OrdenarCocktail(int[] array)
        {
            bool swapped;
            int start = 0;
            int end = array.Length;

            do
            {
                // fase ascendente (de izquierda a derecha)
                swapped = false;
                for (int i = start; i < end - 1; ++i)
                {
                    if (array[i] > array[i + 1])
                    {
                        // Swap elements
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;

                        swapped = true;
                    }
                }

                if (!swapped)
                    break;

                // disminuir el rango ya que el último elemento está en su posición correcta
                end--;

                // fase descendente (de derecha a izquierda)
                swapped = false;
                for (int i = end - 1; i >= start; --i)
                {
                    if (array[i] > array[i + 1])
                    {
                        // Swap elements
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;

                        swapped = true;
                    }
                }

                // aumentar el rango ya que el primer elemento está en su posición correcta
                start++;
            } while (swapped);
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

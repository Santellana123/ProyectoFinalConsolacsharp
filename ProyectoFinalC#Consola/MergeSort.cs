using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalC_Consola
{
    internal class MergeSort
    {
        public static void OrdenarMerge(int[] array)
        {
            if (array == null || array.Length <= 1)
                return;

            // Dividir el array en dos mitades
            int medio = array.Length / 2;
            int[] izquierda = new int[medio];
            int[] derecha = new int[array.Length - medio];

            Array.Copy(array, 0, izquierda, 0, medio);
            Array.Copy(array, medio, derecha, 0, array.Length - medio);

            // Recursivamente ordenar las dos mitades
            OrdenarMerge(izquierda);
            OrdenarMerge(derecha);

            // Combinar las mitades ordenadas
            Combinar(array, izquierda, derecha);
        }

        private static void Combinar(int[] array, int[] izquierda, int[] derecha)
        {
            int i = 0, j = 0, k = 0;

            while (i < izquierda.Length && j < derecha.Length)
            {
                if (izquierda[i] <= derecha[j])
                {
                    array[k] = izquierda[i];
                    i++;
                }
                else
                {
                    array[k] = derecha[j];
                    j++;
                }
                k++;
            }

            while (i < izquierda.Length)
            {
                array[k] = izquierda[i];
                i++;
                k++;
            }

            while (j < derecha.Length)
            {
                array[k] = derecha[j];
                j++;
                k++;
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

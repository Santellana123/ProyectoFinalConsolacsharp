using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalC_Consola
{
    internal class Quicksort
    {
        public static void OrdenarQuick(int[] array)
        {
            if (array == null || array.Length <= 1)
                return;

            QuicksortRecursivo(array, 0, array.Length - 1);
        }

        // Función recursiva para Quicksort
        private static void QuicksortRecursivo(int[] array, int inicio, int fin)
        {
            if (inicio < fin)
            {
                // Obtener el índice de partición, array[p] ahora está en su posición correcta
                int indiceParticion = Particionar(array, inicio, fin);

                // Ordenar los elementos antes y después de la partición
                QuicksortRecursivo(array, inicio, indiceParticion - 1);
                QuicksortRecursivo(array, indiceParticion + 1, fin);
            }
        }

        // Función para particionar el array y devolver el índice de la posición del pivote
        private static int Particionar(int[] array, int inicio, int fin)
        {
            int pivote = array[fin];
            int i = inicio - 1;

            for (int j = inicio; j < fin; j++)
            {
                // Si el elemento actual es menor o igual al pivote
                if (array[j] <= pivote)
                {
                    i++;

                    // Intercambiar array[i] y array[j]
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }

            // Intercambiar array[i+1] y array[fin] (poner el pivote en su posición correcta)
            int temp2 = array[i + 1];
            array[i + 1] = array[fin];
            array[fin] = temp2;

            // Devolver el índice del pivote
            return i + 1;
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

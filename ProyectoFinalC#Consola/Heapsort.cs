using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalC_Consola
{
    internal class Heapsort
    {
        public static void OrdenarHeap(int[] array)
        {
            if (array == null || array.Length <= 1)
                return;

            int n = array.Length;

            // Construir el heap (montículo)
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(array, n, i);
            }

            // Extraer elementos uno por uno desde el heap
            for (int i = n - 1; i > 0; i--)
            {
                // Intercambiar la raíz (elemento máximo) con el último elemento no ordenado
                int temp = array[0];
                array[0] = array[i];
                array[i] = temp;

                // Llamar a Heapify para reconstruir el heap en el subarray reducido
                Heapify(array, i, 0);
            }
        }

        // Función para convertir un subárbol con raíz en el índice 'i' en un montículo (heap)
        private static void Heapify(int[] array, int n, int i)
        {
            int mayor = i;          // Inicializar el mayor como la raíz
            int izquierda = 2 * i + 1;  // índice del hijo izquierdo
            int derecha = 2 * i + 2;     // índice del hijo derecho

            // Si el hijo izquierdo es mayor que la raíz
            if (izquierda < n && array[izquierda] > array[mayor])
            {
                mayor = izquierda;
            }

            // Si el hijo derecho es mayor que la raíz
            if (derecha < n && array[derecha] > array[mayor])
            {
                mayor = derecha;
            }

            // Si el mayor no es la raíz
            if (mayor != i)
            {
                // Intercambiar la raíz con el mayor
                int temp = array[i];
                array[i] = array[mayor];
                array[mayor] = temp;

                // Llamar recursivamente a Heapify para el subárbol afectado
                Heapify(array, n, mayor);
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

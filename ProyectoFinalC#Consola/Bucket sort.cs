using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalC_Consola
{
    internal class Bucket_sort
    {
        public static void OrdenarBucket(int[] array)
    {
        if (array == null || array.Length == 0)
            return;

        int max = array.Max();
        int min = array.Min();
        int range = max - min + 1;

        // Crear buckets
        List<int>[] buckets = new List<int>[range];
        for (int i = 0; i < range; i++)
        {
            buckets[i] = new List<int>();
        }

        // Colocar elementos en los buckets
        for (int i = 0; i < array.Length; i++)
        {
            buckets[array[i] - min].Add(array[i]);
        }

        // Ordenar cada bucket e insertar de nuevo en el array
        int index = 0;
        foreach (var bucket in buckets)
        {
            if (bucket.Count > 0)
            {
                bucket.Sort();
                foreach (var item in bucket)
                {
                    array[index++] = item;
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

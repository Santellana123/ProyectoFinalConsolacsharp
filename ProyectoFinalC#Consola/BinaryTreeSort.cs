using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalC_Consola
{
    internal class BinaryTreeSort
    {
        private class Nodo
        {
            public int Valor;
            public Nodo Izquierda, Derecha;

            public Nodo(int valor)
            {
                Valor = valor;
                Izquierda = Derecha = null;
            }
        }

        // Función para insertar un valor en el árbol binario
        private static Nodo Insertar(Nodo nodo, int valor)
        {
            if (nodo == null)
                return new Nodo(valor);

            if (valor < nodo.Valor)
                nodo.Izquierda = Insertar(nodo.Izquierda, valor);
            else if (valor > nodo.Valor)
                nodo.Derecha = Insertar(nodo.Derecha, valor);

            return nodo;
        }

        // Función para realizar un recorrido en orden del árbol y almacenar los elementos en el array
        private static void RecorridoEnOrden(Nodo nodo, ref int[] array, ref int index)
        {
            if (nodo != null)
            {
                RecorridoEnOrden(nodo.Izquierda, ref array, ref index);
                array[index++] = nodo.Valor;
                RecorridoEnOrden(nodo.Derecha, ref array, ref index);
            }
        }

        // Función principal para ordenar utilizando Binary Tree Sort
        public static void OrdenarBinaryTree(int[] array)
        {
            if (array == null || array.Length <= 1)
                return;

            Nodo raiz = null;

            // Insertar todos los elementos en el árbol binario
            foreach (int valor in array)
            {
                raiz = Insertar(raiz, valor);
            }

            // Realizar un recorrido en orden del árbol y almacenar los elementos en el array
            int index = 0;
            RecorridoEnOrden(raiz, ref array, ref index);
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalC_Consola
{
    internal class ListaEnlazada:EstructuraBase
    {
        private NodoListaEnlazada inicio;

        public override void MostrarFunciones()
        {
            Console.WriteLine("1. Insertar elemento");
            Console.WriteLine("2. Eliminar elemento");
            Console.WriteLine("3. Mostrar Lista Enlazada");
        }

        public void InsertarElemento(int valor)
        {
            NodoListaEnlazada nuevoNodo = new NodoListaEnlazada(valor);
            if (inicio == null)
            {
                inicio = nuevoNodo;
            }
            else
            {
                NodoListaEnlazada actual = inicio;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = nuevoNodo;
            }
        }

        public void EliminarElemento(int valor)
        {
            if (inicio == null)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }

            if (inicio.Valor == valor)
            {
                inicio = inicio.Siguiente;
                return;
            }

            NodoListaEnlazada actual = inicio;
            while (actual.Siguiente != null && actual.Siguiente.Valor != valor)
            {
                actual = actual.Siguiente;
            }

            if (actual.Siguiente != null)
            {
                actual.Siguiente = actual.Siguiente.Siguiente;
            }
            else
            {
                Console.WriteLine($"El elemento {valor} no se encuentra en la lista.");
            }
        }

        public void MostrarLista()
        {
            NodoListaEnlazada actual = inicio;
            while (actual != null)
            {
                Console.Write($"{actual.Valor} ");
                actual = actual.Siguiente;
            }
            Console.WriteLine();
        }

        private class NodoListaEnlazada
        {
            public int Valor { get; }
            public NodoListaEnlazada Siguiente { get; set; }

            public NodoListaEnlazada(int valor)
            {
                Valor = valor;
                Siguiente = null;
            }
        }
    }
}


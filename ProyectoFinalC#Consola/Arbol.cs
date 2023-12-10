using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalC_Consola
{
    internal class Arbol:EstructuraBase
    {
        private NodoArbol raiz;

        public override void MostrarFunciones()
        {
            Console.WriteLine("1. Insertar nodo");
            Console.WriteLine("2. Eliminar nodo");
        }

        public void InsertarNodo(int valor)
        {
            raiz = InsertarNodoRecursivo(raiz, valor);
        }

        private NodoArbol InsertarNodoRecursivo(NodoArbol nodo, int valor)
        {
            if (nodo == null)
            {
                return new NodoArbol(valor);
            }

            if (valor < nodo.Valor)
            {
                nodo.Izquierda = InsertarNodoRecursivo(nodo.Izquierda, valor);
            }
            else if (valor > nodo.Valor)
            {
                nodo.Derecha = InsertarNodoRecursivo(nodo.Derecha, valor);
            }

            return nodo;
        }

        public void EliminarNodo(int valor)
        {
            raiz = EliminarNodoRecursivo(raiz, valor);
        }

        private NodoArbol EliminarNodoRecursivo(NodoArbol nodo, int valor)
        {
            if (nodo == null)
            {
                return nodo;
            }

            if (valor < nodo.Valor)
            {
                nodo.Izquierda = EliminarNodoRecursivo(nodo.Izquierda, valor);
            }
            else if (valor > nodo.Valor)
            {
                nodo.Derecha = EliminarNodoRecursivo(nodo.Derecha, valor);
            }
            else
            {
                if (nodo.Izquierda == null)
                {
                    return nodo.Derecha;
                }
                else if (nodo.Derecha == null)
                {
                    return nodo.Izquierda;
                }

                nodo.Valor = ObtenerMinimoValor(nodo.Derecha);
                nodo.Derecha = EliminarNodoRecursivo(nodo.Derecha, nodo.Valor);
            }

            return nodo;
        }

        private int ObtenerMinimoValor(NodoArbol nodo)
        {
            int minimoValor = nodo.Valor;
            while (nodo.Izquierda != null)
            {
                minimoValor = nodo.Izquierda.Valor;
                nodo = nodo.Izquierda;
            }
            return minimoValor;
        }

        public void MostrarArbol()
        {
            MostrarArbolRecursivo(raiz, 0);
        }

        private void MostrarArbolRecursivo(NodoArbol nodo, int nivel)
        {
            if (nodo != null)
            {
                MostrarArbolRecursivo(nodo.Derecha, nivel + 1);

                for (int i = 0; i < nivel; i++)
                {
                    Console.Write("   ");
                }

                Console.WriteLine(nodo.Valor);

                MostrarArbolRecursivo(nodo.Izquierda, nivel + 1);
            }
        }

        private class NodoArbol
        {
            public int Valor { get; set; }
            public NodoArbol Izquierda { get; set; }
            public NodoArbol Derecha { get; set; }

            public NodoArbol(int valor)
            {
                Valor = valor;
                Izquierda = null;
                Derecha = null;
            }
        }
    }
}


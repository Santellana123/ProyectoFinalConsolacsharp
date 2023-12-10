using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalC_Consola
{
    internal class Pila:EstructuraBase
    {
        private Stack<int> pila = new Stack<int>();

        public override void MostrarFunciones()
        {
            Console.WriteLine("1. Apilar");
            Console.WriteLine("2. Desapilar");
        }

        public void Apilar(int valor)
        {
            pila.Push(valor);
        }

        public void Desapilar()
        {
            if (pila.Count > 0)
            {
                int valorDesapilado = pila.Pop();
                Console.WriteLine($"Elemento desapilado: {valorDesapilado}");
            }
            else
            {
                Console.WriteLine("La pila está vacía.");
            }
        }

        public void MostrarPila()
        {
            foreach (var elemento in pila)
            {
                Console.Write($"{elemento} ");
            }
            Console.WriteLine();
        }
    }
}


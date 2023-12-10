using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalC_Consola
{
    internal class Cola:EstructuraBase
    {
        private Queue<int> cola = new Queue<int>();

        public override void MostrarFunciones()
        {
            Console.WriteLine("1. Encolar");
            Console.WriteLine("2. Desencolar");
        }

        public void Encolar(int valor)
        {
            cola.Enqueue(valor);
        }

        public void Desencolar()
        {
            if (cola.Count > 0)
            {
                int valorDesencolado = cola.Dequeue();
                Console.WriteLine($"Elemento desencolado: {valorDesencolado}");
            }
            else
            {
                Console.WriteLine("La cola está vacía.");
            }
        }

        public void MostrarCola()
        {
            foreach (var elemento in cola)
            {
                Console.Write($"{elemento} ");
            }
            Console.WriteLine();
        }
    }
}


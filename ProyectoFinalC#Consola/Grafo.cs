using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalC_Consola
{
    internal class Grafo:EstructuraBase
    {
        private Dictionary<string, List<string>> vertices;

        public Grafo()
        {
            vertices = new Dictionary<string, List<string>>();
        }

        public override void MostrarFunciones()
        {
            Console.WriteLine("1. Agregar vértice");
            Console.WriteLine("2. Agregar arista");
            Console.WriteLine("3. Mostrar Grafo");
            Console.WriteLine("4. Búsqueda en Profundidad (DFS)");
            Console.WriteLine("5. Búsqueda en Amplitud (BFS)");
        }

        public void AgregarVertice(string nombreVertice)
        {
            if (!vertices.ContainsKey(nombreVertice))
            {
                vertices[nombreVertice] = new List<string>();
            }
            else
            {
                Console.WriteLine($"El vértice {nombreVertice} ya existe en el grafo.");
            }
        }

        public void AgregarArista(string origen, string destino)
        {
            if (vertices.ContainsKey(origen) && vertices.ContainsKey(destino))
            {
                vertices[origen].Add(destino);
            }
            else
            {
                Console.WriteLine("Al menos uno de los vértices no existe en el grafo.");
            }
        }

        public void MostrarGrafo()
        {
            foreach (var vertice in vertices)
            {
                Console.Write($"{vertice.Key}: ");
                Console.WriteLine(string.Join(", ", vertice.Value));
            }
        }

        public void BusquedaProfundidad(string inicio)
        {
            Console.WriteLine("Recorrido DFS:");
            HashSet<string> visitados = new HashSet<string>();
            DFS(inicio, visitados);
            Console.WriteLine();
        }

        private void DFS(string vertice, HashSet<string> visitados)
        {
            if (!visitados.Contains(vertice))
            {
                Console.Write($"{vertice} ");
                visitados.Add(vertice);

                foreach (var vecino in vertices[vertice])
                {
                    DFS(vecino, visitados);
                }
            }
        }

        public void BusquedaAmplitud(string inicio)
        {
            Console.WriteLine("Recorrido BFS:");
            HashSet<string> visitados = new HashSet<string>();
            Queue<string> cola = new Queue<string>();

            visitados.Add(inicio);
            cola.Enqueue(inicio);

            while (cola.Count > 0)
            {
                string actual = cola.Dequeue();
                Console.Write($"{actual} ");

                foreach (var vecino in vertices[actual])
                {
                    if (!visitados.Contains(vecino))
                    {
                        visitados.Add(vecino);
                        cola.Enqueue(vecino);
                    }
                }
            }

            Console.WriteLine();
        }
    }
}


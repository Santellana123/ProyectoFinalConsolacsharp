using ProyectoFinalC_Consola;

Cola cola = new Cola();
Pila pila = new Pila();
Arbol arbol = new Arbol();
ListaEnlazada listaEnlazada = new ListaEnlazada();
Grafo grafo = new Grafo();

while (true)
{
    Console.WriteLine("Elija una estructura de datos:");
    Console.WriteLine("1. Cola");
    Console.WriteLine("2. Pila");
    Console.WriteLine("3. Árbol");
    Console.WriteLine("4. Lista Enlazada");
    Console.WriteLine("5. Grafo");
    Console.WriteLine("6. Algoritmos de Ordenamiento");
    Console.WriteLine("0. Salir");

    Console.Write("Ingrese su elección: ");
    string opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
            RealizarOperacionesCola(cola);
            break;
        case "2":
            RealizarOperacionesPila(pila);
            break;
        case "3":
            RealizarOperacionesArbol(arbol);
            break;
        case "4":
            RealizarOperacionesListaEnlazada(listaEnlazada);
            break;
        case "5":
            RealizarOperacionesGrafo(grafo);
            break;
        case "6":
            RealizarOperacionesOrdenamiento(listaEnlazada);
            break;
        case "0":
            Console.WriteLine("Saliendo del programa. ¡Hasta luego!");
            return;
        default:
            Console.WriteLine("Opción no válida. Inténtelo de nuevo.");
            break;
    }
}
        

        static void MostrarFuncionesBasicas(string nombreEstructura, EstructuraBase estructura)
{
    Console.WriteLine($"Funciones básicas de {nombreEstructura}:");
    estructura.MostrarFunciones();
    Console.WriteLine();
}

static void RealizarOperacionesArbol(Arbol arbol)
{
    while (true)
    {

        Console.WriteLine("Operaciones del Árbol:");
        Console.WriteLine("1. Insertar nodo");
        Console.WriteLine("2. Eliminar nodo");
        Console.WriteLine("3. Mostrar Árbol");
        Console.WriteLine("0. Volver al menú principal");

        Console.Write("Ingrese su elección: ");
        string opcionArbol = Console.ReadLine();

        switch (opcionArbol)
        {
            case "1":
                Console.Write("Ingrese el valor del nuevo nodo: ");
                int valorNodo = int.Parse(Console.ReadLine());
                arbol.InsertarNodo(valorNodo);
                break;
            case "2":
                Console.Write("Ingrese el valor del nodo a eliminar: ");
                int valorEliminar = int.Parse(Console.ReadLine());
                arbol.EliminarNodo(valorEliminar);
                break;
            case "3":
                Console.WriteLine("Árbol actual:");
                arbol.MostrarArbol();
                break;
            case "0":
                return;
            default:
                Console.WriteLine("Opción no válida. Inténtelo de nuevo.");
                break;
        }
    }
}
static void RealizarOperacionesCola(Cola cola)
{
    while (true)
    {
        Console.WriteLine("Operaciones de la Cola:");
        Console.WriteLine("1. Encolar");
        Console.WriteLine("2. Desencolar");
        Console.WriteLine("3. Mostrar Cola");
        Console.WriteLine("0. Volver al menú principal");

        Console.Write("Ingrese su elección: ");
        string opcionCola = Console.ReadLine();

        switch (opcionCola)
        {
            case "1":
                Console.Write("Ingrese el valor a encolar: ");
                int valorEncolar = int.Parse(Console.ReadLine());
                cola.Encolar(valorEncolar);
                break;
            case "2":
                cola.Desencolar();
                break;
            case "3":
                Console.WriteLine("Cola actual:");
                cola.MostrarCola();
                break;
            case "0":
                return;
            default:
                Console.WriteLine("Opción no válida. Inténtelo de nuevo.");
                break;
        }
    }
}
static void RealizarOperacionesPila(Pila pila)
{
    while (true)
    {
        Console.WriteLine("Operaciones de la Pila:");
        Console.WriteLine("1. Apilar");
        Console.WriteLine("2. Desapilar");
        Console.WriteLine("3. Mostrar Pila");
        Console.WriteLine("0. Volver al menú principal");

        Console.Write("Ingrese su elección: ");
        string opcionPila = Console.ReadLine();

        switch (opcionPila)
        {
            case "1":
                Console.Write("Ingrese el valor a apilar: ");
                int valorApilar = int.Parse(Console.ReadLine());
                pila.Apilar(valorApilar);
                break;
            case "2":
                pila.Desapilar();
                break;
            case "3":
                Console.WriteLine("Pila actual:");
                pila.MostrarPila();
                break;
            case "0":
                return;
            default:
                Console.WriteLine("Opción no válida. Inténtelo de nuevo.");
                break;
        }
    }
}
static void RealizarOperacionesListaEnlazada(ListaEnlazada listaEnlazada)
{
    while (true)
    {
        Console.WriteLine("Operaciones de la Lista Enlazada:");
        Console.WriteLine("1. Insertar elemento");
        Console.WriteLine("2. Eliminar elemento");
        Console.WriteLine("3. Mostrar Lista Enlazada");
        Console.WriteLine("0. Volver al menú principal");

        Console.Write("Ingrese su elección: ");
        string opcionLista = Console.ReadLine();

        switch (opcionLista)
        {
            case "1":
                Console.Write("Ingrese el valor a insertar: ");
                int valorInsertar = int.Parse(Console.ReadLine());
                listaEnlazada.InsertarElemento(valorInsertar);
                break;
            case "2":
                Console.Write("Ingrese el valor a eliminar: ");
                int valorEliminar = int.Parse(Console.ReadLine());
                listaEnlazada.EliminarElemento(valorEliminar);
                break;
            case "3":
                Console.WriteLine("Lista Enlazada actual:");
                listaEnlazada.MostrarLista();
                break;
            case "0":
                return;
            default:
                Console.WriteLine("Opción no válida. Inténtelo de nuevo.");
                break;
        }
    }
}
static void RealizarOperacionesGrafo(Grafo grafo)
{
    while (true)
    {
        Console.WriteLine("Operaciones del Grafo:");
        Console.WriteLine("1. Agregar vértice");
        Console.WriteLine("2. Agregar arista");
        Console.WriteLine("3. Mostrar Grafo");
        Console.WriteLine("0. Volver al menú principal");

        Console.Write("Ingrese su elección: ");
        string opcionGrafo = Console.ReadLine();

        switch (opcionGrafo)
        {
            case "1":
                Console.Write("Ingrese el nombre del vértice a agregar: ");
                string nombreVertice = Console.ReadLine();
                grafo.AgregarVertice(nombreVertice);
                break;
            case "2":
                Console.Write("Ingrese el nombre del vértice de origen: ");
                string origen = Console.ReadLine();
                Console.Write("Ingrese el nombre del vértice de destino: ");
                string destino = Console.ReadLine();
                grafo.AgregarArista(origen, destino);
                break;
            case "3":
                Console.WriteLine("Grafo actual:");
                grafo.MostrarGrafo();
                break;
            case "4":
                Console.Write("Ingrese el vértice de inicio para DFS: ");
                string inicioDFS = Console.ReadLine();
                grafo.BusquedaProfundidad(inicioDFS);
                break;
            case "5":
                Console.Write("Ingrese el vértice de inicio para BFS: ");
                string inicioBFS = Console.ReadLine();
                grafo.BusquedaAmplitud(inicioBFS);
                break;
            case "0":
                return;
            default:
                Console.WriteLine("Opción no válida. Inténtelo de nuevo.");
                break;
        }
    }
}
static void RealizarOperacionesOrdenamiento(ListaEnlazada listaEnlazada)
{
    while (true)
    {
        Console.WriteLine("Algoritmos de Ordenamiento:");
        Console.WriteLine("1. Bubblesort");
        Console.WriteLine("2. Cocktail sort");
        Console.WriteLine("3. Insertion sort");
        Console.WriteLine("4. Bucket sort");
        Console.WriteLine("5. Counting sort");
        Console.WriteLine("6. Merge sort");
        Console.WriteLine("7. Binary tree sort");
        Console.WriteLine("8. Radix sort");
        Console.WriteLine("9. Shell sort");
        Console.WriteLine("10. Selection sort");
        Console.WriteLine("11. Heapsort");
        Console.WriteLine("12. Quicksort");
        Console.WriteLine("0. Volver al menú principal");

        Console.Write("Ingrese su elección: ");
        string opcionOrdenamiento = Console.ReadLine();

        switch (opcionOrdenamiento)
        {
            case "1":
                Console.Write("Ingrese los valores separados por espacios: ");
                string inputBubblesort = Console.ReadLine();
                int[] valoresBubblesort = Array.ConvertAll(inputBubblesort.Split(' '), int.Parse);
                Bubblesort.OrdenarBurbuja(valoresBubblesort);
                break;
            case "2":
                Console.Write("Ingrese los valores separados por espacios: ");
                string inputCocktailSort = Console.ReadLine();
                int[] valoresCocktailSort = Array.ConvertAll(inputCocktailSort.Split(' '), int.Parse);
                Cocktail_sort.OrdenarCocktail(valoresCocktailSort);
                break;
            case "3":
                Console.Write("Ingrese los valores separados por espacios: ");
                string inputInsertionSort = Console.ReadLine();
                int[] valoresInsertionSort = Array.ConvertAll(inputInsertionSort.Split(' '), int.Parse);
                InsertionSort.OrdenarInsercion(valoresInsertionSort);

                break;
            case "4":
                Console.Write("Ingrese los valores separados por espacios: ");
                string inputBucketSort = Console.ReadLine();
                int[] valoresBucketSort = Array.ConvertAll(inputBucketSort.Split(' '), int.Parse);
                Bucket_sort.OrdenarBucket(valoresBucketSort);
                break;
            case "5":
                Console.Write("Ingrese los valores separados por espacios: ");
                string inputCountingSort = Console.ReadLine();
                int[] valoresCountingSort = Array.ConvertAll(inputCountingSort.Split(' '), int.Parse);
                CountingSort.OrdenarCounting(valoresCountingSort);
                break;
            case "6":
                Console.Write("Ingrese los valores separados por espacios: ");
                string inputMergeSort = Console.ReadLine();
                int[] valoresMergeSort = Array.ConvertAll(inputMergeSort.Split(' '), int.Parse);
                MergeSort.OrdenarMerge(valoresMergeSort);
                break;
            case "7":
                Console.Write("Ingrese los valores separados por espacios: ");
                string inputBinaryTreeSort = Console.ReadLine();
                int[] valoresBinaryTreeSort = Array.ConvertAll(inputBinaryTreeSort.Split(' '), int.Parse);
                BinaryTreeSort.OrdenarBinaryTree(valoresBinaryTreeSort);
                break;
            case "8":
                Console.Write("Ingrese los valores separados por espacios: ");
                string inputRadixSort = Console.ReadLine();
                int[] valoresRadixSort = Array.ConvertAll(inputRadixSort.Split(' '), int.Parse);
                RadixSort.OrdenarRadix(valoresRadixSort);
                break;
            case "9":
                Console.Write("Ingrese los valores separados por espacios: ");
                string inputShellSort = Console.ReadLine();
                int[] valoresShellSort = Array.ConvertAll(inputShellSort.Split(' '), int.Parse);
                ShellSort.OrdenarShell(valoresShellSort);
                break;
            case "10":
                Console.Write("Ingrese los valores separados por espacios: ");
                string inputSelectionSort = Console.ReadLine();
                int[] valoresSelectionSort = Array.ConvertAll(inputSelectionSort.Split(' '), int.Parse);
                SelectionSort.OrdenarSeleccion(valoresSelectionSort);
                break;
            case "11":
                Console.Write("Ingrese los valores separados por espacios: ");
                string inputHeapsort = Console.ReadLine();
                int[] valoresHeapsort = Array.ConvertAll(inputHeapsort.Split(' '), int.Parse);
                Heapsort.OrdenarHeap(valoresHeapsort);
                break;
            case "12":
                Console.Write("Ingrese los valores separados por espacios: ");
                string inputQuicksort = Console.ReadLine();
                int[] valoresQuicksort = Array.ConvertAll(inputQuicksort.Split(' '), int.Parse);
                Quicksort.OrdenarQuick(valoresQuicksort);
                break;
            case "0":
                return;
            default:
                Console.WriteLine("Opción no válida. Inténtelo de nuevo.");
                break;
        }
    }
}
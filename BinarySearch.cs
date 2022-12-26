namespace Lab03___Search;

class BinarySearch
{
    static void Main1(string[] args)
    {
        Console.WriteLine("\t\t\t*********** Búsqueda Binaria ***********");
        int[] A = { -8, 4, 18, 25, 40, 5, 9, 12, 60, 123, 61, -23, -11, 91, 63, -53, 12, 74, 1, 53 };
        int n = A.Length;
        Console.WriteLine("\nArreglo desordenado: ");

        for (int i = 0; i < n; i++)
        {
            Console.Write($"A[{i}]={A[i]}, ");
        }
        Array.Sort(A);
        Console.WriteLine("\n\nIngrese el número a buscar: ");
        int searched_num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\nArreglo ordenado: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"A[{i}]={A[i]}, ");
        }

        Console.WriteLine();

        DateTime date1 = DateTime.Now;
        Console.WriteLine("\t\t\tHora de inicio: {0}",
                    date1.ToString("hh:mm:ss:fff tt"));

        int posicionEncontrada = busquedaBinaria(A, n, searched_num);

        Console.WriteLine(posicionEncontrada >= 0 ? "\t\t------ Elemento encontrado en posicion: " + posicionEncontrada + " ------"
        : "\t\t------ NO SE ENCONTRÓ EL ELEMENTO ------");

        DateTime date2 = DateTime.Now;
        Console.WriteLine("\t\t\tHora de fin: {0}",
                    date2.ToString("hh:mm:ss:fff tt"));
        
        TimeSpan ts = date2 -date1 ; 
        Console.WriteLine("\t\t\tTiempo de ejecución " +ts.Milliseconds + " ms");
    }

    static int busquedaBinaria(int[] lista, int n, int clave)
    {
        int central, bajo = 0, alto = n - 1;
        int valorCentral;
        while (bajo <= alto)
        {
            central = (bajo + alto) / 2;
            /* indice de elemento central */
            valorCentral = lista[central];
            /* valor del indice central */
            if (lista[central] == clave)
                return central; /* encontrado, devuelve posicion */
            else if (clave < lista[central])
                alto = central - 1; /* ir a sublista inferior */
            else
                bajo = central + 1; /* ir a sublista superior */
        }
        return -1;
        /* elemento no encontrado */
    }
}
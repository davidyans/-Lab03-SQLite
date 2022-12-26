namespace Lab03___Search;

class LinealSearch
{
    static void Main1(string[] args)
    {
        Console.WriteLine("\t\t\t*********** Búsqueda Lineal ***********");    
        int[] A = { 79, 21, 15, 99, 88, 65, 75, 85, 76, 46, 84, 24, 12, 10, 2, 6, 62, 16, 23, 92 };
        int n = A.Length;
        Console.WriteLine("\nArreglo desordenado: ");
        
        
        for (int i = 0; i < n; i++)
        {
            Console.Write($"A[{i}]={A[i]}, ");
        } 

        Console.WriteLine("\n\nIngrese el número a buscar: ");
        int searched_num = Convert.ToInt32(Console.ReadLine());
        
        DateTime date1 = DateTime.Now;
        Console.WriteLine("\t\t\tHora de inicio: {0}",
                    date1.ToString("hh:mm:ss:fff tt"));
        float posicionEncontrada = BusquedaLinealID(A, n, searched_num); // 65 es el elemento a buscar
    
        Console.WriteLine(posicionEncontrada >= 0 ? "\t\t------ Elemento encontrado en posicion: " + posicionEncontrada + " ------"
        : "\t\t------ NO SE ENCONTRÓ EL ELEMENTO ------");

        DateTime date2 = DateTime.Now;
        Console.WriteLine("\t\t\tHora de fin: {0}",
                    date2.ToString("hh:mm:ss:fff tt"));
        
        TimeSpan ts = date2 -date1 ; 
        Console.WriteLine("\t\t\tTiempo de ejecución " +ts.Milliseconds + " ms");

    }

    static int BusquedaLinealID(int[] A, int n, float clave)
    {
        int i;
        for (i = 0; i < n; i++)
            if (A[i] == clave)
                return i;
        return -1;
    }
}
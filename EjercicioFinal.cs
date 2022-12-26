namespace Lab03___Search;

class EjercicioFinal
{
    static void Main(string[] args)
    {
        int successes = 0, failures = 0;
        // Arreglo con 100 numeros aleatorios del 1 al 200
        int[] A = new int[100];
        fillArray(A);

        Console.WriteLine();

        // Arreglo con 50 numeros aleatorios del 1 al 200
        int[] B = new int[50];
        fillArray(B);

        Console.WriteLine("\n ********* Arreglo de búsqueda ************");
        printArray(B);

        count_successes_failures(ref successes, ref failures, A, B);

        // ---------------------- Resultados ----------------------
        // # successes y failures
        Console.WriteLine("\n\n\t\t# búsquedas exitosas: {0}", successes);
        Console.WriteLine("\t\t# búsquedas fallidas: {0}", failures);

        // % successes y failures
        Console.WriteLine("\n\t\tEl % de exitos es: {0}%", (successes * 100) / 50);
        Console.WriteLine("\t\tEl % de fallas es: {0}%", (failures * 100) / 50);

        // Imprimir el arreglo ordenado creciente
        Quicksort(A, 0, A.Length - 1);
        Console.WriteLine("\n\n ********* Arreglo en orden creciente ************");
        printArray(A);

        Console.WriteLine();
    }

    static void fillArray(int[] a){
        Random random = new Random();
        for (int i = 0; i < a.Length; i++)
        {
            a[i] = random.Next(1, 201);
        }
    }

    static void count_successes_failures(ref int successes, ref int failures, int[] A, int[] B){
        for (int i = 0; i < B.Length; i++)
        {
            if (BusquedaSecuencial(A, B[i]) == true)
            {
                successes = successes + 1;
            }
            else
            {
                failures++;
            }
        }
    }

    static void printArray(int[] a){
        for (int i = 0; i < a.Length; i++)
        {
            Console.Write(a[i] + " ");
        }
    }

    static Boolean BusquedaSecuencial(int[] A, int x)
    {
        int i = 0;
        while (i < A.Length && A[i] != x){
            i++;
        }

        if (i < A.Length){
            return true;
        }else{
            return false;
        }
    }

    static void Quicksort(int[] A, int primero, int ultimo)
    {
        int i, j, central, pivote;
        central = (primero + ultimo) / 2;
        pivote = A[central];
        i = primero;
        j = ultimo;
        do
        {
            while (A[i] < pivote)
            {
                i++;
            }
            while (A[j] > pivote)
            {
                j--;
            }
            if (i <= j)
            {
                int tmp = A[i];
                A[i] = A[j];
                A[j] = tmp;
                i++;
                j--;
            }
        } while (i <= j);
        if (primero < j)
        {
            Quicksort(A, primero, j);
        }
        if (i < ultimo)
        {
            Quicksort(A, i, ultimo);
        }
    }
}
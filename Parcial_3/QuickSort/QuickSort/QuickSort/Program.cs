using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] miArreglo = null;
            int intOpcion;
            do
            {
                Console.Clear();
                Console.Write("1.- Generar aleatoriamente datos del arreglo \n" + "2.- Imprimir el arreglo \n" + "3.- Ordenar mediante el método de QuickSort \n" + "0.- Salir \n");
                Console.Write("Elija una opción: ");
                intOpcion = int.Parse(Console.ReadLine());
                switch (intOpcion)
                {
                    case 1: GenerarArregloAleatorio(ref miArreglo); break;
                    case 2: ImprimirArreglo(miArreglo); break;
                    case 3: QuickSort(miArreglo, 0, miArreglo.Length - 1); break;
                }
            }
            while (intOpcion != 0);
            Console.ReadKey();
        }
        static void GenerarArregloAleatorio(ref int[] miArreglo2)
        {
            Random aleatorio = new Random();
            int intTamanoArreglo, intCelda;
            Console.Write("Teclee la cantidad de celdas del arreglo: ");
            intTamanoArreglo = int.Parse(Console.ReadLine());
            miArreglo2 = new int[intTamanoArreglo];
            for (intCelda = 0; intCelda < intTamanoArreglo; intCelda++)
            {
                miArreglo2[intCelda] = aleatorio.Next(1, 100);
            }
        }
        static void ImprimirArreglo(int[] miArreglo3)
        {
            Console.Clear();
            foreach (int intNumero in miArreglo3)
            {
                Console.WriteLine(intNumero);
            }
            Console.ReadKey();
        }
        static void QuickSort(int[] arreglo, int inicio, int final)
        {
            if (inicio < final)
            {
                // Obtener el índice del pivote después de dividir el arreglo
                int indicePivote = Dividir(arreglo, inicio, final);

                // Ordenar recursivamente los elementos antes y después del pivote
                QuickSort(arreglo, inicio, indicePivote - 1);
                QuickSort(arreglo, indicePivote + 1, final);
            }
        }

        // Método para dividir el arreglo y colocar el pivote en su posición correcta
        static int Dividir(int[] arreglo, int inicio, int final)
        {
            // Elegir el último elemento como pivote
            int pivote = arreglo[final];

            // Índice del elemento más pequeño (posición correcta del pivote)
            int posicion = inicio - 1;

            // Recorrer el arreglo desde inicio hasta final-1
            for (int i = inicio; i <= final - 1; i++)
            {
                // Si el elemento actual es menor o igual al pivote
                if (arreglo[i] <= pivote)
                {
                    // Incrementar la posición del elemento más pequeño
                    posicion++;

                    // Intercambiar el elemento actual con el elemento en 'posicion'
                    Cambiar(arreglo, posicion, i);
                }
            }

            // Colocar el pivote en su posición correcta
            // Intercambiar arreglo[posicion+1] con arreglo[final] (el pivote)
            Cambiar(arreglo, posicion + 1, final);

            // Retornar la posición final del pivote
            return posicion + 1;
        }

        // Método para intercambiar dos elementos en un arreglo
        static void Cambiar(int[] arreglo, int a, int b)
        {
            int temporal = arreglo[a];
            arreglo[a] = arreglo[b];
            arreglo[b] = temporal;
        }
    }
}

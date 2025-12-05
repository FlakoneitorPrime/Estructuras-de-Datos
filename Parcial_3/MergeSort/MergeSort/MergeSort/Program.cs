using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
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
                    case 3: miArreglo = MergeSort(miArreglo); break;
                }
            }
            while (intOpcion != 0);
            Console.ReadKey();
        }
        // Método principal de Merge Sort
        // Método principal de Merge Sort
        static int[] MergeSort(int[] arreglo)
        {
            // Caso base: si el arreglo tiene 0 o 1 elemento, ya está ordenado
            if (arreglo.Length <= 1)
            {
                return arreglo;
            }

            // Encontrar el punto medio
            int ptoMedio = arreglo.Length / 2;

            // Dividir el arreglo en dos mitades
            int[] izquierdo = new int[ptoMedio];
            int[] derecho = new int[arreglo.Length - ptoMedio];

            // Copiar elementos a la mitad izquierda
            for (int i = 0; i < ptoMedio; i++)
            {
                izquierdo[i] = arreglo[i];
            }

            // Copiar elementos a la mitad derecha
            for (int i = ptoMedio; i < arreglo.Length; i++)
            {
                derecho[i - ptoMedio] = arreglo[i];
            }

            // Llamadas recursivas para ordenar las mitades
            int[] msIzquierdo = MergeSort(izquierdo);
            int[] msDerecho = MergeSort(derecho);

            // Unir (merge) las dos mitades ordenadas
            return Union(msIzquierdo, msDerecho);
        }

        // Método para unir dos arreglos ordenados
        static int[] Union(int[] arrIzq, int[] arrDer)
        {
            int[] arrResultado = new int[arrIzq.Length + arrDer.Length];
            int i = 0; // Índice para arrIzq
            int j = 0; // Índice para arrDer
            int k = 0; // Índice para arrResultado

            // Comparar elementos de ambos arreglos y copiar el menor
            while (i < arrIzq.Length && j < arrDer.Length)
            {
                if (arrIzq[i] < arrDer[j])
                {
                    arrResultado[k] = arrIzq[i];
                    i++;
                }
                else
                {
                    arrResultado[k] = arrDer[j];
                    j++;
                }
                k++;
            }

            // Copiar los elementos restantes del arreglo izquierdo, si los hay
            while (i < arrIzq.Length)
            {
                arrResultado[k] = arrIzq[i];
                i++;
                k++;
            }

            // Copiar los elementos restantes del arreglo derecho, si los hay
            while (j < arrDer.Length)
            {
                arrResultado[k] = arrDer[j];
                j++;
                k++;
            }

            return arrResultado;
        }

        // Método auxiliar para imprimir el arreglo
        static void ImprimirArreglo(int[] miArreglo3)
        {
            Console.Clear();
            foreach (int intNumero in miArreglo3)
            {
                Console.WriteLine(intNumero);
            }
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
    }
}

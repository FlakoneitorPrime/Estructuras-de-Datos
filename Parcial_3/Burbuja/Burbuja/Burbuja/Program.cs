using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burbuja
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
                Console.Write("1.- Generar aleatoriamente datos del arreglo \n" + "2.- Imprimir el arreglo \n" + "3.- Ordenar mediante el método de la burbuja \n" + "0.- Salir \n");
                Console.Write("Elija una opción: ");
                intOpcion = int.Parse(Console.ReadLine());
                switch (intOpcion)
                {
                    case 1: GenerarArregloAleatorio(ref miArreglo); break;
                    case 2: ImprimirArreglo(miArreglo); break;
                    case 3: Burbuja(miArreglo); break;
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
        static void Burbuja(int[] arreglo)
        {
            int temporal;

            // Bucle externo - recorre todo el arreglo
            for (int i = 0; i < arreglo.Length - 1; i++)
            {
                // Bucle interno - compara elementos adyacentes
                for (int j = 0; j < arreglo.Length - 1 - i; j++)
                {
                    // Si el elemento actual es mayor que el siguiente
                    if (arreglo[j] > arreglo[j + 1])
                    {
                        // Intercambiar los elementos
                        temporal = arreglo[j];
                        arreglo[j] = arreglo[j + 1];
                        arreglo[j + 1] = temporal;
                    }
                }
            }
        }
    }
}

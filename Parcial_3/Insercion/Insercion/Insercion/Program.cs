using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insercion
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
                Console.Write("1.- Generar aleatoriamente datos del arreglo \n" + "2.- Imprimir el arreglo \n" + "3.- Ordenar mediante el método de Inserción \n" + "0.- Salir \n");
                Console.Write("Elija una opción: ");
                intOpcion = int.Parse(Console.ReadLine());
                switch (intOpcion)
                {
                    case 1: GenerarArregloAleatorio(ref miArreglo); break;
                    case 2: ImprimirArreglo(miArreglo); break;
                    case 3: Insercion(miArreglo); break;
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
        static int[] Insercion(int[] arreglo)
        {
            // Comenzamos desde el segundo elemento (índice 1)
            for (int i = 1; i < arreglo.Length; i++)
            {
                int llave = arreglo[i];
                int j = i - 1;

                // Mover los elementos del arreglo[0..i-1] que son mayores que la llave
                // a una posición adelante de su posición actual
                while (j >= 0 && arreglo[j] > llave)
                {
                    arreglo[j + 1] = arreglo[j];
                    j = j - 1;
                }

                // Insertar la llave en su posición correcta
                arreglo[j + 1] = llave;
            }

            return arreglo;
        }
    }
}

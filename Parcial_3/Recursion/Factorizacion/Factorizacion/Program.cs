using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorizacion
{
    class Program
    {
        static void Main(string[] args)
        {
            int Numero, Resultado;
            Console.Write("Capture el númeroa que desea sacar su factorial: ");
            Numero = int.Parse(Console.ReadLine());
            Resultado = Factorial(Numero);
            Console.Write("Resultado: " + Resultado);
            Console.ReadKey();
        }
        static int Factorial(int x)
        {
            if (x == 1)
            {
                return (x);
            }
            else
            {
                return (x * Factorial(x - 1));
            }
        }
    }
}

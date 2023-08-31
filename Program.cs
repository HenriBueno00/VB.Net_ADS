using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_31_08_Operacoes
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.Write("Informe o valor de A: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Informe o valor de B: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("Informe o valor de C: ");
            c = int.Parse(Console.ReadLine());

            c = a + b;

            Console.Write(a + " + " + b + " + " + c);
            Console.ReadKey();
        }
    }
}

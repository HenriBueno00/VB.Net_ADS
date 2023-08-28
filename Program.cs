using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1_VBNet
{
    class Program
    {
        static void Main(string[] args)
        {
            double A = 20, b = 10;
            Console.WriteLine("Hello World!!");
            Console.WriteLine("Fatec Itapetininga");
            Console.WriteLine("Analise e desenvolvimento de sistemas");

            Console.WriteLine(A+" + "+b+" = "+(A+b));
            Console.WriteLine(A + " x " + b + " = " + (A * b));
            Console.WriteLine(A + " mod " + b + " = " + (A % b));
            Console.WriteLine("{0} + {1} = {2:N2
                }",A,b,(A+b));

            Console.ReadKey();
        }
    }
}

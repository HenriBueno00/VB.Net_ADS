using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_31_08_Projeto3
{
    class Program
    {
        static void Main(string[] args)
        {
            string cidade, nome;
            int idade;
            double peso;

            Console.Write("Informe seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Informe sua cidade: ");
            cidade = Console.ReadLine();

            Console.Write("Informe sua idade: ");
            idade = int.Parse(Console.ReadLine());

            Console.Write("Informe seu peso: ");
            peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Informações Digitadas:\n");
            Console.WriteLine("Seu nome é {0}", nome);
            Console.WriteLine("Sua ciade é {0}", cidade);
            Console.WriteLine("Sua idade é {0} Anos", idade);
            Console.WriteLine("Seu peso é {0} Kg", peso);

            Console.ReadKey();
        }
    }
}

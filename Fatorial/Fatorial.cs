using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero para fatorar");
            int x = Convert.ToInt32(Console.ReadLine());

            int resultado = Fatorial(x);
            Console.WriteLine("O resultado é {0}", resultado);



            static int Fatorial(int n)
            {
                // Caso base: fatorial de 0 ou 1 é 1
                if (n == 0 || n == 1)
                    return 1;

                // Chamada recursiva para calcular o fatorial do número anterior
                return n * Fatorial(n - 1);
            }



        }
    }

}


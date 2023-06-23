using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soma_e_Media
{
    internal class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de números que deseja somar (entre 3 e 10): ");
            int i = int.Parse(Console.ReadLine());

            while (i < 3 || i > 10)
            {
                Console.WriteLine("Quantidade inválida! Digite novamente (entre 3 e 10): ");
                i = int.Parse(Console.ReadLine());
            }


            int[] Num = new int[i];
            for (int j = 0; j < i; j++)
            {
                int numero;
                do
                {
                    Console.Write($"Digite o {j + 1}º número: ");
                } while (!int.TryParse(Console.ReadLine(), out numero));
                Num[j] = numero;
            }

            SomaNumeros somanumeros1 = new SomaNumeros();
            int resultado = somanumeros1.Soma(Num);
            Console.WriteLine($"A soma dos números é: {resultado}");

            int media = resultado / i;
            Console.WriteLine("A media é {0}", media);


            Console.ReadKey();
        }

        public class SomaNumeros
        {
            public int Soma(int[] numeros)
            {
                int soma = 0;
                foreach (int num in numeros)
                {
                    soma += num;
                }
                return soma;
            }
        }



    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConversorMoedas
{
    internal class Program
    {
        static void Main()
        {
            Conversor conversor = new Conversor();

            Console.WriteLine("Escolha para qual moeda deseja converter:\n1-Dolar\n2-Euro");
            int op;
            if (int.TryParse(Console.ReadLine(), out op))
            {
                if (op >= 1 && op <= 2)
                {
                    conversor.DefinirCotacao(op);
                }
                else
                {
                    Console.WriteLine("Opção Invalida");
                    Console.ReadKey();
                    Main();
                }
            }
            else
            {
                Console.WriteLine("Opção inválida. Por favor, selecione uma opção válida.");
                Console.ReadKey();
                Main();
            }

            Console.Write("Digite um valor em Real (BRL): ");
            float valorEmReal = float.Parse(Console.ReadLine());

            float valorEmDolar = conversor.ConverterRealParaDolar(valorEmReal);

            Console.WriteLine("Valor em Dólar (USD): " + valorEmDolar);
        }



        class Conversor
        {
            public float Dolar;
            public float Euro;
            private float Moeda;

            public void DefinirCotacao(int opcao)
            {
                /*
                Console.Write("Digite a cotação atual do Dólar: ");
                string input = Console.ReadLine();
                if (float.TryParse(input, out float cotacao))
                {
                    Moeda = cotacao;
                    Console.WriteLine("Cotação da moeda definida com sucesso!");
                }
                else
                {
                    Console.WriteLine("Valor inválido. A cotação não foi definida.");
                }
                 */

            }

            public float ConverterRealParaDolar(float Real)
            {
                return Real / Dolar;
            }

            public float ConverterRealParaEuro(float Real)
            {
                return Real / Euro;
            }
        }


    }

}



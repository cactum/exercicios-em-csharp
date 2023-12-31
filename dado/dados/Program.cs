﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace dado
{
    internal class dado
    {
        static void Main(string[] args)
        {
            bool continuar = true;
            int i = 0, j =0;

            Jogador j1 = new Jogador();
            Console.WriteLine("Digite o nome do Primeiro Jogador");
            j1.nome = Console.ReadLine();

            Jogador j2 = new Jogador();
            Console.WriteLine("Digite o nome do segundo Jogador");
            j2.nome = Console.ReadLine();

           do {
                Console.WriteLine("Iniciando a rodada nº{0}", i + 1);
                Console.WriteLine("Jogador {0} tecle Enter para rolar os dados", j1.nome);
                Console.ReadKey();
                j1.dados();

                Console.WriteLine("Jogador {0} tecle Enter para rolar os dados", j2.nome);
                Console.ReadKey();
                j2.dados();
                i++;

                Console.WriteLine("Digite ENTER para uma nova rodada ou ESC para sair");
                ConsoleKeyInfo keyInfo = Console.ReadKey();

                if (keyInfo.Key == ConsoleKey.Escape)
                {
                    continuar = false;
                }
                else if (keyInfo.Key == ConsoleKey.Enter)
                {
                  Console.WriteLine("Fim da rodada");
                }

            } while (continuar);

            Console.WriteLine("Total de pontos {0}:", j1.nome);
            j1.CalcSomanumArmazenado();

            Console.WriteLine("Total de pontos {0}:", j2.nome);
            j2.CalcSomanumArmazenado();
        }

        public class Jogador
        {
            public string nome = "";
            private List <int> numArmazenado = new List<int>();

            public void dados()
            {
                Random random = new Random();
                int numeroAleatorio = random.Next(1, 6);
                numArmazenado.Add(numeroAleatorio);
                Console.WriteLine(numeroAleatorio);
            }
            
            public void CalcSomanumArmazenado()
            {
                int somaTotal = numArmazenado.Sum();
                Console.WriteLine("Soma total dos dados jogados {0}", somaTotal);
            }

        }

    }

}

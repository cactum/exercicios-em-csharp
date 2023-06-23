using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Jogador j1 = new Jogador();
            Console.WriteLine("Digite o nome do Primeiro Jogador");
            j1.nome = Console.ReadLine();  

            Jogador j2 = new Jogador();
            Console.WriteLine("Digite o nome do segundo Jogador");
            j2.nome = Console.ReadLine();

            Console.WriteLine("Jogador {0} tecle Enter para rolar os dados", j1.nome);
            Console.ReadKey();
            j1.dados();

            Console.WriteLine("Jogador {0} tecle Enter para rolar os dados", j2.nome);
            Console.ReadKey();
            j2.dados();


        }

        public class Jogador
        {
            public string nome = "";

            public void dados()
            {
                Random random = new Random();
                int numeroAleatorio = random.Next(1, 6);
                Console.WriteLine(numeroAleatorio);
            } 


        }

    }

}


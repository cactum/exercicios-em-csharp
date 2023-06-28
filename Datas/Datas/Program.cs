using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace Datas
{
    internal class DataConfig
    {
        static void Main(string[] args)
        {

            MenuFormatoData();

        }

        static void MenuFormatoData()
        {
            Console.Clear();
            Console.WriteLine("Qual o formato de data que deseja visualizar?\n");
            Console.WriteLine("1.Configuração do Sistema\n2.Formato Simples\n3.Formato longo\n4.Formato longo Personalizado\n5.Formato RFC1123 pattern\n");

            int op;
            if (int.TryParse(Console.ReadLine(), out op))
            {
                if (op >= 1 && op <= 5)
                {
                    MenuEventos(op);
                }
                else
                {
                    Console.WriteLine("Opção Invalida");
                    Console.ReadKey();
                    MenuFormatoData();
                }
            }
            else
            {
                Console.WriteLine("Opção inválida. Por favor, selecione uma opção válida.");
                Console.ReadKey();
                MenuFormatoData();
            }
        }

        static void MenuEventos(int formatoData)
        {
            Console.Clear();
            Console.WriteLine("Selecione o evento:\n 1- ENIAC\n 2- RFC1\n 3- Alan Turing\n");

            int op;
            if (int.TryParse(Console.ReadLine(), out op))
            {
                ExibirEvento(op, formatoData);
            }
            else
            {
                Console.WriteLine("Opção inválida. Por favor, selecione uma opção válida.");
                Console.ReadKey();
                MenuEventos(formatoData);
            }
        }

        static void ExibirEvento(int opEvento, int formatoData)
        {
            Console.Clear();
            string dataEvento = "";
            string descricaoEvento = "";

            switch (opEvento)
            {
                case 1:
                    dataEvento = "15 de agosto de 1946";
                    descricaoEvento = "No dia 15 de agosto de 1946 os norte-americanos John Eckert e John Mauchly apresentaram o ENIAC, o primeiro equipamento eletrônico chamado de computador no mundo.";
                    break;
                case 2:
                    dataEvento = "17 de abril de 1969";
                    descricaoEvento = "Em 17 de abril de 1969 foi feita a publicação da RFC1, por esse motivo considera-se esse o dia da internet até hoje.";
                    break;
                case 3:
                    dataEvento = "23 de junho de 1912";
                    descricaoEvento = "Nascimento de Alan Turing, matemático e criptoanalista britânico que é considerado o \"pai da informática\" por ter sido essencial na criação de máquinas que, mais tarde, dariam origem aos PCs que utilizamos hoje para trabalhar, estudar e realizar nossas atividades diárias. Sua genialidade e influência fundamental na história da humanidade, entretanto, foram ceifadas pelo preconceito de uma época que, felizmente, já ficou para trás.";
                    break;
                default:
                    Console.WriteLine("Opção inválida. Por favor, selecione uma opção válida.");
                    Console.ReadKey();
                    MenuEventos(formatoData);
                    return;
            }

            Console.WriteLine("\nCabeçalho do evento:");
            Console.WriteLine("Data: " + FormatarData(dataEvento, formatoData));
            Console.WriteLine("Descrição: " + descricaoEvento);
        }

        static string FormatarData(string data, int formato)
        {
            Console.Clear();
            DateTime dataEvento;
            if (DateTime.TryParse(data, out dataEvento))
            {
                switch (formato)
                {
                    case 1:
                        return dataEvento.ToString();
                    case 2:
                        return dataEvento.ToString("dd-MM-yy");
                    case 3:
                        return dataEvento.ToString("D");
                    case 4:
                        return dataEvento.ToString("dd-MM-yyyy HH:mm:ss");
                    case 5:
                        return dataEvento.ToString("R");
                    default:
                        return data;
                }
            }
            else
            {
                return data;


            }

        }
    }
}

       
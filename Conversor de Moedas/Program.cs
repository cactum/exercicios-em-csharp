using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

class Conversor
{
    private float cotacaoMoeda;   

    public void DefinirCotacaoMoeda(string opMoeda)
    {
        Console.Clear();
        Console.WriteLine("Digite a cotação atual:");
        string input = Console.ReadLine();
        if (float.TryParse(input, out float cotacao))
        {
            cotacaoMoeda = cotacao;
            Console.WriteLine($"Cotacao do {opMoeda} definida com sucesso!");            

        }
        else
        {
            Console.WriteLine($"Valor invalido. A cotação do {opMoeda} não foi definida.");
            DefinirCotacaoMoeda(opMoeda);

        }
    }


    public float ConverterRealEmMoeda(float ValorEmReal)
    {
        return ValorEmReal / cotacaoMoeda;
    }


}

class program
{
    static void Main()
    {
        string Moeda = "";
        int opcao;
        Conversor conversor = new Conversor();
        
        Console.WriteLine("Escolha a opção para qual deseja converter:");
        Console.WriteLine("1-Dolar\n2-Euro");
        opcao = int.Parse(Console.ReadLine());

        if (opcao == 1)
        {
            Moeda = "Dolar (USD)";
            conversor.DefinirCotacaoMoeda(Moeda);
        } 
        else if (opcao == 2)
        {
            Moeda = "Euro (EUR)";
            conversor.DefinirCotacaoMoeda(Moeda);
        }
        else
        {
            Console.WriteLine("Opção inválida.");
            Main();
        }

        Console.WriteLine("Digite o valor em Real (BRL): ");
        float ValorEmReal = float.Parse(Console.ReadLine());

        int opConversao = opcao;

        if (opConversao == 1 || opConversao == 2)
        {
            float ValorConvertido = conversor.ConverterRealEmMoeda(ValorEmReal);
            Console.WriteLine($"valor em {Moeda}: " + ValorConvertido);
            return;
        }
        else
        {
            Console.WriteLine("Opção inválida. Encerrando o programa.");
            return;
        }
    }
}
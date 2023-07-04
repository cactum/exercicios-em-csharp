using System;

class Program
{
    static void Main()
    {
        string[] animais = { "cachorro", "gato", "papagaio", "elefante", "leão", "tigre", "girafa", "macaco", "coelho", "peixe" };
        string[] objetos = { "martelo", "pente", "sofá", "televisão", "mesa", "celular", "cama", "geladeira", "armário", "panela" };
        string[] frutas = { "abacate", "goiaba", "uva", "laranja", "abacaxi", "maçã", "banana", "limão", "tangerina", "jabuticaba" };

        string palavraSorteada = SortearPalavra(animais, objetos, frutas);

        Console.WriteLine("Palavra sorteada: " + palavraSorteada);

    }

    static string SortearPalavra(params string[][] matrizes)
    {
        Random random = new Random();
        int indiceMatrizSorteada = random.Next(0, matrizes.Length);
        string[] matrizSorteada = matrizes[indiceMatrizSorteada];

        int indiceSorteado = random.Next(0, matrizSorteada.Length);
        return matrizSorteada[indiceSorteado];
    }
}



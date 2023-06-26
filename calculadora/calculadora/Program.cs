using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace calculadora
{
    class program
    {
        static void Main(string[] args)
        {
            bool continuar = true;
            int num1, num2, result;
            char ope;

            do
            {
                cabecalho();

                Console.WriteLine("Digite o primeiro numero, tecle Enter ´para continuar");
                Console.WriteLine("Digite a operação e tecle Enter: +, -, *, / ");
                Console.WriteLine("Digite o segundo numero, tecle Enter para continuar");
                num1 = int.Parse(Console.ReadLine());
                ope = Convert.ToChar(Console.ReadLine());
                num2 = int.Parse(Console.ReadLine());


                switch (ope)
                {
                    case '+':
                        result = num1 + num2;
                        Console.WriteLine("Resultado: {0}", result);
                        break;
                    case '-':
                        result = num1 - num2;
                        Console.WriteLine("Resultado: {0}", result);
                        break;
                    case '*':
                        result = num1 * num2;
                        Console.WriteLine("Resultado: {0}", result);
                        break;
                    case '/':
                        if (num1 == 0 || num2 == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Impossivel dividor por 0");
                        }
                        else
                        {
                            result = num1 / num2;
                            Console.WriteLine("Resultado: {0}", result);
                        }
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Operação invalida!");
                        break;
                }

                Console.ReadKey();
                Console.Clear();

                if (Console.ForegroundColor != ConsoleColor.White)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }

                Console.WriteLine("Tecle ENTER para continuar ou ESC para sair");
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.Escape)
                {
                    continuar = false;
                }
            } while (continuar);
        }

        static void cabecalho()
        {
            Console.WriteLine("***** CALCULADORA C# *****");
            Console.WriteLine("\n");
        }

    }

}
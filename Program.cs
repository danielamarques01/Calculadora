using System;
using System.Globalization;
namespace HelloWord
{
    class Program
    {

        enum Menu { Soma = 1, Subtracao, Divisao, Multiplicacao, Potencia, Raiz, Sair }
        static void Main(string[] args)
        {
            bool escolheuSair = false;
            while (!escolheuSair) //Enquanto o usúario NAO(!) ESCOLHER SAIR EXIBA O MENU
            {

                Console.WriteLine("Seja bem-vindo ao CALC, selecione uma das opções:");
                Console.WriteLine("1-soma\n2-Subtração\n3-Divisão\n4-Multiplicação\n5-Potência\n6-Raiz\n7-Sair");

                Menu opcao = (Menu)int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case Menu.Soma:
                        Soma();
                        break;
                    case Menu.Subtracao:
                        Sub();
                        break;
                    case Menu.Divisao:
                        Div();
                        break;
                    case Menu.Multiplicacao:
                        Mult();
                        break;
                    case Menu.Raiz:
                        Raiz();
                        break;
                    case Menu.Potencia:
                    Pot();
                        break;
                    case Menu.Sair:
                        escolheuSair = true;
                        break;
                }



                Console.WriteLine(opcao);
                Console.Clear(); //Serve para limpar as informações quando chegar no final do programa
            }

            static void Soma()
            {
                Console.WriteLine("Soma de dois numeros: ");
                Console.WriteLine("Digite o primeiro numero: ");
                int a = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o segundo numero:");
                int b = int.Parse(Console.ReadLine());

                int resultado = a + b;

                Console.WriteLine($"O resultado é: {resultado}"); //A interpolação ($) é usada para substituir a concatenação
                Console.WriteLine("Aperte ENTER para voltar para o MENU");
                Console.ReadLine();
            }

            static void Sub()
            {
                Console.WriteLine("Subtração de dois números: ");
                Console.WriteLine("Digite o primeiro número ");
                int a = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o segundo número: ");
                int b = int.Parse(Console.ReadLine());

                int resultado = a - b;

                Console.WriteLine($"O resultado é: {resultado}"); //A interpolação ($) é usada para substituir a concatenação
                Console.WriteLine("Aperte ENTER para voltar para o MENU");
                Console.ReadLine();
            }

            static void Div()
            {
                Console.WriteLine("Divisão de dois números: ");
                Console.WriteLine("Digite o primeiro número ");
                int a = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o segundo número: ");
                int b = int.Parse(Console.ReadLine());

                float resultado = (float)a/b;

                Console.WriteLine($"O resultado é: {resultado}"); //A interpolação ($) é usada para substituir a concatenação
                Console.WriteLine("Aperte ENTER para voltar para o MENU");
                Console.ReadLine();
            }

            static void Mult()
            {
                Console.WriteLine("Multiplicação de dois números: ");
                Console.WriteLine("Digite o primeiro número ");
                int a = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o segundo número: ");
                int b = int.Parse(Console.ReadLine());

                int resultado = a * b;

                Console.WriteLine($"O resultado é: {resultado}"); //A interpolação ($) é usada para substituir a concatenação
                Console.WriteLine("Aperte ENTER para voltar para o MENU");
                Console.ReadLine();
            }

            static void Pot()
            {
                Console.WriteLine("Potencia de um número: ");
                Console.WriteLine("Digite a base número ");
                int baseNum = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o expoente: ");
                int expo = int.Parse(Console.ReadLine());

                int resultado = (int)Math.Pow(baseNum, expo);

                Console.WriteLine($"O resultado é: {resultado}"); //A interpolação ($) é usada para substituir a concatenação
                Console.WriteLine("Aperte ENTER para voltar para o MENU");
                Console.ReadLine();

            }

            static void Raiz()
            {
                Console.WriteLine("Raiz de um número: ");
                Console.WriteLine("Digite o número ");
                int a = int.Parse(Console.ReadLine());

                double resultado = Math.Sqrt(a);

                Console.WriteLine($"O resultado é: {resultado}"); //A interpolação ($) é usada para substituir a concatenação
                Console.WriteLine("Aperte ENTER para voltar para o MENU");
                Console.ReadLine();
            }
    
        }
    }
}
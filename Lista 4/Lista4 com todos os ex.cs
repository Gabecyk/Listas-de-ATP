using System;

class Program
{
    static void Main(string[] args)
    {
        // Menu de seleção dos exercícios
        Console.WriteLine("Qual exercício deseja acessar?");
        Console.WriteLine("1 - Ex01");
        Console.WriteLine("2 - Ex02");
        Console.WriteLine("3 - Ex03");
        Console.WriteLine("4 - Ex04");
        Console.WriteLine("5 - Ex05");
        Console.WriteLine("6 - Ex06");
        Console.WriteLine("7 - Ex07");
        Console.WriteLine("8 - Ex08");
        Console.WriteLine("9 - Ex09");
        Console.WriteLine("10 - Ex10");

        // Leitura da escolha do usuário
        int res = int.Parse(Console.ReadLine());

        // Seleção do exercício correspondente
        switch (res)
        {
            case 1:
                Ex01();
                break;
            case 2:
                Ex02();
                break;
            case 3:
                Ex03();
                break;
            case 4:
                Ex04();
                break;
            case 5:
                Ex05();
                break;
            case 6:
                Ex06();
                break;
            case 7:
                Ex07();
                break;
            case 8:
                Ex08();
                break;
            case 9:
                Ex09();
                break;
            case 10:
                Ex10();
                break;
            default:
                Console.WriteLine("Escreva entre os números 1 a 10!");
                break;
        }
    }

    // Função do exercício 1
    static void Ex01()
    {
        // Função para calcular a média aritmética
        static double MediaA(int a, int b, int c)
        {
            int soma = a + b + c;
            return (double)soma / 3;
        }

        // Função para calcular a média ponderada
        static double MediaP(int a, int b, int c)
        {
            return (double)(a * 5 + b * 3 + c * 2) / 10;
        }

        // Função principal do exercício 1
        Console.WriteLine("Quantos alunos deseja calcular as médias?");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Aluno: " + (i + 1));

            // Leitura das notas dos alunos
            Console.WriteLine("Digite a nota:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota:");
            int c = int.Parse(Console.ReadLine());

            // Escolha entre média aritmética ou ponderada
            Console.WriteLine("Digite a opção desejada: \nA - Média aritmética\nP - Média ponderada");
            char op = char.Parse(Console.ReadLine());

            if (op == 'A' || op == 'a')
            {
                double media = MediaA(a, b, c);
                Console.WriteLine("A média aritmética é: " + media);
            }
            else if (op == 'P' || op == 'p')
            {
                double media = MediaP(a, b, c);
                Console.WriteLine("A média ponderada é: " + media);
            }
        }
    }

    // Função do exercício 2
    static void Ex02()
    {
        // Função para calcular a média de filhos
        static double CalcularFilhos(int numFilhos, int i)
        {
            return (double)numFilhos / i;
        }

        // Função para calcular a média de salários
        static double CalcularSalario(int salario, int i)
        {
            return (double)salario / i;
        }

        // Função para coletar dados de salários e número de filhos
        static void Coleta(ref int salario, ref int numFilhos, ref int i)
        {
            char sair;
            do
            {
                Console.WriteLine("Para parar digite 'N':");
                Console.WriteLine("Ou digite qualquer tecla para continuar:");
                sair = char.Parse(Console.ReadLine());
                if (sair != 'N')
                {
                    Console.WriteLine("Informe o Salário:");
                    salario += int.Parse(Console.ReadLine());

                    Console.WriteLine("Quantos filhos possui:");
                    numFilhos += int.Parse(Console.ReadLine());

                    i++; // Incrementa o contador para a média
                }

                Console.Clear();
            } while (sair != 'N');
        }

        // Função principal do exercício 2
        char resInicial;
        int numFilhos = 0, salario = 0;
        int i = 0;

        do
        {
            Console.WriteLine("Deseja fazer o procedimento? \nDigite: 'S' (sim) ou 'N' (não)");
            resInicial = char.Parse(Console.ReadLine());
            if (resInicial == 'S')
            {
                Coleta(ref salario, ref numFilhos, ref i);
                double mediaSalario = CalcularSalario(salario, i);
                double mediaFilhos = CalcularFilhos(numFilhos, i);
                Console.Clear();

                // Exibe os resultados das médias
                Console.WriteLine("A média dos salários é: " + mediaSalario);
                Console.WriteLine("A média de filhos é: " + mediaFilhos);
            }
            else if (resInicial == 'N')
            {
                Console.Clear();
                Console.WriteLine("Procedimento cancelado!");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Digite corretamente!");
            }
        } while (resInicial != 'S' && resInicial != 'N');
    }

    // Funções vazias para os exercícios 3 a 10 (devem ser implementadas conforme necessário)
    static void Ex03()
    {
        // Implemente a lógica do exercício 3 aqui
    }

    static void Ex04()
    {
        // Implemente a lógica do exercício 4 aqui
    }

    static void Ex05()
    {
        // Implemente a lógica do exercício 5 aqui
    }

    static void Ex06()
    {
        // Implemente a lógica do exercício 6 aqui
    }

    static void Ex07()
    {
        // Implemente a lógica do exercício 7 aqui
    }

    static void Ex08()
    {
        // Implemente a lógica do exercício 8 aqui
    }

    static void Ex09()
    {
        // Implemente a lógica do exercício 9 aqui
    }

    static void Ex10()
    {
        // Implemente a lógica do exercício 10 aqui
    }
}

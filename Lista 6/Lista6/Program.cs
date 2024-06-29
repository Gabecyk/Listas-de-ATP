using System;
class Program
{
    public static void Main()
    {
        int opcao;
        string? resp = " ";
        do
        {
            Console.Clear();
            Console.WriteLine("Digite:");
            Console.WriteLine("1 - Para executar o exercicio 1.");
            Console.WriteLine("2 - Para executar o exercicio 2.");
            Console.WriteLine("3 - Para executar o exercicio 3.");
            Console.WriteLine("4 - Para executar o exercicio 4.");
            Console.WriteLine("5 - Para executar o exercicio 5.");
            Console.WriteLine("6 - Para executar o exercicio 6.");
            Console.WriteLine("7 - Para executar o exercicio 7.");
            Console.WriteLine("8 - Para executar o exercicio 8.");
            Console.WriteLine("9 - Para executar o exercicio 9.");
            Console.WriteLine("10 - Para executar o exercicio 10.");
            int.TryParse(Console.ReadLine(), out opcao);

            switch (opcao)
            {
                case 1:
                    ex01 Ex01 = new ex01();
                    Ex01.Run();
                    break;
                case 2:
                    ex02 Ex02 = new ex02();
                    Ex02.Run();
                    break;
                case 3:
                    ex03 Ex03 = new ex03();
                    Ex03.Run();
                    break;
                case 4:
                    ex04 Ex04 = new ex04();
                    Ex04.Run();
                    break;
                case 5:
                    ex05 Ex05 = new ex05();
                    Ex05.Run();
                    break;
                case 6:
                    ex06 Ex06 = new ex06();
                    Ex06.Run();
                    break;
                case 7:
                    ex07 Ex07 = new ex07();
                    Ex07.Run();
                    break;
                case 8:
                    ex08 Ex08 = new ex08();
                    Ex08.Run();
                    break;
                case 9:
                    ex09 Ex09 = new ex09();
                    Ex09.Run();
                    break;
                case 10:
                    ex10 Ex10 = new ex10();
                    Ex10.Run();
                    break;
                default:
                    Console.WriteLine("Opção invalida");
                    break;
            }
            Console.WriteLine("Deseja executar outro exercício? (s/n)");
            resp = Console.ReadLine().ToLower();
        } while (resp.ToLower().Equals("s"));
        if (resp.Equals("n")){
            Console.Clear();
            Console.WriteLine("Programa Finalizado.");
        }
    }
}
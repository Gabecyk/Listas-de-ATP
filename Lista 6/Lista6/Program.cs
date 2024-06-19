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
                default:
                    Console.WriteLine("Opção invalida");
                    break;
            }
            Console.WriteLine("Deseja executar outro exercício? (s/n)");
            resp = Console.ReadLine();
        } while (resp.ToLower().Equals("s"));
        if (resp.Equals("n")){
            Console.Clear();
            Console.WriteLine("Programa Finalizado.");
        }
    }
}
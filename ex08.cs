using System;

class Program
{
    public static void Main(string[] args)
    {

        // Declaração de variáveis
        int n = 0;
        int Fi = 0;
        int Fi2 = 1;
        int Fi3 = 0;

        // Entrada de dados
        Console.WriteLine("Digite o valor inteiro:");
        n = int.Parse(Console.ReadLine());

        // Processamento
        if (1 > n)
        {
            Console.WriteLine("0");
        }
        else if (2 > n)
        {
            Console.WriteLine("1");
        }
        else
        {
            Console.WriteLine("0");
            Console.WriteLine("1");
        }

        // for para calcular os valores de Fibonacci e resultado
        for (int i = 3; i <= n; i++)
        {
            Fi = Fi2 + Fi3;
            Console.WriteLine(Fi);
            Fi3 = Fi2;
            Fi2 = Fi;
        }
    }
}
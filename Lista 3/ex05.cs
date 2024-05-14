using System;

class Program
{
    public static void Main(string[] args)
    {
        // Declaração de variáveis
        int n = 0;
        double s = 0;

        // Entrada de dados
        Console.WriteLine("Digite o valor inteiro:");
        n = int.Parse(Console.ReadLine());

        // if caso seja menor igual a zero ele encerra
        if (n <= 0)
        {
            Console.WriteLine("O número precisa ser positivo");
        }
        else
        {
            for (int i = 1; i <= n; i++)
            {
                if (i == n)
                {
                    s += 1 / (double)s;
                    Console.WriteLine("Final: " + s);
                }
                else
                {
                    s += (double)i / 1;
                    Console.WriteLine(s);
                }
            }
        }

        // Resultado
        Console.WriteLine("Resultado de N: " + s);
    }
}
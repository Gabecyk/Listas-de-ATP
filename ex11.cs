using System;

class Program
{
    public static void Main(string[] args)
    {
        // Variaveis que serão usadas

        int num = 0;
        int qtd1 = 0;
        int qtd2 = 0;
        int qtd3 = 0;
        int qtd4 = 0;
        int qtd5 = 0;
        int qtd6 = 0;

        // do while para repetir o programa até que o usuario digite 0
        do
        {
            Console.Write("Vote nos candidatos de 1 a 4, 5 para nulo e 6 para voto em branco:");
            num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("Você votou no candidato 1");
                    qtd1++;
                    break;
                case 2:
                    Console.WriteLine("Você votou no candidato 2");
                    qtd2++;
                    break;
                case 3:
                    Console.WriteLine("Você votou no candidato 3");
                    qtd3++;
                    break;
                case 4:
                    Console.WriteLine("Você votou no candidato 4");
                    qtd4++;
                    break;
                case 5:
                    Console.WriteLine("Você votou nulo");
                    qtd5++;
                    break;

                case 6:
                    Console.WriteLine("Voto em branco");
                    qtd6++;
                    break;

            }


        } while (num != 0);


        // Apresentação dos resultados

        Console.WriteLine("O candidato 1 recebeu {0} votos", qtd1);
        Console.WriteLine("O candidato 2 recebeu {0} votos", qtd2);
        Console.WriteLine("O candidato 3 recebeu {0} votos", qtd3);
        Console.WriteLine("O candidato 4 recebeu {0} votos", qtd4);
        Console.WriteLine("Votos nulos foram de {0} votos", qtd5);
        Console.WriteLine("Votos em brancos foi de {0} votos", qtd6);
    }
}
using System;
class ex07
{
    static void Main(string[] args)
    {
        int[,] m = new int[5,5];

        preencherM(m);

        exibirM(m);

        Console.WriteLine("A soma da linha 4 é: "+somaLinha4(m));
        Console.WriteLine("A soma da coluna 2 é: " + somaColuna2(m));
        Console.WriteLine("Soma da diagonal principal: " + somaDiagonalPrincipal(m));
        Console.WriteLine("Soma da diagonal secundária: "+ somaDiagonalSecundaria(m));
        Console.WriteLine("Soma da diagonal secundária: " + somaMatriz(m));
    }

    static void preencherM(int[,] m)
    {
        Random r = new Random();
        for (int i = 0; i < m.GetLength(0); i++)
        {
            for (int j = 0; j < m.GetLength(1); j++)
            {
                m[i, j] = r.Next(1, 10);
            }           
        } 
    }

    static void exibirM(int[,] m)
    {
        for(int i = 0; i < m.GetLength(0); i++)
        {
            for(int j = 0; j < m.GetLength(0); j++)
            {
                Console.Write(m[i, j]);
            }
            Console.WriteLine();
        }
    }

    static int somaLinha4(int[,] m)
    {
        int soma = 0;      
        for (int j = 0; j < m.GetLength(0); j++)
        {
            soma += m[3, j];
        }       
        return soma;
    }

    static int somaColuna2(int[,] m)
    {
        int soma = 0;
        for (int i = 0; i < m.GetLength(0); i++)
        {
            soma += m[i, 1];
        }
        return soma;
    }

    static int somaDiagonalPrincipal(int[,] m)
    {
        int soma = 0;
        for (int i = 0; i < m.GetLength(0); i++)
        {
            soma += m[i, i];
        }
        return soma;
    }

    static int somaDiagonalSecundaria(int[,] m)
    {
        int soma = 0;
        int n = m.GetLength(0);
        for (int i = 0;i < m.GetLength(0); i++)
        {
            n--;
            soma += m[i,n];
        }
        return soma;
    }

    static int somaMatriz(int[,] m)
    {
        int soma = 0;
        for(int i = 0; i < m.GetLength(0); i++)
        {
            for (int j = 0; j < m.GetLength(0); j++)
            {
                soma += m[i,j];
            }
        }
        return soma;
    }


}
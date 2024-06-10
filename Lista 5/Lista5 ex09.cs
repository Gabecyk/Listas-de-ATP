using System;

class ex09
{
    static void Main(string[] args)
    {
        //matrizes a,b
        int[,] a = new int[4, 6];
        int[,] b = new int[4, 6];
        preencherMtz(a, b); //Procedimento para preencher

        int[,]s = matrizS(a, b);//função que volta o valor para matriz s
        int[,]d = matrizD(a, b);//função que volta o valor para matriz d

        //Resultado e a exibição das matrizes por meio de procedimento que leva cada um
        Console.WriteLine("Matriz A:");
        exibirMatriz(a);
        Console.WriteLine();

        Console.WriteLine("Matriz B:");
        exibirMatriz(b);
        Console.WriteLine();

        Console.WriteLine("Matriz S:");
        exibirMatriz(s);
        Console.WriteLine();

        Console.WriteLine("Matriz D:");
        exibirMatriz(d);
        Console.WriteLine();
    }

    static void preencherMtz(int[,]a, int[,]b) //Preenchimento das matrizes a e b
    {
        Random r = new Random();
        
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for(int j = 0; j < a.GetLength(1); j++)
            {
                a[i, j] = r.Next(1, 10);
                b[i, j] = r.Next(1, 10);
            }
        }
    }

    static int[,] matrizS(int[,] a, int[,] b) //soma das matrizes que retorna a matriz à matriz s
    {
        int[,] s = new int[4, 6];
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0;j < a.GetLength(1); j++)
            {
                s[i,j] = a[i,j] + b[i,j];
            }
        }
        return s;
    }

    static int[,] matrizD(int[,]a, int[,] b) //subtração das matrizes com a volta da matriz à matriz d
    {
        int[,] d = new int[4, 6];
        for(int i = 0;i < a.GetLength(0); i++)
        {
            for(int j = 0 ;j < a.GetLength(1); j++)
            {
                d[i,j] = a[i,j] - b[i,j];
            }
        }
        return d;
    }

    static void exibirMatriz(int[,]a) //Exibe as matrizes
    {
        for(int i = 0; i < a.GetLength(0); i++)
        {
            for(int j = 0; j < a.GetLength(1); j++)
            {
                Console.Write(a[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}




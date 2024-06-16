using System;

class ex10
{
    static void Main(string[] args) //Inicio
    {
        int[,] m = new int[10, 10]; //Declaração da Matriz 
         preechereExibir(m); //preenche e exibe a matriz

        troca2e8(m);//troca a
        troca4e10(m);//troca b
        trocaDpeDs(m);//troca c
        troca5e10(m);//troca d
    }

    static void preechereExibir(int[,]m) //Exibi a matriz
    {
        Random r = new Random(); //Random
        for (int i = 0; i < m.GetLength(0); i++)
        {
            for (int j = 0; j < m.GetLength(1); j++)
            {
                m[i, j] = r.Next(1, 10);
                Console.Write(m[i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    static void troca2e8(int[,]m) //Troca A
    {
        Console.WriteLine("Matriz A:");
        int[,] a = new int[10, 10];
        for (int j = 0; j < m.GetLength(1); j++)
        {   //Troca de valores
            a[1, j] = m[1, j];
            a[7, j] = m[7, j];
            m[1, j] = a[7, j];
            m[7, j] = a[1, j];
        }
        int count = 0;
        foreach (int value in m)
        {
            Console.Write(value + "\t");
            count++;
            if (count == m.GetLength(0))
            {
                Console.WriteLine(); count = 0;
            }
        }
    }

    static void troca4e10(int[,] m) //Troca B
    {
        Console.WriteLine("Matriz B:");
        int[,] a = new int[10, 10];
        for (int j = 0; j < m.GetLength(1); j++)
        {   //Troca de valores
            a[j, 3] = m[j, 3];
            a[j, 9] = m[j, 9];
            m[j, 3] = a[j, 9];
            m[j, 9] = a[j, 3];
        }
        int count = 0;
        foreach (int value in m)
        {
            Console.Write(value + "\t");
            count++;
            if (count == m.GetLength(0))
            {
                Console.WriteLine(); count = 0;
            }
        }      
    }

    static void trocaDpeDs(int[,] m) //Troca C
    {
        Console.WriteLine("Matriz C:");
        int[,] a = new int[10, 10];
        int n = m.GetLength(0);
        for (int j = 0; j < m.GetLength(1); j++)
        {   //Troca de valores
            n--;
            a[j, j] = m[j, j];
            a[j, n] = m[j, n];
            m[j, j] = a[j, n];
            m[j, n] = a[j, j];
        }
        int count = 0;
        foreach (int value in m)
        {
            Console.Write(value + "\t");
            count++;
            if (count == m.GetLength(0))
            {
                Console.WriteLine(); count = 0;
            }
        }
    }

    static void troca5e10(int[,] m) //Troca D
    {
        Console.WriteLine("Matriz D:");
        int[,] a = new int[10, 10];
        for (int j = 0; j < m.GetLength(1); j++)
        {   //Troca de valores
            a[4, j] = m[4, j];
            a[j, 9] = m[j, 9];
            m[4, j] = a[j, 9];
            m[j, 9] = a[4, j];
        }
        int count = 0;
        foreach (int value in m)
        {
            Console.Write(value + "\t");
            count++;
            if (count == m.GetLength(0))
            {
                Console.WriteLine(); count = 0;
            }
        }
    }

}




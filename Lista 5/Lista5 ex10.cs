using System;

class ex10
{
    static void Main(string[] args)
    {
        int[,] m = new int[10, 10];
         preechereExibir(m);

        troca2e8(m);
        troca4e10(m);
        trocaDpeDs(m);
        troca5e10(m);
    }

    static void preechereExibir(int[,]m)
    {
        Random r = new Random();
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

    static void troca2e8(int[,]m)
    {
        Console.WriteLine("Matriz A:");
        int[,] a = new int[10, 10];
        for (int j = 0; j < m.GetLength(1); j++)
        {
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

    static void troca4e10(int[,] m)
    {
        Console.WriteLine("Matriz B:");
        int[,] a = new int[10, 10];
        for (int j = 0; j < m.GetLength(1); j++)
        {
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

    static void trocaDpeDs(int[,] m)
    {
        Console.WriteLine("Matriz C:");
        int[,] a = new int[10, 10];
        int n = m.GetLength(0);
        for (int j = 0; j < m.GetLength(1); j++)
        {
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

    static void troca5e10(int[,] m)
    {
        Console.WriteLine("Matriz D:");
        int[,] a = new int[10, 10];
        for (int j = 0; j < m.GetLength(1); j++)
        {
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




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

    static void preechereExibir(int[,] m)
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

    static void troca2e8(int[,] m)
    {
        Console.WriteLine("Matriz A:");
        int aux;
        for (int j = 0; j < m.GetLength(1); j++)
        {
            aux = m[1, j];
            m[1, j] = m[7, j];
            m[7, j] = aux;
        }
        
        for (int j = 0; j < m.GetLength(1); j++)
        {
            for (int k = 0; k < m.GetLength(1); k++)
            {
                Console.Write(m[j, k] + "\t");
            }
            Console.WriteLine();
        }
    }

    static void troca4e10(int[,] m)
    {
        Console.WriteLine("Matriz B:");
        int aux;
        for (int j = 0; j < m.GetLength(1); j++)
        {
            aux = m[j, 3];
            m[j, 3] = m[j, 9];
            m[j, 9] = aux;
        }
        
        for (int j = 0; j < m.GetLength(1); j++)
        {
            for (int k = 0; k < m.GetLength(1); k++)
            {
                Console.Write(m[j, k] + "\t");
            }
            Console.WriteLine();
        }
    }

    static void trocaDpeDs(int[,] m)
    {
        Console.WriteLine("Matriz C:");
        int aux;
        int n = m.GetLength(0);
        for (int j = 0; j < m.GetLength(1); j++)
        {
            n--;
            aux = m[j, j];
            m[j, j] = m[j, n];
            m[j, n] = aux;
        }
        
        for (int j = 0; j < m.GetLength(1); j++)
        {
            for (int k = 0; k < m.GetLength(1); k++)
            {
                Console.Write(m[j, k] + "\t");
            }
            Console.WriteLine();
        }
    }

    static void troca5e10(int[,] m)
    {
        Console.WriteLine("Matriz D:");
        int aux;
        for (int j = 0; j < m.GetLength(0); j++)
        {
            aux = m[4, j];
            m[4, j] = m[j, 9];
            m[j, 9] = aux;
        }
        for (int j = 0; j < m.GetLength(1); j++)
        {
            for  (int k = 0; k < m.GetLength(1); k++)
            {
                Console.Write(m[j,k]+ "\t");
            }
            Console.WriteLine();
        }
    }
}




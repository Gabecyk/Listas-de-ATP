using System;
class ex07
{
    static void Main(string[] args)
    {
        int[,] m = new int[5,5]; //Matriz 5x5 criada

        preencherM(m);//procedimento para preencher

        exibirM(m);//Procedimento para exibi-lá


        //resultados ja com os return de cada função
        Console.WriteLine("A soma da linha 4 é: "+somaLinha4(m));
        Console.WriteLine("A soma da coluna 2 é: " + somaColuna2(m));
        Console.WriteLine("Soma da diagonal principal: " + somaDiagonalPrincipal(m));
        Console.WriteLine("Soma da diagonal secundária: "+ somaDiagonalSecundaria(m));
        Console.WriteLine("Soma de toda a matriz: " + somaMatriz(m));
    }

    static void preencherM(int[,] m) //Preenche o vetor
    {
        Random r = new Random();//random para preencher aleatoriamente

        //for duplo para o preenchimento da matriz
        for (int i = 0; i < m.GetLength(0); i++)
        {
            for (int j = 0; j < m.GetLength(1); j++)
            {
                m[i, j] = r.Next(1, 10);
            }           
        } 
    }

    static void exibirM(int[,] m) //Exibi a matriz
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

    static int somaLinha4(int[,] m)//procedimento que soma a linha 4 da matriz
    {
        int soma = 0;      
        for (int j = 0; j < m.GetLength(0); j++)
        {
            soma += m[3, j];
        }       
        return soma; //retorna com o resultado
    }

    static int somaColuna2(int[,] m) //procedimento que soma a coluna 2 da matriz
    {
        int soma = 0;
        for (int i = 0; i < m.GetLength(0); i++)
        {
            soma += m[i, 1];
        }
        return soma; //retorna com o resultado
    }

    static int somaDiagonalPrincipal(int[,] m) //procedimento que soma a diagonal principal da matriz
    {
        int soma = 0;
        for (int i = 0; i < m.GetLength(0); i++)
        {
            soma += m[i, i];
        }
        return soma; //retorna com o resultado
    }

    static int somaDiagonalSecundaria(int[,] m) //procedimento que soma a diagonal secundaria da matriz
    {
        int soma = 0;
        int n = m.GetLength(0);
        for (int i = 0;i < m.GetLength(0); i++)
        {
            n--;
            soma += m[i,n];
        }
        return soma; //retorna com o resultado
    }

    static int somaMatriz(int[,] m) //Procedimento que soma a matriz inteira
    {
        int soma = 0;
        for(int i = 0; i < m.GetLength(0); i++)
        {
            for (int j = 0; j < m.GetLength(0); j++)
            {
                soma += m[i,j];
            }
        }
        return soma; //retorna com o resultado
    }


}
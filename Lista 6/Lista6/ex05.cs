using System;
using System.IO;
using System.Linq.Expressions;
using System.Text;

class ex05
{
    public void Run()
    {
        Console.Clear();
        Console.WriteLine("ex05");

        int n = Numeros();
        
        bool tipo = Tipo(n);
        if(n != 0)
        {
            recebeLinhas(n, tipo);

                        
        }
        else
            Console.WriteLine("Por ser zero nada será feito!");
        
        
    }

    static int Numeros()
    {
        int n = 0;
        Console.WriteLine("Quantas linhas deseja colocar no arquivo?");
        n = int.Parse(Console.ReadLine());
        return n;
    }
    
    static bool Tipo(int n)
    {
        bool tipo;
        if (n > 1)
            tipo = true;
            else 
            tipo = false;

        return tipo;
    }

    static void recebeLinhas(int n, bool tipo) 
    {
        StreamWriter sw = new StreamWriter("ex05.txt", tipo, Encoding.ASCII);
        for (int i = 1; i < (n+1); i++)
        {
            Console.WriteLine($"Escreva a linha {i}:");
            sw.Write  (Console.ReadLine());
        }
    }
}
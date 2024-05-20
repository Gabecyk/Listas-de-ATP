using System;

class Program
{

    public static void procedimentoDois() //Procedimento 2
    {
        Console.WriteLine("Quantas vezes serão realizados o procedimento?");
        int num = int.Parse(Console.ReadLine());

        for (int i = 1; i <= num; i++) //For para repetir a quantidade de vezes que pediu
        {
            Console.WriteLine("Procedimento " + i + ":");
            Oper();
        }

    }

    public static void procedimentoUm() //Procedimento 1
    {
        Oper();
    }

    public static int Oper() // Operação aonde ocorre as fuuncionalidade do código
    {
        int x;
        bool resu = default;
        Console.WriteLine("Escreva um número inteiro:");
        x = int.Parse(Console.ReadLine());

        // if caso seja positivo dará true, caso ser negativo dará false
        if (x > 0)
        {
            resu = true;
            Console.WriteLine(resu);
        }
        else if (x <= 0)
        {
            resu = false;
            Console.WriteLine(resu);
        }
        else
        {
            Console.WriteLine("Escreva apenas números inteiros ou que não seja zero.");
        }
        return x;
    }

    public static void menu() //Menu 
    {
        Console.WriteLine("Escolha uma opção:");
        Console.WriteLine("1 - Procedimento 1");
        Console.WriteLine("2 - Procedimento 2");
    }

    public static void Main(string[] args) //Main
    {
        int res;
        menu(); //Leva ao menu para escolher o procedimento
        res = int.Parse(Console.ReadLine());//lê o que o usuário escolheu

        // if para levar em cada procedimento
        if (res == 1)
        {
            procedimentoUm();
        }
        else if (res == 2)
        {
            procedimentoDois();
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Digite entre os números 1 ou 2!");
            Main(args);
        }
    }
}
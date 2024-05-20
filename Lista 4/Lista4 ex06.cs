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

    public static void Oper() // Operação aonde ocorre as fuuncionalidade do código
    {
        int x;
        Console.WriteLine("Escreva um número inteiro:");
        x = int.Parse(Console.ReadLine());

        bool resu = Verificar(x);

        // if para dar o resultado de true e false
        if (resu)
        {
            Console.WriteLine(resu);
        }
        else
        {
            Console.WriteLine(resu);
        }
    }

    public static bool Verificar(int x) // Caso seja false retornará false, o mesmo para true
    {
        return x > 0;
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
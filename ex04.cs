using System;

class Program
{
    public static void Main(string[] args)
    {
        int num = 0; // variavel usada para armazenar o numero digitado pelo usuario

        Console.WriteLine("Informe um número");
        num = int.Parse(Console.ReadLine());

        // for para a repetição do dado, até que i seja igual a um
        for (int i = num - 1; i > 0; i--)
        {
            num = num * i;

        }

        // if para verificar se o numero é maior que zero, se for maior que zero, ele imprime
        if (num < 0)
        {
            Console.WriteLine("Número invalido");
        }
        else
        {
            Console.WriteLine(" " + num);
        }
    }
}
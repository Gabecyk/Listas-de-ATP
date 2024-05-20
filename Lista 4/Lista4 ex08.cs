using System;

class Program
{
    static double CalcularS(int n) //Calcula a função
    {
        double sum = 0.0;

        for (int i = 1; i <= n; i++)
        {
            double term = (Math.Pow(i, 2) + 1) / (i + 3);
            sum += term;
        }
        
        return sum; //Retorna o valor da função
    }

    private static void Main(string[] args) //Início
    {
        Console.WriteLine("Digite um valor inteiro positivo:");
        int num = int.Parse(Console.ReadLine()); //Lê o número digitado

        if (num > 0) //if para não ser um número negativo
        {
            double resultado = CalcularS(num);
            Console.WriteLine($"O valor de S para N = {num} é: {resultado}");
            //Resultado
        }
        else
        {
            Console.WriteLine("Digite um número positivo!");
        }
    }
}
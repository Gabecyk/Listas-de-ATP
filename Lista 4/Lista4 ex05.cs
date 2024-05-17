using System;

class Program
{
    static void Main(string[] args) //Pede ao usuário os valores
    {
        Console.Write("Digite o primeiro número: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        int num2 = int.Parse(Console.ReadLine());

        int mdc = CalcularMDC(num1, num2); //Pega os valores do parametro CalcularMDC
        Console.WriteLine($"O MDC de {num1} e {num2} é {mdc}");//Resultado
    }

    static int CalcularMDC(int a, int b)//Calcula o MDC
    {
        while (b != 0) //Vai para quando o b ser igual a zero concluindo a operação
        {
            int temp = b;
            b = a % b;
            a = temp;
            Console.WriteLine(temp);
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
        return a; //Retorna o valor de a
    }
}
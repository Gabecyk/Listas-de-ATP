using System;

class Program
{
    static void Main(string[] args)
    {

        // Valores usados
        int num = 0;
        int nN = 0, nZ = 0, nP = 0;
        char res = '0';

        Console.WriteLine("Digite o valor inteiro:");

        // do while ate que digite "N"
        do
        {
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("Você quer acrescentar mais algum número? S ou N");
            res = char.Parse(Console.ReadLine());

            // if para verificar se o numero é positivo, negativo ou zero
            if (num > 0)
            {
                nP++;
            }
            else if (num < 0)
            {
                nN++;
            }
            else
            {
                nZ++;
            }

        } while (res != 'N');


        // Resultado
        Console.WriteLine("Quantidade de números positivos: " + nP);
        Console.WriteLine("Quantidade de números negativos: " + nN);
        Console.WriteLine("Quantidade de zeros: " + nZ);



    }
}
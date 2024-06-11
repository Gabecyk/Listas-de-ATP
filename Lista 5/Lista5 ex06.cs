using System;
class ex06
{
    static void Main(string[] args)
    {
        int[] temp = new int[31]; //variavel para os 31 dias
        tempDias(temp); //vai para o procedimento para receber as temperaturas
    }

    static void tempDias(int[] x)//Procedimento para armazenar as temperaturas
    {
        //variaveis usadas
        int maior = 0;
        int menor = 100;
        double media = 0;
        for (int i = 1; i <= x.Length; i++) //for para preencher o vetor com as temperaturas do mês todo
        {
            Console.WriteLine("Digite a temperatura do dia {0}:", i);
            x[i] = int.Parse(Console.ReadLine());
            if (x[i] >= 15 && x[1] <= 40)//if caso seja maior igual à 15 e menor igual à 40 irá armazenar o dado
            {
                if (maior < x[i])
                    maior = x[i];
                if (menor > x[i])
                    menor = x[i];
                media += x[i];
            }
            else //else caso seja menor que 15 ou maior que 40, não contará
            {
                Console.WriteLine($"{x[i]} essa temperatura não ocorreu\nFaça novamente!");
                i--;
            }
        }

        //Resultados imprimidos
        media = media / x.Length;
        Console.WriteLine($"A menor temperatura foi de: {menor}");
        Console.WriteLine($"A temperatura média foi de: {media}");
        Console.WriteLine($"A maior temperatura foi de: {maior}");
    }
}
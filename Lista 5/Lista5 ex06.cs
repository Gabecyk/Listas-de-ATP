class Program
{
    static void Main(string[] args)
    {
        int[] temp = new int[31];
        tempDias(temp);
    }

    static void tempDias(int[] x)
    {
        int maior = 0;
        int menor = 100;
        double media = 0;
        for (int i = 1; i <= x.Length; i++)
        {
            Console.WriteLine("Digite a temperatura do dia {0}:", i);
            x[i] = int.Parse(Console.ReadLine());
            if (x[i] >= 15 && x[1] <= 40)
            {
                if (maior < x[i])
                    maior = x[i];
                if (menor > x[i])
                    menor = x[i];
                media += x[i];
            }
            else
            {
                Console.WriteLine($"{x[i]} essa temperatura não ocorreu\nFaça novamente!");
                i--;
            }
        }

        media = media / x.Length;
        Console.WriteLine($"A menor temperatura foi de: {menor}");
        Console.WriteLine($"A temperatura média foi de: {media}");
        Console.WriteLine($"A maior temperatura foi de: {maior}");
    }
}
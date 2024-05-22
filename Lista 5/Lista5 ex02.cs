class Program
{
    static void Main(String[] args) // Menu
    {
        double[] notas = new double[10]; // Declaração do vetor e seu tamanho

        PreencherNotas(notas); // Leva para preencher as notas no vetor

        CalcularMedia(notas); // Calcula a média
    }

    static void PreencherNotas(double[] notas) // For para preencher o vetor
    {
        int cont = 1;
        for (int i = 0; i < notas.Length; i++)
        {
            Console.WriteLine("Digite a {0}° nota:", cont);
            notas[i] = double.Parse(Console.ReadLine());
            cont++;
        }
    }

    static void CalcularMedia(double[] notas)
    {
        double media = 0;
        int cont = 0;
        for (int i = 0; i < notas.Length; i++) // For para media ter os valores do vetor
        {
            media += notas[i];
            if (notas[i] >= 6)
                cont++;
        }

        //Resultado
        media = media / 10;
        Console.WriteLine("A média da turma foi: " + media);
        Console.WriteLine("Contagem de alunos acima da média: " + cont);
    }
}
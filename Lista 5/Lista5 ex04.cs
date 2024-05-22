class Program
{
    static void Main(string[] args)
    {

        // vetores usados
        int[] x = new int[10];
        int[] y = new int[10];
        int[] novo = new int[10];

        PreencherVetores(ref x, ref y); //Aonde será preenchidos o x e y

        NovoVetor(ref x, ref y , ref novo); // Procedimento de impar e par no novo vetor

        Resultado(novo); // Resultado do novo vetor 
    }

    static void PreencherVetores(ref int[] x, ref int[] y) // For que preenche os vetores x e y
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Digite o valor "+(i+1)+" de 10 do vetor x");
            x[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0;i < 10; i++)
        {
            Console.WriteLine("Digite o valor " + (i + 1) + " de 10 do vetor y");
            y[i] = int.Parse(Console.ReadLine());
        }
    }

    static void NovoVetor(ref int[] x, ref int[] y, ref int[] novo)
        // Procedimento que faz o novo vetor receber x como impar e y como par
    {
        bool r = true;
        for (int i = 0; i < 10 ; i++)
        {
            if (r) { novo[i] = x[i]; r = false; }
            else { novo[i] = y[i]; r = true; }            
        }
    }

    static void Resultado(int[] novo) // Resultado mostrando os valores do novo vetor
    {
        Console.WriteLine("Resultado:");

        for (int i = 0; i < 10; i++)
        {
            Console.Write(novo[i]);
        }
    }
}
class Program
{

    static double mediaA(int a, int b, int c) // Média aritmetica
    {
        int soma = a + b + c;
        return (double)soma / 3;


    }

    static double mediaP(int a, int b, int c) // Média ponderada
    {
        
        return (double)(a * 5 + b * 3 + c * 2) / 10;


    }

    private static void Main(string[] args)
    {

        Console.WriteLine("Quantos alunos deseja calcular as medias?: "); // Quantos alunos vão ter a nota calculada
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++) { // For para repetir em quanto não for realizado o calculo de todos o alunos pedido
          
            Console.WriteLine("Aluno: " + (i+1)); // Mostra o aluno em que está fazendo a média da nota ex: Aluno 1, 2....


            // Lê as notas dos alunos
            Console.WriteLine("Digite a nota:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota:");
            int c = int.Parse(Console.ReadLine());


            // Opções entre a média Aritmetica ou Ponderada
            Console.WriteLine("Digite as opção desejada: \n A - Média aritmetica \n P - Média ponderada");
            char op = char.Parse(Console.ReadLine());

            if (op == 'A' || op == 'a') // IF para determinar qual função foi escolhida para ser realizada
            {
                double media = mediaA(a, b, c);
                Console.WriteLine("A média aritmetica é: " + media);
            }
            else if (op == 'P' || op == 'p')
            {
                double media = mediaP(a, b, c);
                Console.WriteLine("A média ponderada é: " + media);
            } 

        }
    }
}
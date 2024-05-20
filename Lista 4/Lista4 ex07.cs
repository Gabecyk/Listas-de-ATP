class Program
{
    static void procedimentoDois() // Procedimento 2
    {
        Console.WriteLine("Quantas notas de alunos serão efetuadas?");
        int n = int.Parse(Console.ReadLine());

        int[] vet = new int[n]; //Usei vetores para armazenar cada nota

        for (int i = 0; i < vet.Length; i++)// Repete até que bata o valor de comprimento do vetor
        {
            Console.WriteLine("Nota");
            vet[i] = int.Parse(Console.ReadLine()); //Usando o "i" irá armazenar a cada repetição em lenght diferente do vetor
            If(vet[i]);
        }
    }

    static void procedimentoUm() //Procedimento 1
    {
        int num = 0;
        Console.WriteLine("Digite a nota média final do aluno:");
        num = int.Parse(Console.ReadLine());
        If(num);
    }

    static void If(int x) //Aqui é feito o tratamento do conceito da nota
    {
        if (x <= 39)
        {
            Console.WriteLine("Conceito F");
        }
        else if (x >= 40 && x <= 59)
        {
            Console.WriteLine("Conceito E");
        }
        else if (x >= 60 && x <= 69)
        {
            Console.WriteLine("Conceito D");
        }
        else if (x >= 70 && x <= 79)
        {
            Console.WriteLine("Conceito C");
        }
        else if (x >= 80 && x <= 89)
        {
            Console.WriteLine("Conceito B");
        }
        else if (x >= 90)
        {
            Console.WriteLine("Conceito A");
        }
    }


    static void menu() //Menu 
    {
        Console.WriteLine("Escolha uma opção:");
        Console.WriteLine("1 - Ler a média de um aluno:");
        Console.WriteLine("2 - Ler média de determinado alunos:");
    }

    private static void Main(string[] args) //Main
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
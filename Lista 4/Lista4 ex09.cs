class Program
{

    static void aluno (double a, int b) //Dados do aluno e sua média
    {
        Console.WriteLine("O aluno " + b + " teve a media de: " + a);
    }

    static void Results(double media) //Diz o resultado
    {

        if (media >= 6)
        {
            Console.WriteLine("Aprovado");
        }
        else
        {
            Console.WriteLine("Reprovado");
        }
    }

    static double Media(int a, int b) // Faz a média
    {
        double media = (double)a / b; 
        return media;
    }

    static void Notas(int[] alunos, int n) 
    {
        
        for (int i = 1; i <= alunos.Length; i++) // repetir até que bata o número de alunos
        {
            int s = 0;

            Console.WriteLine("Digite quantas notas o aluno " + i + " Colocará:");
            int not = int.Parse(Console.ReadLine());
            
            for (int j = 1; j <= not; j++) // Repete até que todas as notas sejam colocadas
            {
                Console.WriteLine("Digite a " + j + "º nota:");
                s += int.Parse(Console.ReadLine());    // soma todas as notas para a média            
            }

            double media = Media(s, not); //Faz a média

            Results(media); //Faz a avaliação de aprovado ou reprovado
            
            aluno(media, i); //Dá dados do aluno e sua média
        }
    }

    private static void Main(string[] args) //Começo
    {
        Console.WriteLine("Quantos alunos terão as notas inseridas?");
        int n = int.Parse(Console.ReadLine());

        int[] alunos = new int[n];// o vetor fica com o tamanho de alunos totais

        Notas(alunos, n);
    }   
}


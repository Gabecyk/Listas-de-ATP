using System;
class ex05
{
    static void Main(string[] args) //Principal
    {
        int[] vetor = new int[3];//vetor usado
        Sorteio(ref vetor);//Sorteio dos números para o vetor

        Tentativas(ref vetor);//Aonde será feito as tentativas do user

        Console.ReadKey();
    }

    static void Sorteio(ref int[] vetor)
    {
        Random r = new Random();
        for (int i = 0; i < vetor.Length; i++) // For até que Random preencha o vetor
        {
            vetor[i] = r.Next(9, 51);
        }
    }

    static void Tentativas(ref int[] a)
    {
        int tentativa = 0;
        int num = 0;
        int v = -1;
        int i = 0;
        while(i != v) // while até que o usuário acerte
        {
            Console.WriteLine("Digite o número:");
            num = int.Parse(Console.ReadLine());


            // If caso o usuário acerte o número e verificar
            if (num == a[0])
            {
                Console.WriteLine("Você acertou!");
                Console.WriteLine("Números de tentativas: " + (tentativa + 1));
                i = v;
            }
            if (num == a[1])
            {
                Console.WriteLine("Você acertou!");
                Console.WriteLine("Números de tentativas: " + (tentativa + 1));
                i = v;
            }
            if (num == a[2])
            {
                Console.WriteLine("Você acertou!");
                Console.WriteLine("Números de tentativas: " + (tentativa+ 1));
                i = v;
            }
            
            
            tentativa++;
            
        }
    }
}   
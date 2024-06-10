using System;
class ex03
{
    static void Main(String[] args) // Início
    {       
        int[] vetor = new int[10]; // Vetor inicial

        PreencherVetor(ref vetor);

        int[] vetorN = new int[10]; // vetor com valores negativos

        CopiarNegativo(ref vetor, ref vetorN);

        Resultado(vetorN);
    }

    static void PreencherVetor(ref int[] vetor) //Aonde vai ser preenchido cada valor do vetor
    {
        
        for (int i = 0; i < vetor.Length; i++)
        {
            i++;
            Console.WriteLine("Digite um valor inteiro de "+i+" de 10:");
            i--;
            vetor[i] = int.Parse(Console.ReadLine());
        }
    }
    
    static void CopiarNegativo(ref int[] vetor, ref int[] vetorN) // Aqui todos os valores negativos do vetor vão para vetorN
    {
        for (int i = 0;i < vetor.Length; i++)
        {
            if (vetor[i] < 0) vetorN[i] = vetor[i];
            else vetorN[i] = 1; // Caso a posição do vetor não seja negativo, essa posição vai ser ocupada pelo o num 1, para não ser vazio
        }
    }

    static void Resultado(int[] vetorN) //Mostra o resultado, mostrando o valor negativo e em qual posição do vetor se encontra
    {
        for (int i = 0; i < vetorN.Length; i++)
        {
            if (vetorN[i] < 0) Console.WriteLine("O valor negativo é: " + vetorN[i] + " e está na posição" + i + " do vetor.");
        }
    }

}
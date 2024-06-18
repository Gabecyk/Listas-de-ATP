using System;

class ex01
{
    public void Run()
    {
        Console.Clear(); //Limpar o terminal
        Console.WriteLine("Ex01");
        string? frase = "";

        recebeFrase(ref frase);//Onde o usuário escreve a frase

        int cont = 0;
        contaEspaco(ref cont, frase); //conta os espaços existentes da frase
        Console.WriteLine($"Na frase '{frase}' há {cont} espaços!"); //Resultado
    }

    static string recebeFrase(ref string? frase) //Função para receber a frase
    {
        Console.Write("Escreva a frase: ");
        frase = Console.ReadLine();
        return frase;
    }

    static int contaEspaco(ref int cont, string? frase) //Função que conta os espaços existentes
    {
        for (int i = 0; i < frase.Length; i++) //for para percorrer a frase toda
        {
            if (frase[i] == ' ')//caso tenha o espaço será 1+ no cont
                cont++;
        }
        return cont;//retorna o resultado
    }
}
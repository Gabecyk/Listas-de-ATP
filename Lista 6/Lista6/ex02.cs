using System;

class ex02
{
    public void Run()
    {
        Console.Clear();
        Console.WriteLine("Ex02");

        // Recebe a frase
        string frase = recebeFrase();
        
        // Função para retorna sem as vogais
        string receba = semVogais(frase);
        
        // Resultado
        Console.WriteLine("Aqui está a frase sem as vogais:");
        Console.WriteLine($"{receba}");
    }

    static string recebeFrase() //Função que recebe a frase e a volta
    {
        Console.Write("Escreva a frase: ");
        string frase = Console.ReadLine();
        return new string (frase); // volta a frase
    }

    static string semVogais(string frase) // Tira as vogais existentes da frase
    {
        // Char para delimitar as vogais(caracteres) que serão tiradas
        char[] del = new char[] { 'a', 'e', 'i', 'o', 'u' };

        //Muda para minusculo para não ocorrer erro e usa o split para tirar as vogais
        string[] final = frase.ToLower().Split(del);
        string receba = "";
        for (int i = 0; i < final.Length; i++)//for para guardar o resto da frase
        {
            receba += final[i];
        }

        return new string (receba); // Volta com o resultado da frase sem vogais
    }
}
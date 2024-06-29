using System;
using System.IO;
using System.Text;

class ex07 
{
    public void Run()
    {
        Console.Clear();
        Console.WriteLine("ex07");

        int n = 0; 
        qtdLetra(ref n); //Leva para a função que retorna o qtd de letra será colocadas no arquivo

        StreamWriter sw = new StreamWriter("ex07.txt", false, Encoding.ASCII); //abre arquivo para escrever
        Recebe(sw, n); //Parametro para receber as letras
        sw.Close(); // Fecha arquivo

        StreamReader sr = new StreamReader("ex07.txt"); //Abre arquivo para ler
        string letra = "";
        ler(sr, letra); //Parametro para ler e mostrar resultado
        sr.Close(); //Fecha arquivo

    }

    static int qtdLetra(ref int n)  //Quantas letras serão colocadas
    {
        Console.WriteLine("Quantas letras deseja inserir?");
        n = int.Parse(Console.ReadLine());
        return n; //retorna com a qtd
    }

    static void Recebe(StreamWriter sw, int n) //Recebe as letras para o arquivo
    {
        string confere = "";
        for (int i = 0; i < n; i++) //For até ser a qtd pedida do user
        {
            Console.WriteLine($"Digite a letra {i+1}:");
            confere = Console.ReadLine();
            if(confere.Length > 1 || confere.Length < 1) //if para que não escreva mais de uma letra ou nenhuma
            {
                i--;  
                Console.WriteLine("Escreva uma letra!");
            }
            else
            {
                sw.WriteLine(confere); //Ler a letra escrita
            }
        }
    }

    static void ler(StreamReader sr,string letra) //Exibi as letras no arquivo e mostra qtd de vogais
    {
        Console.WriteLine("O arquivo contém as seguintes letras:");
        int vogais = 0;
        letra = sr.ReadLine(); //recebe a primeira letra
        
        char[] v = new char[]{'a', 'e', 'i', 'o', 'u'}; //char com as vogais para ser usado no if

        while(letra != null) //Irá parar até ser null letra, que vai ser quando não ter mais linhas no sr
        {
            Console.WriteLine(letra); //Exibe
            if (v.Contains(letra.ToLower()[0])) //Verifica se contém as vogais no char, coloco tolower para melhor eficiência
            vogais++; //Caso tenha vogais, vogais recebe +1

            letra = sr.ReadLine(); //letra recebe outra linha para ser lida
        }
        Console.WriteLine($"No arquivo contém {vogais} vogais!"); //Resultado
    }
}
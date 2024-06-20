using System;
using System.IO;
using System.Text;

class ex05
{
    public void Run()
    {
        Console.Clear();
        Console.WriteLine("ex05");

        int n = Numeros(); //n recebe quantidade de linhas que serão preenchidas
               
        StreamWriter sw = new StreamWriter("ex05.txt", false, Encoding.ASCII);//Abre arquivo

        if(n > 0) //O programa continua caso n não for maior que 0
        {
            recebeLinhas(n, sw); //user escreve as linhas
            sw.Close(); //fecha arquivo

            StreamReader sr = new StreamReader("ex05.txt");//abre arquivo para ler
            
            int cont = ExibirArquivo(sr); //Aqui exibi as linhas e retorna junto a qtd de linhas
            sr.Close();//fecha arquivo

            Console.WriteLine($"Este arquivo possui {cont} linhas!"); //qtd de linhas                         
        }
        else
            Console.WriteLine("Por ser menor que 1 nada será feito! \nTente com algum número maior.");        
    }

    static int Numeros() //Salva quantas linha serão preenchidas
    {
        int n = 0;
        Console.WriteLine("Quantas linhas deseja colocar no arquivo?");
        n = int.Parse(Console.ReadLine());
        return n; //retorna com o valor da quatidade
    }

    static void recebeLinhas(int n, StreamWriter sw) //Preenche as linhas em base a qtd
    {
        for (int i = 1; i < (n+1); i++)
        {
            Console.WriteLine($"Escreva a linha {i}:");
            sw.WriteLine (Console.ReadLine());
        }
    }

    static int ExibirArquivo(StreamReader sr) //Exibi as linhas do arquivo
    {
        int n = 0;
        string exibir = sr.ReadLine(); //string recebe a primeira linha do arquivo

        Console.WriteLine("Aqui está oque foi escrito no arquivo:");

        //While até que seja null a string exibir
        while (exibir != null) //a string será null no momento em que acabar de ler a ultima linha e receber de novo o 'sr', que dessa vez por ter acabado, voltará como null
        {
            n++; // soma qtd de linhas lidas
            for(int i = 0; i < 1; i++)
            {
                Console.Write($"Linha {n}: {exibir}"); //exibe a linha do arquivo
            }
            Console.WriteLine();//Quebra a linha
            exibir = sr.ReadLine(); //Recebe a outra linha do arquivo
        }
        return n; //retorna a qtd de linhas lidas
    }
}
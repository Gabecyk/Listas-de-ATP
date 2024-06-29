using System;
using System.IO;
using System.Text;

class ex09 
{
    public void Run() 
    {
        Console.Clear();
        Console.WriteLine("ex09");

        bool  r = false;
        while (r != true) //While para escolher a opcão
        {
            Console.WriteLine("Oque deseja?");
            Console.WriteLine("1 - Inserir dados de aluno");
            Console.WriteLine("2 - Ler dados dos alunos");
            Console.WriteLine("3 - Sair");
            int opc = int.Parse(Console.ReadLine());
            switch (opc){ //switch para escolher
            case 1:
                inserirDados(); //inserir matricula e telefone
                break;
            case 2:
                lerDados(); //ler o arquivo
                break;
            case 3:
                Sair(); //sair
                r = true;
                break;
            default:
            Console.Clear();
                Console.WriteLine("Digite de 1 a 3");
                break;
            }
        }
    }

    static void inserirDados() //insere matricula e telefone no arquivo
    {
        int verif = 0;
        StreamWriter sw = new StreamWriter("D://ex09.txt", true, Encoding.ASCII); //abre arquivo
        do
        {
            Console.WriteLine("Digite a matricula e o telefone na mesma linha sendo separados por uma virgula:");
            Console.WriteLine("Exemplo: 15523,(31) 99293-8282"); //exemplo
            string linha =(Console.ReadLine());//linha escrita com os dados
            if (linha.Contains(",")){ //ve se tem ',' na linha para dividir
                sw.WriteLine(linha); //escreve no arquivo
                verif = 1; //verif recebe 1 para passar do while
            }
            else{ //se não tiver ',' ele repetirá
                Console.Clear();
                Console.WriteLine("Escreava as separando por uma virgura!");
            }
        } while(verif != 1);
        sw.Close();//Fecha arquivo
    }

    static void lerDados() //Ler o arquivo com dados
    {
        Console.Clear();
        StreamReader sr = new StreamReader("D://ex09.txt");//abre o arquivo para ler
        char[] separa = new char[] {','}; //separa a linha com ','
        string linha = "";

        while((linha = sr.ReadLine()) != null) //while para linha receber sr até que seja null
        {
                
            string[] dados = linha.Split(separa); //dados recebe as duas partes da linha, com o split
            Console.WriteLine($"Matricula: {dados[0]}, Telefone: {dados[1]}");//exibe
        }
        Console.WriteLine("Para continuar pressione enter.");
        Console.ReadKey();
        sr.Close();//Fecha arquivo
    }

    static void Sair() //encerra
    {
        Console.Clear();
        Console.WriteLine("Programa encerrado!");
    }
}
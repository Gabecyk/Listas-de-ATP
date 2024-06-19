using System;
using System.IO;
using System.Text;

class ex04
{
    public void Run()
    {
        Console.Clear();
        Console.WriteLine("ex04");
        //Cria o arquivo como false para não acrescentar na proxima vez
        StreamWriter sw = new StreamWriter("C:\\ex04.txt", false, Encoding.ASCII); 

        //Recebe a linha escrita pelo o user
        Console.WriteLine("Escreva uma frase");
        sw.Write (Console.ReadLine());
        //fecha o arquivo
        sw.Close(); 

        //Abre o arquivo para ler
        StreamReader sr = new StreamReader("C:\\ex04.txt");
        string line = sr.ReadLine(); //Line recebe a linha do arquivo
        int cont = 0;//contador

        while (line != null) //While para parar quando line ser null
        {
            for (int i = 0; i < line.Length; i++) //for para contar os caracteres
            {
                cont++;
            }
            Console.WriteLine("A linha escrito: "+line+ " tem "+cont+" caracteres"); //Resultado

            //Line recebe a linha do arquivo de novo, ja que não vai ter mais uma linha, ele receberá null
            line = sr.ReadLine(); 
        }
        sr.Close(); //Fecha o arquivo
    }
}
using System;
using System.IO;
using System.Text;

class ex10
{
    public void Run()
    {
        Console.Clear();
        Console.WriteLine("ex10");

        StreamWriter sw = new StreamWriter("D://ex10.txt", false, Encoding.ASCII);//abre arquivo

        Console.WriteLine("Quantas linhas serão preenchidas?");
        int n = int.Parse(Console.ReadLine()); //Quantas linhas serão preenchidas
        double numero = 0;

        for(int i = 0; i < n; i++) //for para preencher confrome o numero digitado
        {
            Console.WriteLine($"Digite o numero {i+1}:");
            numero = (double.Parse(Console.ReadLine())); //usa double para caso tenha caracter, dê um erro
            
            sw.WriteLine(numero); //guarda no arquivo
        }
        sw.Close();//fecha arquivo

        StreamReader sr = new StreamReader("D://ex10.txt");//abre arquivo para ler
        double max = double.MinValue;
        double min = double.MaxValue;
        double media = 0;
        double num = 0;
        while (!sr.EndOfStream)//while ate o fim do arquivo
        {
            num = double.Parse(sr.ReadLine());//pega do arquivo e converte para double
            Console.WriteLine(num);
            //if's para max e min
            if (num > max)
                max = num;
            if (num < min)
                min = num;
            media += num; //soma para a média
        }
        sr.Close();//fecha arquivo

        //Resultados
        Console.WriteLine($"O valor minimo é {min}");
        Console.WriteLine($"O valor maximo é {max}");
        Console.WriteLine($"A média é {media / n}"); //dividido por n, que era a qtd de linhas pedidas no início
    }
}
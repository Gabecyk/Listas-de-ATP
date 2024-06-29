using System;
using System.IO;
using System.Text;

class ex06 
{
    public void Run()
    {
        Console.Clear();
        Console.WriteLine("ex06");

        Console.WriteLine("Digite um número: "); 
        int n = int.Parse(Console.ReadLine()); //N recebe o número

        StreamWriter sw = new StreamWriter("ex06.txt", false, Encoding.ASCII);//Abre arquivo
        sw.WriteLine($"O número {n} é divisivel por:");

        Console.WriteLine("Aqui estão os divisores de {0}:",n); //Escreve no arquivo criado

        for(int i = 1; i <= n; i++) //for para decobrir os divisores de n
        {
            if (n % i == 0) //se resto de n com i for igual a 0, ele irá escrevar no console tanto para o arquivo
            {
                Console.WriteLine(i);
                sw.WriteLine(i);
            }
        }
        sw.Close();
    }   
}
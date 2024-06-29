using System;
using System.IO;
using System.Text;

class ex08 
{
    public void Run()
    {
        Console.Clear();
        Console.WriteLine("ex08");

        Console.WriteLine("Quatos veículos a locadora possui?");
        int n = int.Parse(Console.ReadLine());//Qtd de veículos

        
        double valor = 0;
        
        Console.WriteLine($"Quanto de aluguel é dos veículos?");
        valor = double.Parse(Console.ReadLine());//aluguel dos veículos
        

        StreamWriter sw = new StreamWriter("resultado.txt", false, Encoding.ASCII); //abre arquivo

        valor = (n * valor)/3;//faz o faturamento mensal

        Console.WriteLine($"Faturamento mensal é de: {valor}.");//faturamento mensal
        sw.WriteLine($"Faturamento mensal é de: {valor}.");//salva no arquivo
        
        Console.WriteLine($"Faturamento anual é de: {valor * 12}.");//faturamento anual
        sw.WriteLine($"Faturamento anual é de: {valor * 12}.");//salva no arquivo

        Console.WriteLine($"Valor de multa no mês: {(valor /n) * 0.2}");//valor da multa
        sw.WriteLine($"Valor de multa no mês: {(valor /n) * 0.2}");//salva no arquivo

        Console.WriteLine($"Manutenção anual é de: {(n*0.02)*600}");//valor da manutenção
        sw.WriteLine($"Manutenção anual é de: {(n*0.02)*600}");//salva no arquivo

        sw.Close();//fecha arquivo
    }
}
class Program
{

    static void procedimentoDois() //Procedimento 2
    {
        Console.WriteLine("Quantos triângulos serão lidos?");
        int num = int.Parse(Console.ReadLine());

        for (int i = 1; i <= num; i++) { //Repete a operação dependendo de quantas vezes o usuário pedir
            Console.WriteLine("Digite os valores do " + i + "º triângulo:");
            verificacao();
        }
    }


    static void procedimentoUm() //Procedimento 1
    {       
        verificacao();
    }

    static void verificacao() { //Verifica se um lado do triângulo não é maior que a soma de outros dois lados 

        Console.WriteLine("Digite o valor do lado X");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor do lado Y");
        int y = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor do lado Z");
        int z = int.Parse(Console.ReadLine());

        if (x > (y + z) || y > (x + z) || z > (x + y)){
            Console.WriteLine("Um comprimento não pode ser maior que a soma dos outros lados!");           
        }
        else
        {
            tipoTriangulo(x , y , z);
        }
        
    }

    static void tipoTriangulo(int x , int y, int z) { //Determina o tipo do triângulo
        
        if (x == y && x == z)
        {
            Console.WriteLine("Triângulo Equilátero");
        }
        else if (x == y || x == z || z == y)
        {
            Console.WriteLine("Triângulo Isóceles");
        }
        else
        {
            Console.WriteLine("Triângulo Escaleno");
        }
        
    }

    static void menu() //Aqui o usuário escolhe à qual procedimento fazer
    {

        Console.WriteLine("Qual procedimento deseja fazer?");
        Console.WriteLine("1 - Verificar qual trìângulo é:");
        Console.WriteLine("2 - Verificar qual trìângulo é, de inderteminadas vezes:");
    }

    private static void Main(string[] args) // Aqui é determinado pela a resposta do usuário no "menu", oque será feito
    {
        
        menu();
        int resp = int.Parse(Console.ReadLine());
        if (resp == 1)
        {
            procedimentoUm();
        }
        else if (resp == 2)
        {
           procedimentoDois();
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Escreva o número 1 ou 2");
            Main(args); // Volta para o início do "Main"
        }
    }

}
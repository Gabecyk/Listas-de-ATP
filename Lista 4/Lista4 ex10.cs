class Program
{
    static void Category(int a, ref char b, ref bool c)
    {
        //If para saber qual categoria está o nadador

        if(a >= 18)
        {
            b = 'A';
        }
        else if(a >= 16 && a <= 17)
        {
            b = 'B';
        }
        else if (a >= 14 && a <= 15) 
        {
            b = 'C';
        }
        else if (a >= 11 && a <= 13)
        {
            b = 'D';
        }
        else if (a >= 8 && a <= 10)
        {
            b = 'E';
        }
        else if (a >= 5 && a <= 7)
        {
            b = 'F';
        }
        else
        {
            //Caso não tenha idade o suficiente o char será falso para impedir que imprima os "dados finais"
            Console.WriteLine("Idade muito baixa!");
            c = false;
        }
    }
    static int Age()
    {
        Console.WriteLine("Digite a sua idade:");
        int age = int.Parse (Console.ReadLine());
        return age;
    }
    private static void Main(string[] args) //Começo
    {
        int idade = Age();//Leva para a seção de idade

        char categoria = default;

        bool verification = true;

        Category(idade, ref categoria, ref verification);//Leva para Category

        if (verification) // Dados finais
        {
            Console.WriteLine("Está na categoria: "+categoria);
            Console.WriteLine("O nadador tem " + idade + " anos e está na categoria: " + categoria);
        }
        else
        {
            Console.WriteLine("Tente novamente daqui alguns anos.");
        }
    }
}
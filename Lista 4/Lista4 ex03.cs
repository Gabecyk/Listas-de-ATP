class Program
{
    static void procedimentoDois() //Segundo procedimento
    {
        int res= 0;
        Console.WriteLine("Digite quantos valores de 3 números serão feitos:"); //Quantos conjuntos de 3 valores serão feitos
        res = int.Parse(Console.ReadLine());
        for (int i = 1; i <= res; i++) //for para parar apenas quando fazer todos os procedimentos determinados pelo o usuário
        {

            int p = 0;
            int s = 0;
            int t = 0;

            Console.WriteLine("Escreva o 1º número:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Escreva o 2º número:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Escreva o 3º número:");
            int c = int.Parse(Console.ReadLine());

            if (a > b && a > c) //if organizar crescetemente os números
            {
                p = a;
                if (b > c)
                {
                    s = b;
                    t = c;
                }
                else
                {
                    s = c;
                    t = b;
                }
            }
            else if (b > a && b > c)
            {
                p = b;
                if (a > c)
                {
                    s = a;
                    t = c;
                }
                else
                {
                    s = c;
                    t = a;
                }
            }
            else if (c > a && c > b)
            {
                p = c;
                if (a > b)
                {
                    s = a;
                    t = b;
                }
                else
                {
                    s = b;
                    t = a;
                }

            }

            Console.WriteLine("Ordem crescente dos números do "+i+ "º conjunto: {0}, {1}, {2}", t, s, p);

        }


    }

    static void procedimentoUm() //Primeiro procedimento
    {
        int a, b, c = 0;
        int p = 0;
        int s = 0;
        int t = 0;

        Console.WriteLine("Escreva o 1º número:");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Escreva o 2º número:");
        b = int.Parse(Console.ReadLine());
        Console.WriteLine("Escreva o 3º número:");
        c = int.Parse(Console.ReadLine());

        if (a > b && a > c) //if organizar crescetemente os números
        {
            p = a;
            if (b > c)
            {
                s = b;
                t = c;
            }
            else
            {
                s = c;
                t = b;
            }
        }
        else if (b > a && b > c)
        {
            p = b;
            if (a > c)
            {
                s = a;
                t = c;
            }
            else
            {
                s = c;
                t = a;
            }
        }
        else if (c > a && c > b)
        {
            p = c;
            if (a > b)
            {
                s = a;
                t = b;
            }
            else
            {
                s = b;
                t = a;
            }
        }
        Console.Clear();
        Console.WriteLine("Ordem crescente dos números: {0}, {1}, {2}", t, s, p); //Resultado com os números crescentes
    }

        static void menu() //Aqui o usuário escolhe à qual procedimento fazer
    {
        int resp;

        Console.WriteLine("Qual procedimento deseja fazer?");
        Console.WriteLine("1 - Ordem crescente:");
        Console.WriteLine("2 - Ordem crescente de inderteminados números:");
    }

    private static void Main(string[] args) // Aqui é determinado pela a resposta do usuário no "menu", oque será feito
    {
        int resp;
        menu();
        resp = int.Parse(Console.ReadLine());
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
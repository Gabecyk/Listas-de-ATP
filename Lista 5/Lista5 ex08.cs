using System;

class ex08
{

    static void Main(string[] args)
    {
        int[,] mtz = new int[4,4]; //Matriz 4x4
        Random r = new Random(); // Randon

        for (int i = 0; i < mtz.GetLength(0); i++) //for da linha
        {
            for (int j = 0; j < mtz.GetLength(1); j++) //for da coluna
            {
                mtz[i, j] = r.Next(1, 10); //distribuindo valores à matriz, valores entre 1 a 9, para melhor entendimento do resultado
            }
        }

    int count = 0;
    foreach (int value in mtz) //Foreach para mostrar a matriz
    {
        Console.Write(value);
        count++;
        if (count == mtz.GetLength(1))
        {
            Console.WriteLine();
            count = 0;
        }
    }
    Console.WriteLine();

    int soma = 0;

    for (int i = 0;i < mtz.GetLength(0);i++) //for para a soma da diagonal principal
    {
        soma += mtz[i,i];
        Console.Write(mtz[i, i]); //Mostra os valores da diagonal
    }

    Console.WriteLine();

    Console.WriteLine($"A soma da diagonal principal é: {soma}"); //Resultado
}
}


class Program
{
    private static void Main(string[] args)
    {

        // Variáveis com o valor de 101 para nãter o ricos de cair valores altos e elas serem salvas no if
        int Menor = 101;
        int P = 101;

        int[] N = new int[20];
        Random t = new Random();
        for (int i = 0; i < N.Length; i++) // For para repetir conforme o tamanho do comprimento do vetor N
        {
            N[i] = t.Next(101); //Distribui número aleatórios ao vetor N 
            Console.WriteLine(N[i]);

            if (N[i] < Menor) // IF caso seja menor, o número será salvado em uma variável junto de sua posição
            {
                Menor = N[i];
                P = i;
            }
        }       
        Console.WriteLine("O menor elemento é " + Menor + " na posição de número: "+P+" do vetor N"); //Resultado final
    }
}
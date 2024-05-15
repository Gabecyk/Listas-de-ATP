class Program
{


    static double calcularFilhos(ref int numFilhos, ref int i) // Procedimento média de filhos
    {
        return (double)numFilhos / i;
    }

    static double calcularSalario(ref int salario, ref int i) // Procedimento média do salário
    {
        
        return (double)salario / i;
    }

    static void coleta(ref int salario, ref int numFilhos, ref int i) // Procedimento que coleta os salários e quantidade de filhos
    {
        
        char sair = default;
        do
        {
            Console.WriteLine("Para parar digite 'N':");
            Console.WriteLine("Ou digite qualquer tecla para continuar:");
            sair = char.Parse(Console.ReadLine());
            if (sair != 'N')
            {
                Console.WriteLine("Informe o Salário:");
                salario += int.Parse(Console.ReadLine());
                

                Console.WriteLine("Quantos filhos possui:");
                numFilhos += int.Parse(Console.ReadLine());

                i++; // i para usar como divisivél nas médias

               
            } 
            else if (sair == 'N')
            {
                
            }

            Console.Clear();

        } while (sair != 'N');

        
    }

    private static void Main(string[] args) //Principal
    {
        char resInicial = default;
        int numFilhos = 0, salario = 0;
        int i = 0;

        do // Repetição para caso queira iniciar o procedimento ou não
        {

            Console.WriteLine("Deseja fazer o procedimento? \n " +
                "Digite: 'S'(sim) ou 'N'(não)");
            resInicial = char.Parse(Console.ReadLine());
            if (resInicial == 'S') // Caso queira fazer o procedimento, ele passará por aqui
            {
                coleta(ref salario, ref numFilhos, ref i); // Leva o usuário para a seção de coleta aonde será digitado e armazenado o salário e número de filhos
                double mediaSalario = calcularSalario(ref salario, ref i); //Faz a média do salário
                double mediaFilhos = calcularFilhos(ref numFilhos, ref i); //Faz a média dos filhos
                Console.Clear();

                //Diz o resultado final das médias
                Console.WriteLine("A média dos salários são: " + mediaSalario);
                Console.WriteLine("A média de filhos são: " + mediaFilhos);

            }
            else if (resInicial == 'N') // Caso não queira fazer o procedimento, o programa será encerrado
            {
                Console.Clear();
                Console.WriteLine("Procedimento cancelado!");
            }
            else // Caso digite errado irá pedir novamente
            {
                Console.Clear();
                Console.WriteLine("Digite corretamente!");

            }

        } while (resInicial != 'S' && resInicial != 'N');


    }
}
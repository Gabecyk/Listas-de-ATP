using System;
class ex03 {
    public void Run() {
        Console.Clear();
        Console.WriteLine("Ex03");
        Console.WriteLine("Digite a frase para ser códificada");
        string frase = Console.ReadLine();

        string codificado = Codificar(frase, 3);

        Exibir(codificado);
    }

    static string Codificar(string frase, int n) 
    {
        // Converte para maiusculo e para um array de caracteres
        char[] conv = frase.ToUpper().ToArray();
        for (int i = 0; i < conv.Length; i++) {

            char dep = conv[i];

            if(char.IsLetter(dep))//vê se realmente é uma letra, caso não seja, retorna false
            {
                // Converte a letra para seu valor ASCII, aplica o "n" e converte de volta
                dep = (char)(dep + n);

                if(dep > 'Z') // Caso passe de Z voltará para o início do alfabeto
                {
                    dep = (char)(dep - 26);
                }
            }
            conv[i] = dep; // Atualiza o array
        }
        return new string(conv); // Converte o array de volta para uma string e retorna
    }

    static void Exibir(string frase) // Resultado
    {
        Console.WriteLine("Aqui está a frase códificada:");
        Console.WriteLine(frase);
    }

}
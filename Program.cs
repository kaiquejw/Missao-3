using System;

class Program
{
    static void Main()
    {
        // Solicita a idade do usuário
        Console.Write("Digite sua idade: ");
        string input = Console.ReadLine();

        // Converte a entrada para inteiro
        int idade;
        if (int.TryParse(input, out idade))
        {
            // Verifica a faixa etária
            if (idade < 12)
            {
                Console.WriteLine("Criança");
            }
            else if (idade >= 12 && idade <= 17)
            {
                Console.WriteLine("Adolescente");
            }
            else
            {
                Console.WriteLine("Adulto");
            }
        }
        else
        {
            // Caso a entrada não seja um número válido
            Console.WriteLine("Idade inválida. Digite um número inteiro.");
        }
    }
}

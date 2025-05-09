namespace TesteTarget.Perguntas;

public class Fibonacci
{
    /*
     * 2) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores
     * anteriores (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem que desejar onde,
     * informado um número, ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número informado
     * pertence ou não a sequência.
     * IMPORTANTE: Esse número pode ser informado através de qualquer entrada de sua preferência ou pode ser previamente
     * definido no código;
     */

    public static void RetornoFibonacci()
    {
        Console.Write("Digite o número que deseja consultar na sequência Fibonacci: ");
        int numero;

        while (true)
        {
            string input = Console.ReadLine() ?? string.Empty;

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Entrada inválida. Digite um número inteiro:");
                continue;
            }

            if (int.TryParse(input, out numero))
            {
                break;
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro:");
            }
        }

        Console.WriteLine(VerificaFibonacci(numero)
            ? $"O número {numero} pertence à sequência de Fibonacci!"
            : $"O número {numero} NÃO pertence à sequência de Fibonacci.");
    }

    static bool VerificaFibonacci(int numero)
    {
        int a = 0;
        int b = 1;

        if (numero == 0 || numero == 1)
            return true;

        while (b <= numero)
        {
            int temp = a;
            a = b;
            b = temp + b;

            if (b == numero)
                return true;
        }

        return false;
    }
}
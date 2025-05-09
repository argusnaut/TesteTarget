namespace TesteTarget.Perguntas;

public class OperacaoString
{
    /*
     * 5) Escreva um programa que inverta os caracteres de um string.
     *
     * IMPORTANTE:
     * a) Essa string pode ser informada através de qualquer entrada de sua preferência ou pode ser previamente definida no código;
     * b) Evite usar funções prontas, como, por exemplo, reverse;
     */

    public static void RetornoString()
    {
        Console.Write("Digite uma string para inverter: ");
        string original = Console.ReadLine() ?? string.Empty;

        string invertida = InverterString(original);

        Console.WriteLine($"String original: {original}");
        Console.WriteLine($"String invertida: {invertida}");
    }

    static string InverterString(string original)
    {
        char[] caracteres = original.ToCharArray();
        int inicio = 0;
        int fim = original.Length - 1;

        while (inicio < fim)
        {
            (caracteres[inicio], caracteres[fim]) = (caracteres[fim], caracteres[inicio]);

            inicio++;
            fim--;
        }

        return new string(caracteres);
    }
}
namespace TesteTarget.Perguntas;

public class ValorSoma
{
    /*
     * 1)	Observe o trecho de código abaixo: int INDICE = 13, SOMA = 0, K = 0;
     * Enquanto K < INDICE faça { K = K + 1; SOMA = SOMA + K; }
     * Imprimir(SOMA);
     * Ao final do processamento, qual será o valor da variável SOMA?
     */

    public static void RetornoSoma()
    {
        const int indice = 13;
        int soma = 0, k = 0;

        while (k < indice)
        {
            k += 1;
            soma += k;
        }

        Console.WriteLine($"O valor da variável SOMA é: {soma}");
    }
}
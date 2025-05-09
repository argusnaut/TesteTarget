namespace TesteTarget.Perguntas;

public class FaturamentoPorEstado
{
    /*
     * 4) Dado o valor de faturamento mensal de uma distribuidora, detalhado por estado:
     * •	SP – R$67.836,43
     * •	RJ – R$36.678,66
     * •	MG – R$29.229,88
     * •	ES – R$27.165,48
     * •	Outros – R$19.849,53
     *
     * Escreva um programa na linguagem que desejar onde calcule o percentual de representação que cada estado teve
     * dentro do valor total mensal da distribuidora.
     */

    public static void RetornoFaturamento()
    {
        // Injeção de dados
        var faturamentoPorEstado = new Dictionary<string, decimal>
        {
            { "SP", 67836.43M },
            { "RJ", 36678.66M },
            { "MG", 29229.88M },
            { "ES", 27165.48M },
            { "Outros", 19849.53M }
        };

        decimal total = faturamentoPorEstado.Sum(x => x.Value);

        Console.WriteLine("Percentual de representação por estado:");
        Console.WriteLine("--------------------------------------");

        foreach (var estado in faturamentoPorEstado)
        {
            decimal percentual = (estado.Value / total) * 100;
            Console.WriteLine($"{estado.Key}: {percentual:N2}%");
        }
    }
}
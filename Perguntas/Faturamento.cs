using System.Text.Json;
using System.Text.Json.Serialization;

namespace TesteTarget.Perguntas;

public class Faturamento
{
    /*
     * 3) Dado um vetor que guarda o valor de faturamento diário de uma distribuidora, faça um programa, na linguagem que desejar, que calcule e retorne:
     * • O menor valor de faturamento ocorrido em um dia do mês;
     * • O maior valor de faturamento ocorrido em um dia do mês;
     * • Número de dias no mês em que o valor de faturamento diário foi superior à média mensal.
     * IMPORTANTE:
     * a) Usar o json ou xml disponível como fonte dos dados do faturamento mensal;
     * b) Podem existir dias sem faturamento, como nos finais de semana e feriados. Estes dias devem ser ignorados no cálculo da média;
     */

    public static void RetornoFaturamento()
    {
        try
        {
            string testFile = Path.Combine(AppContext.BaseDirectory, "dados.json");

            if (!File.Exists(testFile))
            {
                Console.WriteLine("Erro: Arquivo 'dados.json' não encontrado!");
                return;
            }

            string json = File.ReadAllText(testFile);

            List<FaturamentoDiario> faturamentos = JsonSerializer.Deserialize<List<FaturamentoDiario>>(json) ?? [];

            if (faturamentos.Count == 0)
            {
                Console.WriteLine("Nenhum faturamento encontrado!");
            }

            List<FaturamentoDiario> diasComFaturamento = faturamentos.Where(f => f.Valor > 0).ToList();

            double menorFaturamento = diasComFaturamento.Min(f => f.Valor);
            double maiorFaturamento = diasComFaturamento.Max(f => f.Valor);
            double mediaMensal = diasComFaturamento.Average(f => f.Valor);
            int diasAcimaDaMedia = diasComFaturamento.Count(f => f.Valor > mediaMensal);

            Console.WriteLine($"Menor faturamento diário: {menorFaturamento:C2}");
            Console.WriteLine($"Maior faturamento diário: {maiorFaturamento:C2}");
            Console.WriteLine($"Média mensal de faturamento: {mediaMensal:C2}");
            Console.WriteLine($"Dias com faturamento acima da média: {diasAcimaDaMedia}");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public class FaturamentoDiario
    {
        [JsonPropertyName("dia")] public int Dia { get; set; }
        [JsonPropertyName("valor")] public double Valor { get; set; }
    }
}
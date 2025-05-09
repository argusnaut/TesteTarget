using TesteTarget.Perguntas;

namespace TesteTarget;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("====================================");
            Console.WriteLine("    MENU DE TESTES - Target   ");
            Console.WriteLine("====================================");
            Console.WriteLine("Escolha qual teste gostaria de realizar:");
            Console.WriteLine("1 - Cálculo de Soma (Teste 1)");
            Console.WriteLine("2 - Verificação de Fibonacci (Teste 2)");
            Console.WriteLine("3 - Análise de Faturamento (Teste 3)");
            Console.WriteLine("4 - Percentual por Estado (Teste 4)");
            Console.WriteLine("5 - Inversão de String (Teste 5)");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("====================================");
            Console.Write("Digite sua opção: ");

            string opcao = Console.ReadLine() ?? string.Empty;

            switch (opcao)
            {
                case "1":
                    Console.Clear();
                    ValorSoma.RetornoSoma();
                    break;
                case "2":
                    Console.Clear();
                    Fibonacci.RetornoFibonacci();
                    break;
                case "3":
                    Console.Clear();
                    Faturamento.RetornoFaturamento();
                    break;
                case "4":
                    Console.Clear();
                    FaturamentoPorEstado.RetornoFaturamento();
                    break;
                case "5":
                    Console.Clear();
                    OperacaoString.RetornoString();
                    break;
                case "0":
                    Console.WriteLine("Encerrando o programa...");
                    return;
                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
            }

            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}
namespace Ex01
{
    internal class Program
    {
        enum Operacao{
            Soma,
            Subtacao,
            Divisao,
            Multiplicacao
        }

        static string LerOperacao()
        {
            return Console.ReadLine();
        }

        static float Soma(float valor1, float valor2)
        {
            return (float)(valor1 + valor2);
        }

        static float Subtracao(float valor1, float valor2)
        {
            return (float)(valor1 - valor2);
        }

        static float Multiplicacao(float valor1, float valor2)
        {
            return (float)(valor1 * valor2);
        }

        static float Divisao(float valor1, float valor2)
        {
            return (float)(valor1 / valor2);
        }

        static float Calculadora(Operacao operacao, float valor1, float valor2)
        {
            switch (operacao)
            {
                case Operacao.Soma:
                    return Soma(valor1, valor2);

                case Operacao.Subtacao:
                    return Subtracao(valor1, valor2);

                case Operacao.Multiplicacao:
                    return Multiplicacao(valor1, valor2);

                case Operacao.Divisao:
                    return Divisao(valor1, valor2);;

                default:
                    return 0;
            }
        }

        static Operacao ObterOperacao()
        {
            string operacao = Console.ReadLine();

            switch (operacao)
            {
                case "+":
                    return Operacao.Soma;
                case "-":
                    return Operacao.Subtacao;
                case "*":
                    return Operacao.Multiplicacao;
                case "/":
                    return Operacao.Divisao;
                default:
                    throw new Exception("Operação inválida");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo a calculadora!");

            Console.WriteLine("Escreva o primeiro número: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Escreva o segundo número: ");
            float valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine(@"+ - SOMA
'-' - SUBTRACAO
* - MULTIPLICACAO
/ - DIVISAO");

            Operacao operacao = ObterOperacao();

            float resultado = Calculadora(operacao, valor1, valor2);

            Console.WriteLine($"\nResultado:{resultado}");
        }
    }
}

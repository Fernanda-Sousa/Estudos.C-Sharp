using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando projeto 10 - Calculando Poupança");

        double investimento = 1000;

        // rendimento de 0.5% (0.005) ao mês

        investimento = investimento + investimento * 0.005;
        Console.WriteLine(investimento);

        int mes = 1;
        while (mes <= 12)
        {
            investimento = investimento + investimento * 0.005;
            Console.WriteLine("No mês " + mes + " você tem: R$" + investimento);

            mes += 1;
        }

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }

}
using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando projeto 11 - Calculando Poupança 2");

        /*
        int mes = 1;
        while (mes <= 12)
        {
            investimento = investimento + investimento * 0.005;
            Console.WriteLine("No mês " + mes + " você tem: R$" + investimento);

            mes += 1;
        }
        */

        double investimento = 1000;

        for (int mes = 1; mes <= 12; mes++)
        {
            investimento *= 1.005;
            Console.WriteLine("No mês " + mes + " você tem: R$" + investimento);
        }


        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}
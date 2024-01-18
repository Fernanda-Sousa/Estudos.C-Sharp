using csharp_exception.Titular;
using csharp_exception.Contas;
using csharp_exception;
using System.Numerics;

LeitorDeArquivo leitor = new LeitorDeArquivo("contas.txt");
try
{    
    leitor.LerProximaLinha();
    leitor.LerProximaLinha();
}
catch(IOException)
{
    Console.WriteLine("Leitura de arquivo interrompida");
}
finally
{
    leitor.Fechar();
}

////Syntax Sugar:
//using (LeitorDeArquivo leitor = new LeitorDeArquivo("contas.txt"))
//{
//    leitor.LerProximaLinha();
//    leitor.LerProximaLinha();
//    leitor.LerProximaLinha();
//}

/*
try
{
    ContaCorrente conta1 = new ContaCorrente(0, "1234-X");
    conta1.Sacar(50);
    Console.WriteLine(conta1.GetSaldo());
    conta1.Sacar(150);
    Console.WriteLine(conta1.GetSaldo());
}
catch(ArgumentException ex)
{
    Console.WriteLine("Parâmetro com erro: " + ex.ParamName);//pra usar o nome do parametro tenho q passar ele no throw (ContaCorrente)
    Console.WriteLine("Não é possível criar uma conta com o número de agência menor ou igual a zero!");
    Console.WriteLine(ex.StackTrace);
    Console.WriteLine(ex.Message);
}
catch(SaldoInsuficienteException ex)
{
    Console.WriteLine("Operação negada! Saldo Insuficiente!");
    Console.WriteLine(ex.Message);
}
*/

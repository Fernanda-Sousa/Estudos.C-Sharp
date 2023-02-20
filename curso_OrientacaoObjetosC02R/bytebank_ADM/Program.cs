using bytebank_ADM.Funcionarios;
using bytebank_ADM.Utilitario;

Funcionario pedro = new Funcionario("123456789",2000);
pedro.Nome = "Pedro malazartes";

Console.WriteLine(pedro.Nome);
Console.WriteLine(pedro.GetBonificacao());

Diretor roberta = new Diretor("987654321", 5000);
roberta.Nome = "Roberta Silva";

Console.WriteLine(roberta.Nome);
Console.WriteLine(roberta.GetBonificacao());

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
gerenciador.Registrar(pedro);
gerenciador.Registrar(roberta);

Console.WriteLine("Total de bonificações: " + gerenciador.TotalDeBonficacao);
Console.WriteLine("Total de funcionários: " + Funcionario.TotalDeFuncionarios);

pedro.AumentarSalario();
roberta.AumentarSalario();

Console.WriteLine("Novo salário do Pedro: R$" + pedro.Salario);
Console.WriteLine("Novo salário da Roberta: R$" + roberta.Salario);
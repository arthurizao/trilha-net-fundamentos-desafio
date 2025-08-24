using DesafioFundamentos.Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.WriteLine("Bem-vindo ao sistema de estacionamento.\nInforme o valor do preço inicial:");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora, informe o valor por hora:");
precoPorHora = Convert.ToDecimal(Console.ReadLine());

Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Escolha a sua opção:");
    Console.WriteLine("1 - Registrar novo veículo");
    Console.WriteLine("2 - Retirar veículo");
    Console.WriteLine("3 - Visualizar veículos estacionados");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            es.AdicionarVeiculo();
            break;

        case "2":
            es.RemoverVeiculo();
            break;

        case "3":
            es.ListarVeiculos();
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("A opção selecionada não é válida.");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar...");
    Console.ReadLine();
}

Console.WriteLine("O programa foi encerrado.");

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Por favor, digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();
            veiculos.Add(placa);
            Console.WriteLine($"O veículo com a placa {placa} foi adicionado.");
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Informe a placa do veículo para a retirada:");
            string placa = Console.ReadLine();

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite o tempo de permanência em horas:");
                int horas = Convert.ToInt32(Console.ReadLine());
                decimal valorTotal = precoInicial + (precoPorHora * horas);

                veiculos.Remove(placa.ToUpper());

                Console.WriteLine($"O veículo com a placa {placa} foi removido. O custo total foi de: R$ {valorTotal:F2}");
            }
            else
            {
                Console.WriteLine("Desculpe, este veículo não foi encontrado. Verifique se a placa foi digitada corretamente.");
            }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos atualmente estacionados são:");
                foreach (string veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Nenhum veículo estacionado no momento.");
            }
        }
    }
}

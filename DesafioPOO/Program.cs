using System;

namespace DesafioPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instanciação das classes
            Passageiro passageiro = new Passageiro("João", 999999999, "email@email.com", "Rio de Janeiro");
            Motorista motorista = new Motorista("Anônimo");
            Viagens viagens = new Viagens();
            Dinheiro dinheiro = new Dinheiro();
            Credito credito = new Credito();
            Debito debito = new Debito();


            // Apresentação do sistema
            Console.WriteLine($"Bem vindo ao sistema! Já possui conta? (SIM ou NÃO)");
            string resposta = Console.ReadLine();


            // Validação de dados inseridos pelo usuário
            while (String.IsNullOrEmpty(resposta))
            {
                Console.WriteLine("Por favor inserir uma resposta.");
                resposta = Console.ReadLine();
            }

            while (resposta.ToUpper() != "SIM" && resposta.ToUpper() != "NÃO")
            {
                Console.WriteLine("Por favor inserir uma resposta válida.");
                resposta = Console.ReadLine();
            }


            // Condições para contas existentes no sistema
            if (resposta.ToUpper() == "SIM")
            {
                Console.WriteLine("Passageiro ou motorista?");
                string conta = Console.ReadLine();

                if (conta.ToUpper() == "PASSAGEIRO")
                {
                    Console.WriteLine();
                    Console.WriteLine($"Bom dia, {passageiro.Nome}!");
                }

                else if (conta.ToUpper() == "MOTORISTA")
                {
                    Console.WriteLine();
                    Console.WriteLine($"Bom dia, {motorista.Nome}!");
                    Console.WriteLine($"Total de corridas: 91");
                    Console.WriteLine($"Avaliação: 4.98 estrelas");
                    Environment.Exit(0);
                }

            }


            // Condição para utilização de método de cadastro de contas
            if (resposta.ToUpper() == "NÃO")
            {
                Console.WriteLine("Certo, vamos prosseguir!");
                Console.WriteLine("Qual a finalidade da conta? (MOTORISTA ou PASSAGEIRO)");
                string tipoConta = Console.ReadLine();

                if (tipoConta.ToUpper() == "MOTORISTA")
                {
                    motorista.Cadastrar();
                    Environment.Exit(0);
                }

                if (tipoConta.ToUpper() == "PASSAGEIRO")
                {
                    passageiro.Cadastrar();
                }
            }
            Console.WriteLine();

            // Utilização e retorno dos métodos
            credito.SalvarCartao();
            Console.WriteLine();
            Console.WriteLine(">Solicitar viagem<");
            passageiro.SolicitarViagem();
            Console.WriteLine();
            passageiro.AlterarTrajeto();
            Console.WriteLine();

            Console.WriteLine(">Resumo da corrida<");
            Console.WriteLine($"Viagem feita por: {motorista.Nome}");
            Console.WriteLine($"Partida: {passageiro.EnderecoOrigem}");
            Console.WriteLine($"Destino: {passageiro.EnderecoDestino}");
            Console.WriteLine($"Data e horário da viagem: {viagens.Duracao}");
            passageiro.PagamentoEscolhido = Passageiro.FormaPagamento.Credito;
            Console.WriteLine($"Forma de pagamento: {passageiro.PagamentoEscolhido}");
            Console.WriteLine($"Valor pago: R${credito.Valor}");
            passageiro.Avaliar();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPOO
{
    public class Passageiro : Conta
    {
        public string EnderecoOrigem { get; set; }
        public string EnderecoDestino { get; set; }

        public void SolicitarViagem()
        {
            Console.WriteLine("Endereço de origem:");
            EnderecoOrigem = Console.ReadLine();

            Console.WriteLine("Endereço do destino:");
            EnderecoDestino = Console.ReadLine();

            Console.WriteLine("Forma de pagamento:");
            Console.WriteLine(FormaPagamento.Credito);

        }

        public void AlterarTrajeto()
        {
            Console.WriteLine("Deseja alterar o trajeto? SIM ou NÃO");
            string alteracao = Console.ReadLine();

            if (alteracao.ToUpper() == "SIM")
            {
                Console.WriteLine("Informe o novo destino ou parada:");
                EnderecoDestino = Console.ReadLine();
            }
        }

        public void CancelarCorrida()
        {
            Console.WriteLine("Deseja cancelar a corrida? SIM ou NÃO");
            string cancelamento = Console.ReadLine();

            if (cancelamento == "SIM".ToUpper())
            {
                Console.WriteLine("Corrida cancelada.");
                Environment.Exit(0);
            }

        }

        public enum FormaPagamento
        {
            Dinheiro,
            Credito,
            Debito
        }

        public FormaPagamento PagamentoEscolhido { get; set; }

        public Passageiro(string nome, int telefone, string email, string cidade)
        {
            Nome = nome;
            Telefone = telefone;
            Email = email;
            Cidade = cidade;
        }

    }
}

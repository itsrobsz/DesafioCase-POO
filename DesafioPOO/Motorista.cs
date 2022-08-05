using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPOO
{
    public class Motorista : Conta
    {
        private string CNH { get; set; }
        private string CRLV { get; set; }
        public string Carro { get; set; }


        public void AceitarCorrida()
        {
            Console.WriteLine($"Corrida recebida!");
            Console.WriteLine("Deseja aceitar? SIM ou NÃO");

            string aceite = Console.ReadLine();
            if (aceite.ToUpper() == "SIM")
            {
                Console.WriteLine("Corrida aceita.");
            }

        }

        public void IniciarCorrida()
        {
            Console.WriteLine("Passageiro confirmado? (SIM ou NÃO)");
            string confirmacao = Console.ReadLine();

            if (!string.IsNullOrEmpty(confirmacao))
            {
                Console.WriteLine("Passageiro confirmado? (SIM ou NÃO)");
                confirmacao = Console.ReadLine();
            }

            else if (confirmacao.ToUpper() == "SIM")
            {
                Console.WriteLine("Corrida iniciada.");

            }
        }

        public void EncerrarCorrida()
        {
            Console.WriteLine("Encerrar corrida? (SIM ou NÃO)");
            string encerramento = Console.ReadLine();
            
            if (encerramento.ToUpper() == "SIM")
            {
                Console.WriteLine("Corrida encerrada.");
            }
            
        }
        
        public Motorista(string nome)
        {
            Nome = nome;
        }
    }
}

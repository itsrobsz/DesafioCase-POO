using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPOO
{
    public abstract class Cartao : Pagamento
    {
        public string Bandeira { get; set; }
        private string Numero { get; set; }
        protected string Titular { get; set; }
        protected string CVV { get; set; }

        public void SalvarCartao()
        {
            Bandeira = "Mastercard";
            Numero = "456985215458";
            Titular = "João da Silva";
            CVV = "495";
            Console.WriteLine($"Cartão cadastrado: {Bandeira} (Crédito)\nFinal 5458");
        }
    }
}

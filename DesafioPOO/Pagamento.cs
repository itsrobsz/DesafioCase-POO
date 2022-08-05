using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPOO
{
    public abstract class Pagamento
    {
        public DateTime Data { get; set; }
        public float Valor { get; set; } = 25;

        public void Abortar()
        {
            {
                Console.WriteLine("Pagamento não pôde ser realizado.");
                Console.WriteLine("Verifique a forma desejada e caso o problema persista, entre em contato com nossa central.");
            }
        }
    }
}

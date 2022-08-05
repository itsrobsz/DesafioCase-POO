using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPOO
{
    public class Debito : Cartao
    {
        public float Saldo { get; set; } = 250;

        public void Pagar(float _valor)
        {
            Saldo = Saldo - _valor;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPOO
{
    public class Credito : Cartao
    {
        public float Limite { get; set; } = 600;

        public void Pagar(float _valor)
        {
            Limite = Limite - _valor;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPOO
{
    public class Dinheiro
    {
        public float Bonus { get; set; }

        public void Pagar(float _valor)
        {
            Bonus = Bonus - _valor;
        }
    }
}

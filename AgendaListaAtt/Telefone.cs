using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaListaAtt
{
    internal class Telefone
    {
        public string Tipo { get; set; }
        public string Ddd { get; set; }
        public string Numero { get; set; }
        public Telefone Proximo { get; set; }

        public Telefone(string tipo, string ddd, string numero)
        {
            Tipo = tipo;
            Ddd = ddd;
            Numero = numero;
            Proximo = null;
        }
        public override string ToString()
        {
            return "" + Tipo + ":(" + Ddd + ")" + Numero;
        }
    }
}

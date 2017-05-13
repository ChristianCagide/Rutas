using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyControlInv
{
    class Base
    {
        public string nombre { get; set; }
        public int minutos { get; set; }
        public Base quienSigue { get; set; }
        public Base anterior { get; set; }

        public Base(string nombreB, int minutosB)
        {
            nombre = nombreB;
            minutos = minutosB;
        }

        public override string ToString()
        {
            return nombre + Environment.NewLine + minutos.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Lab03
{
    public class Cuenta
    {
        public decimal Saldo { set; get; }
        public virtual string Vender(decimal monto)
        {
            Saldo -= monto;
            return "";
        }

        public override string ToString()
        {
            return "";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Lab03
{
    class Credito : Cuenta
    {

        public override string Vender(decimal monto)
        {
            base.Vender(monto);
            return "Compra realizada por un monto de " + monto;
        }

        public override string ToString()
        {
            return base.ToString() + "Tarjeta de Crédito \nSaldo: " + Saldo;
        }
    }
}

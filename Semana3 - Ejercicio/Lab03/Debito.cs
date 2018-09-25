using System;
using System.Collections.Generic;
using System.Text;

namespace Lab03
{
    class Debito : Cuenta
    {

        public override string Vender(decimal monto)
        {
            if(Saldo >= monto)
            {
                base.Vender(monto);
                return "Compra realizada con exito por un monto de " + monto;
            }
            else
            {
                return "Fondos insuficientes";
            }
            
        }

        public override string ToString()
        {
            return base.ToString() + "Tarjeta de Debito \nSaldo: " + Saldo;
        }
    }


}

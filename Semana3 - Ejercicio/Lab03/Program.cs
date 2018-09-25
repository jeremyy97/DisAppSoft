using System;

namespace Lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            Credito credito = new Credito();
            credito.Saldo = 0;
            Debito debito = new Debito();
            debito.Saldo = 1200000;

            Boolean continuar = true;
            while (continuar)
            {
                Console.WriteLine("Ingrese el numero que antescede a la opcion que desea \n\n1.Comprar \n2.Ver Saldos");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Seleccion el tipo de tarjeta \n\n1.Debito \n2.Credito");
                        int tarjeta = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el monto de la compra:");
                        decimal monto = Convert.ToDecimal(Console.ReadLine());
                        if (tarjeta == 1)
                        {
                            Console.WriteLine(debito.Vender(monto));
                        }else if (tarjeta == 2)
                        {
                            Console.WriteLine(credito.Vender(monto));
                        }
                        else
                            Console.WriteLine("La opcion ingresada no coincide con ningunda de las opciones disponibles");
                        break;
                    case 2:
                        Console.WriteLine("\n***************CUENTAS***************");
                        Console.WriteLine(credito.ToString());
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine(debito.ToString());
                        break;
                    case 3:
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("La opcion ingresada no coincide con ningunda de las opciones disponibles");
                        break;
                }
            }
        }
    }
}

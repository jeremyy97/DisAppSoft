using System;
using System.Collections.Generic;
using System.Text;

namespace Taller_1
{
    class Usuario
    {
        public string Nombre { get; set; }
        public int Tipo { get; set; }


        public Usuario(string nombre, int tipo)
        {
            Nombre = nombre;
            Tipo = tipo;
        }


        public override string ToString()
        {
            if (Tipo == 1)
            {
                return "Por: " + Nombre;
            }
            else
            {
                return "    Por: " + Nombre;
            }
        }
    }
}

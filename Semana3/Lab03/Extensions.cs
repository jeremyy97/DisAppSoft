using System;
using System.Collections.Generic;
using System.Text;

namespace Lab03
{
    public static class Extensions
    {
        public static string GetFormatted(this Person person)
        {
            return person.Name + "1";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Lab03
{
    public class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }


        public virtual string getSummary() //virtual = se puede sobreescribir
        {
            return string.Format("{0} {1}", Name, LastName);
        }
        /*public string GetName()
        {
            return Name;
        }

        public static string GetStaticName(string name)
        {
            return name;
        }*/
    }
}

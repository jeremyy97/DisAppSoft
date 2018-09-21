using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Logic
{
    public class Persona : ILogger
    {
        public Persona()
        {
            
        }

        public Persona(int id, string name, string lastName)
        {
            Name = name;
            Id = id;
            LastName = lastName;
        }

        public string Name { get; set; }
        public int Id { get; set; }
        public string LastName { get; set; }

        public void Log(string log)
        {
            System.Console.WriteLine("Something went wrong");
        }
    }
}

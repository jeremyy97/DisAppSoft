using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab1.Logic;

namespace Lab01.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(">>>>>>>>>>>Person<<<<<<<<<<<<<");

            ILogger logger = new Persona();  //INTERFAZ 

            //EJEMPLO1
            /*Persona person = new Persona();
            person.Id = 1;
            person.Name = "Eddie";
            person.LastName = "Carranza";*/
            
            //EJEMPLO2
            //Persona person = new Persona(1, "Eddie", "Carranza");

            //EJEMPLO3
            Persona person = new Persona { Id = 1, Name = "Eddie", LastName = "Carranza" };

            string personString = string.Format("Id:{0}, Name: {1}, LastName: {2}",person.Id, person.Name, person.LastName);
            System.Console.WriteLine(personString);
            logger.Log("Hello");
            System.Console.ReadKey();
        }
    }
}

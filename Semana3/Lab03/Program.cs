using System;

namespace Lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Person person = new Person() {Name="Pedro" ,LastName="Rodriguez"};
            Student student = new Student() { Name = "Pablo", LastName = "Alvarado" , Average = 9.0};
            Profesor professor = new Profesor() {Name ="Eddie", LastName ="Carranza", Courses = new string[] {"DAS C3", "Redes" } };

            //Console.WriteLine(PrintReport(person));
            //Console.WriteLine(PrintReport(student));

            printReport(person);
            printReport(student);
            printReport(professor);
            Console.ReadKey();
        }
        public static void printReport(Person person)
        {
            Console.WriteLine("****************");
            Console.WriteLine(person.getSummary());
            Console.WriteLine("****************");
        }

        //public static string PrintReport(Person p)
        //{
        //    return p.Name + " " + p.LastName;
        //}

        //public static string PrintReport(Student s)
        //{
        //   return s.Name + " " + s.LastName + " Average: " + s.Average;
        //}
    }
}

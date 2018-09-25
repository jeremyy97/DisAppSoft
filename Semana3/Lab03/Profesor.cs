using System;
using System.Collections.Generic;
using System.Text;

namespace Lab03
{
    public class Profesor : Person
    {
        public string[] Courses { get; set; }

        public override string getSummary()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.getSummary());
            sb.Append("Courses: ");
            for (int i = 0; i < Courses.Length; i++)
            {
                sb.Append(Courses[i] + " ");
            }
            return sb.ToString();
        }
    }
}

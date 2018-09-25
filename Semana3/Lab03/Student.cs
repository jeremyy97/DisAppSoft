using System;
using System.Collections.Generic;
using System.Text;

namespace Lab03
{
    class Student : Person
    {
         public double Average { set; get; }

        public override string getSummary()
        {
            return base.getSummary() + " Average: " + Average;
        }
    }
}

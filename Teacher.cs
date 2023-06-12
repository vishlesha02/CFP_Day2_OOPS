using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    class Teacher : Person
    {
        private String subject;
        public void Explain()
        {
            Console.WriteLine("Explaination begins");
        }
    }
}

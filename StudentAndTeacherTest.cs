using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    class StudentAndTeacherTest : Person

    {
        public static void Main(String[] args)
        {
            Person p = new Person();
            p.Greet();


            Student s = new Student();
            s.SetAge(30);
            s.Greet();
            s.ShowAge();


            Teacher t = new Teacher();
            t.SetAge(30);
            t.Greet();
            t.Explain();
        }
    }
}

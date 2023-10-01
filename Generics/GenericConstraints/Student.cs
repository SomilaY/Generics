using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.GenericConstraints
{
    public class Student
    {
        public int StudentID { get; set; }
        public string Firstname { get; set; }

        public Student(int studentId, string firstname)
        {
            StudentID = studentId;
            Firstname = firstname;
        }


    }
}

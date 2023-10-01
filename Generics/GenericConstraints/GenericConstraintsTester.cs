using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.GenericConstraints
{
    public class GenericConstraintsTester
    {
        static void Main(string[] args)
        {
            MyLinkedList<Student> students = new MyLinkedList<Student>();
            students.AddToFirst(new Student(1, "Somila"));
            students.AddToFirst(new Student(2, "Jabu"));
            students.AddToFirst(new Student(3, "James"));

            foreach (Student st in students)
            {
                Console.WriteLine(st.Firstname);
                Console.ReadLine();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.GenericLinkedList
{
    internal class LinkedListTester
    {
        static void Main(string[] args)
        {
            MyLinkedList<string> names = new MyLinkedList<string>();
            names.AddToFirst("James");
            names.AddToFirst("Blake");
            names.AddToFirst("Travis");
            names.AddToFirst("Scott");

            foreach(string name in names) 
            {
             Console.WriteLine(name);
            }
            
            Console.Read();
        }
    }
}

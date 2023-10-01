using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Create a method that will check if two integers are
             * equal. The method should take the two integers as arguments
             * then return true or false*/
            Console.WriteLine(isIntEqual(2, 5));
            Console.WriteLine(isDoubleEqual(2.5,2.5));
            Console.WriteLine(isStringEqual("hi", "Hi"));
            Console.WriteLine(AreEqual<int>(8,8));

            Console.WriteLine(GetLength<string, int>("Hi", 5));
            Console.Read();
        }

       public static bool isIntEqual(int a, int b) 
        {
         return (a== b);
        }

        /*Create a method that will check if two doubles are
             * equal. The method should take the two double as arguments
             * then return true or false*/

        public static bool isDoubleEqual(double a, double b)
        {
            return (a == b);
        }

        /*Create a method that will check if two strings are
             * equal. The method should take the two strings as arguments
             * then return true or false*/

        public static bool isStringEqual(String a, String b)
        {
            return a.Equals(b);
        }

        static bool AreEqual<T>(T x, T y)
        {
          if (x.GetType() == typeof(string)) 
            {
               return string.Compare(x.ToString(), y.ToString(),true) == 0;
            }
          return x.Equals(y);
        }

        static bool GetLength<T1,T2>(T1 str, T2 length)
        {
            if(true)
            {
                return str.ToString().Length.Equals(length);
            }
        }


    }
}

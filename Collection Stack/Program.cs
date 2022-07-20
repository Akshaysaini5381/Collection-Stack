using System;
using System.Collections.Generic;
namespace Collection_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> s = new Stack<string>();
            s.Push("akshay");
            s.Push("d");
            s.Push("z");
            s.Push("akshay");
           s.Push(null);
            Console.WriteLine("  "+s.Count);
            

            

               foreach (var item in s)
            {
                Console.Write(" "+item);
            }


            Console.WriteLine();
            

        }
    }
}

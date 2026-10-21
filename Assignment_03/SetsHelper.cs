using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_03
{
    public static class SetsHelper<T>
    {
        public static void PrintSet(HashSet<T> set)
        {
            foreach (T s in set)
            {
                Console.Write(s + "   ");
            }
            Console.WriteLine();
            Console.WriteLine("======================================");
        }
    }
}

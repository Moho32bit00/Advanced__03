using System;
using System.Collections.Generic;
using System.Security;
using System.Text;

namespace Assignment_03
{
    #region Exercise 1: Student Grade Manager
    public static class GradesHelper <T>
    {
        public static void PrintList(List<T> list)
        {
            foreach (T item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("======================================");
        }
        public static void RemoveBelow75(List<int> list)
        {
            for (int i = list.Count - 1; i >=0; i--)
            {
                if (list[i] < 75)
                {
                    list.RemoveAt(i);
                }
            }
        }

        public static List<string> StringGrade (List<int> list)
        {
            List <string> Slist = new List<string>();
            int lc = list.Count - 1;
            int i = 0;
            while (lc >= 0)
            {
                Slist.Add($"Grade : {list[i]}");
                lc--; 
                i++;
            }
            return Slist;
        }
    }
    #endregion 
}

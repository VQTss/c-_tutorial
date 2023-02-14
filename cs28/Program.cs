using System.Collections.Generic;
using System;

namespace cs28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HashSet trong C#");
            HashSet<int> set1 = new HashSet<int>() { 1, 2, 3, 5, 6, 7 };
            HashSet<int> set2 = new HashSet<int>() { 8, 9, 10, 5, 6, 4 };
            set1.Add(50);
            set1.Remove(2);
            foreach (var item in set1)
            {
                Console.WriteLine(item);
            }
            set1.UnionWith(set2); // s1 chứa các phần chứa s2
            Console.WriteLine("------------------------------");
            foreach (var item in set1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------------");
            set1.IntersectWith(set2); // s1 chứa các phần chứa s2
            foreach (var a in set1)
            {
                Console.WriteLine(a);
            }
        }
    }
}

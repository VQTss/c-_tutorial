using System.Collections.Generic;
using System;

namespace cs27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Queue");
            Queue<string> cachoso = new Queue<string>();
            cachoso.Enqueue("Ho so 1");
            cachoso.Enqueue("Ho so 2");
            cachoso.Enqueue("Ho so 3");
            // Lặp qua tất cả các hồ sơ
            foreach (var item in cachoso)
            {
                Console.WriteLine(item);
            }
            // Xóa và đồng thời lấy ra phần tử đã xóa - phần tử đầu tiên - bản chất của queue là vậy
            var first = cachoso.Dequeue();
            Console.WriteLine($"Xu ly ho so: {first}");
            Console.WriteLine("Stack");
            Stack<string> hanghoa = new Stack<string>();
            hanghoa.Push("mat hang 1");
            hanghoa.Push("mat hang 2");
            hanghoa.Push("mat hang 3");
            var mathang =  hanghoa.Pop();
            Console.WriteLine(mathang);
        }
    }
}

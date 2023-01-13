using System;

namespace cs05
{
    class Program
    {
        static void Sqr(ref int x){
            x *= x;
        }

        static void GetValues(out int a , out int b){
            a = 10;
            b = 15;
        }
        static void swap(ref int a , ref int b ){
            int temp = a;
            a = b;
            b = temp;
        }


        static void Main(string[] args)
        {
            int a  = 3;
            Sqr(ref a);
            Console.WriteLine(a);
            int c , b;
            GetValues(out c , out b);
            Console.WriteLine("Before Swap:"+c + " "  + b);
            swap(ref c,ref b);
            Console.WriteLine("Then Swap:"+c + " "  + b);
        }
    }
}

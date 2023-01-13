using System;

namespace cs04
{
    class Program
    {
        static void Main(string[] args)
        {
            // trường hợp này sẽ xảy ra lỗi vì 
            /*
            var keyword are called implicitly typed variables
            implicitly typed varibles là kiểu ngầm định
            must be  initialized with a value. If not initialized will be cause an error
            */
            // var n1;
            // n1 = true; => error
            // fix
            var n1 = true;
            Console.WriteLine(n1);
            /*
            Constants = hằng số
            */
            const double PI = 3.14; 
            // PI = 8; //error
            double a =  Convert.ToDouble(Console.ReadLine());

             for (int i = 80,count = 0; count < 5; count++,i+=80)
             {
                Console.WriteLine(i);
             }

            
        }
    }
}

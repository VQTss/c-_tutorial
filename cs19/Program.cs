using System;
using MyExceptions;

namespace cs19
{
    class Program
    {

        static void Register(string name, int age){
            if (string.IsNullOrEmpty(name))
            {
                throw new NameEmptyException();
            }

            if (age < 18 || age > 20)
            {
                
            }
            Console.WriteLine($"Hello {name} - ({age})");
        }
        static void Main(string[] args)
        {


            try
            {
                Register("",20);
            }
            catch (NameEmptyException nne)
            {
                Console.WriteLine(nne.Message);
            }





            // try
            // {
            //     int[] arr = new int[] { 4, 5, 8 };
            //     Console.Write(arr[8]);
            // }
            // catch (Exception e)
            // {
            //     Console.WriteLine(e.Message);
            //     Console.WriteLine(e.StackTrace);
            //     Console.WriteLine(e.GetType().Name);
            //     Console.WriteLine("An error occurred");
            // }
        }
    }
}

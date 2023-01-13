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

            if (age < 18 || age > 100)
            {
                throw new AgeException(age);
            }
            Console.WriteLine($"Hello {name} - ({age})");
        }
        static void Main(string[] args)
        {


            // try
            // {
            //     Register("Vo Quoc Thai ",15);
            // }
            // catch (NameEmptyException nne)
            // {
            //     Console.WriteLine(nne.Message);
            // }
            // catch(AgeException a ){
            //     Console.WriteLine(a.Message);
            //     a.AgeExceptionDetail();
            // }




            try
            {
                int[] arr = new int[] { 4, 5, 8 };
                Console.Write(arr[8]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(e.GetType().Name);
                Console.WriteLine("An error occurred");
            }finally {
                Console.WriteLine("End");
            }
        }
    }
}

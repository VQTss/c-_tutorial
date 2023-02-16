using System;

namespace nullAndnullable
{
    class Program
    {

        // null and nullable
        /*
        
        
        */
        class ABC
        {
            public  void Hello(){
                Console.WriteLine("Xin chao c#");
            }
        }

        static void Main(string[] args)
        {
            /*
                Có 2 trường hợp xảy ra null
                Không khởi tạo đối tượng thì xảy ra null
                và gán nó bằng null
            */
            ABC a = null; // như thế này sẽ bị lỗi 
            if (a != null){
                a.Hello();
            } // ==  a?.Hello();
           
        }
    }
}

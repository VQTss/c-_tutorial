using System;
/*
Namespace là cách tổ chức nhóm code (các lớp, giao diện, cấu trúc ...) thành những nhóm, 
tạo ra phạm vi hoạt động của các thành phần trong nhóm
*/
namespace mymynamespace
{
    public class Class1
    {
        public static void Hello()
        {
            Console.WriteLine("Hello, this is my namespace");
        }
    }
     // Đây là namespace lồng namespace
    namespace sub_myNameSpace
    {
        public class Class1
        {
            public static void Hello()
            {
                Console.WriteLine("Hello, this is my sub namespace");
            }
        }
    }
}
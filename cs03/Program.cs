using System;




/*
    Cấu trúc vòng lặp 
*/
namespace cs03
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            for(khởi tạo;điều kiện;cập nhật){
                // câu lệnh thực thi
            }
            */
            for (int i = 8; i <= 10; i++)
            {
                Console.WriteLine("Số i = " + i);
            }

            
            /*
            while(câu lệnh điều kiện){
                câu lệnh thực thi
            }
            */

            Console.WriteLine("-----------");

            int l = 8;
            while (l <= 10)
            {
                Console.WriteLine("Số i = " + l);
                l++;
            }
            Console.WriteLine("--------------");
            /*
            do
            {
                //Khối lệnh
            }
            while (điều_kiện);
            */

            int j = 10;
            do
            {
                Console.WriteLine("Số j = " + j);
                j += 2;
            }
            while (j <= 20);

        }
    }
}

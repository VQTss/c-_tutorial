using System.IO;
using System;

namespace cs21
{
    class Program
    {

        static void ListFileDirectory(string path)
        {
            String[] directories = System.IO.Directory.GetDirectories(path);
            String[] files = System.IO.Directory.GetFiles(path);
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }
            foreach (var directory in directories)
            {
                Console.WriteLine(directory);
                ListFileDirectory(directory); // Đệ quy
            }
        }

        static void Main(string[] args)
        {
            string path = "obj";
            // Liệt kê cái thư mục con có trong thư mục

            var directories = Directory.GetDirectories(path);

            foreach (var directori in directories)
            {
                Console.WriteLine(directori);
            }
            Console.WriteLine("-------------------------");
            // Liệt kê cái file có trong thư mục
            var files = Directory.GetFiles(path);
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }



            // Directory.CreateDirectory(path); // Dùng để tạo thư mục
            // Directory.Delete(path); // dùng để xóa thư mục

            // if (Directory.Exists(path)) // Kiểm tra thư mục có tồn tại hay không
            // {
            //     Console.WriteLine($"{path} - ton tai");
            // }else
            // {
            //     Console.WriteLine($"{path} -  khong ton tai");

            // }


        }
    }
}

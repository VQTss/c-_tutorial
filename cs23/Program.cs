
using System.Text;
using System.IO;
using System;

namespace cs23
{
    class Program
    {
        static void Main(string[] args)
        {

            
            string path = "data.dat";
            var stream = new FileStream(path: path , FileMode.OpenOrCreate);

            // Lưu dữ liệu
            byte[] buffer = {1,2,3};
            int offset = 0;
            int count = 3;
            stream.Write(buffer,offset , count);

            // Đọc dữ liệu
            int soByteDocDuoc  =  stream.Read(buffer,offset,count);
            // int , double --> bytes
            int a = 1;
            var bytes = BitConverter.GetBytes(a);
            // bytes ->> int, doule
            BitConverter.ToInt32(bytes , 0);

    //
            string s = "abc";
            var byes = Encoding.UTF8.GetBytes(s);


        //    string path = "demo.txt";
        //    string content = "Hello test succees";
        //    string content1 = "\nHappy new year 2023";
        //    File.WriteAllText(path,content);
        //    File.AppendAllText(path,content1);
        //    Console.WriteLine("Change name file: "+path);
        //    File.Move(path,"test.txt"); // đổi tên file
        //    File.Copy("test.txt","123.txt"); // copy thành 1 file khác
        }
    }
}

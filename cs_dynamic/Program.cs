using System;

namespace cs_dynamic
{
    class Program
    {
        // Dynamic - kiểu dữ liệu động
        /*
        Kiểu dữ liệu của dynamic được xác định ở thời điểm được chạy chương trình
        - Nếu có lỗi thì chỉ xảy ở thời điểm thực thi
         Về cách thứ thì khá giống với kiểu ngầm định 'var'
         Tuy nhiên thì chúng có điểm khác nhau : 
            - Khi khai báo kiểu ngầm định 'var' thì phải ráng ngay giá trị cho nó. Căn cứ nào giá trị được
            -  gán thì nó xác định kiểu giá trị
        */

        static void PrintInfor(dynamic obj){
            /*
            Trường hợp này như chúng ta thấy rằng khi biên dịch thì obj vẫn bth 
            vì lúc này obj chưa xác định được kiểu dữ liệu ( biên dịch bằng câu lệnh = dotnet build)
            tuy nhiên khi chúng ta thực thi (dotnet run)  thì xảy ra lỗi
            */
            obj.Name = "Vo Quoc Thai";
            obj.Hello();
        }

        class Student
        {
            public string Name {set; get;}

            public void Hello(){
                Console.WriteLine("Hello,"+ Name);
            }
        }

        static void Main(string[] args)
        {
            dynamic tenbien1;
            var tenbien2 = 123;
            int a = 1;
            Student s = new Student();
            PrintInfor(s);
        }
    }
}

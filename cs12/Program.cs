using System;

namespace cs12
{
    class Program
    {
        // static void Main(string[] args)
        // {
        //     dog d = new dog();
        //     Console.WriteLine(d.Legs);
        //     d.Bark();
        // }
        class Person
        {
            protected int Age { get; set; }
            protected string Name { get; set; }
        }
        class Student : Person
        {
            public Student(string nm)
            {
                Name = nm;
            }
            public void Speak()
            {
                Console.Write("Name: " + Name);

            }
        }
        static void Main(string[] args)
        {
            // Student s = new Student("David");
            /*
            Câu hỏi của chúng ta là tại sao nó lại là error
            Vậy thì ta phải xem xét ở class person vì class có khai báo là protected
            Chỉ có thể lấy giá trị bằng cách kế thừa
            Và chỉ được sử dụng class đó. Đồng thời không được sử dụng thông qua lớp khác
            */
            // s.Name = "Bob"; // Error 

            person p = new person("Thai Vo", 18, 2000);
            Console.WriteLine(p.Name);
            Console.WriteLine(p.Age);
            Console.WriteLine(p.ToString());
        }
    }
}

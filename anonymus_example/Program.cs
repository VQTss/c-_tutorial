using System;
using System.Collections.Generic;
using System.Linq;

namespace anonymus_example
{
    class Program
    {

        // Anonymus - kiểu dữ liệu vô danh
        // Object - thuộc tính - chỉ đọc không thể ghi đè
        // new {thuộc tính = giá trị , thuộc tính  = giá trị}



        static void Main(string[] args)
        {
            var sanpham = new
            {
                Name = "Iphone 8",
                Price = 1000,
                Year = 2018
            };
            //  Console.WriteLine(sanpham.Name); 
            //  Console.WriteLine(sanpham.Price);

            List<Student> students = new List<Student>(){
                new Student() {name = "Phu", year_born = 2002 , address_born = "Hau Giang"},
                new Student() {name = "Quy", year_born = 2003 , address_born = "An Giang"},
                new Student() {name = "Loc", year_born = 2004 , address_born = "Can Tho"},
                new Student() {name = "Thai", year_born = 2005 , address_born = "Dong Thap"}
            };

            var result = from student in  students
                        where student.year_born <= 2004 select new {
                            Name = student.name,
                            NS = student.address_born
                        };
            foreach (var sv  in result)
            {
                Console.WriteLine($"{sv.Name} - {sv.NS}");
            }
        }
    }
}

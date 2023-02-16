using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cs_extend_class
{
    public class cat : animal
    {
        string Food;

        public cat(string s) : base(s)
        {
            this.Legs = 4;
            this.Food = "Mouse";
            Console.WriteLine("Khởi tạo của lớp cat");
        }

        public void Eat(){
            Console.WriteLine($"Food: {Food}");
        }
        // Viết lại phương thức của lớp cơ sớ
        public new void showLegs(){
            Console.WriteLine($"The cat has: {Legs} legs");
        }

        public void showInfor(){
            base.showLegs(); // Dùng để gọi đến lớp cơ sở
            showLegs(); //  phương thức này là của lớp hiện tại 
        }
    }
}
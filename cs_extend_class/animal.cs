using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cs_extend_class
{
    public class animal
    {

        public animal(){
            Console.WriteLine("Khởi tạo animal");
        }
        
        public animal(string abc){
            Console.WriteLine($"Khởi tạo animal (2) - {abc}");
        }

        public int Legs{set;get;}
        public float Weight{set;get;}
    
        public void showLegs(){
            Console.WriteLine($"Legs: {Legs}");
        }
    }
}
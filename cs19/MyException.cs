
using System;

namespace MyExceptions{
    public class NameEmptyException : Exception{
        public NameEmptyException() : base("Name cannot be empty! - class"){

        }
    }


    public class AgeException : Exception{
        
        private int age;
        public int Age{set; get;}

        public AgeException(int age) : base("Age cannot be greater than 20 and less than 18"){
            this.age = age;
        }

        public void AgeExceptionDetail(){
            Console.WriteLine($"Age ={this.age} not suitable");
        }
    }
}




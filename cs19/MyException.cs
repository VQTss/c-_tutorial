
using System;

namespace MyExceptions{
    public class NameEmptyException : Exception{
        public NameEmptyException() : base("Name cannot be empty! - class"){

        }
    }


    public class AgeException : Exception{
        public AgeException() : base("Age cannot be greater than 20 and less than 18"){
            
        }
    }
}




using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cs12
{
    public class person
    {
        string name;
        int age;
        float price;

        public person(string name, int age, float price){
            this.name = name;
            this.age =  age;
            this.price = price;
        }

        public void run(){
            Console.WriteLine($"{this.name} is running");
        }

        public string ToString()
        {
           return $"{this.name} - {this.age} - {this.price}";
           
        }
        
        public string Name{
            set {
                name = value;
            }
            get {
                return name;
            }
        }
        public int Age{
            set => age = value;
            get => age;
        }
        
    }
}
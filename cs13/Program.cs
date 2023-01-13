using System;

namespace cs13
{
    class Program
    {

        class product
        {
            public  product(){
                Console.WriteLine("Product");
            }
            public int price{set; get;} 

            public virtual void productInfor(){
                Console.WriteLine($"Price of product: {price}");
            }

            public void test() => productInfor();

           
        }    

        class Iphone : product
        {
            public Iphone(){

                Console.WriteLine("Iphone");
            }
            public override void productInfor()
            {
                Console.WriteLine($"New product is iphone");
                base.productInfor();
            }
        }


        static void Main(string[] args)
        {
            Iphone i = new Iphone();
            // product p = new Iphone();

        }
    }
}

using System;

namespace cs15
{

    interface  IShape{
        public double tinhChuVi();
        public double tinhDienTich();

    }


    class HinhChuNhat : IShape
    {
        double a ,b;
        public HinhChuNhat(double a , double b){
            this.a = a;
            this.b = b;
        }

        public double tinhChuVi()
        {
            return 2 *a *b;
        }

        public double tinhDienTich()
        {
            return a * b;
        }
    }

    class Circle : IShape
    {
        
        private double r;
        public Circle(double r){
            this.r = r;
        }


        public double tinhChuVi()
        {
            return  2 * Math.PI *  r;
        }

        public double tinhDienTich()
        {
            return Math.PI  *  Math.Pow(r,2);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            IShape s = new HinhChuNhat(4,5);
            Console.WriteLine($"Hinh chu nhat\nChu vi: {s.tinhChuVi()}---Dien tich: {s.tinhDienTich()}");
            s = new Circle(1);
            Console.WriteLine($"Hinh tron\nChu vi: {s.tinhChuVi()}---Dien tich: {s.tinhDienTich()}");
        }
    }
}

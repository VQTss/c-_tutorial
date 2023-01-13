using System.Text;
using System.IO;
using System;

namespace cs24
{

    class Product
    {
        public int ID { set; get; }
        public double Price { set; get; }
        public string Name { set; get; }
        public void Save(Stream stream)
        {

            // int -> 4 bytes
            var bytes_id = BitConverter.GetBytes(ID);
            stream.Write(bytes_id, 0, 4);

            // double -> 8 byes
            var bytes_price = BitConverter.GetBytes(Price);
            stream.Write(bytes_price, 0, 8);
            //  Chuoi name
            var bytes_name = Encoding.UTF8.GetBytes(Name);
            var bytes_len = BitConverter.GetBytes(bytes_name.Length);
            stream.Write(bytes_len, 0, 4);
            stream.Write(bytes_name, 0, bytes_name.Length);
            Console.WriteLine("Sucess");
        }
        public void Restore(Stream stream)
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string path = "data.dat";
            var stream = new FileStream(path,FileMode.Create);
            Product p = new Product()
            {
                ID = 10,
                Price = 1234,
                Name = "Vo Quoc Thai"
            };
            p.Save(stream);
        }
    }
}

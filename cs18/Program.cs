using System;

namespace cs18
{
    class Program
    {

        // Kieu liet ke enum
        /*
            0 - Kem
            1 - Trung Binh
            2-  Kha
            3 - Gioi

        */

        enum HOCLUC{
            Kem, // 0
            TrungBinh = 333, // 1
            Kha, // 2
            Gioi // 3
        }

        static void Main(string[] args)
        {
            HOCLUC hocluc;
            hocluc =  HOCLUC.TrungBinh;
            // Chuyển học lực thành kiểu số
            int so = (int) hocluc;
            Console.WriteLine($"Convert enum to int: {so}");
            // Chuyển kiểu 333 thành học lực
            hocluc = (HOCLUC)(333);
            Console.WriteLine($"Convert int to enum: {hocluc}");
            
            switch (hocluc)
            {   
                // case HOCLUC.Kem:
                case 0:
                    Console.WriteLine("Hoc luc kem");
                    break;
                case HOCLUC.TrungBinh:
                    Console.WriteLine("Hoc luc trung binh");
                    break;
                case HOCLUC.Kha:
                    Console.WriteLine("Hoc luc kha");
                    break;
                case HOCLUC.Gioi:
                    Console.WriteLine("Hoc luc gioi");
                    break;    
                default:
                    break;
            }
            

        }
    }
}

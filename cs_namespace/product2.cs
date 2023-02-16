namespace SanPham{
    public partial class Product{

        public  string ToString()
        {  
            this.description = $"this is {name}";
            return $"{name} / {price} : {description}";
        }

    }
}
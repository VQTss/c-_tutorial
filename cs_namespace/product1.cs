namespace SanPham{

    // Từ khóa partial dùng để chia nhỏ code của class

    // Cách khai báo thì cùng namespace và cùng tên classs 
    // Ví dụ trong namespace SanPham có class là Product
    // thì chia nhỏ ra bằng cách thêm từ khóa 'partial'
    // 
    public partial class Product{
        public string name {set;get;}

        public decimal price{set; get;}

        public string description {set; get;}

    }
}
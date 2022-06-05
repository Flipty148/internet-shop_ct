namespace internet_shop_ct.Models
{
    public class Product
    {
        public int Product_code { get; private set; } //Код товара

        public string Name { get; private set; } //Название товара

        public int Price { get; private set; } //Цена товара

        public static readonly Product wrongProduct = new Product(-1, "wrong", -1 );  //Ошибочный товар

        public Product(int product_code, string name, int price)
        {
            Product_code = product_code;
            Name = name;
            Price = price;
        }

        public Product(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public Product(Product otherProduct)
        {
            Name = otherProduct.Name;
            Price = otherProduct.Price;
        }

        public override string ToString()
        {
            return $"{Product_code}: {Name} ({Price})";
        }
    }
}

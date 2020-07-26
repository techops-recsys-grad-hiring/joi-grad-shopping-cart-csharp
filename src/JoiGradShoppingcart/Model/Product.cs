namespace JoiGradShoppingcart.Model
{
    public class Product
    {
        public double Price { get; }
        public string ProductCode { get; }
        public string Name { get; }
        
        public Product(double price, string productCode, string name)
        {
            Price = price;
            ProductCode = productCode;
            Name = name;
        }
    }
}
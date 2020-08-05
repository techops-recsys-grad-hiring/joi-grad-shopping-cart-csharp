namespace JoiGradShoppingcart.Model
{
    public class Order
    {
        public double TotalPrice { get; }
        public int LoyaltyPoints { get; }

        public Order(double totalPrice, int loyaltyPoints)
        {
            TotalPrice = totalPrice;
            LoyaltyPoints = loyaltyPoints;
        }

        public override string ToString()
        {
            return $"Total price: {TotalPrice}\n" +
                $"Will receive {LoyaltyPoints} loyalty points";
        }
    }
}
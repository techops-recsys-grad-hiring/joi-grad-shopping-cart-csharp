using System;
using System.Collections.Generic;
using System.Linq;
using JoiGradShoppingcart.Model;
using JoiGradShoppingcart.Service;

namespace JoiGradShoppingcart
{
    class SampleApp
    {
        static void Main(string[] args)
        {
            var product1 = new Product(10.0, "DIS_10_PRODUCT1", "product 1");
            var product2 = new Product(20.0, "DIS_10_PRODUCT2", "product 2");
            var products = new List<Product> {product1, product2};
            var customer = new Customer("A Customer");
            var shoppingCart = new ShoppingCart(customer, products);
            shoppingCart.SetOrderService(new ConsoleOrderService());
            var product3 = new Product(30.0, "DIS_10_PRODUCT3", "product 3");
            shoppingCart.AddProduct(product3);
            shoppingCart.Checkout();
        }
    }

    internal class ConsoleOrderService : IOrderService
    {
        public void ShowConfirmation(Customer customer, List<Product> products, double totalPrice, int loyaltyPointsEarned)
        {
            Console.WriteLine("Customer: " + customer.Name);
            Console.WriteLine("Bought: \n" + string.Join('\n', products.Select(p => $"- {p.Name}, {p.Price}")));
            Console.WriteLine("Total price: " + totalPrice);
            Console.WriteLine("Will receive " + loyaltyPointsEarned + " loyalty points");
        }
    }
}
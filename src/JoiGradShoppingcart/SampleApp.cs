using System;
using System.Collections.Generic;
using System.Linq;
using JoiGradShoppingcart.Model;

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

            var product3 = new Product(30.0, "DIS_10_PRODUCT3", "product 3");
            shoppingCart.AddProduct(product3);

            Console.WriteLine(shoppingCart.ToString());
            
            var order = shoppingCart.Checkout();
            Console.WriteLine(order.ToString());
        }
    }
}
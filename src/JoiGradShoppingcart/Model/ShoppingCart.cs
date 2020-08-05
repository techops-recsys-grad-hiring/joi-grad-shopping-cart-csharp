using System;
using System.Collections.Generic;
using System.Linq;

namespace JoiGradShoppingcart.Model
{
    public class ShoppingCart
    {
        private Customer _customer;
        private List<Product> _products;

        public ShoppingCart(Customer customer, List<Product> products)
        {
            _customer = customer;
            _products = products;
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public void RemoveProduct(Product product)
        {
            _products.Remove(product);
        }

        public Order Checkout()
        {
            var totalPrice = 0.0;
            var loyaltyPointsEarned = 0;

            foreach (var product in _products)
            {
                var discount = 0.0;
                
                if (product.ProductCode.StartsWith("DIS_10")) {
                    discount = product.Price * 0.1;
                    loyaltyPointsEarned += (int) product.Price / 10;
                } else if (product.ProductCode.StartsWith("DIS_15")) {
                    discount = product.Price * 0.15;
                    loyaltyPointsEarned += (int) product.Price / 15;
                } else {
                    loyaltyPointsEarned += (int) product.Price / 5;
                }

                totalPrice += product.Price - discount;
            }
            
            return new Order(totalPrice, loyaltyPointsEarned);
        }

        public override string ToString()
        {
            return "Customer: " + _customer.Name + "\n" + "Bought:  \n" + String.Join("\n", _products.Select(product => "- " + product.Name + ", " + product.Price));
        }
    }
}
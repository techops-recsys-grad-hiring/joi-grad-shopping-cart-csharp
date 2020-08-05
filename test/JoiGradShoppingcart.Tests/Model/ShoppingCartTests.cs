using System.Collections.Generic;
using JoiGradShoppingcart.Model;
using Xunit;

namespace JoiGradShoppingcart.Tests.Model
{
    public class ShoppingCartTests
    {
        [Fact]
        public void should_calculate_price_for_no_discount()
        {
            var shoppingCart = new ShoppingCart(new Customer("test"), new List<Product>
            {
                new Product(100, "No_discount_ABCD", "T")
            });

            var order = shoppingCart.Checkout();

            Assert.Equal(100.0, order.TotalPrice);
        }

        [Fact]
        public void should_calculate_loyalty_points_for_no_discount()
        {
            var shoppingCart = new ShoppingCart(new Customer("test"), new List<Product>
            {
                new Product(100, "No_discount_ABCD", "T")
            });

            var order = shoppingCart.Checkout();

            Assert.Equal(20, order.LoyaltyPoints);
        }

        [Fact]
        public void should_calculate_price_for_10_percent_discount()
        {
            var shoppingCart = new ShoppingCart(new Customer("test"), new List<Product>
            {
                new Product(100, "DIS_10_ABCD", "T")
            });

            var order = shoppingCart.Checkout();

            Assert.Equal(90.0, order.TotalPrice);
        }

        [Fact]
        public void should_calculate_loyalty_for_10_percent_discount()
        {
            var shoppingCart = new ShoppingCart(new Customer("test"), new List<Product>
            {
                new Product(100, "DIS_10_ABCD", "T")
            });

            var order = shoppingCart.Checkout();

            Assert.Equal(10, order.LoyaltyPoints);
        }

        [Fact]
        public void should_calculate_price_for_15_percent_discount()
        {
            var shoppingCart = new ShoppingCart(new Customer("test"), new List<Product>
            {
                new Product(100, "DIS_15_ABCD", "T")
            });

            var order = shoppingCart.Checkout();

            Assert.Equal(85.0, order.TotalPrice);
        }

        [Fact]
        public void should_calculate_loyalty_for_15_percent_discount()
        {
            var shoppingCart = new ShoppingCart(new Customer("test"), new List<Product>
            {
                new Product(100, "DIS_15_ABCD", "T")
            });

            var order = shoppingCart.Checkout();

            Assert.Equal(6, order.LoyaltyPoints);
        }
    }
}
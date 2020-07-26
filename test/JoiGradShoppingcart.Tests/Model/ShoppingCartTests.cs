using System.Collections.Generic;
using JoiGradShoppingcart.Model;
using JoiGradShoppingcart.Service;
using Xunit;

namespace JoiGradShoppingcart.Tests.Model
{
    public class ShoppingCartTests
    {
        [Fact]
        public void should_validate_information_passed_on_to_confirmation()
        {
            var shoppingCart = new ShoppingCart(new Customer("test"), new List<Product>
            {
                new Product(100, "DIS_10_ABCD", "T")
            });
            var fakeOrderService = new FakeOrderService();

            shoppingCart.SetOrderService(fakeOrderService);
            shoppingCart.Checkout();

            Assert.Equal(90.0, fakeOrderService.ActualTotalPrice, 1);
        }
    }

    public class FakeOrderService : IOrderService
    {
        public double ActualTotalPrice;

        public void ShowConfirmation(Customer customer, List<Product> products, double totalPrice,
            int loyaltyPointsEarned)
        {
            ActualTotalPrice = totalPrice;
        }
    }
}
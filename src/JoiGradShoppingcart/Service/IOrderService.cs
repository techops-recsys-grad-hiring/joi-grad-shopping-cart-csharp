using System.Collections.Generic;
using JoiGradShoppingcart.Model;

namespace JoiGradShoppingcart.Service
{
    public interface IOrderService
    {
        void ShowConfirmation(Customer customer, List<Product> products, double totalPrice, int loyaltyPointsEarned)
        {
        }
    }
}
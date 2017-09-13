using System.Linq;
using HarryPotterShoppingCart.Models;

namespace HarryPotterShoppingCart
{
    public class ShoppingCartService
    {
        public decimal Calculate(ShoppingCartEntity shoppingCart)
        {
            var totalPrice = shoppingCart.Products.Sum(s => s.Price * s.Qty);

            return totalPrice;
        }
    }
}

using System.Collections.Generic;
using System.Linq;
using HarryPotterShoppingCart.Models;

namespace HarryPotterShoppingCart
{
    public class ShoppingCartService
    {
        public decimal Calculate(ShoppingCartEntity shoppingCart)
        {
            var products = shoppingCart.Products;
            var disCountRate = GetDisCountRate(products);

            var totalPrice = products.Sum(s => s.Price * s.Qty);
            totalPrice = totalPrice * disCountRate;

            return totalPrice;
        }

        private decimal GetDisCountRate(List<ProductEntity> products)
        {
            decimal disCountRate = 1;
            var productUnitCount = products.GroupBy(s => s.Name).Count();

            switch (productUnitCount)
            {
                case 1:
                    disCountRate = 1;
                    break;
                case 2:
                    disCountRate = 0.95m;
                    break;
                case 3:
                    disCountRate = 0.9m;
                    break;
            }

            return disCountRate;
        }
    }
}

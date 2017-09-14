using System.Collections.Generic;
using System.Linq;
using HarryPotterShoppingCart.Models;

namespace HarryPotterShoppingCart
{
    public class ShoppingCartService
    {
        public decimal Calculate(ShoppingCartEntity shoppingCart)
        {
            var totalPrice = 0m;
            var products = shoppingCart.Products;
            var disCountRate = GetDisCountRate(products);

            var distinctProducts = products.GroupBy(s => s.Name).Select(s => s.FirstOrDefault()).ToList();
            var exceptProducts = products.Except(distinctProducts).ToList();

            totalPrice = distinctProducts.Sum(s => s.Price * s.Qty);
            totalPrice = totalPrice * disCountRate;

            if (exceptProducts.Any())
            {
                totalPrice += exceptProducts.Sum(s => s.Price * s.Qty);
            }

            return totalPrice;
        }

        private decimal GetDisCountRate(List<ProductEntity> products)
        {
            var disCountRule = new Dictionary<int, decimal>
            {
                { 1 , 1 },
                { 2 , 0.95m },
                { 3 , 0.9m },
                { 4 , 0.8m },
                { 5 , 0.75m }
            };

            var productUnitCount = products.GroupBy(s => s.Name).Count();

            decimal result = disCountRule.FirstOrDefault(s => s.Key == productUnitCount).Value;
            if (result == 0)
            {
                result = 1;
            }

            return result;
        }
    }
}

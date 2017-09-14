﻿using System.Collections.Generic;
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
            var disCountRule = new Dictionary<int, decimal>
            {
                { 1 , 1 },
                { 2 , 0.95m },
                { 3 , 0.9m },
                { 4 , 0.8m }
            };

            decimal result = 1;
            var productUnitCount = products.GroupBy(s => s.Name).Count();

            result = disCountRule.FirstOrDefault(s => s.Key == productUnitCount).Value;

            return result;
        }
    }
}

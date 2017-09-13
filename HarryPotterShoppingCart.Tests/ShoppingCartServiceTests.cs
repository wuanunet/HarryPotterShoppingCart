using System.Collections.Generic;
using FluentAssertions;
using HarryPotterShoppingCart.Models;
using Xunit;

namespace HarryPotterShoppingCart.Tests
{
    public class ShoppingCartServiceTests
    {
        [Fact]
        public void Calculate_Buy_Qty_1_HerryPotter1_TotalPrice_Should_be_100()
        {
            //// Arrange
            var expected = 100;
            var shoppingCart = new ShoppingCartEntity
            {
                Products = new List<ProductEntity>
                {
                    new ProductEntity { Qty = 1, Name = "HerryPotter1", Price = 100 }
                }
            };

            var target = new ShoppingCartService();
            decimal actual = 0m;

            //// Act
            actual = target.Calculate(shoppingCart);

            //// Assert
            actual.Should().Be(expected);

        }
    }
}
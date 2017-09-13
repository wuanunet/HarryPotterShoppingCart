using System.Collections.Generic;
using FluentAssertions;
using HarryPotterShoppingCart.Models;
using Xunit;

namespace HarryPotterShoppingCart.Tests
{
    public class ShoppingCartServiceTests
    {
        private readonly ShoppingCartService _target;

        public ShoppingCartServiceTests()
        {
            this._target = new ShoppingCartService();
        }

        [Fact]
        public void CalculateTest_購買HerryPotter第一集一本_沒有折扣_購物車費用應為_100_元()
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

            decimal actual = 0m;

            //// Act
            actual = this._target.Calculate(shoppingCart);

            //// Assert
            actual.Should().Be(expected);
        }
    }
}